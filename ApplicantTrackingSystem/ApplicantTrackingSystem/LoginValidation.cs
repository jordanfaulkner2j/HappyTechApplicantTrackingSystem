using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ApplicantTrackingSystem
{
    class LoginValidation
    {
        /// <summary>
        /// compare hash of entered password with hash retrieved from database
        /// </summary>
        /// <param name="enteredEmail">search for password hash using employee's email</param>
        /// <param name="enteredPassword">calculate hash and compare with hash stored in database</param>
        /// <returns>boolean value for emailValid and passwordValid</returns>
        public static (Boolean emailValid, Boolean passwordValid) ValidateCredentials(string enteredEmail, string enteredPassword)
        {
            // retrieve hash from database (entered password never leaves the application)
            string hashedPassword = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GetEmployeeUsingEmail(DatabaseQueries.EMPLOYEE_PASSWORD, enteredEmail));

            // if hash returns null due to no available records based on the query, email address entered is invalid
            if (hashedPassword == null)
            {
                return (false, false);
            }
            else
            {
                // if password hashes match, return true for both values
                if (hashedPassword == HashPassword(enteredPassword))
                {
                    return (true, true);
                }
                // else return false for passwordValid
                else
                {
                    return (true, false);
                }
            }
        }

        /// <summary>
        /// validate entered email address
        /// </summary>
        /// <param name="emailAddress">email address to be validated</param>
        /// <returns>error message or null if valid</returns>
        public static string ValidateEmail(string emailAddress)
        {
            // check if email was not left blank
            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                return "Missing email address!";
            }

            /*
            // check if email address contains character @
            foreach (char character in emailAddress)
            {
                if (character == '@')
                {
                    return null;
                }
            }
            return "Please use your full email address.";
            */

            // check if email address contains character @
            for (int i = 0; i < emailAddress.Length; i++)
            {
                if (emailAddress[i] == '@')
                {
                    // after @ character found, check if it is followed by domain containing dot
                    for (int j = i+1; j < emailAddress.Length; j++)
                    {
                        if (emailAddress[j] == '.')
                        {
                            return null;
                        }
                    }
                    break;
                }
            }
            return "Please use your full email address.";
        }

        /// <summary>
        /// calculate hash on enetered string
        /// </summary>
        /// <param name="plainTextPassword">plaintext to hash</param>
        /// <returns>hash as string in hexidecimal format</returns>
        private static string HashPassword(string plainTextPassword)
        {
            // create SHA256 object
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // generate hash and return its byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainTextPassword));

                // convert byte array to string in hexidecimal format
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                // return string value of the hash
                return builder.ToString();
            }
        }
    }
}

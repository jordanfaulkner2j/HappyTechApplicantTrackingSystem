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
        /// <returns>true if password entered is correct</returns>
        public static Boolean ValidateCredentials(string enteredEmail, string enteredPassword)
        {
            // retrieve hash from database
            string hashedPassword = DatabaseConnection.GetInstanceOfDatabaseConnection().GetPasswordHash(enteredEmail);

            // if hash retrieved from database matches with calculated hash of entered password, return true
            if (hashedPassword == HashPassword(enteredPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// calculate hash on enetered string
        /// </summary>
        /// <param name="password">string to hash</param>
        /// <returns>hash as string in hexidecimal format</returns>
        private static string HashPassword(string password)
        {
            // create SHA256 object
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // generate hash and return its byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

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

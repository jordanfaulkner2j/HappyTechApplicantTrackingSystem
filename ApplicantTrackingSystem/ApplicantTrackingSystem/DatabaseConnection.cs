using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ApplicantTrackingSystem
{
    class DatabaseConnection
    {
        //private object of the class itself
        private static DatabaseConnection instance;

        // connection string for the database
        private string connectionString;

        // connection to the database
        private MySqlConnection connectToDatabase;

        /// <summary>
        /// constructor
        /// </summary>
        private DatabaseConnection()
        {
            connectionString = "datasource = localhost; port = 3306; username = root; password = ; database = applicant_tracking_system;";
        }

        /// <summary>
        /// create a unique object of the class itself
        /// </summary>
        /// <returns>instance of a database</returns>
        public static DatabaseConnection GetInstanceOfDatabaseConnection()
        {
            // if connection to the database has not been established, create new
            if (instance == null)
            {
                instance = new DatabaseConnection();
            }

            return instance;
        }

        // returns a data set based on the query sent as parameter
        /// <summary>
        /// create a data set containing the requested records
        /// </summary>
        /// <param name="sqlQuery">query written in standard database query language</param>
        /// <returns>data set based on the query</returns>
        public DataSet GetDataSet(string sqlQuery)
        {
            // create an empty dataSet
            DataSet dataSet = new DataSet();

            // establish connection with the database and once stopped using, destroy objects
            using (connectToDatabase = new MySqlConnection(connectionString))
            {
                // open connection to the database
                connectToDatabase.Open();
                // create the object dataAdapter to send a query to the database
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlQuery, connectToDatabase);
                // fill in the dataSet
                dataAdapter.Fill(dataSet);
            }

            return dataSet;
        }

        /// <summary>
        /// retrieve hash for employee's password
        /// </summary>
        /// <param name="employeeEmail">employee's email is used as search string</param>
        /// <returns>password hash or null if invalid employee email</returns>
        public string GetPasswordHash(string employeeEmail)
        {
            // establish connection with the database and once stopped using, destroy objects
            using (connectToDatabase = new MySqlConnection(connectionString))
            {
                // open connection to the database
                connectToDatabase.Open();

                // command containing search query and connection string
                MySqlCommand command = new MySqlCommand(string.Format("SELECT employee.password FROM employee INNER JOIN user ON employee.user_id = user.user_id WHERE user.email_address = '{0}';", employeeEmail), connectToDatabase);
                // execute search query
                MySqlDataReader dataReader = command.ExecuteReader();

                // if record available, read it
                if (dataReader.Read())
                {
                    // return the value of password attribute
                    return dataReader["password"].ToString();
                }
            }

            // else return null
            return null;
        }
    }
}

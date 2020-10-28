using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

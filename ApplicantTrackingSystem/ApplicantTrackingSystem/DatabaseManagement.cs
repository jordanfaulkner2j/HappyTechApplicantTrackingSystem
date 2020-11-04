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
    class DatabaseManagement
    {
        //private object of the class itself
        private static DatabaseManagement instance;

        // connection string for the database
        private const string connectionString = "datasource = localhost; port = 3306; username = root; password = ; database = applicant_tracking_system;";

        // connection to the database
        private MySqlConnection connectToDatabase;

        /// <summary>
        /// constructor, create a unique object of the class itself
        /// </summary>
        /// <returns>instance of a database</returns>
        public static DatabaseManagement GetInstanceOfDatabaseConnection()
        {
            // if connection to the database has not been established, create new
            if (instance == null)
            {
                instance = new DatabaseManagement();
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
        /// retrieve single attribute from table
        /// </summary>
        /// <param name="sqlQuery">search query</param>
        /// <param name="returnAttribute">name of the attribute to return</param>
        /// <returns>attribute or null if no records found based on the query</returns>
        public string GetSingleAttribute(string sqlQuery, string returnAttribute)
        {
            // establish connection with the database and once stopped using, destroy objects
            using (connectToDatabase = new MySqlConnection(connectionString))
            {
                // open connection to the database
                connectToDatabase.Open();

                // command containing search query and connection string
                MySqlCommand command = new MySqlCommand(sqlQuery, connectToDatabase);
                // execute search query
                MySqlDataReader dataReader = command.ExecuteReader();

                // if record available, read it
                if (dataReader.Read())
                {
                    // return the value of the requested attribute
                    return dataReader[returnAttribute].ToString();
                }
            }

            // else return null
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace ApplicantTrackingSystem
{
    class DatabaseManagement
    {
        //private object of the class itself
        private static DatabaseManagement _instance;

        // connection string for the database
        private string dbConnectionString = Properties.Settings.Default.connectionString;

        // connection to the database
        private SqlConnection connectToDB;

        /// <summary>
        /// constructor, create a unique object of the class itself
        /// </summary>
        /// <returns>instance of a database</returns>
        public static DatabaseManagement GetInstanceOfDatabaseConnection()
        {
            // if connection to the database has not been established, create new
            if (_instance == null)
            {
                _instance = new DatabaseManagement();
            }

            return _instance;
        }

        /// <summary>
        /// create a data set containing requested records
        /// </summary>
        /// <param name="sqlQuery">query written in standard database query language</param>
        /// <returns>data set based on the query sent as a parameter</returns>
        public DataSet GetDataSet(string sqlQuery)
        {
            // create an empty dataSet
            DataSet dataSet = new DataSet();

            // establish connection with the database and once stopped using, destroy objects
            using (connectToDB = new SqlConnection(dbConnectionString))
            {
                // open connection to the database
                connectToDB.Open();

                // create the object dataAdapter to send a query to the database
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connectToDB);
                // fill in the dataSet
                dataAdapter.Fill(dataSet);
            }

            return dataSet;
        }

        /// <summary>
        /// retrieve single attribute from table in database
        /// </summary>
        /// <param name="sqlQuery">search query</param>
        /// <param name="returnAttribute">name of the attribute to return</param>
        /// <returns>attribute or null if no records found based on the query</returns>
        public string GetSingleAttribute(string sqlQuery, string returnAttribute)
        {
            // establish connection with the database and once stopped using, destroy objects
            using (connectToDB = new SqlConnection(dbConnectionString))
            {
                // open connection to the database
                connectToDB.Open();

                // command containing search query and connection string
                SqlCommand command = new SqlCommand(sqlQuery, connectToDB);
                // execute search query
                SqlDataReader dataReader = command.ExecuteReader();

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

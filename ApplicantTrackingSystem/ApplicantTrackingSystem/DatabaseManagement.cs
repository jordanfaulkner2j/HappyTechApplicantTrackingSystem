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
        // private object of the class itself
        private static DatabaseManagement _instance;

        // private string for the connection string
        private string dbConnectionString;

        // private object of the connection to the database
        private SqlConnection connectToDB;

        /// <summary>
        /// constructor
        /// </summary>
        private DatabaseManagement()
        {
            dbConnectionString = Properties.Settings.Default.connectionString;
        }

        /// <summary>
        /// singleton, return instance of the object
        /// </summary>
        /// <returns>instance of the database connection</returns>
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
        /// return a table containing requested records
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

            // return table
            return dataSet;
        }

        /// <summary>
        /// retrieve entire row for specified record
        /// </summary>
        /// <param name="sqlQuery">search query</param>
        /// <returns>array of strings containing individual attributes or null if no record found</returns>
        public string[] GetEntireRecord(string sqlQuery)
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
                    // declare dynamic array also known as list
                    List<string> record = new List<string>();

                    // append each attribute to the array
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        record.Add(dataReader[i].ToString());
                    }

                    // return fixed length array
                    return record.ToArray();
                }
            }

            // else return null
            return null;
        }

        /// <summary>
        /// retrieve single attribute from specified record
        /// </summary>
        /// <param name="sqlQuery">search query</param>
        /// <param name="returnAttribute">name of the attribute to return</param>
        /// <returns>dynamic attribute or null if no record found based on the query</returns>
        public dynamic GetSingleAttribute(string sqlQuery)
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
                    return dataReader[0];
                }
            }

            // else return null
            return null;
        }

        /// <summary>
        /// update, insert or delete record
        /// </summary>
        /// <param name="sqlQuery">update query</param>
        public void UpdateRecord(string sqlQuery)
        {
            // establish connection with the database and once stopped using, destroy objects
            using (connectToDB = new SqlConnection(dbConnectionString))
            {
                // open connection to the database
                connectToDB.Open();

                // command containing search query and connection string
                SqlCommand command = new SqlCommand(sqlQuery, connectToDB);
                // execute query
                command.ExecuteNonQuery();
            }
        }
    }
}

using System;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace PoliceDB.MainClasses
{
    class ConnectionDB
    {
        static string mySqlconnection = "server=127.0.0.1; user=root; database=police; password=";
        MySqlConnection sqlConnection = new MySqlConnection(mySqlconnection);
        /// <summary>
        /// Відкитя підключення к базі даних
        /// </summary>
        public void openConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        /// <summary>
        /// Закритя підключення к базі даних
        /// </summary>
        public void closeConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}

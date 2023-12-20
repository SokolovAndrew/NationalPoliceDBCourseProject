using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PoliceDB.MainClasses
{
    class GetTableDate
    {
        private ConnectionDB connectionDB;

        public GetTableDate()
        {
            connectionDB = new ConnectionDB();
        }
        /// <summary>
        /// Вивід таблиці по назві таблиці
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="rowCount"></param>
        /// <returns></returns>
        public DataTable GetTable(string tableName, int rowCount)
        {
            try
            {
                connectionDB.openConnection();

                string query = $"SELECT * FROM {tableName} LIMIT {rowCount};";
                MySqlCommand command = new MySqlCommand(query, connectionDB.getConnection());

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connectionDB.closeConnection();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// Вивід таблиці в залежності від пошуку по Name
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="rowCount"></param>
        /// <param name="searchName"></param>
        /// <returns></returns>
        public DataTable GetTable(string tableName, int rowCount, string searchName)
        {
            try
            {
                connectionDB.openConnection();

                string query = $"SELECT * FROM {tableName} WHERE ФІО LIKE @searchName LIMIT {rowCount};";
                MySqlCommand command = new MySqlCommand(query, connectionDB.getConnection());
                command.Parameters.AddWithValue("@searchName", "%" + searchName + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connectionDB.closeConnection();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// Вивід таблиці в залежності від пошуку по Name в Calling
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="rowCount"></param>
        /// <param name="searchName"></param>
        /// <returns></returns>
        public DataTable GetTableCalling(string tableName, int rowCount, string searchName)
        {
            try
            {
                connectionDB.openConnection();

                string query = $"SELECT * FROM {tableName} WHERE Назва LIKE @searchName LIMIT {rowCount};";
                MySqlCommand command = new MySqlCommand(query, connectionDB.getConnection());
                command.Parameters.AddWithValue("@searchName", "%" + searchName + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connectionDB.closeConnection();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PoliceDB.MainClasses
{


    class DatabaseManager
    {
        private ConnectionDB connectionDB;

        public DatabaseManager()
        {
            connectionDB = new ConnectionDB();
        }
        /// <summary>
        /// Функція для отримання списку назв представлень
        /// </summary>
        /// <returns></returns>
        public List<string> GetViewNames()
        {
            try
            {
                connectionDB.openConnection();

                string query = "SHOW FULL TABLES WHERE Table_Type = 'VIEW';";
                MySqlCommand command = new MySqlCommand(query, connectionDB.getConnection());

                MySqlDataReader reader = command.ExecuteReader();

                // Отримання списку назв представлень
                var viewNames = new List<string>();
                while (reader.Read())
                {
                    string tableName = reader.GetString(0);
                    viewNames.Add(tableName);
                }

                reader.Close();
                connectionDB.closeConnection();

                return viewNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return new List<string>();
            }
        }
        /// <summary>
        /// Отримання списку міст
        /// </summary>
        /// <returns></returns>
        public List<string> GetCitiesFromTable()
        {
            try
            {
                connectionDB.openConnection();

                string query = "SELECT name FROM city;";
                MySqlCommand command = new MySqlCommand(query, connectionDB.getConnection());

                MySqlDataReader reader = command.ExecuteReader();

                // Отримання списку міст
                var cityNames = new List<string>();
                while (reader.Read())
                {
                    string cityName = reader.GetString(0);
                    cityNames.Add(cityName);
                }

                reader.Close();
                connectionDB.closeConnection();

                return cityNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
                return new List<string>();
            }
        }
        /// <summary>
        /// Отримаємо id оружейні по переданому id міста
        /// </summary>
        /// <param name="id_city"></param>
        /// <returns></returns>
        public int GetArmoryId(int id_city)
        {
            try
            {
                connectionDB.openConnection();

                string query = "SELECT id FROM armory WHERE id_city = @id_city";
                MySqlCommand command = new MySqlCommand(query, connectionDB.getConnection());
                command.Parameters.AddWithValue("@id_city", id_city);

                int armoryId = Convert.ToInt32(command.ExecuteScalar());

                connectionDB.closeConnection();

                return armoryId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
                return -1; // Повернення -1 як помилкового значення
            }
        }


        /// <summary>
        /// Отримання списку назв команд з таблиці "team"
        /// </summary>
        /// <returns>Список назв команд</returns>
        public List<string> GetTeamNames()
        {
            try
            {
                connectionDB.openConnection();

                string query = "SELECT name FROM team";
                MySqlCommand command = new MySqlCommand(query, connectionDB.getConnection());

                MySqlDataReader reader = command.ExecuteReader();

                var teamNames = new List<string>();
                while (reader.Read())
                {
                    string teamName = reader.GetString(0);
                    teamNames.Add(teamName);
                }

                reader.Close();
                connectionDB.closeConnection();

                return teamNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
                return new List<string>();
            }
        }


        /// <summary>
        /// Повернення списку професій
        /// </summary>
        /// <returns></returns>
        public List<string> GetProfessionList()
        {
            try
            {
                connectionDB.openConnection();

                string query = "SELECT * FROM profession;";
                MySqlCommand command = new MySqlCommand(query, connectionDB.getConnection());

                MySqlDataReader reader = command.ExecuteReader();

                var professionList = new List<string>();
                while (reader.Read())
                {
                    int professionId = reader.GetInt32(0);
                    string professionName = reader.GetString(1);
                    string professionEntry = $"{professionId} - {professionName}";
                    professionList.Add(professionEntry);
                }

                reader.Close();
                connectionDB.closeConnection();

                return professionList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
                return new List<string>();
            }
        }

        /// <summary>
        /// Отриманя списку вільної зброї
        /// </summary>
        /// <param name="id_armory"></param>
        /// <returns></returns>
        public List<string> GetAvailableWeapons(int id_armory)
        {
            try
            {
                connectionDB.openConnection();

                string query = "SELECT w.id, CONCAT(w.id_typeWeapons, ' - ', tw.name) AS weaponInfo " +
                               "FROM weapons AS w " +
                               "INNER JOIN typeWeapons AS tw ON w.id_typeWeapons = tw.id " +
                               "WHERE w.id_armory = @id_armory AND w.status = 'Вільний'";
                MySqlCommand command = new MySqlCommand(query, connectionDB.getConnection());
                command.Parameters.AddWithValue("@id_armory", id_armory);

                MySqlDataReader reader = command.ExecuteReader();

                var weaponList = new List<string>();
                while (reader.Read())
                {
                    int weaponId = reader.GetInt32(0);
                    string weaponInfo = reader.GetString(1);
                    string weaponEntry = $"{weaponId} - {weaponInfo}";
                    weaponList.Add(weaponEntry);
                }

                reader.Close();
                connectionDB.closeConnection();

                return weaponList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
                return new List<string>();
            }
        }

        /// <summary>
        /// Повернення списку робітників
        /// </summary>
        /// <returns></returns>
        public List<string> GetEmployeesList()
        {
            try
            {
                connectionDB.openConnection();

                string query = "SELECT * FROM employees;";
                MySqlCommand command = new MySqlCommand(query, connectionDB.getConnection());

                MySqlDataReader reader = command.ExecuteReader();

                var employeesList = new List<string>();
                while (reader.Read())
                {
                    int employeeId = reader.GetInt32(0);
                    string employeeName = reader.GetString(4);

                    string employeeEntry = $"{employeeId} - {employeeName}";
                    employeesList.Add(employeeEntry);
                }

                reader.Close();
                connectionDB.closeConnection();

                return employeesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
                return new List<string>();
            }
        }


        /// <summary>
        /// Отримання списку назв департаментів
        /// </summary>
        /// <returns></returns>
        public List<string> GetDepartmentNamesFromTable()
        {
            try
            {
                connectionDB.openConnection();

                string query = "SELECT name FROM department;";
                MySqlCommand command = new MySqlCommand(query, connectionDB.getConnection());

                MySqlDataReader reader = command.ExecuteReader();

                // Отримання списку назв департаментів
                var departmentNames = new List<string>();
                while (reader.Read())
                {
                    string departmentName = reader.GetString(0);
                    departmentNames.Add(departmentName);
                }

                reader.Close();
                connectionDB.closeConnection();

                return departmentNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
                return new List<string>();
            }
        }

        public void DeleteRow(string tableName, int columnIndex)
        {
            try
            {
                connectionDB.openConnection();

                string query = $"DELETE FROM {tableName} WHERE id = (SELECT id FROM {tableName} LIMIT 1 OFFSET {columnIndex});";
                MySqlCommand command = new MySqlCommand(query, connectionDB.getConnection());

                int rowsAffected = command.ExecuteNonQuery();

                connectionDB.closeConnection();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Row deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No row found at the specified index.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        /// <summary>
        /// Отримаємо список всіх незавершених діл
        /// </summary>
        /// <returns></returns>
        public List<string> GetCallingList()
        {
            try
            {
                connectionDB.openConnection();

                string query = "SELECT id, name FROM calling WHERE status <> 'Завершено';";
                MySqlCommand command = new MySqlCommand(query, connectionDB.getConnection());

                MySqlDataReader reader = command.ExecuteReader();

                var callingList = new List<string>();
                while (reader.Read())
                {
                    int callingId = reader.GetInt32(0);
                    string callingName = reader.GetString(1);
                    string callingEntry = $"{callingId} - {callingName}";
                    callingList.Add(callingEntry);
                }

                reader.Close();
                connectionDB.closeConnection();

                return callingList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
                return new List<string>();
            }
        }


    }
}

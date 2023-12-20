using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PoliceDB.MainClasses
{
    class InsertInformationDate
    {
        private ConnectionDB connectionDB;

        public InsertInformationDate()
        {
            connectionDB = new ConnectionDB();
        }
        /// <summary>
        /// Додавання департаменту в таблицю
        /// </summary>
        /// <param name="departmentName"></param>
        public void AddDepartmentToTable(string departmentName, int id_city, string street)
        {
            try
            {
                connectionDB.openConnection();

                // Перевірка наявності департаменту з такою ж назвою (без урахування регістру)
                MySqlCommand checkCommand = connectionDB.getConnection().CreateCommand();
                checkCommand.CommandText = "SELECT COUNT(*) FROM department WHERE LOWER(name) = LOWER(@departmentName)";
                checkCommand.Parameters.AddWithValue("@departmentName", departmentName);

                int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Департамент з такою назвою вже існує.");
                    connectionDB.closeConnection();
                    return;
                }

                MySqlCommand command = connectionDB.getConnection().CreateCommand();
                command.CommandText = "INSERT INTO department (name, id_city, street) VALUES (@departmentName, @id_city, @street)";
                command.Parameters.AddWithValue("@departmentName", departmentName);
                command.Parameters.AddWithValue("@id_city", id_city);
                command.Parameters.AddWithValue("@street", street);

                command.ExecuteNonQuery();

                MessageBox.Show("Департамент успішно додано до таблиці!");

                connectionDB.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при додаванні департамента: " + ex.Message);
            }
        }

        /// <summary>
        /// Додавання співробітника
        /// </summary>
        /// <param name="id_department"></param>
        /// <param name="id_weapons"></param>
        /// <param name="id_profession"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        public void AddEmployeeToTable(int id_department, int id_weapons, int id_profession, string name, string gender)
        {
            try
            {
                connectionDB.openConnection();

                MySqlCommand command = connectionDB.getConnection().CreateCommand();
                command.CommandText = "INSERT INTO Employees (id_department, id_weapons, id_profession, name, gender) " +
                                      "VALUES (@id_department, @id_weapons, @id_profession, @name, @gender)";
                command.Parameters.AddWithValue("@id_department", id_department);
                command.Parameters.AddWithValue("@id_weapons", id_weapons);
                command.Parameters.AddWithValue("@id_profession", id_profession);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@gender", gender);

                command.ExecuteNonQuery();

                MessageBox.Show("Співробітника успішно додано до таблиці Employees!");

                connectionDB.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при додаванні співробітника: " + ex.Message);
            }
        }

        /// <summary>
        /// Додавання виклику в таблицю "calling"
        /// </summary>
        /// <param name="id_team">ID команди</param>
        /// <param name="id_city">ID міста</param>
        /// <param name="name">Назва виклику</param>
        /// <param name="description">Опис виклику</param>
        /// <param name="street">Вулиця виклику</param>
        /// <param name="status">Статус виклику</param>
        public void AddCallingToTable(int id_team, int id_city, string name, string description, string street, string status)
        {
            try
            {
                connectionDB.openConnection();

                MySqlCommand command = connectionDB.getConnection().CreateCommand();
                command.CommandText = "INSERT INTO calling (id_team, id_city, name, description, street, status) VALUES (@id_team, @id_city, @name, @description, @street, @status)";
                command.Parameters.AddWithValue("@id_team", id_team);
                command.Parameters.AddWithValue("@id_city", id_city);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@street", street);
                command.Parameters.AddWithValue("@status", status);

                command.ExecuteNonQuery();

                MessageBox.Show("Виклик успішно додано до таблиці!");

                connectionDB.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при додаванні виклику: " + ex.Message);
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PoliceDB.MainClasses
{
    class ChangeInformationDate
    {
        private ConnectionDB connectionDB;

        public ChangeInformationDate()
        {
            connectionDB = new ConnectionDB();
        }
        /// <summary>
        /// Оновлення департаменту
        /// </summary>
        /// <param name="departmentId"></param>
        /// <param name="departmentName"></param>
        /// <param name="id_city"></param>
        /// <param name="street"></param>
        public void UpdateDepartmentInTable(int departmentId, string departmentName, int id_city, string street)
        {
            try
            {
                connectionDB.openConnection();

                // Проверка наличия департамента с таким же именем (в разных регистрах)
                MySqlCommand checkCommand = connectionDB.getConnection().CreateCommand();
                checkCommand.CommandText = "SELECT COUNT(*) FROM department WHERE LOWER(name) = LOWER(@departmentName) AND id <> @departmentId";
                checkCommand.Parameters.AddWithValue("@departmentName", departmentName);
                checkCommand.Parameters.AddWithValue("@departmentId", departmentId);

                int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Департамент з такою назвою вже існує.");
                    connectionDB.closeConnection();
                    return;
                }

                // Обновление данных департамента
                MySqlCommand updateCommand = connectionDB.getConnection().CreateCommand();
                updateCommand.CommandText = "UPDATE department SET name = @departmentName, id_city = @id_city, street = @street WHERE id = @departmentId";
                updateCommand.Parameters.AddWithValue("@departmentName", departmentName);
                updateCommand.Parameters.AddWithValue("@id_city", id_city);
                updateCommand.Parameters.AddWithValue("@street", street);
                updateCommand.Parameters.AddWithValue("@departmentId", departmentId);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                connectionDB.closeConnection();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Інформацію про департамент оновлено успішно!");
                }
                else
                {
                    MessageBox.Show("Не вдалося знайти департамент з вказаним ідентифікатором.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при оновленні інформації про департамент: " + ex.Message);
            }
        }
        /// <summary>
        /// Функція для оновлення статусу в Calling
        /// </summary>
        /// <param name="callingId"></param>
        /// <param name="status"></param>
        public void UpdateCallingStatus(int callingId, string status)
        {
            try
            {
                connectionDB.openConnection();

                MySqlCommand command = connectionDB.getConnection().CreateCommand();
                command.CommandText = "UPDATE calling SET status = @status WHERE id = @callingId";
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@callingId", callingId);

                int rowsAffected = command.ExecuteNonQuery();

                connectionDB.closeConnection();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Статус запису успішно оновлено!");
                }
                else
                {
                    MessageBox.Show("Не вдалося знайти запис з вказаним ідентифікатором.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при оновленні статусу запису: " + ex.Message);
            }
        }

        /// <summary>
        /// Оновлення статусу зброї
        /// </summary>
        /// <param name="weaponsId"></param>
        /// <param name="status"></param>
        public void UpdateWeaponStatus(int weaponsId, string status)
        {
            try
            {
                connectionDB.openConnection();

                MySqlCommand command = connectionDB.getConnection().CreateCommand();
                command.CommandText = "UPDATE weapons SET status = @status WHERE id = @weaponsId";
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@weaponsId", weaponsId);

                command.ExecuteNonQuery();

                connectionDB.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при оновленні статусу зброї: " + ex.Message);
            }
        }

        /// <summary>
        /// Оновлення інформації про співробітника
        /// </summary>
        /// <param name="employeeId">Ідентифікатор співробітника</param>
        /// <param name="departmentId">Ідентифікатор відділу</param>
        /// <param name="professionId">Ідентифікатор професії</param>
        public void UpdateEmployeeInfo(int employeeId, int departmentId, int professionId)
        {
            try
            {
                connectionDB.openConnection();

                MySqlCommand command = connectionDB.getConnection().CreateCommand();
                command.CommandText = "UPDATE employees SET id_department = @departmentId, id_profession = @professionId WHERE id = @employeeId";
                command.Parameters.AddWithValue("@departmentId", departmentId);
                command.Parameters.AddWithValue("@professionId", professionId);
                command.Parameters.AddWithValue("@employeeId", employeeId);

                command.ExecuteNonQuery();

                connectionDB.closeConnection();
                MessageBox.Show("Оновленні інформації про співробітника - успішне ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при оновленні інформації про співробітника: " + ex.Message);
            }
        }


    }
}

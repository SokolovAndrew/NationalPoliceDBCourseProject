using PoliceDB.MainClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PoliceDB.Windows.WindowCalling
{
    public partial class InsertCallingForm : Form
    {
        /// <summary>
        /// Підключення класу з методами для додавання даних в БД
        /// </summary>
        InsertInformationDate insertInformationDate = new InsertInformationDate();
        /// <summary>
        /// Підключення класу для отримання списку з назвами департаменту, професій, табельної зброї
        /// </summary>
        DatabaseManager databaseManager = new DatabaseManager();
        public InsertCallingForm()
        {
            InitializeComponent();
            // Встановлюємо в список назви команд
            cBTeam.DataSource = databaseManager.GetTeamNames();
            // Встановлюємо в список назви міст
            cBCity.DataSource = databaseManager.GetCitiesFromTable();
            List<string> statusList = new List<string>() { "Новий", "Невизначено" };
            // Встановлюємо в список назви статусів
            cBStatus.DataSource = statusList;
        }
        /// <summary>
        /// Додати виклик в Базу даних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id_team = cBTeam.SelectedIndex + 1;
            int id_city = cBCity.SelectedIndex + 1;
            string name = tBName.Text;
            string description = tBDescription.Text;
            string street = tBStreet.Text;
            string status = cBStatus.SelectedItem?.ToString();

            if (id_team == 0 || id_city == 0 || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(street) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля перед додаванням виклику.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                insertInformationDate.AddCallingToTable(id_team, id_city, name, description, street, status);
                Close();
            }

        }
    }
}

using PoliceDB.MainClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PoliceDB.Windows.WindowCalling
{
    public partial class ChangeCallingForm : Form
    {
        /// <summary>
        /// Підключення класу для отримання списку з назвами департаменту, професій, табельної зброї
        /// </summary>
        DatabaseManager databaseManager = new DatabaseManager();

        /// <summary>
        /// Об'єкт для зміни інформація в базі даних
        /// </summary>
        ChangeInformationDate changeInformationDate = new ChangeInformationDate();
        public ChangeCallingForm()
        {
            InitializeComponent();
            cBCalling.DataSource = databaseManager.GetCallingList();
            List<string> statusList = new List<string>() {"У процесі","Скасовано","Завершено"};
            // Встановлюємо в список назви статусів
            cBStatus.DataSource = statusList;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string selectedValue = cBCalling.SelectedItem?.ToString();
            string[] parts = selectedValue?.Split('-');
            int id = 0;
            string status = cBStatus.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedValue) && parts.Length > 0 && int.TryParse(parts[0]?.Trim(), out id) && !string.IsNullOrEmpty(status))
            {
                changeInformationDate.UpdateCallingStatus(id, status);
                Close();
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть всі поля перед оновленням статусу виклику.");
            }
        }
    }
}

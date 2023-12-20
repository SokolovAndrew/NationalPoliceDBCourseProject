using PoliceDB.MainClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceDB.Windows.WindowDepatment
{

    public partial class ChangeDepartmentForm : Form
    {
        /// <summary>
        /// Об'єкт для отримання інформації з бази даних
        /// </summary>
        DatabaseManager databaseManager = new DatabaseManager();
        /// <summary>
        /// Об'єкт для зміни інформація в базі даних
        /// </summary>
        ChangeInformationDate changeInformationDate = new ChangeInformationDate();
        public ChangeDepartmentForm()
        {
            InitializeComponent();
            // Встановлюємо департаменти в випадаючий список
            cBDepartment.DataSource = databaseManager.GetDepartmentNamesFromTable();
            // Встановлюємо міста в випадаючий список
            cBCity.DataSource = databaseManager.GetCitiesFromTable();
        }
        /// <summary>
        /// Виклик запита на зміну даних в таблиці Департамент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Проверка наличия выбранного города
            if (cBCity.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть назву міста.");
                return;
            }

            // Проверка наличия выбранного департамента
            if (cBDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть назву департаменту.");
                return;
            }

            // Получение данных для обновления
            int cityId = cBCity.SelectedIndex + 1; // Получаем индекс выбранного города
            int departmentId = cBDepartment.SelectedIndex + 1; // Получаем индекс выбранного департамента
            string departmentName = tBName.Text.Trim(); // Получаем название департамента из текстового поля
            string street = tBStreet.Text.Trim(); // Получаем название улицы из текстового поля

            // Проверка наличия названия департамента и улицы
            if (string.IsNullOrEmpty(departmentName))
            {
                MessageBox.Show("Введіть назву департаменту.");
                return;
            }
            if (string.IsNullOrEmpty(street))
            {
                MessageBox.Show("Введіть назву вулиці.");
                return;
            }

            // Отображение окна подтверждения обновления
            DialogResult result = MessageBox.Show("Ви впевнені, що бажаєте оновити дані департаменту?", "Підтвердження оновлення", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Выполнение обновления данных
                changeInformationDate.UpdateDepartmentInTable(departmentId, departmentName, cityId, street);
                Close();
            }
        }
    }
}

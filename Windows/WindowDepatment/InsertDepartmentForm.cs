using PoliceDB.MainClasses;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PoliceDB.Windows.WindowDepatment
{
    public partial class InsertDepartmentForm : Form
    {
        /// <summary>
        /// Підключення класу з методами для додавання даних в БД
        /// </summary>
        InsertInformationDate insertInformationDate = new InsertInformationDate();
        /// <summary>
        /// Підключення класу для отримання списку з назвами міст
        /// </summary>
        DatabaseManager databaseManager = new DatabaseManager();
        public InsertDepartmentForm()
        {
            InitializeComponent();
            // Встановлюємо міста в випадаючий список
            cBCity.DataSource = databaseManager.GetCitiesFromTable();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            string departmentName = tBName.Text.Trim();
            string street = tBStreet.Text.Trim();

            // Перевірка наявності спецсимволів
            bool containsSpecialCharacters = ContainsSpecialCharacters(departmentName) || ContainsSpecialCharacters(street);

            if (!string.IsNullOrEmpty(departmentName) && !string.IsNullOrEmpty(street) && !containsSpecialCharacters)
            {
                // Заміна символу ' на \'
                departmentName = departmentName.Replace("'", "\\'");
                street = street.Replace("'", "\\'");

                // Отримати ідентифікатор міста залежно від вашої логіки
                int id_city = cBCity.SelectedIndex + 1;

                insertInformationDate.AddDepartmentToTable(departmentName, id_city, street);
                Close();
            }
            else
            {
                MessageBox.Show("Введіть назву департаменту коректно");
            }
        }

        private bool ContainsSpecialCharacters(string input)
        {
            // Перевірка наявності спецсимволів за допомогою регулярного виразу
            // Перевірка наявності спецсимволів за допомогою регулярного виразу
            string pattern = @"[!@#$%^&*(),.?\\"":{}|<>]";
            return Regex.IsMatch(input, pattern);
        }

    }
}

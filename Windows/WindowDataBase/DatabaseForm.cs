using PoliceDB.MainClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PoliceDB.Windows.WindowDataBase
{
    public partial class DatabaseForm : Form
    {
        /// <summary>
        /// Зберігає об'єкт класу для отриманя назв таблиць з бази даних
        /// </summary>
        DatabaseManager databaseManager = new DatabaseManager();
        /// <summary>
        /// Зберігає об'єкт класу для отриманя таблиці з бази даних
        /// </summary>
        GetTableDate getTableDate = new GetTableDate();
        /// <summary>
        /// Зберігає назви таблиці для виводу в формі
        /// </summary>
        static List<string> viewNames = new List<string>()
        {
        "Оружейні",
        "Виклики",
        "Міста",
        "Склад команди",
        "Департаменти",
        "Співробітники",
        "Професії",
        "Команди",
        "Моделі зброї",
        "Зброя в оружейній"
        };
        // Таблиця в яку будуть занесені дані
        static DataGridView dgw;
        // Назва таблиці
        static string nameTable;
        // Кількість виведених колонок
        static int rowColumns;
        /// <summary>
        /// Отримуємо робочу назву для Бази даних по назві з форми
        /// </summary>
        /// <param name="viewName"></param>
        /// <returns></returns>
        static string GetDBViewName(string viewName)
        {
            // Створюємо відповідність між назвами з форми і назвами з бази даних
            Dictionary<string, string> viewNameMappings = new Dictionary<string, string>()
    {
        { "Оружейні", "armory_view" },
        { "Виклики", "calling_view" },
        { "Міста", "city_view" },
        { "Склад команди", "compositionteam_view" },
        { "Департаменти", "department_view" },
        { "Співробітники", "employees_view" },
        { "Професії", "profession_view" },
        { "Команди", "team_view" },
        { "Моделі зброї", "typeweapons_view" },
        { "Зброя в оружейній", "weapons_view" }
    };

            // Перевіряємо, чи є передана назва у списку viewNames
            if (viewNames.Contains(viewName))
            {
                // Получаем соответствующее название из viewNamesDB
                string dbViewName = viewNameMappings[viewName];
                return dbViewName;
            }

            // Якщо передану назву не знайдено, повертаємо порожній рядок або можемо викидати виняток
            return string.Empty;
        }

        public DatabaseForm()
        {
            InitializeComponent();
            // Ініціалізація випадаючого списку назвами з таблиці
            cbNameTables.DataSource = viewNames;
        }

        /// <summary>
        /// Виникає при зміні таблиці, виводить нову таблицю на екран
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbNameTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Таблиця в яку будуть занесені дані
            dgw = dgwTable;
            // Назва таблиці
            nameTable = GetDBViewName(cbNameTables.SelectedItem.ToString());
            // Кількість виведених колонок
            rowColumns = (int)nudValueColumns.Value;
            FormClasses.ShowTable(dgw, nameTable, rowColumns);
        }
        /// <summary>
        /// Виникає при зміні кількості виведених строк в таблиці
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudValueColumns_ValueChanged(object sender, EventArgs e)
        {
            // Кількість виведених колонок
            rowColumns = (int)nudValueColumns.Value;
            FormClasses.ShowTable(dgw, nameTable, rowColumns);
        }
        /// <summary>
        /// Прибираємо системний звук при натиску Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudValueColumns_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}

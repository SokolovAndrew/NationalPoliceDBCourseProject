using PoliceDB.MainClasses;
using System;
using System.Windows.Forms;

namespace PoliceDB.Windows.WindowDepatment
{
    public partial class DatabaseDepartment : Form
    {
        /// <summary>
        /// Зберігає об'єкт класу для отриманя назв таблиць з бази даних
        /// </summary>
        DatabaseManager databaseManager = new DatabaseManager();
        /// <summary>
        /// Зберігає об'єкт класу для отриманя таблиці з бази даних
        /// </summary>
        GetTableDate getTableDate = new GetTableDate();

        // Таблиця в яку будуть занесені дані
        static DataGridView dgw;
        // Назва таблиці
        static string nameTable = "department_view";
        // Кількість виведених колонок
        static int rowColumns;

        public DatabaseDepartment()
        {
            InitializeComponent();
            // Таблиця в яку будуть занесені дані
            dgw = dgwTable;
            // Кількість виведених колонок
            rowColumns = (int)nudValueColumns.Value;
            FormClasses.ShowTable(dgw, nameTable, rowColumns);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            var newForm = new InsertDepartmentForm();

            // Открытие новой формы как модального диалога
            newForm.ShowDialog();
            // Когда новая форма закрывается, предыдущая форма становится активной снова
            Activate();
            // Оновлення таблиці
            FormClasses.ShowTable(dgw, nameTable, rowColumns);
        }

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

        private void btnChange_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            var newForm = new ChangeDepartmentForm();

            // Открытие новой формы как модального диалога
            newForm.ShowDialog();
            // Когда новая форма закрывается, предыдущая форма становится активной снова
            Activate();
            // Оновлення таблиці
            FormClasses.ShowTable(dgw, nameTable, rowColumns);
        }
    }
}

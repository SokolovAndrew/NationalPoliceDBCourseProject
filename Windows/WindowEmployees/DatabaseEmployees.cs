using PoliceDB.MainClasses;
using System;
using System.Windows.Forms;

namespace PoliceDB.Windows.WindowEmployees
{
    public partial class DatabaseEmployees : Form
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
        static string nameTable = "employees_view";
        // Кількість виведених колонок
        static int rowColumns;
        // Поле для пошуку по name
        string searchName = "";
        public DatabaseEmployees()
        {
            InitializeComponent();
            // Таблиця в яку будуть занесені дані
            dgw = dgwTable;
            // Кількість виведених колонок
            rowColumns = (int)nudValueColumns.Value;
            if (searchName != "")
            {
                FormClasses.ShowTable(dgw, nameTable, rowColumns, searchName);
            }
            else
            {
                FormClasses.ShowTable(dgw, nameTable, rowColumns);
            }
        }
        /// <summary>
        /// Пошук по name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchName = tBSearch.Text;
            if (searchName != "")
            {
                FormClasses.ShowTable(dgw, nameTable, rowColumns, searchName);
            }
            else
            {
                FormClasses.ShowTable(dgw, nameTable, rowColumns);
            }
        }
        /// <summary>
        /// Пошук при натиску на Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Предотвращаем воспроизведение системного звука
                // Проверяем, какая кнопка должна быть вызвана
                if (ActiveControl == tBSearch)
                {
                    // Вызываем определенную кнопку
                    btnSearch.PerformClick(); 
                }
            }
        }
        /// <summary>
        /// Додавання нового співробітника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            var newForm = new InsertEmployeesForm();

            // Открытие новой формы как модального диалога
            newForm.ShowDialog();
            // Когда новая форма закрывается, предыдущая форма становится активной снова
            Activate();
            // Оновлення таблиці
            FormClasses.ShowTable(dgw, nameTable, rowColumns);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            var newForm = new ChangeEmployeesForm();

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

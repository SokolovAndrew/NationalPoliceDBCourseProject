using PoliceDB.MainClasses;
using System;
using System.Windows.Forms;

namespace PoliceDB.Windows.WindowCalling
{
   
    public partial class DatabaseCalling : Form
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
        static string nameTable = "calling_view";
        // Кількість виведених колонок
        static int rowColumns;
        // Поле для пошуку по name
        string searchName = "";

        public DatabaseCalling()
        {
            InitializeComponent();
            // Таблиця в яку будуть занесені дані
            dgw = dgwTable;
            // Кількість виведених колонок
            rowColumns = (int)nudValueColumns.Value;
            FormClasses.ShowTable(dgw, nameTable, rowColumns);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchName = tBSearch.Text;
            if (searchName != "")
            {
                FormClasses.ShowTableCalling(dgw, nameTable, rowColumns, searchName);
            }
            else
            {
                FormClasses.ShowTable(dgw, nameTable, rowColumns);
            }
        }

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
        /// Зміна кількості виведених строк з таблиці
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
        /// Прибираємо системний звук після натиску Enter
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
        /// <summary>
        /// Відкриття форми для вставки даних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            var newForm = new InsertCallingForm();

            // Открытие новой формы как модального диалога
            newForm.ShowDialog();
            // Когда новая форма закрывается, предыдущая форма становится активной снова
            Activate();
            // Оновлення таблиці
            FormClasses.ShowTable(dgw, nameTable, rowColumns);
        }
        /// <summary>
        /// Відкриття даних для зміни даних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            var newForm = new ChangeCallingForm();

            // Открытие новой формы как модального диалога
            newForm.ShowDialog();
            // Когда новая форма закрывается, предыдущая форма становится активной снова
            Activate();
            // Оновлення таблиці
            FormClasses.ShowTable(dgw, nameTable, rowColumns);
        }
    }
}

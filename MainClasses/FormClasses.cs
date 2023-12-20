using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceDB.MainClasses
{
    class FormClasses
    {
        /// <summary>
        /// Зберігає об'єкт класу для отриманя таблиці з бази даних
        /// </summary>
        static GetTableDate getTableDate = new GetTableDate();
        /// <summary>
        /// Функція для виводу таблиці на форму
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="nameTable"></param>
        /// <param name="valueColumns"></param>
        public static void ShowTable(DataGridView dataGridView, string nameTable, int valueColumns)
        {
            dataGridView.DataSource = getTableDate.GetTable(nameTable, valueColumns);
            // Прибираємо рядок зліва
            dataGridView.RowHeadersVisible = false;
            // Текст робимо по центру
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Текст назв колонок робимо по центру
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Текст назв колонок робимо жирним шрифтом
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            // Розтягуємо данні в таблиці по всій ширині
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void ShowTable(DataGridView dataGridView, string nameTable, int valueColumns, string SearchName)
        {
            dataGridView.DataSource = getTableDate.GetTable(nameTable, valueColumns, SearchName);
            // Прибираємо рядок зліва
            dataGridView.RowHeadersVisible = false;
            // Текст робимо по центру
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Текст назв колонок робимо по центру
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Текст назв колонок робимо жирним шрифтом
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            // Розтягуємо данні в таблиці по всій ширині
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void ShowTableCalling(DataGridView dataGridView, string nameTable, int valueColumns, string SearchName)
        {
            dataGridView.DataSource = getTableDate.GetTableCalling(nameTable, valueColumns, SearchName);
            // Прибираємо рядок зліва
            dataGridView.RowHeadersVisible = false;
            // Текст робимо по центру
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Текст назв колонок робимо по центру
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Текст назв колонок робимо жирним шрифтом
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            // Розтягуємо данні в таблиці по всій ширині
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

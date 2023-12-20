using PoliceDB.MainClasses;
using System;
using System.Windows.Forms;

namespace PoliceDB.Windows.WindowEmployees
{
    public partial class ChangeEmployeesForm : Form
    {
        /// <summary>
        /// Підключення класу для отримання списку з назвами департаменту, професій, табельної зброї
        /// </summary>
        DatabaseManager databaseManager = new DatabaseManager();

        /// <summary>
        /// Об'єкт для зміни інформація в базі даних
        /// </summary>
        ChangeInformationDate changeInformationDate = new ChangeInformationDate();
        public ChangeEmployeesForm()
        {
            InitializeComponent();
            // Заповнюємо список департаментами
            cBDepartment.DataSource = databaseManager.GetDepartmentNamesFromTable();
            // Заповнюємо список професіями
            cBProfession.DataSource = databaseManager.GetProfessionList();
            // Заповнюємо список робітниками
            cBEmployees.DataSource = databaseManager.GetEmployeesList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете змінити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                changeInformationDate.UpdateEmployeeInfo(cBEmployees.SelectedIndex + 1, cBDepartment.SelectedIndex + 1, cBProfession.SelectedIndex + 1);
                Close();
            }
        }
    }
}

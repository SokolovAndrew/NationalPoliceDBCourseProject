using PoliceDB.Windows.WindowCalling;
using PoliceDB.Windows.WindowDataBase;
using PoliceDB.Windows.WindowDepatment;
using PoliceDB.Windows.WindowEmployees;
using System;
using System.Windows.Forms;

namespace PoliceDB
{
    public partial class MainMenu : Form
    {
       private Form openForm; // Зміна зберігає відкрите вікно

        private void OpenNewForm(Form childForm)
        {
            if (openForm != null)
                openForm.Close(); // закриваємо минулу відкриту форму

            openForm = childForm; // встановлюємо нову активну форму
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public MainMenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Відкритя форми з таблицями Баз даних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDatabase_Click(object sender, EventArgs e)
        {
            OpenNewForm(new DatabaseForm());
        }
        /// <summary>
        ///  Відкритя форми з управлінням Департаментами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDepartments_Click(object sender, EventArgs e)
        {
            OpenNewForm(new DatabaseDepartment());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenNewForm(new DatabaseEmployees());
        }

        private void btnCalling_Click(object sender, EventArgs e)
        {
            OpenNewForm(new DatabaseCalling());
        }
    }
}

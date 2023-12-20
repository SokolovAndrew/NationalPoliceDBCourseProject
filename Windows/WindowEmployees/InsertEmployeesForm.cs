using PoliceDB.MainClasses;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PoliceDB.Windows.WindowEmployees
{
    public partial class InsertEmployeesForm : Form
    {

        /// <summary>
        /// Підключення класу з методами для додавання даних в БД
        /// </summary>
        InsertInformationDate insertInformationDate = new InsertInformationDate();
        /// <summary>
        /// Підключення класу для отримання списку з назвами департаменту, професій, табельної зброї
        /// </summary>
        DatabaseManager databaseManager = new DatabaseManager();
        public InsertEmployeesForm()
        {
            InitializeComponent();
            // Заповнюємо список департаментами
            cBDepartment.DataSource = databaseManager.GetDepartmentNamesFromTable();
            int id_armory = databaseManager.GetArmoryId(cBDepartment.SelectedIndex + 1);
            // Заповнюємо список вільною зброєю
            cBWeapon.DataSource = databaseManager.GetAvailableWeapons(id_armory);
            // Заповнюємо список професіями
            cBProfession.DataSource = databaseManager.GetProfessionList();
            List<string> genderList = new List<string>() { "Man", "Woman" };
            // Заповнюємо список з полом
            cBGender.DataSource = genderList;
        }
        /// <summary>
        /// Додавання нового сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id_department = cBDepartment.SelectedIndex + 1;
            string selectedWeapon = cBWeapon.SelectedItem?.ToString();
            string[] parts = selectedWeapon?.Split('-');
            int id_weapons = parts?.Length > 0 ? int.Parse(parts[0].Trim()) : 0;
            int id_profession = cBProfession.SelectedIndex + 1;
            string name = tBName.Text;
            string gender = cBGender.SelectedItem?.ToString();

            if (id_department < 0 || string.IsNullOrEmpty(selectedWeapon) || id_weapons == 0 || id_profession <= 0 || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля перед додаванням запису.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка формату імені (Фамілія Ім'я По-батькові)
            string namePattern = @"^[А-ЯІЇЄ][а-яіїє']+(?: [А-ЯІЇЄ][а-яіїє']+){2}$";
            if (!Regex.IsMatch(name, namePattern))
            {
                MessageBox.Show("Невірний формат імені. Введіть ім'я у форматі 'Фамілія Ім'я По-батькові'.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            insertInformationDate.AddEmployeeToTable(id_department, id_weapons, id_profession, name, gender);
            Close();
        }


        /// <summary>
        /// Зміна відображення вільної зброї в залежності від департаменту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_armory = databaseManager.GetArmoryId(cBDepartment.SelectedIndex + 1);
            cBWeapon.DataSource = databaseManager.GetAvailableWeapons(id_armory);
        }

        private void panelDeskTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanelDeskTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cBProfession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblProfession_Click(object sender, EventArgs e)
        {

        }

        private void tBName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblWeapon_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }
    }
}

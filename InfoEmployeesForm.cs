using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class InfoEmployeesForm : Form
    {
        private Form1 mainForm; // Ссылка на основную форму
        private int employeeIndex; // Индекс сотрудника в списке
        public InfoEmployeesForm(Form1 form, int index, string surname, string name, string patronymic, string gender, DateTime dateOfBirth, string address, string specialty, string experience, string education, string educationDocument, string salary, string photoPath)
        {
            InitializeComponent();
            mainForm = form; // Сохраняем ссылку на основную форму
            employeeIndex = index; // Сохраняем индекс сотрудник
            // Установка текста для элементов управления
            SurnameBox.Text = surname;
            NameBox.Text = name;
            PatronymicBox.Text = patronymic;
            comboBox_gender.Text = gender;
            dateTimePickerDateOfBirth.Value = dateOfBirth;
            textBox_Adress.Text = address;
            textBox_Speciality.Text = specialty;
            textBox_Expirience.Text = experience;
            textBox_Education.Text = education;
            textBox_EdDoc.Text = educationDocument;
            textBox_Salary.Text = salary;
            LoadEmployeePhoto(photoPath);
        }



        private void LoadEmployeePhoto(string photoPath)
        {
            if (File.Exists(photoPath))
            {
                try
                {
                    // Загружаем изображение в PictureBox
                    PhotoBox.Image = Image.FromFile(photoPath);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Файл изображения не найден.");
            }
        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            string surname = SurnameBox.Text;
            string name = NameBox.Text;
            string patronymic = PatronymicBox.Text;
            string gender = comboBox_gender.Text;
            DateTime dateOfBirth = dateTimePickerDateOfBirth.Value;
            string address = textBox_Adress.Text;
            string specialty = textBox_Speciality.Text;
            string experience = textBox_Expirience.Text;
            string education = textBox_Education.Text;
            string educationDocument = textBox_EdDoc.Text;
            string salary = textBox_Salary.Text;
            string photoPath = PhotoBox.ImageLocation; // Укажите новый путь к фото, если это необходимо

            // Создаем объект с обновленными данными
            Employee updatedEmployee = new Employee(surname, name, patronymic, gender, dateOfBirth, address, specialty, experience, education, educationDocument, salary, photoPath);
            mainForm.UpdateEmployeeList(employeeIndex, updatedEmployee);

            // Закрываем форму
            this.Close();
        }

        private void PhotoBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Выберите фото сотрудника";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string photoPath = openFileDialog.FileName;
                    LoadEmployeePhoto(photoPath); // Загружаем фото в PictureBox
                    PhotoBox.ImageLocation = photoPath; // Сохраняем путь к фото в метке
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace kurs
{
    public partial class TeamMemberForm : Form
    {
        public List<string> employeeList = new();
        public TeamMemberForm()
        {
            InitializeComponent();
           
            LoadEmployeeListFromJson(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "employeeList.json"));
        }
        public void AddEmployeeToCheckedListBox(string employeeName)
        {
            if (!employeeList.Contains(employeeName)) // Проверяем, чтобы не добавлять дубликаты
            {
                employeeList.Add(employeeName);
                checkedListBoxEmployees.Items.Add(employeeName);
            }
        }
        // Метод для загрузки сотрудников при открытии формы
        public void LoadEmployees(List<Employee> employees)
        {
            checkedListBoxEmployees.Items.Clear(); // Очищаем текущие элементы
            employeeList.Clear(); // Очищаем список сотрудников

            foreach (var employee in employees)
            {
                string employeeName = $"{employee.Surname} {employee.Name} {employee.Patronymic}";
                employeeList.Add(employeeName);
                checkedListBoxEmployees.Items.Add(employeeName);
            }
        }
        // Метод для получения списка сотрудников
        public List<string> GetEmployeeList()
        {
            return employeeList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string teamName = textBoxTeamName.Text;

            // Проверяем, что название не пустое
            if (string.IsNullOrWhiteSpace(teamName))
            {
                MessageBox.Show("Пожалуйста, введите название коллектива.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем список для хранения коллективов
            List<string> teamMembers = new();

            // Проходим по строкам DataGridView и собираем данные
            foreach (DataGridViewRow row in dataGridViewTeamMembers.Rows)
            {
                if (row.Cells["LastName"].Value != null)
                {
                    string lastName = row.Cells["LastName"].Value.ToString();
                    string startDate = row.Cells["StartDate"].Value?.ToString() ?? "Не указана";
                    string endDate = row.Cells["EndDate"].Value?.ToString() ?? "Не указана";

                    teamMembers.Add($"{lastName} (с {startDate} по {endDate})");
                }
            }



            // Закрываем форму и передаем данные обратно в Form1
            Form1 mainForm = (Form1)Owner;
            if (mainForm == null)
            {
                MessageBox.Show("Не удалось получить родительскую форму.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mainForm.AddTeamName(teamName);
            mainForm.AddTeamMembers(teamName, teamMembers);
            mainForm.SaveTeamsDataToFile("teamsData.json");
            this.Close();
        }

        private void btnAddSelectedEmployees_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxEmployees.CheckedItems)
            {
                string selectedEmployee = item.ToString();
                // Добавляем выбранного сотрудника в DataGridView
                dataGridViewTeamMembers.Rows.Add(selectedEmployee, "Не указана", "Не указана");
            }
        }
        // Новый метод для сохранения списка сотрудников в файл JSON
        public void SaveEmployeeListToJson(string filePath)
        {
            var json = JsonSerializer.Serialize(employeeList);
            File.WriteAllText(filePath, json);
        }

        // Новый метод для загрузки списка сотрудников из файла JSON
        public void LoadEmployeeListFromJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                employeeList = JsonSerializer.Deserialize<List<string>>(json);

                checkedListBoxEmployees.Items.Clear(); // Очищаем текущие элементы
                foreach (var employeeName in employeeList)
                {
                    checkedListBoxEmployees.Items.Add(employeeName);
                }
            }

        }

    }
}

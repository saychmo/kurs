using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace kurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            projects = ProgramJSON.LoadProjects();
            UpdateProjectListView();
            form2 = new Form2();
            LoadEmployees();
            LoadTeamsFromFile();
            LoadTeamsDataFromFile("teamsData.json");
        }

        private List<Employee> employees = new();
        private List<Project> projects = new();
        private TeamMemberForm teamMemberForm = null!;
        public Form2 form2 = null!;
        private ReplaceProjectForm replaceForm;
        private void LoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    photoPath.ImageLocation = filePath; // устанавливаем путь к изображению
                }
            }
        }


        private void Surname_Enter(object sender, EventArgs e)
        {
            if (Surname_textBox.Text == "Фамилия")
            {
                Surname_textBox.Clear();
                Surname_textBox.ForeColor = Color.Black;
            }
        }

        private void Surname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Surname_textBox.Text) || Surname_textBox.Text == "Фамилия")
            {
                Surname_textBox.Text = "Фамилия";
                Surname_textBox.ForeColor = Color.Gray;
            }
        }

        private void Name_textBox_Enter(object sender, EventArgs e)
        {
            if (Name_textBox.Text == "Имя")
            {
                Name_textBox.Clear();
                Name_textBox.ForeColor = Color.Black;
            }
        }

        private void Name_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_textBox.Text) || Name_textBox.Text == "Имя")
            {
                Name_textBox.Text = "Имя";
                Name_textBox.ForeColor = Color.Gray;
            }
        }

        private void Address_textBox_Enter(object sender, EventArgs e)
        {
            if (Address_textBox.Text == "Ул. , д.")
            {
                Address_textBox.Clear();
                Address_textBox.ForeColor = Color.Black;
            }
        }

        private void Address_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Address_textBox.Text) || Address_textBox.Text == "Ул. , д.")
            {
                Address_textBox.Text = "Ул. , д.";
                Address_textBox.ForeColor = Color.Gray;
            }
        }

        private void Patronymic_textBox_Enter(object sender, EventArgs e)
        {
            if (Patronymic_textBox.Text == "Отчество")
            {
                Patronymic_textBox.Clear();
                Patronymic_textBox.ForeColor = Color.Black;
            }
        }

        private void Patronymic_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Patronymic_textBox.Text) || Patronymic_textBox.Text == "Отчество")
            {
                Patronymic_textBox.Text = "Отчество";
                Patronymic_textBox.ForeColor = Color.Gray;
            }
        }

        public void CreateProject_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new(); // Передаем список проектов
            form2.ProjectAdded += Form2_ProjectAdded; // Подписываемся на событие
            form2.UpdateLiderComboBox(employees);
            form2.ShowDialog();
        }

        // Обработчик обновления проекта
        private void ReplaceForm_ProjectUpdated(Project updatedProject)
        {
            // Находим проект по имени
            var existingProjectIndex = projects.FindIndex(p => p.ProjectName == updatedProject.ProjectName);

            if (existingProjectIndex != -1)
            {
                // Обновляем проект
                projects[existingProjectIndex] = updatedProject;

                // Сохраняем изменения
                ProgramJSON.SaveProjects(projects);
                UpdateProjectListView();

                MessageBox.Show("Проект успешно обновлен", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form2_ProjectAdded(Project project)
        {
            projects.Add(project);
            ProgramJSON.SaveProjects(projects);
            UpdateProjectListView();

            DetailForm detailForm = new(project);
            detailForm.ShowDialog();
        }

        private void UpdateProjectListView()
        {
            listViewProjects.Items.Clear();
            foreach (var project in projects)
            {
                ListViewItem item = new(project.ProjectName);
                item.SubItems.Add(project.StartDate.ToShortDateString());
                item.SubItems.Add(project.EndDate.ToShortDateString());
                listViewProjects.Items.Add(project.ProjectName);
            }
        }

        private void addEmpoeeys_button_Click(object sender, EventArgs e)
        {
            if (Surname_textBox.Text == "Фамилия" ||
                Name_textBox.Text == "Имя" ||
                Patronymic_textBox.Text == "Отчество")
            {
                MessageBox.Show("Пожалуйста, заполните все поля: Фамилия, Имя и Отчество.");
                return;
            }
            // Проверка на уникальность сотрудника
            string fullName = $"{Surname_textBox.Text} {Name_textBox.Text} {Patronymic_textBox.Text}";
            if (employees.Any(emp => $"{emp.Surname} {emp.Name} {emp.Patronymic}" == fullName))
            {
                MessageBox.Show("Сотрудник с таким ФИО уже существует.");
                return;
            }
            // Проверка пола
            if (Gender.Text == "Пол")
            {
                MessageBox.Show("Укажите пол сотрудника.");
                return;
            }

            // Проверка даты рождения
            if (date_of_bith_Picker.Value >= DateTime.Now.Date || date_of_bith_Picker.Value.Date < new DateTime(1900, 1, 1))
            {
                MessageBox.Show("Укажите корректную дату рождения (не сегодняшнюю и не будущую дату, и не раньше 1900 года).");
                return;
            }

            // Проверка адреса
            if (Address_textBox.Text == "Ул. , д.")
            {
                MessageBox.Show("Укажите адрес сотрудника.");
                return;
            }

            // Проверка специальности
            if (specialty_comboBox.Text == "Специальность")
            {
                MessageBox.Show("Выберите специальность сотрудника.");
                return;
            }

            // Проверка опыта работы
            if (experience_comboBox.Text == "Опыт работы")
            {
                MessageBox.Show("Укажите опыт работы сотрудника.");
                return;
            }

            // Проверка образования
            if (string.IsNullOrWhiteSpace(education_textBox.Text))
            {
                MessageBox.Show("Укажите образование сотрудника.");
                return;
            }

            // Проверка документа об образовании
            if (string.IsNullOrWhiteSpace(educationDocument_textBox.Text))
            {
                MessageBox.Show("Укажите документ об образовании сотрудника.");
                return;
            }

            // Проверка зарплаты перед созданием сотрудника
            if (!decimal.TryParse(salary_textBox.Text, out decimal salaryValue) || salaryValue <= 0)
            {
                MessageBox.Show("Зарплата работника должна быть положительным числом!");
                return;
            }
            // Удаляем сообщение о том, что нет сотрудников, если оно есть
            if (listExployee_textBox.Text.Contains("Нет сотрудников для отображения."))
            {
                listExployee_textBox.Clear();
            }
            Employee employee = new(
                Surname_textBox.Text,
                Name_textBox.Text,
                Patronymic_textBox.Text,
                Gender.Text,
                date_of_bith_Picker.Value,
                Address_textBox.Text,
                specialty_comboBox.Text,
                experience_comboBox.Text,
                education_textBox.Text,
                educationDocument_textBox.Text,
                salary_textBox.Text,
                photoPath.ImageLocation
            );
            listExployee_textBox.Text += $"{Surname_textBox.Text} {Name_textBox.Text} {Patronymic_textBox.Text}" + "\r\n";

            employees.Add(employee);

            // Обновляем CheckedListBox в TeamMemberForm
            if (teamMemberForm != null && !teamMemberForm.IsDisposed)
            {
                teamMemberForm.AddEmployeeToCheckedListBox($"{Surname_textBox.Text} {Name_textBox.Text} {Patronymic_textBox.Text}");
            }

        }


        private void listExployee_textBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listExployee_textBox.GetLineFromCharIndex(listExployee_textBox.SelectionStart);
            if (index >= 0 && index < employees.Count)
            {
                Employee selectedEmployee = employees[index];

                // Создаем новую форму и передаем данные
                InfoEmployeesForm detailsForm = new(
                    this, // Передаем ссылку на основную форму
                    index,
                    selectedEmployee.Surname,
                    selectedEmployee.Name,
                    selectedEmployee.Patronymic,
                    selectedEmployee.Gender,
                    selectedEmployee.DateOfBirth,
                    selectedEmployee.Address,
                    selectedEmployee.Specialty,
                    selectedEmployee.Experience,
                    selectedEmployee.Education,
                    selectedEmployee.EducationDocument,
                    selectedEmployee.Salary,
                    selectedEmployee.PhotoPath
                );

                detailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Недостаточно данных для отображения информации о сотруднике.");
            }
        }
        private void SaveEmployees()
        {
            ProgramJSON.SaveEmployees(employees);

        }

        private void LoadEmployees()
        {
            listExployee_textBox.Clear();
            employees = ProgramJSON.LoadEmployees();
            if (employees != null)
            {
                foreach (var employee in employees)
                {
                    listExployee_textBox.AppendText($"{employee.Surname} {employee.Name} {employee.Patronymic}\r\n");
                }
            }
            else
            {
                // Обработка случая, если employees равно null
                listExployee_textBox.AppendText("Нет сотрудников для отображения.\n");
            }


            // Открываем Form2 и передаем список сотрудников
            Form2 form2 = new();
            form2.UpdateLiderComboBox(employees);

        }
        private void listViewProjects_DoubleClick(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedItems.Count > 0)
            {
                string selectedProjectName = listViewProjects.SelectedItems[0].Text;
                Project selectedProject = projects.Find(p => p.ProjectName == selectedProjectName);

                if (selectedProject != null)
                {
                    DetailForm detailForm = new(selectedProject);
                    detailForm.ShowDialog();
                }
            }
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedItems.Count > 0)
            {
                int selectedIndex = listViewProjects.SelectedItems[0].Index;
                projects.RemoveAt(selectedIndex);
                UpdateProjectListView();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите проект для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (employees.Count == 0)
            {
                MessageBox.Show("Список сотрудников пуст.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, выбран ли сотрудник в TextBox (например, выделение текста)
            if (listExployee_textBox.SelectionLength > 0)
            {
                string selectedEmployee = listExployee_textBox.SelectedText.Trim();

                // Находим индекс выбранного сотрудника
                int indexToRemove = -1;
                for (int i = 0; i < employees.Count; i++)
                {
                    string fullName = $"{employees[i].Surname} {employees[i].Name} {employees[i].Patronymic}";
                    if (fullName.Equals(selectedEmployee, StringComparison.OrdinalIgnoreCase))
                    {
                        indexToRemove = i;
                        break;
                    }
                }

                if (indexToRemove != -1)
                {
                    var removedEmployee = employees[indexToRemove];
                    string fullName = $"{removedEmployee.Surname} {removedEmployee.Name} {removedEmployee.Patronymic}";

                    employees.RemoveAt(indexToRemove);
                    listExployee_textBox.Text = string.Join(Environment.NewLine, employees.Select(e => $"{e.Surname} {e.Name} {e.Patronymic}"));

                    // Уведомляем форму создания команды об удалении (если она открыта)
                    if (teamMemberForm != null)
                    {
                        teamMemberForm.RemoveEmployeeFromAllLists(fullName);
                    }
                    else
                    {
                        // Если форма не открыта, вызываем обработчик напрямую
                        OnEmployeeDeletedFromList(fullName);
                    }
                }
                else
                {
                    MessageBox.Show("Выбранный сотрудник не найден в списке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void UpdateEmployeeList(int index, Employee updatedEmployee)
        {
            if (index >= 0 && index < employees.Count)
            {
                // Обновляем информацию о сотруднике
                employees[index] = updatedEmployee;

                SaveEmployees();
                LoadEmployees();
                form2.UpdateLiderComboBox(employees);
            }
        }


        public void btnCreateTeam_Click(object sender, EventArgs e)
        {
            teamMemberForm = new TeamMemberForm(this);
            teamMemberForm.Owner = this;
            teamMemberForm.LoadEmployees(employees);
            teamMemberForm.EmployeeDeletedFromList += OnEmployeeDeletedFromList;
            teamMemberForm.ShowDialog();
            UpdateEmployeeList_1(teamMemberForm);
        }

        private Dictionary<string, List<string>> teamsData = new();
        private TeamInfoForm teamInfoForm;

        // Обработчик удаления сотрудника из всех списков
        private void OnEmployeeDeletedFromList(string fullName)
        {
            // Удаляем сотрудника из всех команд
            foreach (var team in teamsData.Keys.ToList())
            {
                if (teamsData.ContainsKey(team))
                {
                    var updatedMembers = teamsData[team]
                        .Where(member => !member.StartsWith(fullName))
                        .ToList();

                    teamsData[team] = updatedMembers;
                }
            }

            // Сохраняем изменения
            SaveTeamsDataToFile("teamsData.json");

            // Обновляем открытую форму информации о команде
            if (teamInfoForm != null && teamInfoForm.Visible)
            {
                teamInfoForm.RemoveTeamMember(fullName);
            }
        }
        public void AddTeamName(string teamName)
        {
            textBoxTeams.AppendText(teamName + Environment.NewLine);
            SaveTeamNameToFile(teamName); // Сохраняем название в файл
        }
        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            // Получаем выделенный текст из textBoxTeams
            var selectedText = textBoxTeams.SelectedText;

            if (!string.IsNullOrEmpty(selectedText))
            {
                // Удаляем строку из textBoxTeams
                string[] lines = textBoxTeams.Lines;

                // Фильтруем список, исключая выделенный элемент
                var updatedLines = lines.Where(line => line != selectedText).ToList();

                // Обновляем текстовое поле
                textBoxTeams.Lines = updatedLines.ToArray();

                // Также удаляем название коллектива из хранимых данных
                teamsData.Remove(selectedText);
                SaveTeamsDataToFile("teamsData.json");
                SaveTeamsToFile();
            }
            else
            {
                MessageBox.Show("Выберите название коллектива для удаления.");
            }
        }
        private void SaveTeamNameToFile(string teamName)
        {
            string filePath = "teams.txt"; // Путь к файлу
            using (StreamWriter writer = new(filePath, true)) // true для добавления в файл
            {
                writer.WriteLine(teamName);
            }
        }
        private void LoadTeamsFromFile()
        {
            string filePath = "teams.txt"; // Путь к файлу
            if (File.Exists(filePath))
            {
                string[] teamNames = File.ReadAllLines(filePath);
                foreach (string teamName in teamNames)
                {
                    textBoxTeams.AppendText(teamName + Environment.NewLine);
                }
            }
        }
        private void SaveTeamsToFile()
        {

            List<string> teamsData = textBoxTeams.Lines.ToList(); // Получаем текущие названия команд из текстового поля
            string filePath = "teams.txt";

            try
            {
                // Записываем данные в файл
                File.WriteAllLines(filePath, teamsData);
                MessageBox.Show("Список команд успешно сохранен в файл.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}");
            }
        }
        public void SaveTeamsDataToFile(string filePath)
        {
            string json = JsonConvert.SerializeObject(teamsData, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        public void LoadTeamsDataFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                teamsData = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json);
            }

        }

        public void AddTeamMembers(string teamName, List<string> teamMembers)
        {
            if (teamsData == null)
            {
                teamsData = new Dictionary<string, List<string>>();
            }
            // Сохраняем участников в словаре
            if (teamsData.ContainsKey(teamName))
            {
                teamsData[teamName].AddRange(teamMembers);
            }
            else
            {
                teamsData[teamName] = new List<string>(teamMembers);
            }

        }
        private void textBoxTeams_MouseClick(object sender, MouseEventArgs e)
        {
            int index = textBoxTeams.GetLineFromCharIndex(textBoxTeams.SelectionStart);
            string[] lines = textBoxTeams.Lines;

            if (index >= 0 && index < lines.Length)
            {
                string selectedTeamName = lines[index];

                // Получаем участников для выбранного коллектива
                if (teamsData.TryGetValue(selectedTeamName, out List<string> teamMembers))
                {
                    // Открываем форму с информацией о коллективе
                    TeamInfoForm teamInfoForm = new(selectedTeamName, teamMembers);
                    teamInfoForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Участники не найдены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEmployees();
            ProgramJSON.SaveProjects(projects);
        }

        private void UpdateEmployeeList_1(TeamMemberForm teamMemberForm)
        {
            if (teamMemberForm == null)
            {
                MessageBox.Show("teamMemberForm не инициализирован.");
                return;
            }

            var checkedItems = teamMemberForm.GetEmployeeList(); // Получаем список сотрудников

            teamMemberForm.employeeList.Clear();
            foreach (var item in checkedItems)
            {
                teamMemberForm.employeeList.Add(new string(item));
            }

            teamMemberForm.SaveEmployeeListToJson(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "employeeList.json"));
        }


        private void CreateSpeciality_button_Click(object sender, EventArgs e)
        {
            using (AddSpecialtyForm addSpecialtyForm = new())
            {
                if (addSpecialtyForm.ShowDialog() == DialogResult.OK)
                {
                    string newSpecialty = addSpecialtyForm.Specialty;
                    if (!string.IsNullOrWhiteSpace(newSpecialty))
                    {
                        specialty_comboBox.Items.Add(newSpecialty); // Добавить специальность в ComboBox
                    }
                }
            }
        }

        private void EditProject_button_Click_1(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите проект для редактирования", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProjectName = listViewProjects.SelectedItems[0].Text;
            var projectToEdit = projects.FirstOrDefault(p => p.ProjectName == selectedProjectName);

            if (projectToEdit != null)
            {
                ReplaceProjectForm replaceForm = new ReplaceProjectForm(projectToEdit, employees);
                replaceForm.ProjectUpdated += ReplaceForm_ProjectUpdated;
                replaceForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Проект не найден", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
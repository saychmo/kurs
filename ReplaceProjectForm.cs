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
    public partial class ReplaceProjectForm : Form
    {
        private Project _originalProject;
        public event Action<Project> ProjectUpdated;
        private BindingSource bindingSource = new BindingSource();
        private List<Employee> _employees;

        public ReplaceProjectForm(Project project, List<Employee> employees)
        {
            InitializeComponent();
            _originalProject = project;
            _employees = employees;

            InitializeForm();
            FillFormWithProjectData();
        }

        private void InitializeForm()
        {
            bindingSource.DataSource = _employees;
            Edit_Lider_comboBox.DataSource = bindingSource;
            Edit_Lider_comboBox.DisplayMember = "FullName";
        }

        private void FillFormWithProjectData()
        {
            // Заполняем поля данными проекта
            Edit_projectName_textBox.Text = _originalProject.ProjectName;
            Edit_projectCost_textBox.Text = _originalProject.Cost;
            Edit_Start_Project.Value = _originalProject.StartDate;
            Edit_End_Project.Value = _originalProject.EndDate;

            // Выбираем лидера проекта
            var leader = _employees.FirstOrDefault(e =>
                e.FullName == _originalProject.ProjectLeader.FullName);
            if (leader != null)
            {
                Edit_Lider_comboBox.SelectedItem = leader;
            }

            // Данные клиента
            Edit_clientName_textBox.Text = _originalProject.ProjectClient.Name;
            Edit_address_textBox.Text = _originalProject.ProjectClient.Address;
            Edit_bankName_textBox.Text = _originalProject.ProjectClient.BankName;
            Edit_accountNumber_textBox.Text = _originalProject.ProjectClient.AccountNumber;
            Edit_inn_textBox.Text = _originalProject.ProjectClient.INN;
            Edit_responsiblePerson_textBox.Text = _originalProject.ProjectClient.ResponsiblePerson;
            Edit_responsiblePersonPhone_textBox.Text = _originalProject.ProjectClient.ResponsiblePersonPhone;
            Edit_premiumRate_textBox.Text = _originalProject.PremiumRate;
        }


        private void Edit_OK_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Валидация (как в Form2)
                if (string.IsNullOrWhiteSpace(Edit_projectName_textBox.Text))
                {
                    MessageBox.Show("Введите название проекта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Edit_clientName_textBox.Text))
                {
                    MessageBox.Show("Введите заказщика проекта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Edit_Start_Project.Value >= Edit_End_Project.Value)
                {
                    MessageBox.Show("Дата окончания проекта должна быть позже даты начала", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создаем обновленный проект
                Employee projectLeader = (Employee)Edit_Lider_comboBox.SelectedItem;
                Client client = new Client(
                    Edit_clientName_textBox.Text,
                    Edit_address_textBox.Text,
                    Edit_bankName_textBox.Text,
                    Edit_accountNumber_textBox.Text,
                    Edit_inn_textBox.Text,
                    Edit_responsiblePerson_textBox.Text,
                    Edit_responsiblePersonPhone_textBox.Text
                );

                Project updatedProject = new Project(
                    Edit_projectName_textBox.Text,
                    Edit_projectCost_textBox.Text,
                    Edit_Start_Project.Value,
                    Edit_End_Project.Value,
                    projectLeader,
                    client,
                    Edit_premiumRate_textBox.Text
                );

                ProjectUpdated?.Invoke(updatedProject);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

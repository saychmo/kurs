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
    public partial class Form2 : Form
    {
        public event Action<Project> ProjectAdded;
        private BindingSource bindingSource = new BindingSource();

        public Form2()
        {
            InitializeComponent();
            bindingSource.DataSource = new List<Employee>(); // Инициализируем пустой список
            Lider_comboBox.DataSource = bindingSource; // Привязываем BindingSource к ComboBox
            Lider_comboBox.DisplayMember = "FullName"; // Указываем, какое свойство отображать
        }
        public void UpdateLiderComboBox(List<Employee> employees)
        {
            if (employees == null || employees.Count == 0)
            {
                MessageBox.Show("Список сотрудников пуст.");
                return;
            }

            bindingSource.DataSource = employees; // Устанавливаем новый источник данных
            bindingSource.ResetBindings(true); // Обновляем привязку
        }
        private void OK_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка всех обязательных полей
                if (string.IsNullOrWhiteSpace(clientName_textBox.Text))
                {
                    MessageBox.Show("Введите заказчика проекта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(address_textBox.Text))
                {
                    MessageBox.Show("Введите адрес заказчика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(bankName_textBox.Text))
                {
                    MessageBox.Show("Введите название банка заказчика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(accountNumber_textBox.Text))
                {
                    MessageBox.Show("Введите номер счета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверка ИНН (должен быть числом и содержать 10 или 12 цифр)
                if (string.IsNullOrWhiteSpace(inn_textBox.Text) ||
                    !inn_textBox.Text.All(char.IsDigit) ||
                    (inn_textBox.Text.Length != 10 && inn_textBox.Text.Length != 12))
                {
                    MessageBox.Show("ИНН должен содержать:\n- только цифры\n- 10 или 12 символов",
                                  "Ошибка в ИНН", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверка телефона (только цифры, минимум 10 символов)
                string phoneDigits = new string(responsiblePersonPhone_textBox.Text.Where(char.IsDigit).ToArray());
                if (phoneDigits.Length < 10)
                {
                    MessageBox.Show("Номер телефона должен содержать:\n- минимум 10 цифр\n- можно использовать разделители",
                                  "Ошибка в телефоне", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(responsiblePerson_textBox.Text))
                {
                    MessageBox.Show("Введите ответственное лицо", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(projectName_textBox.Text))
                {
                    MessageBox.Show("Введите название проекта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(projectCost_textBox.Text))
                {
                    MessageBox.Show("Введите стоимость проекта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(premiumRate_textBox.Text))
                {
                    MessageBox.Show("Введите премиальную ставку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверка дат проекта
                if (Start_Project.Value >= End_Project.Value)
                {
                    MessageBox.Show("Дата окончания проекта должна быть позже даты начала", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Получаем данные из текстовых полей
                string? employeeName = Lider_comboBox.Text;
                string clientName = clientName_textBox.Text;
                string clientAddress = address_textBox.Text;
                string clientBank = bankName_textBox.Text;
                string clientAccountNumber = accountNumber_textBox.Text;
                string clientINN = inn_textBox.Text;
                string clientResponsiblePerson = responsiblePerson_textBox.Text;
                string clientPhone = responsiblePersonPhone_textBox.Text;
                // Создаем экземпляры Employee и Client
                Employee projectLeader = new Employee(employeeName);
                Client client = new Client(clientName, clientAddress, clientBank, clientAccountNumber, clientINN, clientResponsiblePerson, clientPhone);

                // Создаем экземпляр Project
                Project project = new Project(
                    projectName_textBox.Text,
                    projectCost_textBox.Text,
                    Start_Project.Value,
                    End_Project.Value,
                    projectLeader,
                    client,
                    premiumRate_textBox.Text
                );


                ProjectAdded?.Invoke(project); // Вызываем событие
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

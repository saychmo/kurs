namespace kurs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            employee = new TabPage();
            Gender = new ComboBox();
            Address_textBox = new TextBox();
            panel1 = new Panel();
            CreateSpeciality_button = new Button();
            addEmpoeeys_button = new Button();
            salary_textBox = new TextBox();
            label5 = new Label();
            experience_comboBox = new ComboBox();
            specialty_comboBox = new ComboBox();
            educationDocument_textBox = new TextBox();
            label4 = new Label();
            education_textBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            date_of_bith_Picker = new DateTimePicker();
            Patronymic_textBox = new TextBox();
            Name_textBox = new TextBox();
            Surname_textBox = new TextBox();
            photoPath = new PictureBox();
            project = new TabPage();
            listViewProjects = new ListView();
            btnDeleteProject = new Button();
            CreateProject_button = new Button();
            label6 = new Label();
            team = new TabPage();
            btnRemoveTeam = new Button();
            btnCreateTeam = new Button();
            textBoxTeams = new TextBox();
            label8 = new Label();
            btnDeleteEmployee = new Button();
            label7 = new Label();
            listExployee_textBox = new TextBox();
            label9 = new Label();
            tabControl1.SuspendLayout();
            employee.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)photoPath).BeginInit();
            project.SuspendLayout();
            team.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(employee);
            tabControl1.Controls.Add(project);
            tabControl1.Controls.Add(team);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(687, 393);
            tabControl1.TabIndex = 0;
            // 
            // employee
            // 
            employee.Controls.Add(Gender);
            employee.Controls.Add(Address_textBox);
            employee.Controls.Add(panel1);
            employee.Controls.Add(label2);
            employee.Controls.Add(label1);
            employee.Controls.Add(date_of_bith_Picker);
            employee.Controls.Add(Patronymic_textBox);
            employee.Controls.Add(Name_textBox);
            employee.Controls.Add(Surname_textBox);
            employee.Controls.Add(photoPath);
            employee.Location = new Point(4, 29);
            employee.Name = "employee";
            employee.Padding = new Padding(3);
            employee.Size = new Size(679, 360);
            employee.TabIndex = 0;
            employee.Text = "Сотрудники";
            employee.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "муж", "жен" });
            Gender.Location = new Point(152, 211);
            Gender.Name = "Gender";
            Gender.Size = new Size(192, 28);
            Gender.TabIndex = 9;
            Gender.Text = "Пол";
            // 
            // Address_textBox
            // 
            Address_textBox.BorderStyle = BorderStyle.FixedSingle;
            Address_textBox.ForeColor = Color.Gray;
            Address_textBox.Location = new Point(152, 302);
            Address_textBox.Multiline = true;
            Address_textBox.Name = "Address_textBox";
            Address_textBox.Size = new Size(192, 34);
            Address_textBox.TabIndex = 8;
            Address_textBox.Text = "Ул. , д.";
            Address_textBox.Enter += Address_textBox_Enter;
            Address_textBox.Leave += Address_textBox_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(CreateSpeciality_button);
            panel1.Controls.Add(addEmpoeeys_button);
            panel1.Controls.Add(salary_textBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(experience_comboBox);
            panel1.Controls.Add(specialty_comboBox);
            panel1.Controls.Add(educationDocument_textBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(education_textBox);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(373, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 354);
            panel1.TabIndex = 7;
            // 
            // CreateSpeciality_button
            // 
            CreateSpeciality_button.BackColor = Color.LimeGreen;
            CreateSpeciality_button.FlatStyle = FlatStyle.System;
            CreateSpeciality_button.ForeColor = SystemColors.ActiveCaptionText;
            CreateSpeciality_button.Location = new Point(251, 18);
            CreateSpeciality_button.Name = "CreateSpeciality_button";
            CreateSpeciality_button.Size = new Size(26, 28);
            CreateSpeciality_button.TabIndex = 9;
            CreateSpeciality_button.Text = "+";
            CreateSpeciality_button.UseVisualStyleBackColor = false;
            CreateSpeciality_button.Click += CreateSpeciality_button_Click;
            // 
            // addEmpoeeys_button
            // 
            addEmpoeeys_button.BackColor = Color.WhiteSmoke;
            addEmpoeeys_button.Cursor = Cursors.Hand;
            addEmpoeeys_button.FlatStyle = FlatStyle.Popup;
            addEmpoeeys_button.Location = new Point(63, 322);
            addEmpoeeys_button.Name = "addEmpoeeys_button";
            addEmpoeeys_button.Size = new Size(144, 29);
            addEmpoeeys_button.TabIndex = 8;
            addEmpoeeys_button.Text = "Добавить";
            addEmpoeeys_button.UseVisualStyleBackColor = false;
            addEmpoeeys_button.Click += addEmpoeeys_button_Click;
            // 
            // salary_textBox
            // 
            salary_textBox.BorderStyle = BorderStyle.FixedSingle;
            salary_textBox.Location = new Point(129, 124);
            salary_textBox.Name = "salary_textBox";
            salary_textBox.Size = new Size(157, 27);
            salary_textBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 127);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 6;
            label5.Text = "Зарплата:";
            // 
            // experience_comboBox
            // 
            experience_comboBox.FormattingEnabled = true;
            experience_comboBox.Items.AddRange(new object[] { "1 год", "2-4 года", "5-8 лет", "9-12 лет", "13-18 лет", "> 18 лет" });
            experience_comboBox.Location = new Point(29, 71);
            experience_comboBox.Name = "experience_comboBox";
            experience_comboBox.Size = new Size(201, 28);
            experience_comboBox.TabIndex = 5;
            experience_comboBox.Text = "Опыт работы";
            // 
            // specialty_comboBox
            // 
            specialty_comboBox.FormattingEnabled = true;
            specialty_comboBox.Items.AddRange(new object[] { "Аналитик", "Бухгалтер", "Дизайнер", "Инженер", "Лаборант", "Маркетолог", "Менеджер" });
            specialty_comboBox.Location = new Point(29, 18);
            specialty_comboBox.Name = "specialty_comboBox";
            specialty_comboBox.Size = new Size(201, 28);
            specialty_comboBox.TabIndex = 4;
            specialty_comboBox.Text = "Специальность";
            // 
            // educationDocument_textBox
            // 
            educationDocument_textBox.BorderStyle = BorderStyle.FixedSingle;
            educationDocument_textBox.Location = new Point(152, 240);
            educationDocument_textBox.Multiline = true;
            educationDocument_textBox.Name = "educationDocument_textBox";
            educationDocument_textBox.Size = new Size(125, 61);
            educationDocument_textBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.Location = new Point(3, 222);
            label4.Name = "label4";
            label4.Size = new Size(153, 75);
            label4.TabIndex = 2;
            label4.Text = "Данные документа о получении образования:";
            // 
            // education_textBox
            // 
            education_textBox.BorderStyle = BorderStyle.FixedSingle;
            education_textBox.Location = new Point(129, 174);
            education_textBox.Multiline = true;
            education_textBox.Name = "education_textBox";
            education_textBox.Size = new Size(157, 34);
            education_textBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 177);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 0;
            label3.Text = "Образование:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 302);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 6;
            label2.Text = "Дом.адрес:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 264);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 5;
            label1.Text = "Дата рождения:";
            // 
            // date_of_bith_Picker
            // 
            date_of_bith_Picker.Location = new Point(152, 264);
            date_of_bith_Picker.Name = "date_of_bith_Picker";
            date_of_bith_Picker.Size = new Size(192, 27);
            date_of_bith_Picker.TabIndex = 4;
            // 
            // Patronymic_textBox
            // 
            Patronymic_textBox.ForeColor = Color.Gray;
            Patronymic_textBox.Location = new Point(152, 157);
            Patronymic_textBox.Name = "Patronymic_textBox";
            Patronymic_textBox.Size = new Size(192, 27);
            Patronymic_textBox.TabIndex = 3;
            Patronymic_textBox.Text = "Отчество";
            Patronymic_textBox.Enter += Patronymic_textBox_Enter;
            Patronymic_textBox.Leave += Patronymic_textBox_Leave;
            // 
            // Name_textBox
            // 
            Name_textBox.ForeColor = Color.Gray;
            Name_textBox.Location = new Point(152, 105);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(192, 27);
            Name_textBox.TabIndex = 2;
            Name_textBox.Text = "Имя";
            Name_textBox.Enter += Name_textBox_Enter;
            Name_textBox.Leave += Name_textBox_Leave;
            // 
            // Surname_textBox
            // 
            Surname_textBox.ForeColor = Color.Gray;
            Surname_textBox.Location = new Point(152, 55);
            Surname_textBox.Name = "Surname_textBox";
            Surname_textBox.Size = new Size(192, 27);
            Surname_textBox.TabIndex = 1;
            Surname_textBox.Text = "Фамилия";
            Surname_textBox.Enter += Surname_Enter;
            Surname_textBox.Leave += Surname_Leave;
            // 
            // photoPath
            // 
            photoPath.Cursor = Cursors.Hand;
            photoPath.Image = Properties.Resources._285641_id_user_icon;
            photoPath.Location = new Point(6, 55);
            photoPath.Name = "photoPath";
            photoPath.Size = new Size(128, 129);
            photoPath.SizeMode = PictureBoxSizeMode.StretchImage;
            photoPath.TabIndex = 0;
            photoPath.TabStop = false;
            photoPath.Click += LoadImage_Click;
            // 
            // project
            // 
            project.Controls.Add(listViewProjects);
            project.Controls.Add(btnDeleteProject);
            project.Controls.Add(CreateProject_button);
            project.Controls.Add(label6);
            project.Location = new Point(4, 29);
            project.Name = "project";
            project.Padding = new Padding(3);
            project.Size = new Size(679, 360);
            project.TabIndex = 1;
            project.Text = "Проекты";
            project.UseVisualStyleBackColor = true;
            // 
            // listViewProjects
            // 
            listViewProjects.Location = new Point(32, 56);
            listViewProjects.MultiSelect = false;
            listViewProjects.Name = "listViewProjects";
            listViewProjects.Size = new Size(167, 204);
            listViewProjects.TabIndex = 3;
            listViewProjects.UseCompatibleStateImageBehavior = false;
            listViewProjects.DoubleClick += listViewProjects_DoubleClick;
            // 
            // btnDeleteProject
            // 
            btnDeleteProject.BackColor = Color.Gainsboro;
            btnDeleteProject.Cursor = Cursors.Hand;
            btnDeleteProject.FlatStyle = FlatStyle.System;
            btnDeleteProject.ForeColor = SystemColors.ActiveCaptionText;
            btnDeleteProject.Location = new Point(32, 325);
            btnDeleteProject.Name = "btnDeleteProject";
            btnDeleteProject.Size = new Size(167, 29);
            btnDeleteProject.TabIndex = 2;
            btnDeleteProject.Text = "Удалить проект";
            btnDeleteProject.UseVisualStyleBackColor = false;
            btnDeleteProject.Click += btnDeleteProject_Click;
            // 
            // CreateProject_button
            // 
            CreateProject_button.BackColor = Color.Gainsboro;
            CreateProject_button.Cursor = Cursors.Hand;
            CreateProject_button.FlatStyle = FlatStyle.System;
            CreateProject_button.ForeColor = SystemColors.ActiveCaptionText;
            CreateProject_button.Location = new Point(32, 289);
            CreateProject_button.Name = "CreateProject_button";
            CreateProject_button.Size = new Size(168, 29);
            CreateProject_button.TabIndex = 1;
            CreateProject_button.Text = "Создать проект";
            CreateProject_button.UseVisualStyleBackColor = false;
            CreateProject_button.Click += CreateProject_button_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 17);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 0;
            label6.Text = "Проекты";
            // 
            // team
            // 
            team.Controls.Add(btnRemoveTeam);
            team.Controls.Add(btnCreateTeam);
            team.Controls.Add(textBoxTeams);
            team.Controls.Add(label8);
            team.Controls.Add(btnDeleteEmployee);
            team.Controls.Add(label7);
            team.Controls.Add(listExployee_textBox);
            team.Controls.Add(label9);
            team.Cursor = Cursors.Hand;
            team.Location = new Point(4, 29);
            team.Name = "team";
            team.Padding = new Padding(3);
            team.Size = new Size(679, 360);
            team.TabIndex = 2;
            team.Text = "Коллектив";
            team.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTeam
            // 
            btnRemoveTeam.FlatStyle = FlatStyle.Flat;
            btnRemoveTeam.Location = new Point(534, 316);
            btnRemoveTeam.Name = "btnRemoveTeam";
            btnRemoveTeam.Size = new Size(108, 29);
            btnRemoveTeam.TabIndex = 7;
            btnRemoveTeam.Text = "Удалить";
            btnRemoveTeam.UseVisualStyleBackColor = true;
            btnRemoveTeam.Click += btnRemoveTeam_Click;
            // 
            // btnCreateTeam
            // 
            btnCreateTeam.FlatStyle = FlatStyle.Popup;
            btnCreateTeam.Location = new Point(356, 316);
            btnCreateTeam.Name = "btnCreateTeam";
            btnCreateTeam.Size = new Size(151, 29);
            btnCreateTeam.TabIndex = 6;
            btnCreateTeam.Text = "Создать коллектив";
            btnCreateTeam.UseVisualStyleBackColor = true;
            btnCreateTeam.Click += btnCreateTeam_Click;
            // 
            // textBoxTeams
            // 
            textBoxTeams.BorderStyle = BorderStyle.FixedSingle;
            textBoxTeams.Location = new Point(356, 53);
            textBoxTeams.Multiline = true;
            textBoxTeams.Name = "textBoxTeams";
            textBoxTeams.Size = new Size(296, 248);
            textBoxTeams.TabIndex = 4;
            textBoxTeams.MouseClick += textBoxTeams_MouseClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(356, 18);
            label8.Name = "label8";
            label8.Size = new Size(178, 20);
            label8.TabIndex = 3;
            label8.Text = "Творческие коллективы";
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = Color.Thistle;
            btnDeleteEmployee.FlatStyle = FlatStyle.Popup;
            btnDeleteEmployee.ForeColor = SystemColors.ControlText;
            btnDeleteEmployee.Location = new Point(76, 316);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(182, 29);
            btnDeleteEmployee.TabIndex = 2;
            btnDeleteEmployee.Text = "Удалить сотрудника";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Thistle;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(23, 18);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 1;
            label7.Text = "Сотрудники";
            // 
            // listExployee_textBox
            // 
            listExployee_textBox.BackColor = SystemColors.Menu;
            listExployee_textBox.BorderStyle = BorderStyle.FixedSingle;
            listExployee_textBox.Location = new Point(17, 53);
            listExployee_textBox.Multiline = true;
            listExployee_textBox.Name = "listExployee_textBox";
            listExployee_textBox.Size = new Size(300, 248);
            listExployee_textBox.TabIndex = 0;
            listExployee_textBox.MouseDoubleClick += listExployee_textBox_MouseDoubleClick;
            // 
            // label9
            // 
            label9.BackColor = Color.Thistle;
            label9.Dock = DockStyle.Right;
            label9.Location = new Point(338, 3);
            label9.Name = "label9";
            label9.Size = new Size(338, 354);
            label9.TabIndex = 5;
            label9.Text = "label9";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Cursor = Cursors.Hand;
            Name = "Form1";
            FormClosing += Form1_FormClosing;
            tabControl1.ResumeLayout(false);
            employee.ResumeLayout(false);
            employee.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)photoPath).EndInit();
            project.ResumeLayout(false);
            project.PerformLayout();
            team.ResumeLayout(false);
            team.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage employee;
        private TabPage project;
        private TabPage team;
        private PictureBox photoPath;
        private TextBox Surname_textBox;
        private TextBox Patronymic_textBox;
        private TextBox Name_textBox;
        private DateTimePicker date_of_bith_Picker;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox Address_textBox;
        private TextBox education_textBox;
        private Label label3;
        private Label label4;
        private TextBox educationDocument_textBox;
        private ComboBox specialty_comboBox;
        private ComboBox experience_comboBox;
        private Label label5;
        private ComboBox Gender;
        private TextBox salary_textBox;
        private Button btnDeleteProject;
        private Button CreateProject_button;
        private Label label6;

        private Button addEmpoeeys_button;
        private Label label7;
        private TextBox listExployee_textBox;
        private Button btnDeleteEmployee;

        private ListView listViewProjects;
        private Label label8;
        private TextBox textBoxTeams;
        private Label label9;
        private Button btnCreateTeam;
        private Button CreateSpeciality_button;
        private Button btnRemoveTeam;
    }
}
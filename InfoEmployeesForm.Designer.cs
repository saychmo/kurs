namespace kurs
{
    partial class InfoEmployeesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            label10 = new Label();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            PhotoBox = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            SurnameBox = new TextBox();
            SaveChanges_button = new Button();
            NameBox = new TextBox();
            PatronymicBox = new TextBox();
            dateTimePickerDateOfBirth = new DateTimePicker();
            comboBox_gender = new ComboBox();
            textBox_Adress = new TextBox();
            textBox_Speciality = new TextBox();
            textBox_Expirience = new TextBox();
            textBox_Salary = new TextBox();
            textBox_Education = new TextBox();
            textBox_EdDoc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PhotoBox).BeginInit();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.BackColor = SystemColors.ActiveCaption;
            lbl.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(0, 9);
            lbl.Name = "lbl";
            lbl.Size = new Size(593, 74);
            lbl.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 100);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 1;
            label2.Text = "Дата рождения:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 183);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 2;
            label3.Text = "Дом. адрес:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 143);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 3;
            label4.Text = "Пол:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.InactiveCaption;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(-1, 223);
            label8.Name = "label8";
            label8.Size = new Size(156, 28);
            label8.TabIndex = 7;
            label8.Text = "Специальность:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.InactiveCaption;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(-1, 265);
            label10.Name = "label10";
            label10.Size = new Size(138, 28);
            label10.TabIndex = 9;
            label10.Text = "Опыт работы:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.InactiveCaption;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(-1, 308);
            label12.Name = "label12";
            label12.Size = new Size(100, 28);
            label12.TabIndex = 11;
            label12.Text = "Зарплата:";
            // 
            // label14
            // 
            label14.BackColor = SystemColors.InactiveCaption;
            label14.Location = new Point(0, 83);
            label14.Name = "label14";
            label14.Size = new Size(594, 398);
            label14.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.InactiveCaption;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(-1, 352);
            label15.Name = "label15";
            label15.Size = new Size(141, 28);
            label15.TabIndex = 19;
            label15.Text = "Образование:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.InactiveCaption;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(-1, 390);
            label17.Name = "label17";
            label17.Size = new Size(278, 28);
            label17.TabIndex = 21;
            label17.Text = "Документы об образовании:";
            // 
            // PhotoBox
            // 
            PhotoBox.Location = new Point(443, 100);
            PhotoBox.Name = "PhotoBox";
            PhotoBox.Size = new Size(125, 142);
            PhotoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PhotoBox.TabIndex = 23;
            PhotoBox.TabStop = false;
            PhotoBox.Click += PhotoBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 24;
            label1.Text = "Фамилия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.InactiveCaption;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(224, 9);
            label5.Name = "label5";
            label5.Size = new Size(51, 28);
            label5.TabIndex = 25;
            label5.Text = "Имя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.InactiveCaption;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(416, 9);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 26;
            label6.Text = "Отчество";
            // 
            // SurnameBox
            // 
            SurnameBox.BackColor = SystemColors.ActiveCaption;
            SurnameBox.ForeColor = SystemColors.MenuText;
            SurnameBox.Location = new Point(12, 41);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(160, 27);
            SurnameBox.TabIndex = 30;
            // 
            // SaveChanges_button
            // 
            SaveChanges_button.FlatStyle = FlatStyle.Flat;
            SaveChanges_button.Location = new Point(154, 449);
            SaveChanges_button.Name = "SaveChanges_button";
            SaveChanges_button.Size = new Size(234, 29);
            SaveChanges_button.TabIndex = 31;
            SaveChanges_button.Text = "Сохранить изменения";
            SaveChanges_button.UseVisualStyleBackColor = true;
            SaveChanges_button.Click += SaveChanges_button_Click;
            // 
            // NameBox
            // 
            NameBox.BackColor = SystemColors.ActiveCaption;
            NameBox.Location = new Point(224, 41);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(164, 27);
            NameBox.TabIndex = 32;
            // 
            // PatronymicBox
            // 
            PatronymicBox.BackColor = SystemColors.ActiveCaption;
            PatronymicBox.Location = new Point(416, 40);
            PatronymicBox.Name = "PatronymicBox";
            PatronymicBox.Size = new Size(164, 27);
            PatronymicBox.TabIndex = 33;
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.CalendarMonthBackground = SystemColors.ButtonHighlight;
            dateTimePickerDateOfBirth.Location = new Point(163, 102);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(178, 27);
            dateTimePickerDateOfBirth.TabIndex = 34;
            // 
            // comboBox_gender
            // 
            comboBox_gender.BackColor = SystemColors.InactiveCaption;
            comboBox_gender.FormattingEnabled = true;
            comboBox_gender.Items.AddRange(new object[] { "муж", "жен" });
            comboBox_gender.Location = new Point(58, 147);
            comboBox_gender.Name = "comboBox_gender";
            comboBox_gender.Size = new Size(114, 28);
            comboBox_gender.TabIndex = 35;
            // 
            // textBox_Adress
            // 
            textBox_Adress.BackColor = SystemColors.InactiveCaption;
            textBox_Adress.Location = new Point(123, 187);
            textBox_Adress.Name = "textBox_Adress";
            textBox_Adress.Size = new Size(218, 27);
            textBox_Adress.TabIndex = 36;
            // 
            // textBox_Speciality
            // 
            textBox_Speciality.BackColor = SystemColors.InactiveCaption;
            textBox_Speciality.Location = new Point(154, 227);
            textBox_Speciality.Name = "textBox_Speciality";
            textBox_Speciality.Size = new Size(187, 27);
            textBox_Speciality.TabIndex = 37;
            // 
            // textBox_Expirience
            // 
            textBox_Expirience.BackColor = SystemColors.InactiveCaption;
            textBox_Expirience.Location = new Point(154, 269);
            textBox_Expirience.Name = "textBox_Expirience";
            textBox_Expirience.Size = new Size(187, 27);
            textBox_Expirience.TabIndex = 38;
            // 
            // textBox_Salary
            // 
            textBox_Salary.BackColor = SystemColors.InactiveCaption;
            textBox_Salary.Location = new Point(114, 312);
            textBox_Salary.Name = "textBox_Salary";
            textBox_Salary.Size = new Size(142, 27);
            textBox_Salary.TabIndex = 39;
            // 
            // textBox_Education
            // 
            textBox_Education.BackColor = SystemColors.InactiveCaption;
            textBox_Education.Location = new Point(146, 356);
            textBox_Education.Name = "textBox_Education";
            textBox_Education.Size = new Size(195, 27);
            textBox_Education.TabIndex = 40;
            // 
            // textBox_EdDoc
            // 
            textBox_EdDoc.BackColor = SystemColors.InactiveCaption;
            textBox_EdDoc.Location = new Point(283, 394);
            textBox_EdDoc.Name = "textBox_EdDoc";
            textBox_EdDoc.Size = new Size(213, 27);
            textBox_EdDoc.TabIndex = 41;
            // 
            // InfoEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 490);
            Controls.Add(textBox_EdDoc);
            Controls.Add(textBox_Education);
            Controls.Add(textBox_Salary);
            Controls.Add(textBox_Expirience);
            Controls.Add(textBox_Speciality);
            Controls.Add(textBox_Adress);
            Controls.Add(comboBox_gender);
            Controls.Add(dateTimePickerDateOfBirth);
            Controls.Add(PatronymicBox);
            Controls.Add(NameBox);
            Controls.Add(SaveChanges_button);
            Controls.Add(SurnameBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(PhotoBox);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl);
            Controls.Add(label14);
            Name = "InfoEmployeesForm";
            Text = "InfoEmployees";
            ((System.ComponentModel.ISupportInitialize)PhotoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label10;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label17;
        private PictureBox PhotoBox;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox SurnameBox;
        private Button SaveChanges_button;
        private TextBox NameBox;
        private TextBox PatronymicBox;
        private DateTimePicker dateTimePickerDateOfBirth;
        private ComboBox comboBox_gender;
        private TextBox textBox_Adress;
        private TextBox textBox_Speciality;
        private TextBox textBox_Expirience;
        private TextBox textBox_Salary;
        private TextBox textBox_Education;
        private TextBox textBox_EdDoc;
    }
}
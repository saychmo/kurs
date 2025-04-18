namespace kurs
{
    partial class Form2
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
            OK_button = new Button();
            projectName_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            projectCost_textBox = new TextBox();
            label3 = new Label();
            Start_Project = new DateTimePicker();
            label4 = new Label();
            End_Project = new DateTimePicker();
            label5 = new Label();
            label22 = new Label();
            label20 = new Label();
            label18 = new Label();
            label16 = new Label();
            label14 = new Label();
            label12 = new Label();
            label10 = new Label();
            clientName_textBox = new TextBox();
            address_textBox = new TextBox();
            bankName_textBox = new TextBox();
            accountNumber_textBox = new TextBox();
            inn_textBox = new TextBox();
            responsiblePerson_textBox = new TextBox();
            responsiblePersonPhone_textBox = new TextBox();
            premiumRate_textBox = new TextBox();
            label6 = new Label();
            Lider_comboBox = new ComboBox();
            SuspendLayout();
            // 
            // OK_button
            // 
            OK_button.BackColor = Color.FromArgb(192, 192, 255);
            OK_button.Cursor = Cursors.Hand;
            OK_button.FlatStyle = FlatStyle.Flat;
            OK_button.ForeColor = SystemColors.ActiveCaptionText;
            OK_button.Location = new Point(435, 340);
            OK_button.Name = "OK_button";
            OK_button.Size = new Size(99, 32);
            OK_button.TabIndex = 0;
            OK_button.Text = "Добавить";
            OK_button.UseVisualStyleBackColor = false;
            OK_button.Click += OK_button_Click;
            // 
            // projectName_textBox
            // 
            projectName_textBox.BorderStyle = BorderStyle.FixedSingle;
            projectName_textBox.Location = new Point(215, 20);
            projectName_textBox.Name = "projectName_textBox";
            projectName_textBox.Size = new Size(188, 27);
            projectName_textBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 2;
            label1.Text = "Введите название проекта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(203, 20);
            label2.TabIndex = 3;
            label2.Text = "Введите стоимость проекта";
            // 
            // projectCost_textBox
            // 
            projectCost_textBox.BorderStyle = BorderStyle.FixedSingle;
            projectCost_textBox.Location = new Point(215, 75);
            projectCost_textBox.Name = "projectCost_textBox";
            projectCost_textBox.Size = new Size(188, 27);
            projectCost_textBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 140);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 5;
            label3.Text = "Начало проекта";
            // 
            // Start_Project
            // 
            Start_Project.Location = new Point(31, 173);
            Start_Project.Name = "Start_Project";
            Start_Project.Size = new Size(168, 27);
            Start_Project.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 140);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 7;
            label4.Text = "Конец проекта";
            // 
            // End_Project
            // 
            End_Project.Location = new Point(239, 173);
            End_Project.Name = "End_Project";
            End_Project.Size = new Size(164, 27);
            End_Project.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 233);
            label5.Name = "label5";
            label5.Size = new Size(169, 20);
            label5.TabIndex = 9;
            label5.Text = "Руководитель проекта";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(487, 269);
            label22.Name = "label22";
            label22.Size = new Size(110, 20);
            label22.TabIndex = 32;
            label22.Text = "номер тел. ОЛ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(487, 233);
            label20.Name = "label20";
            label20.Size = new Size(30, 20);
            label20.TabIndex = 31;
            label20.Text = "ОЛ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(487, 180);
            label18.Name = "label18";
            label18.Size = new Size(119, 20);
            label18.TabIndex = 30;
            label18.Text = "ИНН заказчика";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(487, 140);
            label16.Name = "label16";
            label16.Size = new Size(103, 20);
            label16.TabIndex = 29;
            label16.Text = "Номер счета ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(487, 106);
            label14.Name = "label14";
            label14.Size = new Size(119, 20);
            label14.TabIndex = 28;
            label14.Text = "Банк заказчика";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(487, 65);
            label12.Name = "label12";
            label12.Size = new Size(129, 20);
            label12.TabIndex = 27;
            label12.Text = "Адрес заказчика";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(487, 29);
            label10.Name = "label10";
            label10.Size = new Size(139, 20);
            label10.TabIndex = 26;
            label10.Text = "Заказщик проекта";
            // 
            // clientName_textBox
            // 
            clientName_textBox.BorderStyle = BorderStyle.FixedSingle;
            clientName_textBox.Location = new Point(632, 29);
            clientName_textBox.Name = "clientName_textBox";
            clientName_textBox.Size = new Size(170, 27);
            clientName_textBox.TabIndex = 33;
            // 
            // address_textBox
            // 
            address_textBox.BorderStyle = BorderStyle.FixedSingle;
            address_textBox.Location = new Point(632, 65);
            address_textBox.Name = "address_textBox";
            address_textBox.Size = new Size(170, 27);
            address_textBox.TabIndex = 34;
            // 
            // bankName_textBox
            // 
            bankName_textBox.BorderStyle = BorderStyle.FixedSingle;
            bankName_textBox.Location = new Point(632, 99);
            bankName_textBox.Name = "bankName_textBox";
            bankName_textBox.Size = new Size(170, 27);
            bankName_textBox.TabIndex = 35;
            // 
            // accountNumber_textBox
            // 
            accountNumber_textBox.BorderStyle = BorderStyle.FixedSingle;
            accountNumber_textBox.Location = new Point(632, 133);
            accountNumber_textBox.Name = "accountNumber_textBox";
            accountNumber_textBox.Size = new Size(170, 27);
            accountNumber_textBox.TabIndex = 36;
            // 
            // inn_textBox
            // 
            inn_textBox.BorderStyle = BorderStyle.FixedSingle;
            inn_textBox.Location = new Point(632, 176);
            inn_textBox.Name = "inn_textBox";
            inn_textBox.Size = new Size(170, 27);
            inn_textBox.TabIndex = 37;
            // 
            // responsiblePerson_textBox
            // 
            responsiblePerson_textBox.BorderStyle = BorderStyle.FixedSingle;
            responsiblePerson_textBox.Location = new Point(632, 226);
            responsiblePerson_textBox.Name = "responsiblePerson_textBox";
            responsiblePerson_textBox.Size = new Size(170, 27);
            responsiblePerson_textBox.TabIndex = 38;
            // 
            // responsiblePersonPhone_textBox
            // 
            responsiblePersonPhone_textBox.BorderStyle = BorderStyle.FixedSingle;
            responsiblePersonPhone_textBox.Location = new Point(632, 262);
            responsiblePersonPhone_textBox.Name = "responsiblePersonPhone_textBox";
            responsiblePersonPhone_textBox.Size = new Size(170, 27);
            responsiblePersonPhone_textBox.TabIndex = 39;
            // 
            // premiumRate_textBox
            // 
            premiumRate_textBox.BorderStyle = BorderStyle.FixedSingle;
            premiumRate_textBox.Location = new Point(215, 293);
            premiumRate_textBox.Name = "premiumRate_textBox";
            premiumRate_textBox.Size = new Size(188, 27);
            premiumRate_textBox.TabIndex = 41;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 282);
            label6.Name = "label6";
            label6.Size = new Size(219, 50);
            label6.TabIndex = 40;
            label6.Text = "Премия при досрочном выполнении проекта";
            // 
            // Lider_comboBox
            // 
            Lider_comboBox.FormattingEnabled = true;
            Lider_comboBox.Items.AddRange(new object[] { "Авдюков" });
            Lider_comboBox.Location = new Point(215, 230);
            Lider_comboBox.Name = "Lider_comboBox";
            Lider_comboBox.Size = new Size(188, 28);
            Lider_comboBox.TabIndex = 43;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 384);
            Controls.Add(Lider_comboBox);
            Controls.Add(premiumRate_textBox);
            Controls.Add(label6);
            Controls.Add(responsiblePersonPhone_textBox);
            Controls.Add(responsiblePerson_textBox);
            Controls.Add(inn_textBox);
            Controls.Add(accountNumber_textBox);
            Controls.Add(bankName_textBox);
            Controls.Add(address_textBox);
            Controls.Add(clientName_textBox);
            Controls.Add(label22);
            Controls.Add(label20);
            Controls.Add(label18);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(End_Project);
            Controls.Add(label4);
            Controls.Add(Start_Project);
            Controls.Add(label3);
            Controls.Add(projectCost_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(projectName_textBox);
            Controls.Add(OK_button);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OK_button;
        private TextBox projectName_textBox;
        private Label label1;
        private Label label2;
        private TextBox projectCost_textBox;
        private Label label3;
        private DateTimePicker Start_Project;
        private Label label4;
        private DateTimePicker End_Project;
        private Label label5;
        private Label label22;
        private Label label20;
        private Label label18;
        private Label label16;
        private Label label14;
        private Label label12;
        private Label label10;
        private TextBox clientName_textBox;
        private TextBox address_textBox;
        private TextBox bankName_textBox;
        private TextBox accountNumber_textBox;
        private TextBox inn_textBox;
        private TextBox responsiblePerson_textBox;
        private TextBox responsiblePersonPhone_textBox;
        private TextBox premiumRate_textBox;
        private Label label6;
        private ComboBox Lider_comboBox;
    }
}
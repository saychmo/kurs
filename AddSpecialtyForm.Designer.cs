namespace kurs
{
    partial class AddSpecialtyForm
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
            btnAdd = new Button();
            txtSpecialty = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(137, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSpecialty
            // 
            txtSpecialty.BorderStyle = BorderStyle.FixedSingle;
            txtSpecialty.Location = new Point(69, 36);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(222, 27);
            txtSpecialty.TabIndex = 1;
            // 
            // AddSpecialtyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 125);
            Controls.Add(txtSpecialty);
            Controls.Add(btnAdd);
            Name = "AddSpecialtyForm";
            Text = "AddSpecialtyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtSpecialty;
    }
}
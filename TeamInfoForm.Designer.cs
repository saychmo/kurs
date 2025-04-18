namespace kurs
{
    partial class TeamInfoForm
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
            labelTeamName = new Label();
            dataGridViewTeamInfo = new DataGridView();
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeamInfo).BeginInit();
            SuspendLayout();
            // 
            // labelTeamName
            // 
            labelTeamName.BackColor = Color.Thistle;
            labelTeamName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTeamName.Location = new Point(-1, 0);
            labelTeamName.Name = "labelTeamName";
            labelTeamName.Size = new Size(612, 33);
            labelTeamName.TabIndex = 0;
            labelTeamName.Text = "label1";
            // 
            // dataGridViewTeamInfo
            // 
            dataGridViewTeamInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeamInfo.Location = new Point(0, 33);
            dataGridViewTeamInfo.Name = "dataGridViewTeamInfo";
            dataGridViewTeamInfo.RowHeadersWidth = 51;
            dataGridViewTeamInfo.RowTemplate.Height = 29;
            dataGridViewTeamInfo.Size = new Size(611, 361);
            dataGridViewTeamInfo.TabIndex = 1;
            // 
            // buttonClose
            // 
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(248, 418);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(118, 29);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // TeamInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 459);
            Controls.Add(buttonClose);
            Controls.Add(dataGridViewTeamInfo);
            Controls.Add(labelTeamName);
            Name = "TeamInfoForm";
            Text = "TeamInfoForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeamInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTeamName;
        private DataGridView dataGridViewTeamInfo;
        private Button buttonClose;
    }
}
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
    public partial class TeamInfoForm : Form
    {
        public TeamInfoForm(string teamName, List<string> teamMembers)
        {
            InitializeComponent();

            labelTeamName.Text = teamName;

            // Настройка DataGridView
            dataGridViewTeamInfo.Columns.Add("LastName", "Фамилия");
            dataGridViewTeamInfo.Columns.Add("StartDate", "Дата начала");
            dataGridViewTeamInfo.Columns.Add("EndDate", "Дата конца");

            // Заполнение DataGridView участниками
            foreach (var member in teamMembers)
            {
                var parts = member.Split(new[] { " (с ", " по " }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    dataGridViewTeamInfo.Rows.Add(parts[0], parts[1], parts[2].TrimEnd(')'));
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

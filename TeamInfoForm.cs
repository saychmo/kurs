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
        private string _teamName;
        private List<string> _teamMembers;

        public TeamInfoForm(string teamName, List<string> teamMembers)
        {
            InitializeComponent();
            _teamName = teamName;
            _teamMembers = new List<string>(teamMembers); // Создаем копию

            InitializeDataGridView();
            FillDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridViewTeamInfo.Columns.Add("LastName", "Фамилия");
            dataGridViewTeamInfo.Columns.Add("StartDate", "Дата начала");
            dataGridViewTeamInfo.Columns.Add("EndDate", "Дата конца");
        }

        private void FillDataGridView()
        {
            dataGridViewTeamInfo.Rows.Clear();
            foreach (var member in _teamMembers)
            {
                var parts = member.Split(new[] { " (с ", " по " }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    dataGridViewTeamInfo.Rows.Add(parts[0], parts[1], parts[2].TrimEnd(')'));
                }
            }
        }

        // Метод для удаления сотрудника из команды
        public void RemoveTeamMember(string fullName)
        {
            // Удаляем из внутреннего списка
            var memberToRemove = _teamMembers.FirstOrDefault(m => m.StartsWith(fullName));
            if (memberToRemove != null)
            {
                _teamMembers.Remove(memberToRemove);
                // Обновляем DataGridView
                FillDataGridView();
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

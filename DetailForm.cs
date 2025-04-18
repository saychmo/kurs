using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace kurs
{
    public partial class DetailForm : Form
    {
        public DetailForm(Project project)
        {
            InitializeComponent();
            DisplayProjectDetails(project);

        }
        private void DisplayProjectDetails(Project project)
        {
            infoProject_label.Text = project.ProjectName;
            lblSalary.Text = project.Cost;
            lblStart.Text = project.StartDate.ToString("d");
            lblEnd.Text = project.EndDate.ToString("d");
            lblLider.Text = project.ProjectLeader.Surname;
            lblPremiumRate.Text = project.PremiumRate;

            lblClientName.Text = project.ProjectClient.Name;
            lblClientAddress.Text = project.ProjectClient.Address;
            lblBankName.Text = project.ProjectClient.BankName;
            lblAccountNumber.Text = project.ProjectClient.AccountNumber;
            lbl_INN.Text = project.ProjectClient.INN;
            lblResponsiblePerson.Text = project.ProjectClient.ResponsiblePerson;
            lblNumber_ResponsiblePerson.Text = project.ProjectClient.ResponsiblePersonPhone;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

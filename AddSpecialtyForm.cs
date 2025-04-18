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
    public partial class AddSpecialtyForm : Form
    {
        public string? Specialty { get; private set; }
        public AddSpecialtyForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Specialty = txtSpecialty.Text;
            this.DialogResult = DialogResult.OK; 
            this.Close(); 
        }
    }
}

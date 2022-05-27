using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_automation
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            PatientLoginform openForm = new PatientLoginform();
            openForm.Show();
            this.Hide();
            
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            DoctorLoginform openForm = new DoctorLoginform();
            openForm.Show();
            this.Hide();
        }

        private void btnSecretary_Click(object sender, EventArgs e)
        {
            SecretaryLoginform openForm = new SecretaryLoginform();
            openForm.Show();
            this.Hide();
        }
    }
}

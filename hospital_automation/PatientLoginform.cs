using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospital_automation
{
    public partial class PatientLoginform : Form
    {
        public PatientLoginform()
        {
            InitializeComponent();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientRegisterform openForm = new PatientRegisterform();
            openForm.Show();
           
        }

        SqlCon cm = new SqlCon();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Patients Where patientTC=@p1 and patientPassword=@p2",cm.connect());
            cmd.Parameters.AddWithValue("@p1", mtboxTC.Text);
            cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                PatientMenuForm openForm = new PatientMenuForm();
                openForm.tc = mtboxTC.Text;
                openForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre Girdiniz.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cm.connect().Close();

        }
    }
}

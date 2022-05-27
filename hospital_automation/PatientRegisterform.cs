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
    public partial class PatientRegisterform : Form
    {
        public PatientRegisterform()
        {
            InitializeComponent();
        }
        SqlCon cn = new SqlCon();
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Patients (patientName,patientSurname,patientTC,patientPhone,patientPassword,patientGender)" +
                "values (@p1,@p2,@p3,@p4,@p5,@p6)",cn.connect());
            
            command.Parameters.AddWithValue("@p1",txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", mtboxTC.Text);
            command.Parameters.AddWithValue("@p4", mtboxPhone.Text);
            command.Parameters.AddWithValue("@p5", txtPassword.Text);
            if (rbtnMan.Checked == true)
            {
                command.Parameters.AddWithValue("@p6", "Erkek");
            }
            if (rbtnWoman.Checked == true)
            {
                command.Parameters.AddWithValue("@p6", "Kadin");
            }
            command.ExecuteNonQuery();
            cn.connect().Close();
            MessageBox.Show("Kaydınız Gerçekleştirilimiştir. Şifreniz: "+txtPassword.Text,"İşlem Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}

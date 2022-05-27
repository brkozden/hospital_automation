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
    public partial class EditInformationform : Form
    {
        public EditInformationform()
        {
            InitializeComponent();
        }

        public string TCNo;
        SqlCon bgl = new SqlCon();
        private void EditInformationform_Load(object sender, EventArgs e)
        {
            mtboxTC.Text = TCNo;
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Patients where patientTC=@p1",bgl.connect());
            cmd.Parameters.AddWithValue("@p1", mtboxTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                mtboxPhone.Text = dr[4].ToString();
                txtPassword.Text = dr[5].ToString();
                string Gender = dr[6].ToString();

                if (Gender =="Erkek")
                {
                    rbtnMan.Checked = true;
                }
                if (Gender == "Kadin")
                {
                    rbtnWoman.Checked = true;
                }




            }
            bgl.connect();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Update Tbl_Patients set patientName=@p1,patientSurname=@p2,patientPhone=@p3," +
                "patientPassword=@p4,patientGender=@p5 Where patientTC=@p6", bgl.connect());
            cmd2.Parameters.AddWithValue("@p1", txtName.Text);
            cmd2.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd2.Parameters.AddWithValue("@p3", mtboxPhone.Text);
            cmd2.Parameters.AddWithValue("@p4", txtPassword.Text);
            cmd2.Parameters.AddWithValue("@p6", mtboxTC.Text);

            if (rbtnMan.Checked == true)
            {
                cmd2.Parameters.AddWithValue("@p5", "Erkek");
            }
            if (rbtnWoman.Checked == true)
            {
                cmd2.Parameters.AddWithValue("@p5", "Kadin");
            }
            cmd2.ExecuteNonQuery();

            bgl.connect().Close();
            MessageBox.Show("Kayıt Bilgileriniz Başarıyla Güncellendi.", "İşlem Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        }
}

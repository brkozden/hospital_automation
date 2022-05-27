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
    public partial class DoctorLoginform : Form
    {
        public DoctorLoginform()
        {
            InitializeComponent();
        }
        SqlCon bgl = new SqlCon();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Doctors Where doctorTC=@p1 and doctorPassword=@p2", bgl.connect());
            cmd.Parameters.AddWithValue("@p1",mtboxTC.Text);
            cmd.Parameters.AddWithValue("@p2",txtPassword.Text);
           SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DoctorDetailsform frm = new DoctorDetailsform();
                frm.TC = mtboxTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC Kimlik No veya Şifre Yanlış.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.connect().Close();

        }
    }
}

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
    public partial class SecretaryLoginform : Form
    {
        public SecretaryLoginform()
        {
            InitializeComponent();
        }
        SqlCon bgl = new SqlCon();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Secretaries where secretaryTC=@p1 and secretaryPassword=@p2",bgl.connect());
            cmd.Parameters.AddWithValue("@p1", mtboxTC.Text);
            cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
           SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                SecretaryDetailsform openForm = new SecretaryDetailsform();
                openForm.TC = mtboxTC.Text;
                openForm.Show();
                 this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre Girdiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.connect().Close();
        }
    }
}

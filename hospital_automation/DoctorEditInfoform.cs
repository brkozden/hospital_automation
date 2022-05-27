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
    public partial class DoctorEditInfoform : Form
    {
        public DoctorEditInfoform()
        {
            InitializeComponent();
        }
        SqlCon bgl = new SqlCon();
        public string TCNO;
        private void DoctorEditInfoform_Load(object sender, EventArgs e)
        {
            mtboxTC.Text = TCNO;
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Doctors Where doctorTC=@p1",bgl.connect());
            cmd.Parameters.AddWithValue("@p1",TCNO);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                cmbBranch.Text = dr[3].ToString();
                txtPassword.Text = dr[5].ToString();
             
            }
            bgl.connect().Close();
            SqlCommand cmd2 = new SqlCommand("Select branchName From Tbl_Branches", bgl.connect());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0]);
            }
            bgl.connect().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Doctors set doctorName=@p1,doctorSurname=@p2,doctorBranch=@p3,doctorPassword=@p4 Where doctorTC=@p5", bgl.connect());
            cmd.Parameters.AddWithValue("@p1",txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", cmbBranch.Text);
            cmd.Parameters.AddWithValue("@p4", txtPassword.Text);
            cmd.Parameters.AddWithValue("@p5", mtboxTC.Text);
            cmd.ExecuteNonQuery();
            bgl.connect().Close();
            MessageBox.Show("Kayıt Güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

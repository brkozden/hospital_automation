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
    public partial class Doctorformcs : Form
    {
        public Doctorformcs()
        {
            InitializeComponent();
        }
        SqlCon bgl = new SqlCon();
        private void Doctorformcs_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doctors", bgl.connect());
            da.Fill(dt);
            dtDoctors.DataSource = dt;

            SqlCommand cmd4 = new SqlCommand("Select branchName From Tbl_Branches", bgl.connect());
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                cbxBranch.Items.Add(dr4[0]);
            }
            bgl.connect().Close();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doctors (doctorName,doctorSurname,doctorBranch,doctorTC,doctorPassword) values (@p1,@p2,@p3,@p4,@p5)",bgl.connect());
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", cbxBranch.Text);
            cmd.Parameters.AddWithValue("@p4", mtxtTC.Text);
            cmd.Parameters.AddWithValue("@p5", txtPassword.Text);
            cmd.ExecuteNonQuery();
            bgl.connect().Close();
            MessageBox.Show("Doktor Ekleme İşlemi Başarıyla Yapıldı","İşlem Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void dtDoctors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int elect = dtDoctors.SelectedCells[0].RowIndex;
            txtName.Text = dtDoctors.Rows[elect].Cells[1].Value.ToString();
            txtSurname.Text = dtDoctors.Rows[elect].Cells[2].Value.ToString();
            cbxBranch.Text = dtDoctors.Rows[elect].Cells[3].Value.ToString();
            mtxtTC.Text = dtDoctors.Rows[elect].Cells[4].Value.ToString();
            txtPassword.Text = dtDoctors.Rows[elect].Cells[5].Value.ToString();
            lblID.Text = dtDoctors.Rows[elect].Cells[0].Value.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Delete From Tbl_Doctors Where doctorid=@p1",bgl.connect());
            cmd2.Parameters.AddWithValue("@p1",lblID.Text);
            cmd2.ExecuteNonQuery();
            bgl.connect().Close();
            MessageBox.Show("Doktor Kaydı Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("update Tbl_Doctors set doctorName=@p1,doctorSurname=@p2,doctorBranch=@p3,doctorPassword=@p4,doctorTC=@p5 Where doctorid=@p6 ", bgl.connect());
            cmd3.Parameters.AddWithValue("@p1", txtName.Text);
            cmd3.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd3.Parameters.AddWithValue("@p3", cbxBranch.Text);           
            cmd3.Parameters.AddWithValue("@p4", txtPassword.Text);
            cmd3.Parameters.AddWithValue("@p5", mtxtTC.Text);
            cmd3.Parameters.AddWithValue("@p6", lblID.Text);
            cmd3.ExecuteNonQuery();
            bgl.connect().Close();
            MessageBox.Show("Doktor Güncelleme Başarılı","İşlem Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

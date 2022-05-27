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
    public partial class Branchform : Form
    {
        public Branchform()
        {
            InitializeComponent();
        }
        SqlCon bgl = new SqlCon();
        private void Branchform_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branches",bgl.connect());
            da.Fill(dt);
           dataGridView1.DataSource = dt;
            bgl.connect().Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Branches (branchName) values (@p1)",bgl.connect());
            cmd.Parameters.AddWithValue("@p1",txtBranchName.Text);
            cmd.ExecuteNonQuery();
            bgl.connect().Close();
            MessageBox.Show("Yeni Branş Eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
          


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int elect = dataGridView1.SelectedCells[0].RowIndex;
            txtBranchID.Text = dataGridView1.Rows[elect].Cells[0].Value.ToString();
            txtBranchName.Text = dataGridView1.Rows[elect].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("delete from Tbl_Branches where branchID=@p1",bgl.connect());
            cmd2.Parameters.AddWithValue("@p1", txtBranchID.Text);
            cmd2.ExecuteNonQuery();
            bgl.connect().Close();
            MessageBox.Show("Branş Silindi.","İşlem Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Update Tbl_Branches set branchName=@p1 where branchID=@p2", bgl.connect());
            cmd3.Parameters.AddWithValue("@p1", txtBranchName.Text);
            cmd3.Parameters.AddWithValue("@p2",txtBranchID.Text);
            cmd3.ExecuteNonQuery();
            bgl.connect().Close();
            MessageBox.Show("Branş Güncelleme İşlemi Başarılı","İşlem Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}

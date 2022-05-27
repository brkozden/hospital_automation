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
    public partial class DoctorDetailsform : Form
    {
        public DoctorDetailsform()
        {
            InitializeComponent();
        }
        SqlCon bgl = new SqlCon();
        public string TC;

        private void DoctorDetailsform_Load(object sender, EventArgs e)
        {
            lblTC2.Text = TC;
            SqlCommand cmd = new SqlCommand("Select doctorName,doctorSurname From Tbl_Doctors Where doctorTC=@p1",bgl.connect());
            cmd.Parameters.AddWithValue("@p1",TC);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lblName.Text = dr["doctorName"].ToString();
                lblSurname.Text = dr["doctorSurname"].ToString();

            }
            bgl.connect().Close();

            DataTable dt = new DataTable();
            string doctorNameSurname;
            doctorNameSurname = lblName.Text+" "+lblSurname.Text;
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments Where appointmentDoctor='"+doctorNameSurname+"'",bgl.connect());
            da.Fill(dt);
            dataGridView1.DataSource= dt;



        }

        private void btnEditInformation_Click(object sender, EventArgs e)
        {
            DoctorEditInfoform fr = new DoctorEditInfoform();
            fr.TCNO = TC;
            fr.Show();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            Announcementsform fr = new Announcementsform();
            fr.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int elect = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[elect].Cells[7].Value.ToString();
        }
    }
}

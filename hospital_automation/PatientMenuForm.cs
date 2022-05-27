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
    public partial class PatientMenuForm : Form
    {
        public PatientMenuForm()
        {
            InitializeComponent();
        }
        public string tc;
        SqlCon bgl = new SqlCon();
        private void PatientMenuForm_Load(object sender, EventArgs e)
        {   lblTC2.Text = tc;
            SqlCommand cmd = new SqlCommand("Select  patientName,patientSurname From Tbl_Patients where patientTC=@p1",bgl.connect());
            cmd.Parameters.AddWithValue("@p1",tc);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblNameSurname2.Text = dr[0].ToString(); 
                lblNameSurname3.Text = dr[1].ToString();

            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments where patientTC="+tc, bgl.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.connect().Close();

           

            

            SqlCommand cmd2 = new SqlCommand("Select branchName From Tbl_Branches",bgl.connect());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbxBranch.Items.Add(dr2[0]);
            }
            bgl.connect().Close();




        }

        private void cmbbxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbxDoctor.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("Select doctorName,doctorSurname From Tbl_Doctors where doctorBranch=@p1", bgl.connect());
            cmd3.Parameters.AddWithValue("@p1",cmbbxBranch.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                cmbbxDoctor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.connect().Close();
        }

        private void cmbbxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments where appointmentBranch=N'"+cmbbxBranch.Text+ "' and appointmentDoctor=N'"+ cmbbxDoctor.Text +"' and appointmentStatus=0",bgl.connect());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.connect().Close();
        }

        private void lnkEditInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          EditInformationform openForm = new EditInformationform();
            openForm.TCNo = lblTC2.Text;
            openForm.Show();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int elect = dataGridView2.SelectedCells[0].RowIndex;
            txtAppointmentID.Text = dataGridView2.Rows[elect].Cells[0].Value.ToString();
        }

        private void btnMakeanAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("update Tbl_Appointments set appointmentStatus=1,patientTC=@p1,patientComplaint=@p2 Where appointmentid=@p3",bgl.connect());
            cmd4.Parameters.AddWithValue("@p1",lblTC2.Text);
            cmd4.Parameters.AddWithValue("@p2", rtxtComplaint.Text);
            cmd4.Parameters.AddWithValue("@p3", txtAppointmentID.Text);
            cmd4.ExecuteNonQuery();
            bgl.connect().Close();
            MessageBox.Show("Randevu Alındı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}

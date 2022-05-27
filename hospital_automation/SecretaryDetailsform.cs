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
    public partial class SecretaryDetailsform : Form
    {
        public SecretaryDetailsform()
        {
            InitializeComponent();
        }
        public String TC;
        SqlCon bgl = new SqlCon();
        private void SecretaryDetailsform_Load(object sender, EventArgs e)
        {
            lblTC2.Text = TC;
            SqlCommand cmd = new SqlCommand("Select secretaryName,secretarySurname From Tbl_Secretaries where secretaryTC=@p1",bgl.connect());
            cmd.Parameters.AddWithValue("@p1", TC);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblName.Text = dr[0].ToString();
                lblSurname.Text = dr[1].ToString();
            }
            bgl.connect().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select branchName From Tbl_Branches", bgl.connect());
             da.Fill(dt);
            dtBranch.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoctorName + ' ' + doctorSurname) as 'Doktor Adı',doctorBranch From Tbl_Doctors", bgl.connect());
            da2.Fill(dt2);
           dtDoctors.DataSource = dt2;

            SqlCommand cmd3 = new SqlCommand("Select branchName From Tbl_Branches", bgl.connect());
            SqlDataReader dr2 = cmd3.ExecuteReader();
            while (dr2.Read())
            {
                cbbxBranch.Items.Add(dr2[0]);
            }
            bgl.connect().Close();

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("insert into Tbl_Appointments (appointmentDate,appointmentTime,appointmentBranch,appointmentDoctor) values (@p1,@p2,@p3,@p4)",bgl.connect());
            cmd2.Parameters.AddWithValue("@p1",mtxtDate.Text);
            cmd2.Parameters.AddWithValue("@p2", mtxtTime.Text);
            cmd2.Parameters.AddWithValue("@p3", cbbxBranch.Text);
            cmd2.Parameters.AddWithValue("@p4", cbbxDoctor.Text);
            cmd2.ExecuteNonQuery();
            bgl.connect().Close();

            MessageBox.Show("Randevu Oluşturuldu", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbbxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbxDoctor.Items.Clear();
            SqlCommand cmd4 = new SqlCommand("Select doctorName,doctorSurname From Tbl_Doctors Where doctorBranch=@p1", bgl.connect());
            cmd4.Parameters.AddWithValue("@p1",cbbxBranch.Text);
            SqlDataReader dr3 = cmd4.ExecuteReader();
            while (dr3.Read())
            { 
                cbbxDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.connect().Close();
        }

        private void btnAnnouncementCreate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("insert into Tbl_Announcements (announcement) values (@p1)",bgl.connect());
            cmd4.Parameters.AddWithValue("@p1",rtxtAnnouncement.Text);
            cmd4.ExecuteNonQuery();
            bgl.connect().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            Doctorformcs openForm = new Doctorformcs();
            openForm.Show();
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            Branchform openForm = new Branchform();
            openForm.Show();
        }

        private void btnAppointmentList_Click(object sender, EventArgs e)
        {
            AppointmentListform openForm = new AppointmentListform();
            openForm = new AppointmentListform();
            openForm.Show();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            Announcementsform openForm = new Announcementsform();
            openForm.Show();
        }
    }
}

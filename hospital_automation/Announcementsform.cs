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
    public partial class Announcementsform : Form
    {
        public Announcementsform()
        {
            InitializeComponent();
        }
        SqlCon bgl = new SqlCon();
        private void Announcementsform_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Announcements",bgl.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.connect().Close();   
        }
    }
}

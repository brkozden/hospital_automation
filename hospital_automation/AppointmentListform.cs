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
    public partial class AppointmentListform : Form
    {
        public AppointmentListform()
        {
            InitializeComponent();
        }
        SqlCon bgl = new SqlCon();
        private void AppointmentListform_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* From Tbl_Appointments",bgl.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            

        }
        public int choose;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            choose  = dataGridView1.SelectedCells[0].RowIndex;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_management_System.views_UI_
{
    public partial class ManageLecturersUI : Form
    {
        public ManageLecturersUI()
        {
            InitializeComponent();

            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Lecturer", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Lecturer", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void ManageLecturersUI_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Lecturer", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbxEmpID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbxLecName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cmbFaculty.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            cmbDept.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cmbCenter.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cmbBuilding.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            cmbLevel.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txbRank.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

            cmbxStartTime.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            cmbxEndTime.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }
    }
}

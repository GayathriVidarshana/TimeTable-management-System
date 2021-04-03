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
    public partial class ManageSubjectsUI : Form
    {
        public ManageSubjectsUI()
        {
            InitializeComponent();
            loadAllSubjectData();
        }

        private void ManageSubjectsUI_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Subject", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
        }

        public void loadAllSubjectData()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Subject", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewManageSubjects.DataSource = dt;
            cn.Close();

        }
    }
}

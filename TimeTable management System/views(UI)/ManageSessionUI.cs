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
    public partial class ManageSessionUI : Form
    {
        public ManageSessionUI()
        {
            InitializeComponent();
            loadAllSessionData();
        }

        private void ManageSessionUI_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Session", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
        }
        public void loadAllSessionData()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Session", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1ManageSession.DataSource = dt;
            cn.Close();

        }
    }
}

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
            emptyInsertedValues();
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

            chkbxMonday.Checked = false;
            chkbxTuesday.Checked = false;
            chkbxWednesday.Checked = false;
            chkbxThursday.Checked = false;
            chkbxFriday.Checked = false;
            chkbxSaturday.Checked = false;
            chkbxSunday.Checked = false;

            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Lecturer WHERE employeeId='"+tbxEmpID.Text+"'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                String aa = dr["activeDays"].ToString();
                String[] a = aa.Split(' ');
                foreach (Control cc in this.Controls)
                {
                    if(cc is CheckBox)
                    {
                        CheckBox b = (CheckBox)cc;
                        for(int j=0;j<a.Length;j++)
                        {
                            if(a[j].ToString() == b.Text)
                            {
                                b.Checked = true;
                            }
                        }
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            cn.Open();

            string s = "";
            foreach (Control cc in this.Controls)
            {
                if (cc is CheckBox)
                {
                    CheckBox b = (CheckBox)cc;
                    if (b.Checked)
                    {
                        s = b.Text + " , " + s;
                    }
                }
            }

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Lecturer SET lecName='" + tbxLecName.Text + "',faculty='" + cmbFaculty.Text + "',dept='" + cmbDept.Text + "',center='" + cmbCenter.Text + "',building='" + cmbBuilding.Text + "',level='" + cmbLevel.Text + "',rank='" + txbRank.Text + "',activeDays='" + s + "',startTime='" + cmbxStartTime.Text + "',endTime='" + cmbxEndTime.Text + "'WHERE employeeId='" + tbxEmpID.Text + "'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Successfully updated");
                emptyInsertedValues();
                reloadTable();


            }
            catch
            {
                MessageBox.Show("Unsuccessfully");
            }

        }
        public void emptyInsertedValues() //create method to reset inserted values----------------------
        {

            tbxEmpID.Text = "";
            txbRank.Text = "";
            tbxLecName.Text = "";

            /* cmbDept.SelectedItem = null;
             cmbBuilding.SelectedItem = null;
             cmbCenter.SelectedItem = null;
             cmbxEndTime.SelectedItem = null;
             cmbFaculty.SelectedItem = null;
             cmbLevel.SelectedItem = null;
             cmbxStartTime.SelectedItem = null; */

            cmbDept.Text = "";
            cmbBuilding.Text = "";
            cmbCenter.Text = "";
            cmbxEndTime.Text = "";
            cmbFaculty.Text = "";
            cmbLevel.Text = "";
            cmbxStartTime.Text = "";

            chkbxMonday.Checked = false;
            chkbxTuesday.Checked = false;
            chkbxWednesday.Checked = false;
            chkbxTuesday.Checked = false;
            chkbxFriday.Checked = false;
            chkbxSaturday.Checked = false;
            chkbxSunday.Checked = false;
        }

        public void reloadTable() 
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

        private void btnGenerateRank_Click(object sender, EventArgs e)
        {
            // Generate Rank

            String a = cmbLevel.Text;
            String b = tbxEmpID.Text;
            String c = ".";
            String d = a + c + b;
            txbRank.Text = d;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Lecturer WHERE employeeId='" + tbxEmpID.Text + "'", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
                cn.Close();
                reloadTable();
                emptyInsertedValues();
            }
            catch
            {
                MessageBox.Show("Unsuccessfully");
            }
        }
    }
}

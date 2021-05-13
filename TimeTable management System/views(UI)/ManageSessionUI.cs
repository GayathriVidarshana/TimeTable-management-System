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
            loadLecturerDetails();
            loadStudentGroup();
            loadSubjectNames();
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
        public void loadSubjectNames()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            //cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Subject", cn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //cmd.ExecuteNonQuery;
            SqlDataReader myReader;

            try
            {
                cn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    String sgrpname = myReader.GetString(1);
                    cbSelectSubject.Items.Add(sgrpname);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadStudentGroup()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            //cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student_D", cn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //cmd.ExecuteNonQuery;
            SqlDataReader myReader;

            try
            {
                cn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    String sgrpname = myReader.GetString(6);
                    cbxSelectGroup.Items.Add(sgrpname);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//End of loadStudentGroup method

        private void btnClear_Click(object sender, EventArgs e)
        {
            emptyInsertedValues();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
                cn.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Session SET lecturer1Id='" + cbxLec1.Text + "',lecturer2Id='" + cbxLec2.Text + "',tag='" + cbxTag.Text + "',group_s='" + cbxSelectGroup.Text + "',subjectId='" + cbSelectSubject.Text + "',noOfStudents='" + numericUpDownNoOfStudents.Text + "',duration='" + tbDuration.Text + "'WHERE Id='" + dataGridView1ManageSession.SelectedRows[0].Cells[0].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Successfully updated");
                    //loadAllSubjectData();
                    emptyInsertedValues();
                    loadAllSessionDataMthd();
                }
                catch
                {
                    MessageBox.Show("Unsuccessfully");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            emptyInsertedValues();
            loadAllSessionDataMthd();
        }

        public void emptyInsertedValues() //create method to reset inserted values----------------------
        {

            tbDuration.Text = "";
            tbSelectedLecturers.Text = "";

            cbxLec1.Text = null;
            cbxLec2.Text = null;
            cbSelectSubject.Text = null;
            cbxSelectGroup.Text = null;
            cbxTag.Text = null;

            numericUpDownNoOfStudents.Text = "";

        } // End of emptyInsertedValues method -----------------------------------------------------------
        public void loadLecturerDetails()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            //cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Lecturer", cn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //cmd.ExecuteNonQuery;
            SqlDataReader myReader;

            try
            {
                cn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    String sname = myReader.GetString(1);
                    cbxLec1.Items.Add(sname);
                    cbxLec2.Items.Add(sname);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//End of loadLecturer method---------------------------------
        private bool IsValidForm()
        {
            if (cbxLec1.Text == String.Empty)
            {
                MessageBox.Show("Select lecturer 1", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbxLec2.Text == String.Empty)
            {
                MessageBox.Show("Select lecturer 2", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbxTag.Text == String.Empty)
            {
                MessageBox.Show("Select tag", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbxSelectGroup.Text == String.Empty)
            {
                MessageBox.Show("Select relevent group", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbSelectSubject.Text == String.Empty)
            {
                MessageBox.Show("Select Subject", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dataGridView1ManageSession_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //txbxSubjCode.Text = dataGridViewManageSubjects.SelectedRows[0].Cells[0].Value.ToString();
            cbxLec1.Text = dataGridView1ManageSession.SelectedRows[0].Cells[1].Value.ToString();
            cbxLec2.Text = dataGridView1ManageSession.SelectedRows[0].Cells[2].Value.ToString();
            cbxTag.Text = dataGridView1ManageSession.SelectedRows[0].Cells[3].Value.ToString();
            cbxSelectGroup.Text = dataGridView1ManageSession.SelectedRows[0].Cells[4].Value.ToString();
            cbSelectSubject.Text = dataGridView1ManageSession.SelectedRows[0].Cells[5].Value.ToString();
            numericUpDownNoOfStudents.Text = dataGridView1ManageSession.SelectedRows[0].Cells[6].Value.ToString();
            tbDuration.Text = dataGridView1ManageSession.SelectedRows[0].Cells[7].Value.ToString();
        }
        public void loadAllSessionDataMthd()
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

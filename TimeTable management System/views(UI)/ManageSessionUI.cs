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

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            emptyInsertedValues();
        }

        public void emptyInsertedValues() //create method to reset inserted values----------------------
        {

            tbDuration.Text = "";
            tbSelectedLecturers.Text = "";

            cbxLec1.SelectedItem = null;
            cbxLec2.SelectedItem = null;
            cbSelectSubject.SelectedItem = null;
            cbxSelectGroup.SelectedItem = null;
            cbxTag.SelectedItem = null;

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
        }//End of loadLecturer method
    }
}

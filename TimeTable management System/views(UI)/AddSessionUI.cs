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
    public partial class AddSessionUI : Form
    {
        public AddSessionUI()
        {
            InitializeComponent();
            loadLecturerDetails(); // called mathod for load lecturer names to combo box
            loadStudentGroup();
            loadSubjectNames();
        }

        private void AddSessionUI_Load(object sender, EventArgs e)
        {

        }

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
                while(myReader.Read())
                {
                    String sname = myReader.GetString(1);
                    cbxLec1.Items.Add(sname);
                    cbxLec2.Items.Add(sname);

                }
            }catch(Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
        }//End of loadLecturer method

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValidForm()) {
                    SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");


                        try
                        {
                            cn.Open();

                            SqlCommand cmd = new SqlCommand("INSERT INTO Session(lecturer1Id,lecturer2Id,tag,group_s,subjectId,noOfStudents,duration) VALUES ('" + cbxLec1.Text + "','" + cbxLec2.Text + "','" + cbxTag.Text + "','" + cbxSelectGroup.Text + "','" + cbSelectSubject.Text + "','" + numericUpDownNoOfStudents.Text + "','" + tbDuration.Text + "')", cn);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Successfully");
                             emptyInsertedValues();
                             //autoIncrementSubjectId();
                        }
                         catch (Exception ex)
                        {

                           //MessageBox.Show("Unsuccesfully");
                            MessageBox.Show(ex.Message);
                        }
            }
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


        private void btnClear_Click(object sender, EventArgs e)
        {
            emptyInsertedValues();
        }
    }
}

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
    public partial class AddSubjectUI : Form
    {
        public AddSubjectUI()
        {
            InitializeComponent();
            autoIncrementSubjectId();
            emptyInsertedValues();
        }
        String semester; // Create globle variable-----------

        private void AddSubjectUI_Load(object sender, EventArgs e)
        {

        }
        public void emptyInsertedValues() //create method to reset inserted values----------------------
        {

            txbxSubjName.Text = "";
            cbxOfferdYear.SelectedItem = null;
            radioButton1Sem1.Checked = false;
            radioButton2Sem2.Checked = false;
            nUpDwnNoOfEvaluationHours.Text = "";
            nUpDwnNoOfLabHours.Text = "";
            nUpDwnNoOfLecturerHours.Text = "";
            nUpDwnNoOfTutorialHours.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            emptyInsertedValues();
        }

        public void autoIncrementSubjectId() //Create method to Auto increment employee ID----------------
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            String empId;
            String Query = "SELECT subjectCode FROM Subject ORDER BY subjectCode DESC";

            cn.Open();
            // SqlCommand cmd = new SqlCommand("SELECT MAX(employeeId) FROM Lecturer", cn);
            SqlCommand cmd = new SqlCommand(Query, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                empId = id.ToString("0000");

            }
            else if (Convert.IsDBNull(dr))
            {
                empId = ("0001");
            }
            else
            {
                empId = ("0001");
            }

            cn.Close();
            txbxSubjCode.Text = empId.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");


                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Subject(subjectCode,subjectName,offeredYear,offeredSem,noOfLecHours,noOfTutorialHours,noOfLabHours,noOfEvaluationHours) VALUES ('" + txbxSubjCode.Text + "','" + txbxSubjName.Text + "','" + cbxOfferdYear.Text + "','" + semester + "','" + nUpDwnNoOfLecturerHours.Text + "','" + nUpDwnNoOfTutorialHours.Text + "','" + nUpDwnNoOfLabHours.Text + "','" + nUpDwnNoOfEvaluationHours.Text + "')", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Successfully");
                    emptyInsertedValues();
                    autoIncrementSubjectId();
                }
                catch
                {
                    MessageBox.Show("Unsuccesfully");
                }
            }
        }

        private void radioButton1Sem1_CheckedChanged(object sender, EventArgs e)
        {
            semester = "1";
        }

        private void radioButton2Sem2_CheckedChanged(object sender, EventArgs e)
        {
            semester = "2";
        }

        private bool IsValidForm()
        {
            if (cbxOfferdYear.Text == String.Empty)
            {
                MessageBox.Show("Select offered year", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if ((radioButton1Sem1.Checked = false) && (radioButton2Sem2.Checked=false))
            {
                MessageBox.Show("Add semester", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (nUpDwnNoOfLecturerHours.Text == "")
            {
                MessageBox.Show("Add number of lecturer hours", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (nUpDwnNoOfTutorialHours.Text == "")
            {
                MessageBox.Show("Add number of tutorial hours", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (nUpDwnNoOfLabHours.Text == "")
            {
                MessageBox.Show("Add number of lab hours", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (nUpDwnNoOfEvaluationHours.Text == "")
            {
                MessageBox.Show("Add number of evaluation hours", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

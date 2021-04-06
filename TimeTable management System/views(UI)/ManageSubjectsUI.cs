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
        String semester; // Create globle variable-----------

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

        private void dataGridViewManageSubjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txbxSubjCode.Text = dataGridViewManageSubjects.SelectedRows[0].Cells[0].Value.ToString();
            txbxSubjName.Text = dataGridViewManageSubjects.SelectedRows[0].Cells[1].Value.ToString();
            cbxOfferdYear.Text = dataGridViewManageSubjects.SelectedRows[0].Cells[2].Value.ToString();

            nUpDwnNoOfLecturerHours.Text = dataGridViewManageSubjects.SelectedRows[0].Cells[4].Value.ToString();
            nUpDwnNoOfTutorialHours.Text = dataGridViewManageSubjects.SelectedRows[0].Cells[5].Value.ToString();
            nUpDwnNoOfLabHours.Text = dataGridViewManageSubjects.SelectedRows[0].Cells[6].Value.ToString();
            nUpDwnNoOfEvaluationHours.Text = dataGridViewManageSubjects.SelectedRows[0].Cells[7].Value.ToString();





        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Subject SET subjectName='" + txbxSubjName.Text + "',offeredYear='" + cbxOfferdYear.Text + "',offeredSem='" + semester + "',noOfLecHours='" + nUpDwnNoOfLecturerHours.Text + "',noOfTutorialHours='" + nUpDwnNoOfTutorialHours.Text + "',noOfLabHours='" + nUpDwnNoOfLabHours.Text + "',noOfEvaluationHours='" + nUpDwnNoOfEvaluationHours.Text + "'WHERE subjectCode='" + txbxSubjCode.Text + "'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Successfully updated");
                loadAllSubjectData();
                emptyInsertedValues();
            }
            catch {
                MessageBox.Show("Unsuccessfully");
            }

        }
        public void emptyInsertedValues() //create method to reset inserted values----------------------
        {
            txbxSubjCode.Text = "";
            txbxSubjName.Text = "";
            cbxOfferdYear.SelectedItem = null;
            radioButton1Sem1.Checked = false;
            radioButton2Sem2.Checked = false;
            nUpDwnNoOfEvaluationHours.Text = "";
            nUpDwnNoOfLabHours.Text = "";
            nUpDwnNoOfLecturerHours.Text = "";
            nUpDwnNoOfTutorialHours.Text = "";
            cbxOfferdYear.Text = "";

        }

        private void radioButton1Sem1_CheckedChanged(object sender, EventArgs e)
        {
            semester = "1st Semester";
        }

        private void radioButton2Sem2_CheckedChanged(object sender, EventArgs e)
        {
            semester = "2nd Semester";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            emptyInsertedValues();
            loadAllSubjectData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Subject WHERE subjectCode='" + txbxSubjCode.Text + "'", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
                cn.Close();
                loadAllSubjectData();
                emptyInsertedValues();
            }
            catch
            {
                MessageBox.Show("Unsuccessfully");
            }
        }
    }
}

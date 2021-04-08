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
    public partial class AddNewLecturerUI : Form
    {
        public AddNewLecturerUI()
        {
            InitializeComponent();
            autoIncrementEmpId();

            //----------------
            btnGenerateRank.Enabled = false;
            btnSave.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (IsValidForm())

            {

                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");

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
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Lecturer(employeeId,lecName,faculty,dept,center,building,level,rank,activeDays,startTime,endTime) VALUES ('" + tbEmpID.Text + "','" + tbLecName.Text + "','" + cbFaculty.Text + "','" + cbDept.Text + "','" + cbCenter.Text + "','" + cbBuilding.Text + "','" + cbLevel.Text + "','" + tbRank.Text + "','" + s + "','" + cbStartTime.Text + "','" + cbEndTime.Text + "')", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Successfully");
                    emptyInsertedValues();
                    autoIncrementEmpId();
                }
                catch
                {
                    MessageBox.Show("Unsuccesfully");
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e) //Clear button-------------
        {
            emptyInsertedValues();
        }

        private void AddNewLecturerUI_Load(object sender, EventArgs e)
        {
            
        }

        public void autoIncrementEmpId() //Create method to Auto increment employee ID----------------
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\TTMSDB.mdf;Integrated Security=True");
            String empId;
            String Query = "SELECT employeeId FROM Lecturer ORDER BY employeeId DESC";

            cn.Open();
            // SqlCommand cmd = new SqlCommand("SELECT MAX(employeeId) FROM Lecturer", cn);
            SqlCommand cmd = new SqlCommand(Query, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                empId = id.ToString("00000");

            }
            else if (Convert.IsDBNull(dr))
            {
                empId = ("00001");
            }
            else
            {
                empId = ("00001");
            }

            cn.Close();
            tbEmpID.Text = empId.ToString();
        }
        public void emptyInsertedValues() //create method to reset inserted values----------------------
        {

            tbLecName.Text = "";
            tbRank.Text = "";
            cbDept.SelectedItem = null;
            cbBuilding.SelectedItem = null;
            cbCenter.SelectedItem = null;
            cbEndTime.SelectedItem = null;
            cbFaculty.SelectedItem = null;
            cbLevel.SelectedItem = null;
            cbStartTime.SelectedItem = null;

            chkbxMonday.Checked = false;
            chckbxTuesday.Checked = false;
            chckbxWednesday.Checked = false;
            chckbxThursday.Checked = false;
            chckbxFriday.Checked = false;
            chckbxSaturday.Checked = false;
            chckbxSunday.Checked = false;
        }
        private void btnGenerateRank_Click(object sender, EventArgs e)
        {

            // Generate Rank

            String a = cbLevel.Text;
            String b = tbEmpID.Text;
            String c = ".";
            String d = a + c + b;
            tbRank.Text = d;
        }

        private void tbLecName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            if (tbLecName.Text.Length > 30)
            {
                // MessageBox.Show("Max characters limit is 23 letters", "Textbox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProviderLecName.SetError(tbLecName, "Max characters limit is 30 letters");
                btnSave.Enabled = false;
            }
            else 
            {
                errorProviderLecName.SetError(tbLecName, "");
                btnSave.Enabled = true;
            } 
        }

        private void tbLecName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLevel.SelectedItem == null)
            {
                btnGenerateRank.Enabled = false;
            }
            else
            {
                btnGenerateRank.Enabled = true;
            }
        }

     

        private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tbRank_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFaculty_Validating(object sender, CancelEventArgs e)
        {

        }

        private bool IsValidForm()
        {
            if (cbFaculty.Text == String.Empty)
            {
                MessageBox.Show("Select Faculty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (tbLecName.Text == String.Empty)
            {
                MessageBox.Show("Add Lecturer name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbDept.Text == String.Empty)
            {
                MessageBox.Show("Select department", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbCenter.Text == String.Empty)
            {
                MessageBox.Show("Select center", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbBuilding.Text == String.Empty)
            {
                MessageBox.Show("Select building", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (tbRank.Text == String.Empty)
            {
                MessageBox.Show("Click Generate rank Button", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbStartTime.Text == String.Empty)
            {
                MessageBox.Show("Start time cannot be empty ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbEndTime.Text == String.Empty)
            {
                MessageBox.Show("End time cannot be empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void tbLecName_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TimeTable_management_System
{
    public partial class Form2 : Form
    {

        //Creating microsoft sql connection
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Anjaani 1st take\Notes 3rd year 1st semester\ITPM\itpm 3rdy\TimeTable-management-System\TimeTable management System\database\TTMSDB.mdf;Integrated Security=True");

        int lecSessId;
        int groupId;
        int locationId;

        public Form2()
        {
            InitializeComponent();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Clear all data in spaces
            cmbLfaculty.Text = cmbLname.Text = cmbLsession.Text = cmbLtimefrom.Text = cmbLtimeto.Text = "";
            lecSessId = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonclearLocation_Click(object sender, EventArgs e)
        {
            //Clear all data in spaces
            comboBoxfacultyL.Text = comboBoxbuildingL.Text = comboBoxroomnoL.Text = comboBoxtimefromL.Text = comboBoxtimetoL.Text = "";
            locationId = 0;
        }

        private void buttonclearGroup_Click(object sender, EventArgs e)
        {
            //Clear all data in spaces
            cmbGfaculty.Text = cmbGgroupId.Text = cmbGsubgroup.Text = cmbGtimefrom.Text = cmbGtimeto.Text = "";
            groupId = 0;
        }

        private void buttonaddLS_Click(object sender, EventArgs e)
        {

            if (IsValidLecSeent())
            {


                //Add data to database
                sqlconn.Open();
                //SqlCommand cmd = sqlcon.CreateCommand();
                //cmd.CommandText = "insert into Lec_WorkingD(faculty, lecturerName, noOfDays, workingdays, workinghours, workingminutes) values ('" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + numericUpDown1.Text + "', '" + s + "', '" + numericUpDown2.Text + "', '" + numericUpDown3.Text + "')";
                SqlCommand command = new SqlCommand("insert into lsLecSession(lsFaculty, lsLecname, lsSession, lsTimeFrom, lsTimeTo) values ('" + cmbLfaculty.Text + "', '" + cmbLname.Text + "', '" + cmbLsession.Text + "', '" + cmbLtimefrom.Text + "', '" + cmbLtimeto.Text + "')", sqlconn);
                command.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show("Saved Successfully");

                GridFillLs();
            }

        }


        private bool IsValidLecSeent()
        {
            if (cmbLfaculty.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Faculty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cmbLname.Text == String.Empty)
            {
                MessageBox.Show("Please Entee lecturer name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cmbLsession.Text == String.Empty)
            {
                MessageBox.Show("Please Enter session", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cmbLtimefrom.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Time from", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cmbLtimeto.Text == String.Empty)
            {
                MessageBox.Show("Please Enter time to", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }


        void GridFillLs()
        {
            sqlconn.Open();
            SqlDataAdapter sdpa = new SqlDataAdapter("ViewLecSession", sqlconn);
            sdpa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable datatable = new DataTable();
            sdpa.Fill(datatable);
            dataGridViewLec.DataSource = datatable;
            dataGridViewLec.Columns[0].Visible = false;
            sqlconn.Close();

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            GridFillLs();
            GridFillgrp();
            GridFillLocation();
        }

        private void cmbLfaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Populate lecturer dropdown list according to the data selected in faculty dropdown list
            cmbLname.Items.Clear();

            if (cmbLfaculty.Text == "Engineering")
            {
                cmbLname.Items.Add("Dr.s.Wijewardhana");
                cmbLname.Items.Add("Dr.W.M.J.L.Wijekoon");
                cmbLname.Items.Add("Dr.E.C.Kulasekara");
                cmbLname.Items.Add("Dr.W.K.Wimalasiri");
                cmbLname.Items.Add("Dr.S.C.S.Karunarathne");
                cmbLname.Items.Add("Dr.S.C.S.Karunarathne");
                cmbLname.Items.Add("Prof.A.T.Suraweera");
                cmbLname.Items.Add("Prof.H.S.Thilakasiri");
                cmbLname.Items.Add("Prof.R.A.Aththalage");
                cmbLname.Items.Add("Dr.M.N.Wijesundara");
            }

            if (cmbLfaculty.Text == "Computing")
            {
                cmbLname.Items.Add("Dr.G.N.Kodagoda");
                cmbLname.Items.Add("Mr.H.S.Jayasena");
                cmbLname.Items.Add("Prof.H.S.C.Perera");
                cmbLname.Items.Add("Dr.A.P.N.Somarathna");
                cmbLname.Items.Add("Prof.H.S.Thilakasiri");
                cmbLname.Items.Add("Prof.R.A.Aththalage");
                cmbLname.Items.Add("Dr.M.N.Wijesundara");
                cmbLname.Items.Add("Prof.S.E.Piris");
                cmbLname.Items.Add("Dr.A.L.G.Senevirathna");
                cmbLname.Items.Add("Dr.R.S.Perera");
            }

            if (cmbLfaculty.Text == "Business Management")
            {
                cmbLname.Items.Add("Dr.G.Tharmarajah");
                cmbLname.Items.Add("Dr.J.Lanel");
                cmbLname.Items.Add("Prof.K.N.Pulasinghe");
                cmbLname.Items.Add("Dr.A.P.N.Somarathne");
                cmbLname.Items.Add("Prof.L.A.S.R.Perera");
                cmbLname.Items.Add("Prof.L.A.S.R.Piris");
                cmbLname.Items.Add("Prof.M.P.Marasinghe");
                cmbLname.Items.Add("Dr.T.S.K.Rathnayaka");
                cmbLname.Items.Add("Dr.G.B.Ruupasinghe");
                cmbLname.Items.Add("Dr.R.P.Thilakumara");
            }

        }

        private void buttonaddGroup_Click(object sender, EventArgs e)
        {

            if (IsValidGroup())
            {

                //Add data to database
                sqlconn.Open();
                //SqlCommand cmd = sqlcon.CreateCommand();
                //cmd.CommandText = "insert into Lec_WorkingD(faculty, lecturerName, noOfDays, workingdays, workinghours, workingminutes) values ('" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + numericUpDown1.Text + "', '" + s + "', '" + numericUpDown2.Text + "', '" + numericUpDown3.Text + "')";
                SqlCommand command1 = new SqlCommand("insert into gGroup(gFaculty, gGroupId, gSubGroup, gTimeFrom, gTimeTo) values ('" + cmbGfaculty.Text + "', '" + cmbGgroupId.Text + "', '" + cmbGsubgroup.Text + "', '" + cmbGtimefrom.Text + "', '" + cmbGtimeto.Text + "')", sqlconn);
                command1.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show("Saved Successfully");

                GridFillgrp();
            }
        }



        private bool IsValidGroup()
        {
            if (cmbGfaculty.Text == String.Empty)
            {
                MessageBox.Show("Please Enter faculty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cmbGgroupId.Text == String.Empty)
            {
                MessageBox.Show("Please Enter group id", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cmbGsubgroup.Text == String.Empty)
            {
                MessageBox.Show("Please Enter sub group", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cmbGtimefrom.Text == String.Empty)
            {
                MessageBox.Show("Please Enter time from", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cmbGtimeto.Text == String.Empty)
            {
                MessageBox.Show("Please Enter time to", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }


        void GridFillgrp()
        {
            sqlconn.Open();
            SqlDataAdapter sdpa1 = new SqlDataAdapter("ViewGroup", sqlconn);
            sdpa1.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable datatable1 = new DataTable();
            sdpa1.Fill(datatable1);
            dataGridViewGroup.DataSource = datatable1;
            dataGridViewGroup.Columns[0].Visible = false;
            sqlconn.Close();

        }

        private void cmbGfaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonaddLocation_Click(object sender, EventArgs e)
        {


            if (IsValidLocation())
            {

                //Add data to database
                sqlconn.Open();
                //SqlCommand cmd = sqlcon.CreateCommand();
                //cmd.CommandText = "insert into Lec_WorkingD(faculty, lecturerName, noOfDays, workingdays, workinghours, workingminutes) values ('" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + numericUpDown1.Text + "', '" + s + "', '" + numericUpDown2.Text + "', '" + numericUpDown3.Text + "')";
                SqlCommand command3 = new SqlCommand("insert into lLocation(lFaculty, lBuilding, lRoomNo, lTimeFrom, lTimeTo) values ('" + comboBoxfacultyL.Text + "', '" + comboBoxbuildingL.Text + "', '" + comboBoxroomnoL.Text + "', '" + comboBoxtimefromL.Text + "', '" + comboBoxtimetoL.Text + "')", sqlconn);
                command3.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show("Saved Successfully");

                GridFillLocation();
            }

        }


        private bool IsValidLocation()
        {
            if (comboBoxfacultyL.Text == String.Empty)
            {
                MessageBox.Show("Please Enter faculty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBoxbuildingL.Text == String.Empty)
            {
                MessageBox.Show("Please Enter building", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBoxroomnoL.Text == String.Empty)
            {
                MessageBox.Show("Please Enter room no:", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBoxtimefromL.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Time from", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBoxtimetoL.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Time to", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dataGridViewLec_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewLec.CurrentRow.Index != -1)
            {

                lecSessId = Convert.ToInt32(dataGridViewLec.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void buttonDeleteLS_Click(object sender, EventArgs e)
        {

            sqlconn.Open();
            SqlCommand cmdlsess = new SqlCommand("DELETE FROM lsLecSession WHERE ls_Id = " + dataGridViewLec.SelectedRows[0].Cells[0].Value.ToString() + "", sqlconn);
            cmdlsess.ExecuteNonQuery();
            dataGridViewLec.Rows.RemoveAt(dataGridViewLec.SelectedRows[0].Index);
            sqlconn.Close();
            MessageBox.Show("Record has been deleted successfully");

        }

        private void dataGridViewLec_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void buttondeleteGroup_Click(object sender, EventArgs e)
        {

            sqlconn.Open();
            SqlCommand cmdgrp = new SqlCommand("DELETE FROM gGroup WHERE g_Id = " + dataGridViewGroup.SelectedRows[0].Cells[0].Value.ToString() + "", sqlconn);
            cmdgrp.ExecuteNonQuery();
            dataGridViewGroup.Rows.RemoveAt(dataGridViewGroup.SelectedRows[0].Index);
            sqlconn.Close();
            MessageBox.Show("Record has been deleted successfully");

        }

        private void buttondeleteLocation_Click(object sender, EventArgs e)
        {

            sqlconn.Open();
            SqlCommand cmdloc = new SqlCommand("DELETE FROM lLocation WHERE l_Id = " + dataGridViewLocation.SelectedRows[0].Cells[0].Value.ToString() + "", sqlconn);
            cmdloc.ExecuteNonQuery();
            dataGridViewLocation.Rows.RemoveAt(dataGridViewLocation.SelectedRows[0].Index);
            sqlconn.Close();
            MessageBox.Show("Record has been deleted successfully");


        }

        private void comboBoxsearchLS_TextChanged(object sender, EventArgs e)
        {

            sqlconn.Open();
            SqlCommand cmdls = new SqlCommand("select * from lsLecSession where lsfaculty = '" + comboBoxsearchLS.Text + "' ", sqlconn);
            SqlDataAdapter sdls = new SqlDataAdapter(cmdls);
            DataTable dtls = new DataTable();
            sdls.Fill(dtls);
            dataGridViewLec.DataSource = dtls;
            sqlconn.Close();

        }

        private void comboBoxsearchLN_TextChanged(object sender, EventArgs e)
        {

            sqlconn.Open();
            SqlCommand cmdls1 = new SqlCommand("select * from lsLecSession where lsLecname = '" + comboBoxsearchLN.Text + "' ", sqlconn);
            SqlDataAdapter sdls1 = new SqlDataAdapter(cmdls1);
            DataTable dtls1 = new DataTable();
            sdls1.Fill(dtls1);
            dataGridViewLec.DataSource = dtls1;
            sqlconn.Close();

        }

        private void comboBoxsearchLN_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Populate lecturer dropdown list according to the data selected in faculty dropdown list
            comboBoxsearchLN.Items.Clear();

            if (comboBoxsearchLS.Text == "Engineering")
            {
                comboBoxsearchLN.Items.Add("Dr.s.Wijewardhana");
                comboBoxsearchLN.Items.Add("Dr.W.M.J.L.Wijekoon");
                comboBoxsearchLN.Items.Add("Dr.E.C.Kulasekara");
                comboBoxsearchLN.Items.Add("Dr.W.K.Wimalasiri");
                comboBoxsearchLN.Items.Add("Dr.S.C.S.Karunarathne");
                comboBoxsearchLN.Items.Add("Dr.S.C.S.Karunarathne");
                comboBoxsearchLN.Items.Add("Prof.A.T.Suraweera");
                comboBoxsearchLN.Items.Add("Prof.H.S.Thilakasiri");
                comboBoxsearchLN.Items.Add("Prof.R.A.Aththalage");
                comboBoxsearchLN.Items.Add("Dr.M.N.Wijesundara");
            }

            if (comboBoxsearchLS.Text == "Computing")
            {
                comboBoxsearchLN.Items.Add("Dr.G.N.Kodagoda");
                comboBoxsearchLN.Items.Add("Mr.H.S.Jayasena");
                comboBoxsearchLN.Items.Add("Prof.H.S.C.Perera");
                comboBoxsearchLN.Items.Add("Dr.A.P.N.Somarathna");
                comboBoxsearchLN.Items.Add("Prof.H.S.Thilakasiri");
                comboBoxsearchLN.Items.Add("Prof.R.A.Aththalage");
                comboBoxsearchLN.Items.Add("Dr.M.N.Wijesundara");
                comboBoxsearchLN.Items.Add("Prof.S.E.Piris");
                comboBoxsearchLN.Items.Add("Dr.A.L.G.Senevirathna");
                comboBoxsearchLN.Items.Add("Dr.R.S.Perera");
            }

            if (comboBoxsearchLS.Text == "Business Management")
            {
                comboBoxsearchLN.Items.Add("Dr.G.Tharmarajah");
                comboBoxsearchLN.Items.Add("Dr.J.Lanel");
                comboBoxsearchLN.Items.Add("Prof.K.N.Pulasinghe");
                comboBoxsearchLN.Items.Add("Dr.A.P.N.Somarathne");
                comboBoxsearchLN.Items.Add("Prof.L.A.S.R.Perera");
                comboBoxsearchLN.Items.Add("Prof.L.A.S.R.Piris");
                comboBoxsearchLN.Items.Add("Prof.M.P.Marasinghe");
                comboBoxsearchLN.Items.Add("Dr.T.S.K.Rathnayaka");
                comboBoxsearchLN.Items.Add("Dr.G.B.Ruupasinghe");
                comboBoxsearchLN.Items.Add("Dr.R.P.Thilakumara");
            }

        }

        private void comboBoxsearchGid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxsearchGfaculty_TextChanged(object sender, EventArgs e)
        {
            sqlconn.Open();
            SqlCommand cmdg = new SqlCommand("select * from gGroup where gFaculty = '" + comboBoxsearchGfaculty.Text + "' ", sqlconn);
            SqlDataAdapter sdg = new SqlDataAdapter(cmdg);
            DataTable dtg = new DataTable();
            sdg.Fill(dtg);
            dataGridViewGroup.DataSource = dtg;
            sqlconn.Close();
        }

        private void comboBoxsearchGid_TextChanged(object sender, EventArgs e)
        {

            sqlconn.Open();
            SqlCommand cmdg1 = new SqlCommand("select * from gGroup where gGroupId = '" + comboBoxsearchGid.Text + "' ", sqlconn);
            SqlDataAdapter sdg1 = new SqlDataAdapter(cmdg1);
            DataTable dtg1 = new DataTable();
            sdg1.Fill(dtg1);
            dataGridViewGroup.DataSource = dtg1;
            sqlconn.Close();

        }

        private void comboBoxsearchLfaculty_TextChanged(object sender, EventArgs e)
        {

            sqlconn.Open();
            SqlCommand cmdloc = new SqlCommand("select * from lLocation where lFaculty = '" + comboBoxsearchLfaculty.Text + "' ", sqlconn);
            SqlDataAdapter sdgloc = new SqlDataAdapter(cmdloc);
            DataTable dtgloc = new DataTable();
            sdgloc.Fill(dtgloc);
            dataGridViewLocation.DataSource = dtgloc;
            sqlconn.Close();

        }

        private void comboBoxsearchLbuilding_TextChanged(object sender, EventArgs e)
        {

            sqlconn.Open();
            SqlCommand cmdloc1 = new SqlCommand("select * from lLocation where lBuilding = '" + comboBoxsearchLbuilding.Text + "' ", sqlconn);
            SqlDataAdapter sdgloc1 = new SqlDataAdapter(cmdloc1);
            DataTable dtgloc1 = new DataTable();
            sdgloc1.Fill(dtgloc1);
            dataGridViewLocation.DataSource = dtgloc1;
            sqlconn.Close();

        }

        private void comboBoxsearchLS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void GridFillLocation()
        {
            sqlconn.Open();
            SqlDataAdapter sdpa2 = new SqlDataAdapter("ViewLocation", sqlconn);
            sdpa2.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable datatable2 = new DataTable();
            sdpa2.Fill(datatable2);
            dataGridViewLocation.DataSource = datatable2;
            dataGridViewLocation.Columns[0].Visible = false;
            sqlconn.Close();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void cmbLfaculty_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Select Faculty", cmbLfaculty);
        }

        private void cmbLname_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Select Lecturer Name", cmbLname);
        }

        private void cmbLsession_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Select Session", cmbLsession);
        }

        private void cmbLtimefrom_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Select Time From", cmbLtimefrom);
        }

        private void cmbLtimeto_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Select Time To", cmbLtimeto);
        }

        private void cmbGfaculty_MouseHover(object sender, EventArgs e)
        {
            toolTip6.Show("Select Faculty", cmbGfaculty);
        }

        private void cmbGgroupId_MouseHover(object sender, EventArgs e)
        {
            toolTip7.Show("Select group id", cmbGgroupId);
        }

        private void cmbGsubgroup_MouseHover(object sender, EventArgs e)
        {
            toolTip8.Show("Select sub group", cmbGsubgroup);
        }

        private void cmbGtimefrom_MouseHover(object sender, EventArgs e)
        {
            toolTip9.Show("Select time from", cmbGtimefrom);
        }

        private void cmbGtimeto_MouseHover(object sender, EventArgs e)
        {
            toolTip10.Show("Select time to", cmbGtimeto);
        }

        private void comboBoxfacultyL_MouseHover(object sender, EventArgs e)
        {
            toolTip11.Show("Select faculty", comboBoxfacultyL);
        }

        private void comboBoxbuildingL_MouseHover(object sender, EventArgs e)
        {
            toolTip12.Show("Select building", comboBoxbuildingL);
        }

        private void comboBoxroomnoL_MouseHover(object sender, EventArgs e)
        {
            toolTip13.Show("Select room no:", comboBoxroomnoL);
        }

        private void comboBoxtimefromL_MouseHover(object sender, EventArgs e)
        {
            toolTip14.Show("Select time from", comboBoxtimefromL);
        }

        private void comboBoxtimetoL_MouseHover(object sender, EventArgs e)
        {
            toolTip15.Show("Select time to", comboBoxtimetoL);
        }

        private void buttonDeleteLS_MouseHover(object sender, EventArgs e)
        {
            toolTip16.Show("Delete the selected row", buttonDeleteLS);
        }

        private void buttondeleteGroup_MouseHover(object sender, EventArgs e)
        {
            toolTip17.Show("Delete the selected row", buttondeleteGroup);
        }

        private void buttondeleteLocation_MouseHover(object sender, EventArgs e)
        {
            toolTip18.Show("Delete the selected row", buttondeleteLocation);
        }
    }
}

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
using System.Data.Sql;

namespace TimeTable_management_System.views_UI_
{
    public partial class sprint1 : Form
    {

        //Creating microsoft sql connection
        SqlConnection sqlcon = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = TTMS; Integrated Security = True");
        
        int lecId;
        int batchId;

        SqlCommand scmd;

        

        

        public sprint1()
        {
            InitializeComponent();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Clear all data in spaces after saving the data
            comboBox7.Text = comboBox8.Text = numericUpDown7.Text = numericUpDown8.Text = "";
            batchId = 0;

            //Clear all checked check boxes
            if (this.checkBox15.Checked)
                this.checkBox15.Checked = false;
            if (this.checkBox16.Checked)
                this.checkBox16.Checked = false;
            if (this.checkBox17.Checked)
                this.checkBox17.Checked = false;
            if (this.checkBox18.Checked)
                this.checkBox18.Checked = false;
            if (this.checkBox19.Checked)
                this.checkBox19.Checked = false;
            if (this.checkBox20.Checked)
                this.checkBox20.Checked = false;
            if (this.checkBox21.Checked)
                this.checkBox21.Checked = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            

           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearLecWD();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            //Populate lecturer dropdown list according to the data selected in faculty dropdown list
            comboBox2.Items.Clear();

            if (comboBox1.Text == "Engineering")
            {
                comboBox2.Items.Add("Dr.s.Wijewardhana");
                comboBox2.Items.Add("Dr.W.M.J.L.Wijekoon");
                comboBox2.Items.Add("Dr.E.C.Kulasekara");
                comboBox2.Items.Add("Dr.W.K.Wimalasiri");
                comboBox2.Items.Add("Dr.S.C.S.Karunarathne");
            }

            if (comboBox1.Text == "Computing")
            {
                comboBox2.Items.Add("Dr.G.N.Kodagoda");
                comboBox2.Items.Add("Mr.H.S.Jayasena");
                comboBox2.Items.Add("Prof.H.S.C.Perera");
                comboBox2.Items.Add("Dr.A.P.N.Somarathna");
                comboBox2.Items.Add("Prof.S.E.Piris");
            }

            if (comboBox1.Text == "Business Management")
            {
                comboBox2.Items.Add("Dr.G.Tharmarajah");
                comboBox2.Items.Add("Dr.J.Lanel");
                comboBox2.Items.Add("Prof.K.N.Pulasinghe");
                comboBox2.Items.Add("Dr.A.P.N.Somarathne");
                comboBox2.Items.Add("Prof.L.A.S.R.Perera");
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

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

            

            //Add data to database
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandText = "insert into Lec_WorkingD(faculty, lecturerName, noOfDays, workingdays, workinghours, workingminutes) values ('" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + numericUpDown1.Text + "', '" + s + "', '" + numericUpDown2.Text + "', '" + numericUpDown3.Text + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Saved Successfully");
            ClearLecWD();
            GridFill();

        }


        void GridFill()
        {
            sqlcon.Open();
            SqlDataAdapter sdp = new SqlDataAdapter("LecViewAll", sqlcon);
            sdp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtb = new DataTable();
            sdp.Fill(dtb);
            dataGridView1.DataSource = dtb;
            dataGridView1.Columns[0].Visible = false;
            sqlcon.Close();

        }


        

        string wd;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            wd = "Monday";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            wd = "Tuesday";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            wd = "Wednesday";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            wd = "Thursday";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            wd = "Friday";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            wd = "Saturday";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            wd = "Sunday";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //int num1 = Convert.ToInt32(this.numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //int num2 = Convert.ToInt32(this.numericUpDown2.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            //int num3 = Convert.ToInt32(this.numericUpDown3.Value);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Populate lecturer dropdown list according to the data selected in faculty dropdown list
            comboBox4.Items.Clear();

            if (comboBox3.Text == "Engineering")
            {
                comboBox4.Items.Add("Dr.s.Wijewardhana");
                comboBox4.Items.Add("Dr.W.M.J.L.Wijekoon");
                comboBox4.Items.Add("Dr.E.C.Kulasekara");
                comboBox4.Items.Add("Dr.W.K.Wimalasiri");
                comboBox4.Items.Add("Dr.S.C.S.Karunarathne");
            }

            if (comboBox3.Text == "Computing")
            {
                comboBox4.Items.Add("Dr.G.N.Kodagoda");
                comboBox4.Items.Add("Mr.H.S.Jayasena");
                comboBox4.Items.Add("Prof.H.S.C.Perera");
                comboBox4.Items.Add("Dr.A.P.N.Somarathna");
                comboBox4.Items.Add("Prof.S.E.Piris");
            }

            if (comboBox3.Text == "Business Management")
            {
                comboBox4.Items.Add("Dr.G.Tharmarajah");
                comboBox4.Items.Add("Dr.J.Lanel");
                comboBox4.Items.Add("Prof.K.N.Pulasinghe");
                comboBox4.Items.Add("Dr.A.P.N.Somarathne");
                comboBox4.Items.Add("Prof.L.A.S.R.Perera");
            }

            

        }

        private void button9_Click(object sender, EventArgs e)
        {

            string r = "";
            foreach (Control cn in this.Controls)
            {
                if (cn is CheckBox)
                {
                    CheckBox cb = (CheckBox)cn;
                    if (cb.Checked)
                    {
                        r = cb.Text + " " + r;
                    }
                }
            }

            //Add batch data to database
            sqlcon.Open();
            SqlCommand cmd1 = sqlcon.CreateCommand();
            cmd1.CommandText = "insert into batchWorkingD(batch, workingDays, workingHours, workingMinutes, timeSlot) values ('" + comboBox7.Text + "', '" + r + "', '" +numericUpDown7.Text+ "', '" +numericUpDown8.Text+ "', '" + comboBox8.Text + "')";
            cmd1.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Saved Successfully");

            //Clear all data in spaces after saving the data
            comboBox7.Text = comboBox8.Text = numericUpDown7.Text = numericUpDown8.Text = "";
            batchId = 0;

            //Clear all checked check boxes
            if (this.checkBox15.Checked)
                this.checkBox15.Checked = false;
            if (this.checkBox16.Checked)
                this.checkBox16.Checked = false;
            if (this.checkBox17.Checked)
                this.checkBox17.Checked = false;
            if (this.checkBox18.Checked)
                this.checkBox18.Checked = false;
            if (this.checkBox19.Checked)
                this.checkBox19.Checked = false;
            if (this.checkBox20.Checked)
                this.checkBox20.Checked = false;
            if (this.checkBox21.Checked)
                this.checkBox21.Checked = false;

            batchGridFill();

        }


        void batchGridFill()
        {
            sqlcon.Open();
            SqlDataAdapter sdp = new SqlDataAdapter("BatchViewAll", sqlcon);
            sdp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtb = new DataTable();
            sdp.Fill(dtb);
            dataGridView2.DataSource = dtb;
            dataGridView2.Columns[0].Visible = false;
            sqlcon.Close();

        }


        string batchWorkingDays;

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            batchWorkingDays = "Monday";
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            batchWorkingDays = "Tuesday";
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            batchWorkingDays = "Wednesday";
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            batchWorkingDays = "Thursday";
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            batchWorkingDays = "Friday";
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            batchWorkingDays = "Saturday";
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            batchWorkingDays = "Sunday";
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            //int no1 = Convert.ToInt32(this.numericUpDown7.Value);
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            //int no2 = Convert.ToInt32(this.numericUpDown8.Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sprint1_Load(object sender, EventArgs e)
        {
            //Clear data inserted to the spaces
            ClearLecWD();

            //Clear data inserted to the spaces in update page
            comboBox5.Text = comboBox6.Text = numericUpDown4.Text = numericUpDown5.Text = numericUpDown6.Text = "";
            lecId = 0;

            //Clear data inserted to the spaces in batch page
            comboBox7.Text = comboBox8.Text = numericUpDown7.Text = numericUpDown8.Text = "";
            batchId = 0;



            GridFill();
            batchGridFill();
            

            //      sqlcon.Open();
            //    sdp = new SqlDataAdapter("select * from Lec_workingD", sqlcon);
            //  dtb = new DataTable();
            //sdp.Fill(dtb);
            //dataGridView1.DataSource = dtb;
            //sqlcon.Close();

        }


        void ClearLecWD()
        {
            comboBox1.Text = comboBox2.Text = numericUpDown1.Text = numericUpDown2.Text = numericUpDown3.Text = "";
            lecId = 0;

            if (this.checkBox1.Checked)
                this.checkBox1.Checked = false;
            if (this.checkBox2.Checked)
                this.checkBox2.Checked = false;
            if (this.checkBox3.Checked)
                this.checkBox3.Checked = false;
            if (this.checkBox4.Checked)
                this.checkBox4.Checked = false;
            if (this.checkBox5.Checked)
                this.checkBox5.Checked = false;
            if (this.checkBox6.Checked)
                this.checkBox6.Checked = false;
            if (this.checkBox7.Checked)
                this.checkBox7.Checked = false;
        }


        

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                comboBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                numericUpDown4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                numericUpDown5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                numericUpDown6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                lecId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand sqlCommand = new SqlCommand("UpdateLecWD", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@lid", lecId);
            sqlCommand.Parameters.AddWithValue("@lFaculty", comboBox5.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@lecName", comboBox6.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@noofD", numericUpDown4.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@lworkingD", checkBox8.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@lworkingH", numericUpDown5.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@lworkingM", numericUpDown6.Text.Trim());
            sqlCommand.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Data Updated Successfully.");

            //Clear enetered data of all the combo boxes and numericUpDown
            comboBox5.Text = comboBox6.Text = numericUpDown4.Text = numericUpDown5.Text = numericUpDown6.Text = "";
            lecId = 0;

            //Clear all checked check boxes
            if (this.checkBox8.Checked)
                this.checkBox8.Checked = false;
            if (this.checkBox9.Checked)
                this.checkBox9.Checked = false;
            if (this.checkBox10.Checked)
                this.checkBox10.Checked = false;
            if (this.checkBox11.Checked)
                this.checkBox11.Checked = false;
            if (this.checkBox12.Checked)
                this.checkBox12.Checked = false;
            if (this.checkBox13.Checked)
                this.checkBox13.Checked = false;
            if (this.checkBox14.Checked)
                this.checkBox14.Checked = false;

            GridFill();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand sqlCommand = new SqlCommand("DeleteLecWD", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@lid", lecId);
            sqlCommand.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Data Deleted Successfully.");

            //Clear enetered data of all the combo boxes and numericUpDown
            comboBox5.Text = comboBox6.Text = numericUpDown4.Text = numericUpDown5.Text = numericUpDown6.Text = "";
            lecId = 0;

            //Clear all checked check boxes
            if (this.checkBox8.Checked)
                this.checkBox8.Checked = false;
            if (this.checkBox9.Checked)
                this.checkBox9.Checked = false;
            if (this.checkBox10.Checked)
                this.checkBox10.Checked = false;
            if (this.checkBox11.Checked)
                this.checkBox11.Checked = false;
            if (this.checkBox12.Checked)
                this.checkBox12.Checked = false;
            if (this.checkBox13.Checked)
                this.checkBox13.Checked = false;
            if (this.checkBox14.Checked)
                this.checkBox14.Checked = false;

            GridFill();

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Populate lecturer dropdown list according to the data selected in faculty dropdown list
            comboBox6.Items.Clear();

            if (comboBox5.Text == "Engineering")
            {
                comboBox6.Items.Add("Dr.s.Wijewardhana");
                comboBox6.Items.Add("Dr.W.M.J.L.Wijekoon");
                comboBox6.Items.Add("Dr.E.C.Kulasekara");
                comboBox6.Items.Add("Dr.W.K.Wimalasiri");
                comboBox6.Items.Add("Dr.S.C.S.Karunarathne");
            }

            if (comboBox5.Text == "Computing")
            {
                comboBox6.Items.Add("Dr.G.N.Kodagoda");
                comboBox6.Items.Add("Mr.H.S.Jayasena");
                comboBox6.Items.Add("Prof.H.S.C.Perera");
                comboBox6.Items.Add("Dr.A.P.N.Somarathna");
                comboBox6.Items.Add("Prof.S.E.Piris");
            }

            if (comboBox5.Text == "Business Management")
            {
                comboBox6.Items.Add("Dr.G.Tharmarajah");
                comboBox6.Items.Add("Dr.J.Lanel");
                comboBox6.Items.Add("Prof.K.N.Pulasinghe");
                comboBox6.Items.Add("Dr.A.P.N.Somarathne");
                comboBox6.Items.Add("Prof.L.A.S.R.Perera");
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand sqlCommand = new SqlCommand("UpdateBatchWD", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@BId", batchId);
            sqlCommand.Parameters.AddWithValue("@Bbatch", comboBox7.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@bworkingD", checkBox15.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@bworkingH", numericUpDown7.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@bworkingM", numericUpDown8.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@btimeSlot", comboBox8.Text.Trim());
            sqlCommand.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Data Updated Successfully.");

            //Clear all data in spaces after saving the data
            comboBox7.Text = comboBox8.Text = numericUpDown7.Text = numericUpDown8.Text = "";
            batchId = 0;

            //Clear all checked check boxes
            if (this.checkBox15.Checked)
                this.checkBox15.Checked = false;
            if (this.checkBox16.Checked)
                this.checkBox16.Checked = false;
            if (this.checkBox17.Checked)
                this.checkBox17.Checked = false;
            if (this.checkBox18.Checked)
                this.checkBox18.Checked = false;
            if (this.checkBox19.Checked)
                this.checkBox19.Checked = false;
            if (this.checkBox20.Checked)
                this.checkBox20.Checked = false;
            if (this.checkBox21.Checked)
                this.checkBox21.Checked = false;


            batchGridFill();

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow.Index != -1)
            {
                comboBox7.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                numericUpDown7.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                numericUpDown8.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                comboBox8.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                batchId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand sqlCommand = new SqlCommand("DeleteBatchWD", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@bchid", batchId);
            sqlCommand.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Data Deleted Successfully.");

            //Clear all data in spaces after saving the data
            comboBox7.Text = comboBox8.Text = numericUpDown7.Text = numericUpDown8.Text = "";
            batchId = 0;

            //Clear all checked check boxes
            if (this.checkBox15.Checked)
                this.checkBox15.Checked = false;
            if (this.checkBox16.Checked)
                this.checkBox16.Checked = false;
            if (this.checkBox17.Checked)
                this.checkBox17.Checked = false;
            if (this.checkBox18.Checked)
                this.checkBox18.Checked = false;
            if (this.checkBox19.Checked)
                this.checkBox19.Checked = false;
            if (this.checkBox20.Checked)
                this.checkBox20.Checked = false;
            if (this.checkBox21.Checked)
                this.checkBox21.Checked = false;


            batchGridFill();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }
    }
}

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
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Anjaani 1st take\Notes 3rd year 1st semester\ITPM\itpm 3rdy\TimeTable-management-System\TimeTable management System\database\TTMSDB.mdf;Integrated Security=True");
        
        int lecId, sessiondt_id;
        int batchId;
        string days = "";
        

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

            //Disable delete button when there is no record to delete
            button11.Enabled = false;

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
                comboBox2.Items.Add("Dr.S.C.S.Karunarathne");
                comboBox2.Items.Add("Prof.A.T.Suraweera");
                comboBox2.Items.Add("Prof.H.S.Thilakasiri");
                comboBox2.Items.Add("Prof.R.A.Aththalage");
                comboBox2.Items.Add("Dr.M.N.Wijesundara");
            }

            if (comboBox1.Text == "Computing")
            {
                comboBox2.Items.Add("Dr.G.N.Kodagoda");
                comboBox2.Items.Add("Mr.H.S.Jayasena");
                comboBox2.Items.Add("Prof.H.S.C.Perera");
                comboBox2.Items.Add("Dr.A.P.N.Somarathna");
                comboBox2.Items.Add("Prof.H.S.Thilakasiri");
                comboBox2.Items.Add("Prof.R.A.Aththalage");
                comboBox2.Items.Add("Dr.M.N.Wijesundara");
                comboBox2.Items.Add("Prof.S.E.Piris");
                comboBox2.Items.Add("Dr.A.L.G.Senevirathna");
                comboBox2.Items.Add("Dr.R.S.Perera");
            }

            if (comboBox1.Text == "Business Management")
            {
                comboBox2.Items.Add("Dr.G.Tharmarajah");
                comboBox2.Items.Add("Dr.J.Lanel");
                comboBox2.Items.Add("Prof.K.N.Pulasinghe");
                comboBox2.Items.Add("Dr.A.P.N.Somarathne");
                comboBox2.Items.Add("Prof.L.A.S.R.Perera");
                comboBox2.Items.Add("Prof.L.A.S.R.Piris");
                comboBox2.Items.Add("Prof.M.P.Marasinghe");
                comboBox2.Items.Add("Dr.T.S.K.Rathnayaka");
                comboBox2.Items.Add("Dr.G.B.Ruupasinghe");
                comboBox2.Items.Add("Dr.R.P.Thilakumara");
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           if (IsValidLecWD())
            {

                /*if (IsValidLecWD())
                {
                    try
                    {
                        //Add data to database
                        sqlconn.Open();
                        //SqlCommand cmd = sqlcon.CreateCommand();
                        //cmd.CommandText = "insert into Lec_WorkingD(faculty, lecturerName, noOfDays, workingdays, workinghours, workingminutes) values ('" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + numericUpDown1.Text + "', '" + s + "', '" + numericUpDown2.Text + "', '" + numericUpDown3.Text + "')";
                        SqlCommand cmd = new SqlCommand("insert into Lec_WorkingD(faculty, lecturerName, noOfDays, workingdays, workinghours, workingminutes) values ('" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + numericUpDown1.Text + "', '" + s + "', '" + numericUpDown2.Text + "', '" + numericUpDown3.Text + "')", sqlcon);
                        cmd.ExecuteNonQuery();
                        sqlconn.Close();

                        MessageBox.Show("Saved Successfully");
                        ClearLecWD();
                        GridFill();
                    }
                    catch
                    {
                        MessageBox.Show("Unsuccessfull");
                    }
                }*/

                //Add data to database
                sqlconn.Open();
                //SqlCommand cmd = sqlcon.CreateCommand();
                //cmd.CommandText = "insert into Lec_WorkingD(faculty, lecturerName, noOfDays, workingdays, workinghours, workingminutes) values ('" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + numericUpDown1.Text + "', '" + s + "', '" + numericUpDown2.Text + "', '" + numericUpDown3.Text + "')";
                SqlCommand cmd = new SqlCommand("insert into Lec_WorkingD(faculty, lecturerName, noOfDays, workingdays, workinghours, workingminutes) values ('" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + numericUpDown1.Text + "', '" + getLecWD() + "', '" + numericUpDown2.Text + "', '" + numericUpDown3.Text + "')", sqlconn);
                cmd.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show("Saved Successfully");
                ClearLecWD();
                GridFill();
            }

        }


        private string getLecWD()
        {
            StringBuilder result = new StringBuilder();
            if (checkBox1.Checked)
                result.AppendFormat("{0},", checkBox1.Text);
            if (checkBox2.Checked)
                result.AppendFormat("{0},", checkBox2.Text);
            if (checkBox3.Checked)
                result.AppendFormat("{0},", checkBox3.Text);
            if (checkBox4.Checked)
                result.AppendFormat("{0},", checkBox4.Text);
            if (checkBox5.Checked)
                result.AppendFormat("{0},", checkBox5.Text);
            if (checkBox6.Checked)
                result.AppendFormat("{0},", checkBox6.Text);
            if (checkBox7.Checked)
                result.AppendFormat("{0},", checkBox7.Text);
            if (result.Length > 0) result.Length--;
            return result.ToString();
        }

        

        private bool IsValidLecWD()
        {
            if (comboBox1.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Faculty Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox2.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Lecturer Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numericUpDown1.Text == String.Empty)
            {
                MessageBox.Show("Please Enter No: of Working Days", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numericUpDown2.Text == String.Empty)
            {
                MessageBox.Show("Please Enter No: of Working Hours", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        } 




        void GridFill()
        {
            sqlconn.Open();
            SqlDataAdapter sdp = new SqlDataAdapter("LecViewAll", sqlconn);
            sdp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtb = new DataTable();
            sdp.Fill(dtb);
            dataGridView1.DataSource = dtb;
            dataGridView1.Columns[0].Visible = false;
            sqlconn.Close();

        }


        

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            
        } 

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            
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
                comboBox4.Items.Add("Prof.A.T.Suraweera");
                comboBox4.Items.Add("Prof.H.S.Thilakasiri");
                comboBox4.Items.Add("Prof.R.A.Aththalage");
                comboBox4.Items.Add("Dr.M.N.Wijesundara");
            }

            if (comboBox3.Text == "Computing")
            {
                comboBox4.Items.Add("Dr.G.N.Kodagoda");
                comboBox4.Items.Add("Mr.H.S.Jayasena");
                comboBox4.Items.Add("Prof.H.S.C.Perera");
                comboBox4.Items.Add("Dr.A.P.N.Somarathna");
                comboBox4.Items.Add("Prof.S.E.Piris");
                comboBox4.Items.Add("Prof.R.A.Aththalage");
                comboBox4.Items.Add("Dr.M.N.Wijesundara");
                comboBox4.Items.Add("Prof.S.E.Piris");
                comboBox4.Items.Add("Dr.A.L.G.Senevirathna");
                comboBox4.Items.Add("Dr.R.S.Perera");
            }

            if (comboBox3.Text == "Business Management")
            {
                comboBox4.Items.Add("Dr.G.Tharmarajah");
                comboBox4.Items.Add("Dr.J.Lanel");
                comboBox4.Items.Add("Prof.K.N.Pulasinghe");
                comboBox4.Items.Add("Dr.A.P.N.Somarathne");
                comboBox4.Items.Add("Prof.L.A.S.R.Perera");
                comboBox4.Items.Add("Prof.L.A.S.R.Piris");
                comboBox4.Items.Add("Prof.M.P.Marasinghe");
                comboBox4.Items.Add("Dr.T.S.K.Rathnayaka");
                comboBox4.Items.Add("Dr.G.B.Ruupasinghe");
                comboBox4.Items.Add("Dr.R.P.Thilakumara");
            }






            /*sqlconn.Open();
            SqlCommand cmd3 = new SqlCommand("select * from Lec_workingD where faculty = '" + comboBox3 + "' ", sqlcon);
            SqlDataAdapter sd1 = new SqlDataAdapter(cmd3);
            DataTable dt = new DataTable();
            sd1.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close(); */



        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (IsValidBatchWD())
            {


                //Add batch data to database
                sqlconn.Open();
                SqlCommand cmd1 = sqlconn.CreateCommand();
                cmd1.CommandText = "insert into batchWorkingD(batch, workingDays, workingHours, workingMinutes, timeSlot) values ('" + comboBox7.Text + "', '" + getBatchWD() + "', '" + numericUpDown7.Text + "', '" + numericUpDown8.Text + "', '" + comboBox8.Text + "')";
                cmd1.ExecuteNonQuery();
                sqlconn.Close();

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

        }


        private string getBatchWD()
        {
            StringBuilder batchresult = new StringBuilder();
            if (checkBox15.Checked)
                batchresult.AppendFormat("{0},", checkBox15.Text);
            if (checkBox16.Checked)
                batchresult.AppendFormat("{0},", checkBox16.Text);
            if (checkBox17.Checked)
                batchresult.AppendFormat("{0},", checkBox17.Text);
            if (checkBox18.Checked)
                batchresult.AppendFormat("{0},", checkBox18.Text);
            if (checkBox19.Checked)
                batchresult.AppendFormat("{0},", checkBox19.Text);
            if (checkBox20.Checked)
                batchresult.AppendFormat("{0},", checkBox20.Text);
            if (checkBox21.Checked)
                batchresult.AppendFormat("{0},", checkBox21.Text);
            if (batchresult.Length > 0) batchresult.Length--;
            return batchresult.ToString();
        }


        private bool IsValidBatchWD()
        {
            if (comboBox7.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Batch", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox8.Text == String.Empty)
            {
                MessageBox.Show("Please Enter time slot", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numericUpDown7.Text == String.Empty)
            {
                MessageBox.Show("Please Enter working hours", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }


        void batchGridFill()
        {
            sqlconn.Open();
            SqlDataAdapter sdp = new SqlDataAdapter("BatchViewAll", sqlconn);
            sdp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtb = new DataTable();
            sdp.Fill(dtb);
            dataGridView2.DataSource = dtb;
            dataGridView2.Columns[0].Visible = false;
            sqlconn.Close();

        }


        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void sprint1_Load(object sender, EventArgs e)
        {
            //Clear data inserted to the spaces
            ClearLecWD();

            //Disable delete button(faculty) when there is no record to delete
            button8.Enabled = false;

            //Disable delete button(manage session) when there is no record to delete
            button17.Enabled = false;

            //Disable delete button(batch) when there is no record to delete
            button11.Enabled = false;

            //Clear data inserted to the spaces in update page
            comboBox5.Text = comboBox6.Text = numericUpDown4.Text = numericUpDown5.Text = numericUpDown6.Text = "";
            lecId = 0;

            //Clear data inserted to the spaces in batch page
            comboBox7.Text = comboBox8.Text = numericUpDown7.Text = numericUpDown8.Text = "";
            batchId = 0;



            GridFill();
            batchGridFill();
            GridFillSessionDT();

            


            //      sqlconn.Open();
            //    sdp = new SqlDataAdapter("select * from Lec_workingD", sqlconn);
            //  dtb = new DataTable();
            //sdp.Fill(dtb);
            //dataGridView1.DataSource = dtb;
            //sqlconn.Close();




        }




        void ClearLecWD()
        {
            comboBox1.Text = comboBox2.Text = numericUpDown1.Text = numericUpDown2.Text = numericUpDown3.Text = "";
            lecId = 0;

            //Disable delete button when there is no record to delete
            button8.Enabled = false;

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
                    diplaychechValue();
                
                    lecId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                   /* SqlDataReader sqlDataReader;
                    SqlCommand sqlCommand = new SqlCommand("Select workingdays from Lec_workingD", sqlconn);
                    sqlconn.Open();
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        String workingd = sqlDataReader.GetString(7);


                    }*/

                    //Enable delete button when there are records to delete
                    button8.Enabled = Enabled;
                }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {



                sqlconn.Open();
                SqlCommand sqlCommand = new SqlCommand("UpdateLecWD", sqlconn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@lid", lecId);
                sqlCommand.Parameters.AddWithValue("@lfaculty", comboBox5.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@lLecname", comboBox6.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@noDay", numericUpDown4.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@workingd", updLecWD());
                sqlCommand.Parameters.AddWithValue("@workingh", numericUpDown5.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@workingm", numericUpDown6.Text.Trim());
                sqlCommand.ExecuteNonQuery();
                sqlconn.Close();

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



        private string updLecWD()
        {
            StringBuilder resultchk = new StringBuilder();
            if (checkBox8.Checked)
                resultchk.AppendFormat("{0},", checkBox8.Text);
            if (checkBox9.Checked)
                resultchk.AppendFormat("{0},", checkBox9.Text);
            if (checkBox10.Checked)
                resultchk.AppendFormat("{0},", checkBox10.Text);
            if (checkBox11.Checked)
                resultchk.AppendFormat("{0},", checkBox11.Text);
            if (checkBox12.Checked)
                resultchk.AppendFormat("{0},", checkBox12.Text);
            if (checkBox13.Checked)
                resultchk.AppendFormat("{0},", checkBox13.Text);
            if (checkBox14.Checked)
                resultchk.AppendFormat("{0},", checkBox14.Text);
            if (resultchk.Length > 0) resultchk.Length--;
            return resultchk.ToString();
        }


        private void button8_Click(object sender, EventArgs e)
        {



                sqlconn.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteLecWD", sqlconn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@lid", lecId);
                sqlCommand.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show("Data Deleted Successfully.");

                //Clear enetered data of all the combo boxes and numericUpDown
                comboBox5.Text = comboBox6.Text = numericUpDown4.Text = numericUpDown5.Text = numericUpDown6.Text = "";
                lecId = 0;
                //Disable delete button when there is no record to delete
                button8.Enabled = false;

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
                comboBox6.Items.Add("Dr.S.C.S.Karunarathne");
                comboBox6.Items.Add("Prof.A.T.Suraweera");
                comboBox6.Items.Add("Prof.H.S.Thilakasiri");
                comboBox6.Items.Add("Prof.R.A.Aththalage");
                comboBox6.Items.Add("Dr.M.N.Wijesundara");
            }

            if (comboBox5.Text == "Computing")
            {
                comboBox6.Items.Add("Dr.G.N.Kodagoda");
                comboBox6.Items.Add("Mr.H.S.Jayasena");
                comboBox6.Items.Add("Prof.H.S.C.Perera");
                comboBox6.Items.Add("Dr.A.P.N.Somarathna");
                comboBox6.Items.Add("Prof.S.E.Piris");
                comboBox6.Items.Add("Prof.R.A.Aththalage");
                comboBox6.Items.Add("Dr.M.N.Wijesundara");
                comboBox6.Items.Add("Prof.S.E.Piris");
                comboBox6.Items.Add("Dr.A.L.G.Senevirathna");
                comboBox6.Items.Add("Dr.R.S.Perera");
            }

            if (comboBox5.Text == "Business Management")
            {
                comboBox6.Items.Add("Dr.G.Tharmarajah");
                comboBox6.Items.Add("Dr.J.Lanel");
                comboBox6.Items.Add("Prof.K.N.Pulasinghe");
                comboBox6.Items.Add("Dr.A.P.N.Somarathne");
                comboBox6.Items.Add("Prof.L.A.S.R.Perera");
                comboBox6.Items.Add("Prof.L.A.S.R.Piris");
                comboBox6.Items.Add("Prof.M.P.Marasinghe");
                comboBox6.Items.Add("Dr.T.S.K.Rathnayaka");
                comboBox6.Items.Add("Dr.G.B.Ruupasinghe");
                comboBox6.Items.Add("Dr.R.P.Thilakumara");
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
            
            if(comboBox7.SelectedItem != null && comboBox8.SelectedItem != null)
            {

                sqlconn.Open();
                SqlCommand sqlCommand = new SqlCommand("UpdateBatchWD", sqlconn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@b_id", batchId);
                sqlCommand.Parameters.AddWithValue("@bbatch", comboBox7.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@bworkingd", updBatchWD());
                sqlCommand.Parameters.AddWithValue("@bworkingh", numericUpDown7.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@bworkingm", numericUpDown8.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@timesl", comboBox8.Text.Trim());
                sqlCommand.ExecuteNonQuery();
                sqlconn.Close();

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
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
            

        }



        private string updBatchWD()
        {
            StringBuilder batchresultupd = new StringBuilder();
            if (checkBox15.Checked)
                batchresultupd.AppendFormat("{0},", checkBox15.Text);
            if (checkBox16.Checked)
                batchresultupd.AppendFormat("{0},", checkBox16.Text);
            if (checkBox17.Checked)
                batchresultupd.AppendFormat("{0},", checkBox17.Text);
            if (checkBox18.Checked)
                batchresultupd.AppendFormat("{0},", checkBox18.Text);
            if (checkBox19.Checked)
                batchresultupd.AppendFormat("{0},", checkBox19.Text);
            if (checkBox20.Checked)
                batchresultupd.AppendFormat("{0},", checkBox20.Text);
            if (checkBox21.Checked)
                batchresultupd.AppendFormat("{0},", checkBox21.Text);
            if (batchresultupd.Length > 0) batchresultupd.Length--;
            return batchresultupd.ToString();
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

                //Enable delete button when there are records to delete
                button11.Enabled = Enabled;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            if(comboBox7.SelectedItem != null && comboBox8.SelectedItem != null)
            {

                sqlconn.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteBatchWD", sqlconn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@b_id", batchId);
                sqlCommand.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show("Data Deleted Successfully.");

                //Clear all data in spaces after saving the data
                comboBox7.Text = comboBox8.Text = numericUpDown7.Text = numericUpDown8.Text = "";
                batchId = 0;

                //Disable delete button when there is no record to delete
                button11.Enabled = false;

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
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
            

        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            sqlconn.Open();
            SqlCommand cmd3 = new SqlCommand("select * from Lec_workingD where faculty = '" + comboBox3.Text + "' ", sqlconn);
            SqlDataAdapter sd1 = new SqlDataAdapter(cmd3);
            DataTable dt = new DataTable();
            sd1.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close(); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            /*comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["faculty"].Value.ToString();
            comboBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["lecturerName"].Value.ToString();*/
        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            sqlconn.Open();
            SqlCommand cmd4 = new SqlCommand("select * from Lec_workingD where lecturerName = '" + comboBox4.Text + "' ", sqlconn);
            SqlDataAdapter sd2 = new SqlDataAdapter(cmd4);
            DataTable dt123 = new DataTable();
            sd2.Fill(dt123);
            dataGridView1.DataSource = dt123;
            sqlconn.Close();
        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip7.Show("Select a faculty name", comboBox1);
        }

        private void comboBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip8.Show("Select a lecturer name", comboBox2);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Clear the data provided to spaces", button3);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("View inserted data", button2);
        }

        private void comboBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Search from faculty name", comboBox3);
        }

        private void comboBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Search from lecturer name", comboBox4);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Go for update or delete", button4);
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            toolTip6.Show("Clear the data provided to spaces", button12);
        }

        private void comboBox7_MouseHover(object sender, EventArgs e)
        {
            toolTip9.Show("Select a batch", comboBox7);
        }

        private void comboBox8_MouseHover(object sender, EventArgs e)
        {
            toolTip10.Show("Select a time slot", comboBox8);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {

            //Disable delete button when there is no record to delete
            button17.Enabled = false;

            //Clear all data in spaces
            comboBox9.Text = comboBox10.Text = comboBox11.Text = comboBox12.Text = "";

        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (IsValidSessionDT())
            {


                //Add data to database
                sqlconn.Open();
                //SqlCommand cmd = sqlcon.CreateCommand();
                //cmd.CommandText = "insert into Lec_WorkingD(faculty, lecturerName, noOfDays, workingdays, workinghours, workingminutes) values ('" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + numericUpDown1.Text + "', '" + s + "', '" + numericUpDown2.Text + "', '" + numericUpDown3.Text + "')";
                SqlCommand cmds = new SqlCommand("insert into ManageSessionDT(dtSession, dtDay, dtTimeFrom, dtTimeTo) values ('" + comboBox9.Text + "', '" + comboBox10.Text + "', '" + comboBox11.Text + "', '" + comboBox12.Text + "')", sqlconn);
                cmds.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show("Saved Successfully");

                GridFillSessionDT();

            }

        }



        private bool IsValidSessionDT()
        {
            if (comboBox9.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Session", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox10.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Day", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox11.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Time From", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox12.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Time To", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }


        void GridFillSessionDT()
        {
            sqlconn.Open();
            SqlDataAdapter sdpadapter = new SqlDataAdapter("ViewSessionDT", sqlconn);
            sdpadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable datatablesession = new DataTable();
            sdpadapter.Fill(datatablesession);
            dataGridView3.DataSource = datatablesession;
            dataGridView3.Columns[0].Visible = false;
            sqlconn.Close();

        }

        private void button16_Click(object sender, EventArgs e)
        {

            sqlconn.Open();
            SqlCommand sqlCommand1 = new SqlCommand("UpdateSessionDT", sqlconn);
            sqlCommand1.CommandType = CommandType.StoredProcedure;
            sqlCommand1.Parameters.AddWithValue("@dtId", sessiondt_id);
            sqlCommand1.Parameters.AddWithValue("@dt_session", comboBox9.Text.Trim());
            sqlCommand1.Parameters.AddWithValue("@dt_day", comboBox10.Text.Trim());
            sqlCommand1.Parameters.AddWithValue("@dt_timeFrom", comboBox11.Text.Trim());
            sqlCommand1.Parameters.AddWithValue("@dt_timeTo", comboBox12.Text.Trim());
            sqlCommand1.ExecuteNonQuery();
            sqlconn.Close();

            MessageBox.Show("Data Updated Successfully.");

            GridFillSessionDT();

        }

        private void button17_Click(object sender, EventArgs e)
        {

            sqlconn.Open();
            SqlCommand sqlCommand2 = new SqlCommand("DeleteSessionDT", sqlconn);
            sqlCommand2.CommandType = CommandType.StoredProcedure;
            sqlCommand2.Parameters.AddWithValue("@dtId", sessiondt_id);
            sqlCommand2.ExecuteNonQuery();
            sqlconn.Close();

            MessageBox.Show("Data Deleted Successfully.");

            GridFillSessionDT();

        }

        private void comboBox13_TextChanged(object sender, EventArgs e)
        {

            sqlconn.Open();
            SqlCommand cmdmsdt = new SqlCommand("select * from ManageSessionDT where dtSession = '" + comboBox13.Text + "' ", sqlconn);
            SqlDataAdapter sdmsdt = new SqlDataAdapter(cmdmsdt);
            DataTable dtmsdt = new DataTable();
            sdmsdt.Fill(dtmsdt);
            dataGridView3.DataSource = dtmsdt;
            sqlconn.Close();

        }

        private void comboBox9_MouseHover(object sender, EventArgs e)
        {
            toolTip11.Show("Select Session", comboBox9);
        }

        private void comboBox10_MouseHover(object sender, EventArgs e)
        {
            toolTip12.Show("Select Day", comboBox10);
        }

        private void comboBox11_MouseHover(object sender, EventArgs e)
        {
            toolTip13.Show("Select Time From", comboBox11);
        }

        private void comboBox12_MouseHover(object sender, EventArgs e)
        {
            toolTip14.Show("Select Time To", comboBox12);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.CurrentRow.Selected = true;
        }

        private void dataGridView3_DoubleClick_1(object sender, EventArgs e)
        {

            if (dataGridView3.CurrentRow.Index != -1)
            {
                comboBox9.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                comboBox10.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                comboBox11.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
                comboBox12.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
                sessiondt_id = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value.ToString());

                button17.Enabled = Enabled;

            }

            

        }


        //========================================== check box disply ==============================================

        public bool diplaychechValue() {


            sqlconn.Open();
            SqlCommand cmdmsdt = new SqlCommand("select workingdays from Lec_workingD", sqlconn);
            if ( " [dbo].[Lec_workingD].[workingdays] " == "Monday" )  {

                return checkBox8.Checked;
            }
            if (" [dbo].[Lec_workingD].[workingdays] " == "Tuseday")
            {

                return checkBox9.Checked;
            }
            if (" [dbo].[Lec_workingD].[workingdays] " == "Wednesday")
            {

                return checkBox10.Checked;
            }
            if (" [dbo].[Lec_workingD].[workingdays] " == "Thursday")
            {

                return checkBox11.Checked;
            }
            if (" [dbo].[Lec_workingD].[workingdays] " == "Friday")
            {

                return checkBox12.Checked;
            }
            if (" [dbo].[Lec_workingD].[workingdays] " == "Saturday")
            {

                return checkBox13.Checked;
            }
            if (" [dbo].[Lec_workingD].[workingdays] " == "Sunday")
            {

                return checkBox14.Checked;
            }

            sqlconn.Close();

            return false;
        }
        

    }
}

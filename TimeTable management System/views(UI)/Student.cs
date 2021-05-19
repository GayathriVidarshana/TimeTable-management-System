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


    public partial class Student : Form
    {
//DATABASE CONNECTION ===================================================================================================
       // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-V7M4G0I\SQLEXPRESS;Initial Catalog=TTMS;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Desktop\ITPM TTMS\TimeTable management System\TimeTable management System\database\TimeTableDB.mdf;Integrated Security=True");
        public int Id;
        public Student()
        {
            InitializeComponent();
            Display_Data();
            


        }




//CREATE GROUP ID ===========================================================================================================

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = ""+textBox1.Text + "." +comboBox5.Text + ".G." +grp_no.Value ;

        }
//CREATE STUDENT GROUP (DATA INSERT PART) ====================================================================================
        private void button3_Click(object sender, EventArgs e)
        {
            if (IsValiad())
            {
                conn.Open();

                try
                {
                    
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO [Student_D] ( Faculty, Acc_yrSem, Program, grpNo, SubgrpNo, grpId, subgrpID) VALUES ('" + comboBox4.Text + "','" + comboBox5.Text + "', '" + textBox1.Text + "', '" + grp_no.Value + "', '" + sub_grp_no.Value + "', '" + textBox3.Text + "', '" + textBox2.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Student Group Is Successfully Created");
                    clear_fields();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                conn.Close();
                Display_Data();
                clear_fields();

            }


        }
//VALIDATE FIELLDS ===========================================================================================================
        private bool IsValiad()

        {
            if (comboBox4.Text == string.Empty)
            {

                MessageBox.Show("Faculty can not be Empty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            } else if (comboBox5.Text == string.Empty) {

                MessageBox.Show("Acadamic Year And Semester can not be Empty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (textBox1.Text == string.Empty) {

                MessageBox.Show("Program can not be Empty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            } else if (grp_no.Value == 0) {

                MessageBox.Show("Group Number can not be Zero(0)", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;


            } else if (sub_grp_no.Value == 0) {
                MessageBox.Show("Sub Group Number can not be Zero(0)", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            } else if (textBox3.Text == string.Empty) {
                MessageBox.Show("Group ID can not be Empty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if( textBox2.Text == string.Empty)
            {

                MessageBox.Show("Sub Group ID can not be Empty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;

        }
//CLEAR FIELDS ================================================================================================================
        public void clear_fields() {

            comboBox4.Text = "";
            comboBox5.Text = "";
            textBox1.Text = "";
            grp_no.Value = 0;
            sub_grp_no.Value = 0;
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox9.Text = "";
            textBox4.Text = "";
            comboBox11.Text = "";
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            textBox5.Text = "";
            textBox6.Text = "";
        }
//CLEAR BUTTON ===============================================================================================================
        private void button4_Click(object sender, EventArgs e)
        {
            clear_fields();
        }
        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            fill_combo();

        }
//FILL COMBOBOX =============================================================================================================
        public void fill_combo() {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Desktop\ITPM TTMS\TimeTable management System\TimeTable management System\database\TimeTableDB.mdf;Integrated Security=True");
            conn.Open();
            try
            {
               
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT program FROM [Student_D]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter Dadap = new SqlDataAdapter(cmd);
                Dadap.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                   
                    comboBox2.Items.Add(dr["program"].ToString());
                    comboBox7.Items.Add(dr["program"].ToString());
                    comboBox11.Items.Add(dr["program"].ToString());





                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           conn.Close();

        }
// CREATE GROUP ID (AUTO CREATED GROUPID) ===================================================================================
        public string Generate_grpID(string grpId)
        {
            string grpID = this.grp_no.Value.ToString();
            string grpidA = " " + textBox1.Text + " . " + comboBox5.Text + ".G " + this.grp_no.Value.ToString();
            return grpidA;
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            comboBox9.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox4.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            comboBox11.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            numericUpDown3.Value= Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[4].Value.ToString());
            numericUpDown4.Value = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[5].Value.ToString());
            textBox5.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            textBox6.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
        }

//FUNCTION OF DISPLAY DATA IN TABLE =======================================================================================================
        public void Display_Data() {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Student_D]";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView1.DataSource = Dtable;
            dataGridView2.DataSource = Dtable;
            
            conn.Close();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            fill_combo();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Display_Data();
            dataGridView2.CurrentRow.Selected = true;
            comboBox6.Text = dataGridView2.Rows[e.RowIndex].Cells["Faculty"].Value.ToString();
            comboBox7.Text = dataGridView2.Rows[e.RowIndex].Cells["program"].Value.ToString();
            comboBox8.Text = dataGridView2.Rows[e.RowIndex].Cells["Acc_yrSem"].Value.ToString();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            fill_combo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fill_combo();
            dataGridView1.CurrentRow.Selected = true;
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Faculty"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["program"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Acc_yrSem"].Value.ToString();

        }
//DELETE SELECTED ROW FROM TABLE (DELETE) ====================================================================================
        private void button9_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (Id > 0)
            {
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM [Student_D] WHERE Id = '" + this.Id + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Tag Is Successfully Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Try again");

                }
            }
            else
            {

                MessageBox.Show("Please select an Tag to DELETE", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            conn.Close();
            Display_Data();
            clear_fields();
        }


 //UPDATE SELECTED DATA ======================================================================================================
        private void button6_Click(object sender, EventArgs e)
        {

            conn.Open();
            if (Id > 0)
            {
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = " UPDATE [Student_D] SET  Faculty = '" + comboBox9.Text + "', program = '" + textBox4.Text + "', Acc_yrSem = '" + comboBox11.Text + "',  grpNo = '" + numericUpDown3.Value + "',  SubgrpNo = '" + numericUpDown4.Value + "',  grpId = '" + textBox4.Text + "', subgrpID = '" + textBox4.Text + "' WHERE Id = '" + this.Id + "'";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("The Tag Is Successfully Updated");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Try again");
                }
            }
            else
            {

                MessageBox.Show("Please select an Tag to UPDATE", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            conn.Close();
            clear_fields();
            Display_Data();
        }
//CLEAR BUTTON ================================================================================================================
        private void button7_Click(object sender, EventArgs e)
        {
            clear_fields();
        }
//DISPLAY DATA USING SLECTED VALUE (COMBO BOX) ==============================================================================
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Student_D] WHERE Faculty = '"+comboBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView1.DataSource = Dtable;
            conn.Close();

        }
//DISPLAY DATA USING SLECTED VALUE (COMBO BOX PROGRAM) =====================================================================
        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Student_D] WHERE program = '" + comboBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView1.DataSource = Dtable;
            conn.Close();
        }
//DISPLAY DATA USING SLECTED VALUE (COMBO BOX ACC-YEAR) =====================================================================
        private void comboBox3_TextChange(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Student_D] WHERE Acc_yrSem = '" + comboBox3.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView1.DataSource = Dtable;
            conn.Close();
        }
 //DISPLAY DATA USING SLECTED VALUE (COMBO BOX FACULTY) =====================================================================
        private void comboBox6_TextChange(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Student_D] WHERE Faculty = '" + comboBox6.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView2.DataSource = Dtable;
            conn.Close();
        }
//DISPLAY DATA USING SLECTED VALUE (COMBO BOX FACULTY) =====================================================================
        private void comboBox7_TextChange(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Student_D] WHERE program = '" + comboBox7.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView2.DataSource = Dtable;
            conn.Close();
        }
//DISPLAY DATA USING SLECTED VALUE (COMBO BOX ACC-YER) =====================================================================
        private void comboBox8_TextChange(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Student_D] WHERE Acc_yrSem = '" + comboBox8.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView2.DataSource = Dtable;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          panel4.Show();

        }

//CREATE SUB GROUP ID ========================================================================================================
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = "" + textBox1.Text + "." + comboBox5.Text + ".G." + grp_no.Value;
            textBox2.Text = "" + textBox1.Text + "." + comboBox5.Text + ".G." + grp_no.Value + "." +sub_grp_no.Value;
        }
//CREATE GROUP ID ========================================================================================================
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            textBox5.Text = "" + textBox4.Text + "." + comboBox11.Text + ".G." + numericUpDown3.Value;
            textBox6.Text = "" + textBox4.Text + "." + comboBox11.Text + ".G." + numericUpDown3.Value + "." + numericUpDown4.Value;
        }
//CREATE SUB GROUP ID ========================================================================================================
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            textBox5.Text = "" + textBox4.Text + "." + comboBox11.Text + ".G." + numericUpDown3.Value;
            textBox6.Text = "" + textBox4.Text + "." + comboBox11.Text + ".G." + numericUpDown3.Value + "." + numericUpDown4.Value;
        }

        private void comboBox9_TextChange(object sender, EventArgs e)
        {
            textBox5.Text = "" + textBox4.Text + "." + comboBox11.Text + ".G." + numericUpDown3.Value;
            textBox6.Text = "" + textBox4.Text + "." + comboBox11.Text + ".G." + numericUpDown3.Value + "." + numericUpDown4.Value;
        }

        private void textBox4_TextChange(object sender, EventArgs e)
        {
            textBox5.Text = "" + textBox4.Text + "." + comboBox11.Text + ".G." + numericUpDown3.Value;
            textBox6.Text = "" + textBox4.Text + "." + comboBox11.Text + ".G." + numericUpDown3.Value + "." + numericUpDown4.Value;
        }

        private void comboBox11_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "" + textBox4.Text + "." + comboBox11.Text + ".G." + numericUpDown3.Value;
            textBox6.Text = "" + textBox4.Text + "." + comboBox11.Text + ".G." + numericUpDown3.Value + "." + numericUpDown4.Value;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text = "" + textBox4.Text + "." + comboBox11.Text + ".G." + numericUpDown3.Value;
            textBox6.Text = "" + textBox4.Text + "." + comboBox11.Text + ".G." + numericUpDown3.Value + "." + numericUpDown4.Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "" + textBox1.Text + "." + comboBox5.Text + ".G." + grp_no.Value;
            textBox2.Text = "" + textBox1.Text + "." + comboBox5.Text + ".G." + grp_no.Value + "." + sub_grp_no.Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1) {

                
                comboBox9.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox11.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                numericUpDown3.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                numericUpDown4.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                Id = Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            } else {

                MessageBox.Show("Plese Select a row");
            }
        }

       
    }
}

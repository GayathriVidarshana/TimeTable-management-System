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

namespace TimeTable_management_System.views_UI_
{
    public partial class SessionC : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Desktop\ITPM TTMS\TimeTable management System\TimeTable management System\database\TimeTableDB.mdf;Integrated Security=True");
        public int Id;
        public int pId;
        public string session01;
        public string session02;
        public string Session;

        public SessionC()
        {
            InitializeComponent();
            displayData();
            displayParalellSession();
            fillCombobox_con_session();
            fillCombobox_para_session();

            //Session() display session data from database
            // FillComboSession(); // fill combo box using session table
        }
        //======================================== CONSECUTIVE SESSION PANEL ===================================================================
        private void button1_Click_1(object sender, EventArgs e)
        {
            //CREATE CONSECUTIVE SESSION ===============================================================================
            if (IsValid())
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO [Cons_session_Table] VALUES ('" + comboBox3.Text + "', '" + comboBox4.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consecutive Session successfully Created ");
                    clearFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again....");
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                displayData();
                clearFields();

            }
        }

        //CHECK FIELDS ARE NOT NULL ====================================================================================================
        private bool IsValid()
        {

            if (comboBox3.Text == string.Empty || comboBox4.Text == string.Empty)
            {

                MessageBox.Show(" Session 01 and Session 02 should select", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }
        //CLEAR FIELDS==================================================================================================================

        public void clearFields()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";
            comboBox11.Text = "";
            comboBox12.Text = "";
            comboBox13.Text = "";
            comboBox19.Text = "";
            comboBox20.Text = "";
            comboBox21.Text = "";
            comboBox14.Text = "";
            comboBox15.Text = "";
            comboBox16.Text = "";
            comboBox17.Text = "";
            comboBox18.Text = "";
            comboBox22.Text = "";
            comboBox23.Text = "";
            comboBox24.Text = "";
        }


        // DISPALY TABLE DATA (DATAGRIDVIEW 02)=========================================================================================
        public void displayData()
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Cons_session_Table]";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView2.DataSource = Dtable;

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        //CLEAR COMBO BOX AND DISPLAY TABLE DATA =========================================================================================
        private void button11_Click(object sender, EventArgs e)
        {
            clearFields();
            displayData();
        }
        // NAVIGATE TO CREATE PAGE USING EDIT BUTTON=====================================================================================
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                Id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                comboBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                comboBox4.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();



                tabControl2.Controls.Clear();
                tabControl2.Controls.Add(tabPage4);
                tabControl2.Controls.Add(tabPage5);
                tabPage4.Show();
                tabPage5.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //PASS SELECTED VALUE TO EDIT ==================================================================================================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            comboBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            comboBox4.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
        }
        //DELETE CONSECUTIVE SESSION (DELETE BUTTON) ===================================================================================
        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                Id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM [Cons_session_Table] WHERE Id = '" + this.Id + "' ";

                cmd.ExecuteNonQuery();
                MessageBox.Show("The Session Is Successfully Deleted");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Try again");
            }

            conn.Close();
            displayData();
        }
        //UPDATE BUTTON VALIDATION =====================================================================================================
        private bool selectedDta()
        {

            if (comboBox3.Text == string.Empty || comboBox4.Text == string.Empty)
            {

                MessageBox.Show("Before click update button select a relevent data from counsecutive table and fields can not to be empty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        //UPDATE SESSION DATA (UPDATE BUTTON) ==========================================================================================
        private void button12_Click(object sender, EventArgs e)
        {
            if (selectedDta())
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE [Cons_session_Table] SET  Session_01 = '" + comboBox3.Text + "', Session_02 = '" + comboBox4.Text + "' WHERE Id = '" + this.Id + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consecutive Session successfully Updated");
                    clearFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again....");
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                displayData();

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            comboBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            comboBox4.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
        }
        // ============================================== PARALELL SESSION PART ========================================================

        //CREATE PARALELL SESSION ======================================================================================================
        private void button6_Click(object sender, EventArgs e)
        {

            if (isPSvalid())
            {
                conn.Open();

                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO [Session_para] (Session_01, Session_02, day , E_time, S_time, duration)VALUES ('" + comboBox7.Text + "', '" + comboBox9.Text + "', '" + comboBox6.Text + "', '" + comboBox20.Text + "', '" + comboBox19.Text + "', '" + comboBox21.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paralell Session successfully Created ");
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again");
                    MessageBox.Show(ex.Message);
                }

                conn.Close();
                displayParalellSession();
                clearFields();
            }



        }
        //VALIDATE PARALELL FIELDS =====================================================================================================
        private bool isPSvalid()
        {
            if (comboBox7.Text == string.Empty && comboBox9.Text == string.Empty && comboBox6.Text == string.Empty && comboBox19.Text == string.Empty && comboBox20.Text == string.Empty && comboBox21.Text == string.Empty)
            {

                MessageBox.Show("fields con not be empty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        //DISPALY PARALLEL SESSION DATA IN DATA GRID VIEW 4 =============================================================================
        public void displayParalellSession()
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Session_para]";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView4.DataSource = Dtable;

            conn.Close();
        }
        //DELETE PARALELL SESSION (DELETE BUTTON) ======================================================================================
        private void button8_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                pId = Convert.ToInt32(dataGridView4.SelectedRows[0].Cells[0].Value);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM [Session_para] WHERE Id = '" + this.pId + "' ";

                cmd.ExecuteNonQuery();
                MessageBox.Show("The Paralell Session Is Successfully Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Try again");
            }

            conn.Close();
            displayParalellSession();
        }

        //NAVIGATE TO CREATE PARALELL SESSION PAGE ==============================================================================
        private void button7_Click(object sender, EventArgs e)
        {

            try
            {

                Id = Convert.ToInt32(dataGridView4.SelectedRows[0].Cells[0].Value);
                comboBox7.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
                comboBox9.Text = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();
                comboBox19.Text = dataGridView4.SelectedRows[0].Cells[3].Value.ToString();
                comboBox20.Text = dataGridView4.SelectedRows[0].Cells[4].Value.ToString();
                comboBox21.Text = dataGridView4.SelectedRows[0].Cells[5].Value.ToString();
                comboBox6.Text = dataGridView4.SelectedRows[0].Cells[6].Value.ToString();



                tabControl3.Controls.Clear();
                tabControl3.Controls.Add(tabPage6);
                tabControl3.Controls.Add(tabPage7);
                tabPage6.Show();
                tabPage7.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //UPDATE PARALELL SESSION =====================================================================================================
        private void button13_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE [Session_para] SET  Session_01 ='" + comboBox7.Text + "', Session_02 ='" + comboBox9.Text + "', S_time ='" + comboBox19.Text + "', Etime ='" + comboBox20.Text + "', duration ='" + comboBox21.Text + "', day ='" + comboBox6.Text + "', WHERE Id = '" + this.Id + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Paralell Session successfully Updated");
                clearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again....");
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            displayParalellSession();
            clearFields();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        //===================================================== NON OVELAPPING PART ====================================================

        //CREATE NON OVERLAPPING SESSION ===============================================================================================
        private void button10_Click(object sender, EventArgs e)
        {

            if (isOSvalid())
            {
                conn.Open();

                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO [NonOverlappingSession] (Session_01, Session_02, S_time, E_time, Duration, Day )VALUES ('" + comboBox15.Text + "', '" + comboBox16.Text + "', '" + comboBox17.Text + "', '" + comboBox22.Text + "', '" + comboBox23.Text + "', '" + comboBox24.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Non Overlapping Session successfully Created ");
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again");
                    MessageBox.Show(ex.Message);
                }

                conn.Close();
                clearFields();



            }
        }
        //VALIDATE NON OVERLAPPING SESSION ============================================================================================
        public bool isOSvalid() {

            if (comboBox15.Text == string.Empty && comboBox16.Text == string.Empty && comboBox17.Text == string.Empty && comboBox22.Text == string.Empty && comboBox23.Text == string.Empty && comboBox24.Text == string.Empty)
            {

                MessageBox.Show("fields con not be empty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        //fill combo box grpid and subject id
        private void tabPage4_Click(object sender, EventArgs e)
        {
            //FillComboSession();

        }

        //fill combo box grpid and subject id
        private void tabPage6_Click(object sender, EventArgs e)
        {
            //FillComboSession();
        }

        //fill combo box grpid and subject id
        private void tabPage3_Click(object sender, EventArgs e)
        {
            //FillComboSession();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        //=============================================================================================================================================================================================

        //DISPLAY DATA FROM USING COMBO BOX 01, (SUBJECT CODE) =========================================================================================================================================
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [SESSION] WHERE SUBJECT_CODE = '" + comboBox1.Text + "' OR GROUP_ID = '" + comboBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView1.DataSource = Dtable;
            conn.Close();
        }
        //DISPLAY DATA FROM USING COMBO BOX 01, (GROUP ID) =========================================================================================================================================
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [SESSION] WHERE SUBJECT_CODE = '" + comboBox1.Text + "' OR GROUP_ID = '" + comboBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView1.DataSource = Dtable;
            conn.Close();
        }
        //DISPLAY DATA FROM USING COMBO BOX 01, (GROUP ID) =========================================================================================================================================

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [SESSION] WHERE SUBJECT_CODE = '" + comboBox8.Text + "' OR GROUP_ID = '" + comboBox5.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView1.DataSource = Dtable;
            conn.Close();
        }
        //DISPLAY DATA FROM USING COMBO BOX 01, (GROUP ID) =========================================================================================================================================

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [SESSION] WHERE SUBJECT_CODE = '" + comboBox8.Text + "' OR GROUP_ID = '"+comboBox5.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView1.DataSource = Dtable;
            conn.Close();
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [SESSION] WHERE SUBJECT_CODE = '" + comboBox18.Text + "' OR GROUP_ID = '" + comboBox14.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView1.DataSource = Dtable;
            conn.Close();
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [SESSION] WHERE SUBJECT_CODE = '" + comboBox18.Text + "' OR GROUP_ID = '" + comboBox14.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView1.DataSource = Dtable;
            conn.Close();
        }


        //DISPLY DATA OF SESSIONS TABLE IN ALL UI
        //=====================================Conect with session table ==============================================================
        public void Sessiond()
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Session]";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView5.DataSource = Dtable;
            dataGridView1.DataSource = Dtable;
            dataGridView3.DataSource = Dtable;
            conn.Close();
        }
        // FILL COMBOBOX USING SESSION TABLE ==================================================================================

        public void FillComboSession() {

            conn.Open();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  subjectCode, groupId FROM [Session]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter Dadap = new SqlDataAdapter(cmd);
                Dadap.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["subjectCode"].ToString());
                    comboBox2.Items.Add(dr["groupId"].ToString());
                    comboBox8.Items.Add(dr["subjectCode"].ToString());
                    comboBox5.Items.Add(dr["groupId"].ToString());
                    comboBox18.Items.Add(dr["subjectCode"].ToString());
                    comboBox14.Items.Add(dr["groupId"].ToString());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();


        }


        //FILL COMBOBOX USING Con.Session table ===============================================================================
        public void fillCombobox_con_session() {

            conn.Open();

            if (comboBox10.SelectedItem == "Session_01")
            {
                comboBox11.Items.Clear();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  Session_01 FROM [Cons_session_Table]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter Dadap = new SqlDataAdapter(cmd);
                Dadap.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox11.Items.Add(dr["Session_01"].ToString());

                }
            }
            else if (comboBox10.SelectedItem == "Session_02")
            {
                comboBox11.Items.Clear();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  Session_02 FROM [Cons_session_Table]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter Dadap = new SqlDataAdapter(cmd);
                Dadap.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox11.Items.Add(dr["Session_02"].ToString());

                }

            }

            
            conn.Close();
        }    
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCombobox_con_session();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Cons_session_Table] WHERE Session_01 = '" + comboBox11.Text + "' OR Session_02 = '" + comboBox11.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView2.DataSource = Dtable;

            conn.Close();


        }



        //FILL COMBO BOX IN PARALELL SESSION MANAGEMENT USING TABLE ===================================================================
        public void fillCombobox_para_session()
        {

            conn.Open();

            if (comboBox13.SelectedItem == "Session_01")
            {
                comboBox12.Items.Clear();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  Session_01 FROM [Session_para]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter Dadap = new SqlDataAdapter(cmd);
                Dadap.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox12.Items.Add(dr["Session_01"].ToString());

                }
            }
            else if (comboBox13.SelectedItem == "Session_02")
            {
                comboBox12.Items.Clear();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  Session_02 FROM [Session_para]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter Dadap = new SqlDataAdapter(cmd);
                Dadap.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox12.Items.Add(dr["Session_02"].ToString());

                }

            }


            conn.Close();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Session_para] WHERE Session_01 = '" + comboBox12.Text + "' OR Session_02 = '" + comboBox12.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView4.DataSource = Dtable;

            conn.Close();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCombobox_para_session();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  * FROM [Session]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter Dadap = new SqlDataAdapter(cmd);
            Dadap.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox3.Items.Add(dr["Session_01"].ToString());

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  * FROM [Session]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter Dadap = new SqlDataAdapter(cmd);
            Dadap.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox4.Items.Add(dr["Session_02"].ToString());

            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox7.Items.Clear();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  * FROM [Session]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter Dadap = new SqlDataAdapter(cmd);
            Dadap.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox7.Items.Add(dr["Session_01"].ToString());

            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox9.Items.Clear();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  * FROM [Session]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter Dadap = new SqlDataAdapter(cmd);
            Dadap.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox9.Items.Add(dr["Session_02"].ToString());

            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox15.Items.Clear();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  * FROM [Session]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter Dadap = new SqlDataAdapter(cmd);
            Dadap.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox15.Items.Add(dr["Session_01"].ToString());

            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox16.Items.Clear();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  * FROM [Session]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter Dadap = new SqlDataAdapter(cmd);
            Dadap.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox16.Items.Add(dr["Session_02"].ToString());

            }
        }
    }


}



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
    public partial class rooms : Form
    {
        public rooms()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-UT64EL6;Initial Catalog=locations;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\TTMS\TimeTable-management-System\TimeTable management System\database\TTMSDB.mdf;Integrated Security=True");

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidMRoom())
            {
                try
                {
                    //insert data
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into rtag(Tag, Room) VALUES('" + comboBox1.Text + "','" + comboBox2.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Successfully");
                    //BindData();
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Unsuccesfull");
                }
            }
        }

        private bool IsValidMRoom()
        {
            //throw new NotImplementedException();

            if (comboBox1.Text == String.Empty)
            {
                MessageBox.Show("Please Fill All Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox2.Text == String.Empty)
            {
                MessageBox.Show("Please Fill All Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsValidMRoom1() {
            if (subjectcomboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Subject", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (tab2comboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Tag", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (room2comboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Room", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsValidMRoom2() {
            if (groupcomboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Group", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (subgroupcomboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Sub Group", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (room3comboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Room", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsValidMRoom3() {
            if (lecturercomboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Lecturer", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (room4comboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Room", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsValidMRoom4() {
            if (sessioncomboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Session", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (room5comboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Room", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else {
                return true;
            }
        }
        private bool IsValidMRoom5() {
            if (consecomboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Consecutive Session", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (room6comboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Room", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsValidMRoom6()
        {
            if (startcomboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Start Time", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (endcomboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select End Time", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (room7comboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Select Room", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "Lecture")
            {
                comboBox2.Items.Add("Main Auditorium");
                comboBox2.Items.Add("N3E");
                comboBox2.Items.Add("A506");
                comboBox2.Items.Add("507A");
                comboBox2.Items.Add("D3");
            }
            if (comboBox1.Text == "Lab")
            {
                comboBox2.Items.Add("13H");
                comboBox2.Items.Add("N3D");
                comboBox2.Items.Add("N3C");
                comboBox2.Items.Add("602");
                comboBox2.Items.Add("12H");
            }
            if (comboBox1.Text == "Tute")
            {
                comboBox2.Items.Add("E5");
                comboBox2.Items.Add("N3E");
                comboBox2.Items.Add("Mini Auditorium");
                comboBox2.Items.Add("E8");
                comboBox2.Items.Add("506A");
            }
            if (comboBox1.Text == "Game Development Practical")
            {
                comboBox2.Items.Add("IM Lab");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox2.Text = "";
            this.ActiveControl = comboBox1;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            subjectcomboBox.Text = tab2comboBox.Text = room2comboBox.Text = "";
            this.ActiveControl = tab2comboBox;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            room2comboBox.Items.Clear();
            if (tab2comboBox.Text == "Lecture")
            {
                room2comboBox.Items.Add("Main Auditorium");
                room2comboBox.Items.Add("N3E");
                room2comboBox.Items.Add("A506");
                room2comboBox.Items.Add("507A");
                room2comboBox.Items.Add("D3");
            }
            if (tab2comboBox.Text == "Lab")
            {
                room2comboBox.Items.Add("13H");
                room2comboBox.Items.Add("N3D");
                room2comboBox.Items.Add("N3C");
                room2comboBox.Items.Add("602");
                room2comboBox.Items.Add("12H");
                
            }
            if (tab2comboBox.Text == "Tute")
            {
                room2comboBox.Items.Add("E5");
                room2comboBox.Items.Add("N3E");
                room2comboBox.Items.Add("Mini Auditorium");
                room2comboBox.Items.Add("E8");
                room2comboBox.Items.Add("506A");
            }
            if (tab2comboBox.Text == "Game Development Practical")
            {
                room2comboBox.Items.Add("IM Lab");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsValidMRoom1())
            {
                try
                {
                    //insert data
                    con.Open();
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandText = "insert into rosubject (Subject, Tag, Room) values ('" + subjectcomboBox.Text + "', '" + tab2comboBox.Text + "', '" + room2comboBox.Text + "')";
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Successfully");
                    //BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Unsuccesfull");
                }
            }
        }

        private void groupcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subgroupcomboBox.Items.Clear();
            if (groupcomboBox.Text == "Y1S1 14")
            {
                subgroupcomboBox.Items.Add("Y1S1 14.1");
                subgroupcomboBox.Items.Add("Y1S1 14.2");
                subgroupcomboBox.Items.Add("Y1S1 14.3");
                subgroupcomboBox.Items.Add("Y1S1 14.4");
                subgroupcomboBox.Items.Add("Y1S1 14.5");
            }
            if (groupcomboBox.Text == "Y2S2 CSNE 1")
            {
                subgroupcomboBox.Items.Add("Y2S2 CSNE 1.1");
                subgroupcomboBox.Items.Add("Y2S2 CSNE 1.2");
                subgroupcomboBox.Items.Add("Y2S2 CSNE 1.3");
                subgroupcomboBox.Items.Add("Y2S2 CSNE 1.4");
                subgroupcomboBox.Items.Add("Y2S2 CSNE 1.5");
            }
            if (groupcomboBox.Text == "Y3S1 IT 3")
            {
                subgroupcomboBox.Items.Add("Y3S1 IT 3.1");
                subgroupcomboBox.Items.Add("Y3S1 IT 3.2");
                subgroupcomboBox.Items.Add("Y3S1 IT 3.3");
                subgroupcomboBox.Items.Add("Y3S1 IT 3.4");
                subgroupcomboBox.Items.Add("Y3S1 IT 3.5");
            }
            if (groupcomboBox.Text == "Y4S2 DS 6")
            {
                subgroupcomboBox.Items.Add("Y4S2 DS 6.1");
                subgroupcomboBox.Items.Add("Y4S2 DS 6.2");
                subgroupcomboBox.Items.Add("Y4S2 DS 6.3");
                subgroupcomboBox.Items.Add("Y4S2 DS 6.4");
                subgroupcomboBox.Items.Add("Y4S2 DS 6.5");
            }
            if (groupcomboBox.Text == "Y3S2 SE WE 5")
            {
                subgroupcomboBox.Items.Add("Y3S2 SE WE 5.1");
                subgroupcomboBox.Items.Add("Y3S2 SE WE 5.2");
                subgroupcomboBox.Items.Add("Y3S2 SE WE 5.3");
                subgroupcomboBox.Items.Add("Y3S2 SE WE 5.4");
                subgroupcomboBox.Items.Add("Y3S2 SE WE 5.5");
            }
        }

        private void clear3button_Click(object sender, EventArgs e)
        {
            groupcomboBox.Text = subgroupcomboBox.Text = room3comboBox.Text = "";
            this.ActiveControl = groupcomboBox;
        }

        private void clear4button_Click(object sender, EventArgs e)
        {
            lecturercomboBox.Text = room4comboBox.Text = "";
            this.ActiveControl = lecturercomboBox;
        }

        private void clear5button_Click(object sender, EventArgs e)
        {
            sessioncomboBox.Text = room5comboBox.Text = "";
            this.ActiveControl = sessioncomboBox;
        }

        private void clear6button_Click(object sender, EventArgs e)
        {
            consecomboBox.Text = room6comboBox.Text = "";
            this.ActiveControl = consecomboBox;
        }

        private void clear7button_Click(object sender, EventArgs e)
        {
            startcomboBox.Text = endcomboBox.Text = room7comboBox.Text = "";
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           if (dateTimePicker1.Value == DateTimePicker.MinimumDateTime)
            {
                dateTimePicker1.Value = DateTime.Now; // show current month/year when user reopens the date popup.
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = " ";
            }
            else
            {
                dateTimePicker1.Format = DateTimePickerFormat.Short;
            }
        }

       private void allocate4button_Click(object sender, EventArgs e)
        {
            if (IsValidMRoom3())
            {
                try
                {
                    //insert data
                    con.Open();
                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandText = "insert into rlecturer(Lecturer, Room) VALUES('" + lecturercomboBox.Text + "','" + room4comboBox.Text + "')";
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Successfully");
                    //BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Unsuccesfull");
                }
            }
        }

        /*private void allocate5button_Click(object sender, EventArgs e)
        {
            if (IsValidMRoom4())
            {
                try
                {
                    //insert data
                    con.Open();
                    SqlCommand cmd4 = con.CreateCommand();
                    cmd4.CommandText = "insert into rsession (Session, Room) VALUES ('" + sessioncomboBox.Text + "','" + room5comboBox.Text + "')";
                    cmd4.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Successfully");
                    //BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Unsuccesfull");
                }
            }
        }*/

        private void allocate6button_Click(object sender, EventArgs e)
        {
            if (IsValidMRoom5())
            {
                try
                {
                    //insert data
                    con.Open();
                    SqlCommand cmd5 = con.CreateCommand();
                    cmd5.CommandText = "insert into rcon(Consecutive_Session, Room) VALUES('" + consecomboBox.Text + "','" + room6comboBox.Text + "')";
                    cmd5.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Successfully");
                    //BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Unsuccesfull");
                }
            }
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (IsValidMRoom6())
            {

                try
                {
                    //insert data
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into rnon(Non_Reservable_Session, Start_Time, End_Time, Room) VALUES('"+ dateTimePicker1.Value + "','" + startcomboBox.Text + "','" + endcomboBox.Text + "','" + room7comboBox.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Successfully");
                    //BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Unsuccesfull");
                }
            }
        }

       private void allocate4button_Click_1(object sender, EventArgs e)
        {
            if (IsValidMRoom3())
            {
                try
                {
                    //insert data
                    con.Open();
                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandText = "insert into rlecturer(Lecturer, Room) VALUES('" + lecturercomboBox.Text + "','" + room4comboBox.Text + "')";
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Successfully");
                    //BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Unsuccesfull");
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (IsValidMRoom1())
            {
                try
                {
                    //insert data
                    con.Open();
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandText = "insert into rosubject (Subject, Tag, Room) values ('" + subjectcomboBox.Text + "', '" + tab2comboBox.Text + "', '" + room2comboBox.Text + "')";
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Successfully");
                    //BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Unsuccesfull");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (IsValidMRoom4())
            {
                try
                {
                    //insert data
                    con.Open();
                    SqlCommand cmd4 = con.CreateCommand();
                    cmd4.CommandText = "insert into rsession (Session, Room) VALUES ('" + sessioncomboBox.Text + "','" + room5comboBox.Text + "')";
                    cmd4.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Successfully");
                    //BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Unsuccesfull");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (IsValidMRoom5())
            {
                try
                {
                    //insert data
                    con.Open();
                    SqlCommand cmd5 = con.CreateCommand();
                    cmd5.CommandText = "insert into rcon(Consecutive_Session, Room) VALUES('" + consecomboBox.Text + "','" + room6comboBox.Text + "')";
                    cmd5.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Successfully");
                    //BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Unsuccesfull");
                }
            }
        }

        private void groupbutton_Click(object sender, EventArgs e)
        {
            if (IsValidMRoom2())
            {
                try
                {
                    //insert data
                    con.Open();
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandText = "insert into rgroup (group_r, Sub_Group, Room)VALUES ('" + groupcomboBox.Text + "','" + subgroupcomboBox.Text + "','" + room3comboBox.Text + "')";
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Successfully");
                    //BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unsuccesfull");
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}




﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace TimeTable_management_System.views_UI_
{
    public partial class managelocations : Form
    {

        public managelocations()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UT64EL6;Initial Catalog=locations;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (IsValidMLocation())
            {
                try
                {
                    //insert data
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into loc3(building_name, room_name, room_type, capacity) VALUES('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + numericUpDown1.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Successfully");
                    BindData();
                }
                catch
                {
                    MessageBox.Show("Unsuccesfull");
                }
                
            }

        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from loc3", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to update?", "Update Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand command = new SqlCommand("update loc3 set building_name = '" + comboBox4.Text + "', room_name = '" + comboBox5.Text + "', room_type = '" + comboBox6.Text + "', capacity = '" + numericUpDown2.Text + "' where building_name= '" + comboBox4.Text + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated Successfully");
                BindData();
            }
            else
            {
                MessageBox.Show("Unsuccessfull");
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "Main Building")
            {
                comboBox2.Items.Add("Main Auditorium");
                comboBox2.Items.Add("406");
                comboBox2.Items.Add("A506");
                comboBox2.Items.Add("507A");
                comboBox2.Items.Add("602");
            }
            if (comboBox1.Text == "New Building")
            {
                comboBox2.Items.Add("13H");
                comboBox2.Items.Add("N3E");
                comboBox2.Items.Add("N3C");
                comboBox2.Items.Add("N3D");
                comboBox2.Items.Add("12H");
            }
            if (comboBox1.Text == "Engineering Faculty")
            {
                comboBox2.Items.Add("E5");
                comboBox2.Items.Add("E2");
                comboBox2.Items.Add("E7");
                comboBox2.Items.Add("E8");
                comboBox2.Items.Add("E10");
            }
            if (comboBox1.Text == "Business Faculty")
            {
                comboBox2.Items.Add("D5");
                comboBox2.Items.Add("D3");
                comboBox2.Items.Add("D2");
                comboBox2.Items.Add("D6");
                comboBox2.Items.Add("D10");
            }
        }

        private void managelocations_Load(object sender, EventArgs e)
        {
            gridbind();
            BindData();
            //autoincrement id
            //SqlDataAdapter sad = new SqlDataAdapter("select isnull (max(cast(ID as int)), 0)+1 from loc1",con);
            //DataTable dt = new DataTable();
            //sad.Fill(dt);
            //textBox2.Text = dt.Rows[0][0].ToString();
            //focus to building name
            this.ActiveControl = comboBox1;
        }

        private void gridbind()
        {
            string connstring = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connstring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from loc3", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                con.Close();
            }


        }
        /*public void gridview()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from loc1", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "insert_data");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "insert_data";
            con.Close();

        }*/
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearbutton1_Click(object sender, EventArgs e)
        {

            comboBox1.Text = comboBox2.Text = comboBox3.Text = numericUpDown1.Text = "";
            //SqlDataAdapter sad = new SqlDataAdapter("select isnull (max(cast(ID as int)), 0)+1 from loc1", con);
            //DataTable dt = new DataTable();
            //sad.Fill(dt);
            //textBox2.Text = dt.Rows[0][0].ToString();
            //focus to building name
            this.ActiveControl = comboBox1;


        }

        private void clearbutton2_Click(object sender, EventArgs e)
        {
            comboBox7.Text = comboBox4.Text = comboBox5.Text = comboBox6.Text = numericUpDown2.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Full(object sender, TabControlCancelEventArgs e)
        {

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (IsValidMLocation())
            {
                /*try {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into loc3(building_name, room_name, room_type, capacity) VALUES('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + numericUpDown1.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Successfully");
                    BindData();
                }
                catch
                {
                    MessageBox.Show("Unsuccesfull");
                }*/
            }

            /*con.Open();
            SqlCommand cmd = new SqlCommand("select Building_Name, Room_Name, Room_Type, Capacity from loc1 where Building_Name = @Building_Name", con);
            cmd.Parameters.AddWithValue("@Building_Name", (textBox1.Text));
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                comboBox4.Text = da.GetValue(0).ToString();
                comboBox5.Text = da.GetValue(1).ToString();
                comboBox6.Text = da.GetValue(2).ToString();
                numericUpDown2.Text= da.GetValue(3).ToString();
                
            }
            con.Close();*/





        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete loc3 where building_name = '" + comboBox4.Text + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete Successfully");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("Please fill the all fields");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from loc3 where building_name ='" + comboBox7.Text + "' ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
            if (comboBox4.Text == "Main Building")
            {
                comboBox5.Items.Add("Main Auditorium");
                comboBox5.Items.Add("406");
                comboBox5.Items.Add("A506");
                comboBox5.Items.Add("507A");
                comboBox5.Items.Add("602");
            }
            if (comboBox4.Text == "New Building")
            {
                comboBox5.Items.Add("13H");
                comboBox5.Items.Add("N3E");
                comboBox5.Items.Add("N3C");
                comboBox5.Items.Add("N3D");
                comboBox5.Items.Add("12H");
            }
            if (comboBox4.Text == "Engineering Faculty")
            {
                comboBox5.Items.Add("E5");
                comboBox5.Items.Add("E2");
                comboBox5.Items.Add("E7");
                comboBox5.Items.Add("E8");
                comboBox5.Items.Add("E10");
            }
            if (comboBox4.Text == "Business Faculty")
            {
                comboBox5.Items.Add("D5");
                comboBox5.Items.Add("D3");
                comboBox5.Items.Add("D2");
                comboBox5.Items.Add("D6");
                comboBox5.Items.Add("D10");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            //textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            comboBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["building_name"].Value.ToString();
            comboBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["room_name"].Value.ToString();
            comboBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["room_type"].Value.ToString();
            numericUpDown2.Value = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["capacity"].Value);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only characters
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult da = MessageBox.Show("Please use only letters");
            }
           
        }*/




        private void numericUpDown1_MouseClick(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Select Room Capacity", numericUpDown1);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void numericUpDown2_MouseClick(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Update Room Capacity", numericUpDown2);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private bool IsValidMLocation()
        {
            if (comboBox1.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Building Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox2.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Room Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox3.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Room Type", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numericUpDown1.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Room Capacity", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox7.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Building Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                return true;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_MouseHover(object sender, EventArgs e)
        {

        }

        private void comboBox7_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from loc3 where building_name ='" + comboBox7.Text + "' ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void comboBox5_MouseHover(object sender, EventArgs e)
        {

        }

        private void comboBox6_MouseHover(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
           

        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void comboBox3_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void comboBox7_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Select Building Name", comboBox7);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void comboBox4_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Update Building Name", comboBox4);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void comboBox5_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Update Room Name", comboBox5);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void comboBox6_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Update Room Type", comboBox6);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void comboBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Select Building Name", comboBox1);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void comboBox3_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Select Room Type", comboBox3);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void comboBox2_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Select Room Name", comboBox2);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void addbutton_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Add details", addbutton);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void clearbutton1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Clear selected details", clearbutton1);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void searchbutton_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Search details from Building Name", searchbutton);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void managelocations_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void updatebutton_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Update selected details", updatebutton);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void deletebutton_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Delete selected details", deletebutton);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void clearbutton2_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("clear selected details", clearbutton2);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statistics s = new statistics();
            s.Show();
            this.Hide();
        }
    }
} 
    



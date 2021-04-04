using System;
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
            //insert data
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into loc1(ID, Building_Name, Room_Name, Room_Type, Capacity) VALUES('" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + numericUpDown1.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add Successfully");
            BindData();
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from loc1", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void updatebutton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update loc1 set Building_Name = '" + comboBox4.Text + "', Room_Name = '" + comboBox5.Text + "', Room_Type = '" + comboBox6.Text + "', Capacity = '" + numericUpDown2.Text + "' where Building_Name = '" + textBox1.Text + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");
            BindData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if(comboBox1.Text == "Main Building")
            {
                comboBox2.Items.Add("Main Auditorium");
                comboBox2.Items.Add("406");
                comboBox2.Items.Add("A506");
                comboBox2.Items.Add("507A");
                comboBox2.Items.Add("602");
            }
            if(comboBox1.Text == "New Building")
            {
                comboBox2.Items.Add("13H");
                comboBox2.Items.Add("N3E");
                comboBox2.Items.Add("N3C");
                comboBox2.Items.Add("N3D");
                comboBox2.Items.Add("12H");
            }
            if(comboBox1.Text == "Engineering Faculty")
            {
                comboBox2.Items.Add("E5");
                comboBox2.Items.Add("E2");
                comboBox2.Items.Add("E7");
                comboBox2.Items.Add("E8");
                comboBox2.Items.Add("E10");
            }
            if(comboBox1.Text == "Business Faculty")
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
        }

        private void gridbind()
        {
            string connstring = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connstring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from loc1", con);
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
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            comboBox2.Items.Remove(comboBox2.SelectedItem);
            comboBox3.Items.Remove(comboBox3.SelectedItem);
            textBox2.Clear();

        }

        private void clearbutton2_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Remove(comboBox4.SelectedItem);
            comboBox5.Items.Remove(comboBox5.SelectedItem);
            comboBox6.Items.Remove(comboBox6.SelectedItem);
            textBox1.Clear();
            //numericUpDown2.Value.();
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
            if (textBox1.Text != "")
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete loc1 where Building_Name = '" + textBox1.Text + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete Successfully");
                    BindData();
                }
            }
           else
            {
               MessageBox.Show("Enter Building Name");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from loc1 where Building_Name ='" + textBox1.Text + "' ", con);
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
            comboBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["Building_Name"].Value.ToString();
            comboBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["Room_Name"].Value.ToString();
            comboBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["Room_Type"].Value.ToString();
            //numericUpDown2.Value = dataGridView1.Rows[e.RowIndex].Cells["Capacity"].Text();
        }
    }
}
    



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
            //con.Open();
            //String query = "INSERT INTO loc1 (ID,Building Name,Room Name,Room Type,Capacity) VALUES('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + numericUpDown1.Text + "')";
            //SqlDataAdapter SDA = new SqlDataAdapter(query, con);

            /*   con.Close();
               BindData();
               if (comboBox1.SelectedIndex > 0 || comboBox1.SelectedIndex == 0)
               {
                   string gettext = comboBox1.SelectedItem.ToString();
                   MessageBox.Show("Add Successfully");
               }
               else
               {
                   MessageBox.Show("Please fill all the fields");
               }

               void BindData()
               {
                   SqlCommand command = new SqlCommand("SELECT * FROM loc1", con);
                   SqlDataAdapter sd = new SqlDataAdapter(command);
                   DataTable dt = new DataTable();
                   dataGridView1.DataSource = dt;
               }*/
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into loc1(ID, Building_Name, Room_Name, Room_Type, Capacity) VALUES('"+textBox2.Text+"','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + numericUpDown1.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add Successfully");

            
        
            


        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void managelocations_Load(object sender, EventArgs e)
        {
            
        }

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
            
        }

        private void clearbutton2_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Remove(comboBox4.SelectedItem);
            comboBox5.Items.Remove(comboBox5.SelectedItem);
            comboBox6.Items.Remove(comboBox6.SelectedItem);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

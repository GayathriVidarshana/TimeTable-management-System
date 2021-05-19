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
    public partial class tag : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-V7M4G0I\SQLEXPRESS;Initial Catalog=TTMS;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Desktop\ITPM TTMS\TimeTable management System\TimeTable management System\database\TimeTableDB.mdf;Integrated Security=True");
        public int Id;
        public tag()
        {
            InitializeComponent();
            display_data();

        }
        private void tag_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

 
        private void button3_Click(object sender, EventArgs e)
        {


            if (IsValiad()) {
                conn.Open();
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO [Tag_D] ( Tag_Name, Tag_Code) VALUES ('" + txtName.Text + "','" + txtTag.Text + "')";
                    cmd.ExecuteNonQuery();
                    txtTag.Text = "";
                    txtName.Text = "";
                    MessageBox.Show("The Tag Is Successfully Created");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Try again");
                    MessageBox.Show(ex.Message);
                }

                conn.Close();
                display_data();

            }
        }

//SHOW TABLE DATA ===========================================================================================================
        public void display_data()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Tag_D]";
            
            cmd.ExecuteNonQuery();
            DataTable Dtable = new DataTable();
            SqlDataAdapter Dadapter = new SqlDataAdapter(cmd);
            Dadapter.Fill(Dtable);
            dataGridView2.DataSource = Dtable;
            conn.Close();


        }

//DELETE TAG ==================================================================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (Id > 0)
            {
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM [Tag_D] WHERE Id = '" + this.Id + "' ";
                    cmd.ExecuteNonQuery();
                    txtTag.Text = "";
                    txtName.Text = "";
                    MessageBox.Show("The Tag Is Successfully Deleted");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Try again");
                }
            }
            else {

                MessageBox.Show("Please select an Tag to DELETE", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            conn.Close();
            display_data();

        }

    


        private void tag_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTMSDataSet1.Tag_D' table. You can move, or remove it, as needed.
        //    this.tag_DTableAdapter.Fill(this.tTMSDataSet1.Tag_D);
            // TODO: This line of code loads data into the 'tTMSDataSet.Tag' table. You can move, or remove it, as needed.
        //    this.tagTableAdapter.Fill(this.tTMSDataSet.Tag);

        }


        private bool IsValiad()
        
            {
                    if (txtTag.Text == string.Empty || txtName.Text == string.Empty)
                    {

                        MessageBox.Show("Tag Code & Tag Name can not be empty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                  return true;

            }
//CLEAR FIELDS ==============================================================================================================
        public void clear_fields() {
            txtName.Clear();
            txtTag.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear_fields();
        }


//UPDATE TAG ==================================================================================================================
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (Id > 0) {
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = " UPDATE [Tag_D] SET  Tag_Name = '" + txtName.Text + "', Tag_Code = '" + txtTag.Text + "' WHERE Id = '" + this.Id + "'";
                    cmd.ExecuteNonQuery();
                    txtTag.Text = "";
                    txtName.Text = "";
                    MessageBox.Show("The Tag Is Successfully Updated");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Try again");
                }
            }
            else {

                MessageBox.Show("Please select an Tag to UPDATE", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }

            conn.Close();
            display_data();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            txtTag.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

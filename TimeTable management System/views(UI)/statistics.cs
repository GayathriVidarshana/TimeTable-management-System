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
using System.Windows.Forms.DataVisualization.Charting;

namespace TimeTable_management_System.views_UI_
{
    public partial class statistics : Form
    {
        public statistics()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\database\\TTMSDB.mdf;Integrated Security=True");
        //this.fa_lectblTableAdapter.Fill(this.TTMSDBDataSet.fa_lectbl);
        public int AcademicYear { get; private set; }
        public int Subject { get; private set; }
        public object TTMSDB { get; private set; }

        private void showchartbutton1_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\database\\TTMSDB.mdf;Integrated Security=True";
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("select Faculty AND Total_Lecturers from fa_lectbl", con);
            SqlCommand cmd = sqlCommand;
            //SqlDataReader reader = cmd.ExecuteReader();
            Series sr = new Series();*/
            try
            {
                falectblBindingSource.EndEdit();
                fa_lectblTableAdapter.Update(TTMSDBDataSet.fa_lectbl);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
                //chart1.Series["Total Number of Lecturers"].Points.AddY(reader.GetInt32(0));
                chart1.Series["Total Number of Lecturers"].XValueMember = "Faculty";
                chart1.Series["Total Number of Lecturers"].YValueMembers = "Total_Lecturers";
                //chart1.DataSource = ;
                chart1.DataBind();
            
        }

        private void showchartbutton2_Click_1(object sender, EventArgs e)
        {
            /*chart2.Series["Total Number of Subjects"].Points.AddXY("1st Year",10);
            chart2.Series["Total Number of Subjects"].Points.AddXY("2nd Year", 10);
            chart2.Series["Total Number of Subjects"].Points.AddXY("3rd Year", 12);
            chart2.Series["Total Number of Subjects"].Points.AddXY("4th Year", 13);*/
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void statistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTMSDBDataSet.fa_lectbl' table. You can move, or remove it, as needed.
            this.fa_lectblTableAdapter.Fill(this.tTMSDBDataSet.fa_lectbl);
            //this.fa_lectblTableAdapter.Fill(this.dbo.fa_lectbl);
        }
    }
    }


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

        public int AcademicYear { get; private set; }
        public int Subject { get; private set; }

        private void showchartbutton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-UT64EL6;Initial Catalog=Statistics;Integrated Security=True";
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from lec", con);
            SqlCommand cmd = sqlCommand;
            SqlDataReader reader = cmd.ExecuteReader();
            Series sr = new Series();
            while (reader.Read())
            {
               chart1.Series["Total Number of Lecturers"].Points.AddY(reader.GetInt32(0));
               
            }
         }

        private void showchartbutton2_Click_1(object sender, EventArgs e)
        {
            chart2.Series["Total Number of Subjects"].Points.AddXY("1st Year",10);
            chart2.Series["Total Number of Subjects"].Points.AddXY("2nd Year", 10);
            chart2.Series["Total Number of Subjects"].Points.AddXY("3rd Year", 12);
            chart2.Series["Total Number of Subjects"].Points.AddXY("4th Year", 13);
        }

        
    }
    }


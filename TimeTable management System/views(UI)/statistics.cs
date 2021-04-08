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
        public object TTMSDB { get; private set; }

        private void showchartbutton1_Click(object sender, EventArgs e)
        {
                chart1.Series["Total Number of Lecturers"].XValueMember = "Faculty";
                chart1.Series["Total Number of Lecturers"].YValueMembers = "TotalLec";
                chart1.DataSource = tTMSDBDataSet1.lec;
                chart1.DataBind();
         }

        private void showchartbutton2_Click_1(object sender, EventArgs e)
        {
            /*chart2.Series["Total Number of Subjects"].Points.AddXY("1st Year",10);
            chart2.Series["Total Number of Subjects"].Points.AddXY("2nd Year", 10);
            chart2.Series["Total Number of Subjects"].Points.AddXY("3rd Year", 12);
            chart2.Series["Total Number of Subjects"].Points.AddXY("4th Year", 13);*/
            chart2.Series["Total Number of Subjects"].XValueMember = "AcademicYear";
            chart2.Series["Total Number of Subjects"].YValueMembers = "Totalsub";
            chart2.DataSource = tTMSDBDataSet2.sub;
            chart2.DataBind();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void statistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTMSDBDataSet5.stu' table. You can move, or remove it, as needed.
            this.stuTableAdapter1.Fill(this.tTMSDBDataSet5.stu);
            // TODO: This line of code loads data into the 'tTMSDBDataSet4.stu' table. You can move, or remove it, as needed.
            this.stuTableAdapter.Fill(this.tTMSDBDataSet4.stu);
            // TODO: This line of code loads data into the 'tTMSDBDataSet3.sub' table. You can move, or remove it, as needed.
            this.subTableAdapter1.Fill(this.tTMSDBDataSet3.sub);
            // TODO: This line of code loads data into the 'tTMSDBDataSet2.sub' table. You can move, or remove it, as needed.
            this.subTableAdapter.Fill(this.tTMSDBDataSet2.sub);
            // TODO: This line of code loads data into the 'tTMSDBDataSet1.lec' table. You can move, or remove it, as needed.
            this.lecTableAdapter.Fill(this.tTMSDBDataSet1.lec);
            // TODO: This line of code loads data into the 'tTMSDBDataSet.fa_lectbl' table. You can move, or remove it, as needed.
            this.fa_lectblTableAdapter.Fill(this.tTMSDBDataSet.fa_lectbl);
            //this.fa_lectblTableAdapter.Fill(this.dbo.fa_lectbl);

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showchartbutton3_Click(object sender, EventArgs e)
        {
            chart3.Series["Total Number of Students"].XValueMember = "Faculty";
            chart3.Series["Total Number of Students"].YValueMembers = "TotalStu";
            chart3.DataSource = tTMSDBDataSet5.stu;
            chart3.DataBind();
        }
    }
    }


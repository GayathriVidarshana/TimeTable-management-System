using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_management_System.views_UI_
{
    public partial class Stat : Form
    {
        public Stat()
        {
            InitializeComponent();
        }

        private void Stat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTMSDBDataSet2.stu' table. You can move, or remove it, as needed.
            this.stuTableAdapter.Fill(this.tTMSDBDataSet2.stu);
            // TODO: This line of code loads data into the 'tTMSDBDataSet1.sub' table. You can move, or remove it, as needed.
            this.subTableAdapter.Fill(this.tTMSDBDataSet1.sub);
            // TODO: This line of code loads data into the 'tTMSDBDataSet.lec' table. You can move, or remove it, as needed.
            this.lecTableAdapter.Fill(this.tTMSDBDataSet.lec);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Total Number of Lecturers"].XValueMember = "Faculty";
            chart1.Series["Total Number of Lecturers"].YValueMembers = "TotalLec";
            chart1.DataSource = tTMSDBDataSet.lec;
            chart1.DataBind();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart2.Series["Total Number of Subjects"].XValueMember = "AcademicYear";
            chart2.Series["Total Number of Subjects"].YValueMembers = "TotalSub";
            chart2.DataSource = tTMSDBDataSet1.sub;
            chart2.DataBind();
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart3.Series["Total Number of Students"].XValueMember = "Faculty";
            chart3.Series["Total Number of Students"].YValueMembers = "TotalStu";
            chart3.DataSource = tTMSDBDataSet2.stu;
            chart3.DataBind();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

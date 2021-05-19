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
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            tag tagui = new tag();
            tagui.TopLevel = false;
            panel3.Controls.Add(tagui);
            tagui.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tagui.Dock = DockStyle.Fill;
            tagui.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Student studentui = new Student();
            studentui.TopLevel = false;
            panel3.Controls.Add(studentui);
            studentui.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            studentui.Dock = DockStyle.Fill;
            studentui.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            SessionC SessionM = new SessionC();
            SessionM.TopLevel = false;
            panel3.Controls.Add(SessionM);
            SessionM.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SessionM.Dock = DockStyle.Fill;
            SessionM.Show();
        }
    }
}

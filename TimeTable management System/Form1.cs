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
using TimeTable_management_System.views_UI_;

namespace TimeTable_management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddNewLecturerUI intrfrm = new AddNewLecturerUI();
            intrfrm.TopLevel = false;
            panel1.Controls.Add(intrfrm);
            intrfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            intrfrm.Dock = DockStyle.Fill;
            intrfrm.Show();

        }

        private void btnManageLecturer_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ManageLecturersUI intrfrm = new ManageLecturersUI();
            intrfrm.TopLevel = false;
            panel1.Controls.Add(intrfrm);
            intrfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            intrfrm.Dock = DockStyle.Fill;
            intrfrm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddSubjectUI intrfrm = new AddSubjectUI();
            intrfrm.TopLevel = false;
            panel1.Controls.Add(intrfrm);
            intrfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            intrfrm.Dock = DockStyle.Fill;
            intrfrm.Show();

        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ManageSubjectsUI intrfrm = new ManageSubjectsUI();
            intrfrm.TopLevel = false;
            panel1.Controls.Add(intrfrm);
            intrfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            intrfrm.Dock = DockStyle.Fill;
            intrfrm.Show();

        }
    }
}


namespace TimeTable_management_System.views_UI_
{
    partial class ManageLecturersUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chkbxWednesday = new System.Windows.Forms.CheckBox();
            this.chkbxThursday = new System.Windows.Forms.CheckBox();
            this.chkbxSaturday = new System.Windows.Forms.CheckBox();
            this.chkbxTuesday = new System.Windows.Forms.CheckBox();
            this.chkbxSunday = new System.Windows.Forms.CheckBox();
            this.chkbxFriday = new System.Windows.Forms.CheckBox();
            this.chkbxMonday = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox8ByCenter = new System.Windows.Forms.ComboBox();
            this.comboBox7ByFaculty = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelDataSet = new TimeTable_management_System.ModelDataSet();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.cmbBuilding = new System.Windows.Forms.ComboBox();
            this.cmbCenter = new System.Windows.Forms.ComboBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.txbRank = new System.Windows.Forms.TextBox();
            this.tbxLecName = new System.Windows.Forms.TextBox();
            this.tbxEmpID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbxEndTime = new System.Windows.Forms.ComboBox();
            this.cmbxStartTime = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnGenerateRank = new System.Windows.Forms.Button();
            this.lecturerTableAdapter = new TimeTable_management_System.ModelDataSetTableAdapters.LecturerTableAdapter();
            this.lecturerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.errorProviderLecName = new System.Windows.Forms.ErrorProvider(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLecName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkbxWednesday
            // 
            this.chkbxWednesday.AutoSize = true;
            this.chkbxWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxWednesday.Location = new System.Drawing.Point(629, 547);
            this.chkbxWednesday.Name = "chkbxWednesday";
            this.chkbxWednesday.Size = new System.Drawing.Size(105, 21);
            this.chkbxWednesday.TabIndex = 80;
            this.chkbxWednesday.Text = "Wednesday";
            this.chkbxWednesday.UseVisualStyleBackColor = true;
            // 
            // chkbxThursday
            // 
            this.chkbxThursday.AutoSize = true;
            this.chkbxThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxThursday.Location = new System.Drawing.Point(810, 547);
            this.chkbxThursday.Name = "chkbxThursday";
            this.chkbxThursday.Size = new System.Drawing.Size(90, 21);
            this.chkbxThursday.TabIndex = 79;
            this.chkbxThursday.Text = "Thursday";
            this.chkbxThursday.UseVisualStyleBackColor = true;
            // 
            // chkbxSaturday
            // 
            this.chkbxSaturday.AutoSize = true;
            this.chkbxSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxSaturday.Location = new System.Drawing.Point(421, 576);
            this.chkbxSaturday.Name = "chkbxSaturday";
            this.chkbxSaturday.Size = new System.Drawing.Size(87, 21);
            this.chkbxSaturday.TabIndex = 78;
            this.chkbxSaturday.Text = "Saturday";
            this.chkbxSaturday.UseVisualStyleBackColor = true;
            // 
            // chkbxTuesday
            // 
            this.chkbxTuesday.AutoSize = true;
            this.chkbxTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxTuesday.Location = new System.Drawing.Point(420, 547);
            this.chkbxTuesday.Name = "chkbxTuesday";
            this.chkbxTuesday.Size = new System.Drawing.Size(85, 21);
            this.chkbxTuesday.TabIndex = 77;
            this.chkbxTuesday.Text = "Tuesday";
            this.chkbxTuesday.UseVisualStyleBackColor = true;
            // 
            // chkbxSunday
            // 
            this.chkbxSunday.AutoSize = true;
            this.chkbxSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxSunday.Location = new System.Drawing.Point(630, 576);
            this.chkbxSunday.Name = "chkbxSunday";
            this.chkbxSunday.Size = new System.Drawing.Size(78, 21);
            this.chkbxSunday.TabIndex = 76;
            this.chkbxSunday.Text = "Sunday";
            this.chkbxSunday.UseVisualStyleBackColor = true;
            // 
            // chkbxFriday
            // 
            this.chkbxFriday.AutoSize = true;
            this.chkbxFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxFriday.Location = new System.Drawing.Point(184, 576);
            this.chkbxFriday.Name = "chkbxFriday";
            this.chkbxFriday.Size = new System.Drawing.Size(69, 21);
            this.chkbxFriday.TabIndex = 75;
            this.chkbxFriday.Text = "Friday";
            this.chkbxFriday.UseVisualStyleBackColor = true;
            // 
            // chkbxMonday
            // 
            this.chkbxMonday.AutoSize = true;
            this.chkbxMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxMonday.Location = new System.Drawing.Point(183, 547);
            this.chkbxMonday.Name = "chkbxMonday";
            this.chkbxMonday.Size = new System.Drawing.Size(80, 21);
            this.chkbxMonday.TabIndex = 74;
            this.chkbxMonday.Text = "Monday";
            this.chkbxMonday.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 547);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 73;
            this.label15.Text = "Active Days";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(592, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 72;
            this.label12.Text = "By Center";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(308, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 71;
            this.label11.Text = "By Faculty";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 70;
            this.label10.Text = "By Department";
            // 
            // comboBox8ByCenter
            // 
            this.comboBox8ByCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8ByCenter.FormattingEnabled = true;
            this.comboBox8ByCenter.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Matara",
            "Kandy",
            "Kurunagala",
            "Jaffna"});
            this.comboBox8ByCenter.Location = new System.Drawing.Point(591, 119);
            this.comboBox8ByCenter.Name = "comboBox8ByCenter";
            this.comboBox8ByCenter.Size = new System.Drawing.Size(222, 24);
            this.comboBox8ByCenter.TabIndex = 69;
            this.comboBox8ByCenter.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // comboBox7ByFaculty
            // 
            this.comboBox7ByFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7ByFaculty.FormattingEnabled = true;
            this.comboBox7ByFaculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities & Sciences"});
            this.comboBox7ByFaculty.Location = new System.Drawing.Point(307, 119);
            this.comboBox7ByFaculty.Name = "comboBox7ByFaculty";
            this.comboBox7ByFaculty.Size = new System.Drawing.Size(222, 24);
            this.comboBox7ByFaculty.TabIndex = 68;
            this.comboBox7ByFaculty.SelectedIndexChanged += new System.EventHandler(this.comboBox7ByFaculty_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lecturerBindingSource, "employeeId", true));
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Department of IT",
            "Department of CSE",
            "Department of CSNE"});
            this.comboBox6.Location = new System.Drawing.Point(27, 119);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(222, 24);
            this.comboBox6.TabIndex = 67;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.modelDataSet;
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbLevel
            // 
            this.cmbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbLevel.Location = new System.Drawing.Point(660, 439);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(268, 24);
            this.cmbLevel.TabIndex = 65;
            // 
            // cmbBuilding
            // 
            this.cmbBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuilding.FormattingEnabled = true;
            this.cmbBuilding.Items.AddRange(new object[] {
            "New building",
            "D-block "});
            this.cmbBuilding.Location = new System.Drawing.Point(660, 400);
            this.cmbBuilding.Name = "cmbBuilding";
            this.cmbBuilding.Size = new System.Drawing.Size(268, 24);
            this.cmbBuilding.TabIndex = 64;
            // 
            // cmbCenter
            // 
            this.cmbCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCenter.FormattingEnabled = true;
            this.cmbCenter.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Matara",
            "Kandy",
            "Kurunagala",
            "Jaffna"});
            this.cmbCenter.Location = new System.Drawing.Point(660, 366);
            this.cmbCenter.Name = "cmbCenter";
            this.cmbCenter.Size = new System.Drawing.Size(268, 24);
            this.cmbCenter.TabIndex = 63;
            // 
            // cmbDept
            // 
            this.cmbDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "Department of IT",
            "Department of CSE",
            "Department of CSNE"});
            this.cmbDept.Location = new System.Drawing.Point(187, 471);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(227, 24);
            this.cmbDept.TabIndex = 62;
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities & Sciences"});
            this.cmbFaculty.Location = new System.Drawing.Point(187, 437);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(227, 24);
            this.cmbFaculty.TabIndex = 61;
            // 
            // txbRank
            // 
            this.txbRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRank.Location = new System.Drawing.Point(660, 478);
            this.txbRank.Name = "txbRank";
            this.txbRank.ReadOnly = true;
            this.txbRank.Size = new System.Drawing.Size(126, 22);
            this.txbRank.TabIndex = 60;
            // 
            // tbxLecName
            // 
            this.tbxLecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLecName.Location = new System.Drawing.Point(187, 404);
            this.tbxLecName.Name = "tbxLecName";
            this.tbxLecName.Size = new System.Drawing.Size(227, 22);
            this.tbxLecName.TabIndex = 59;
            this.tbxLecName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLecName_KeyPress);
            // 
            // tbxEmpID
            // 
            this.tbxEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmpID.Location = new System.Drawing.Point(187, 368);
            this.tbxEmpID.Name = "tbxEmpID";
            this.tbxEmpID.ReadOnly = true;
            this.tbxEmpID.Size = new System.Drawing.Size(227, 22);
            this.tbxEmpID.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 371);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label9.Size = new System.Drawing.Size(85, 22);
            this.label9.TabIndex = 57;
            this.label9.Text = "Employee Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 442);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label8.Size = new System.Drawing.Size(53, 22);
            this.label8.TabIndex = 56;
            this.label8.Text = "Faculty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 473);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 55;
            this.label7.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(551, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Rank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(551, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Building";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 407);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "Lecturer Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(901, 189);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(440, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "Manage lecturers";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 80);
            this.panel1.TabIndex = 66;
            // 
            // cmbxEndTime
            // 
            this.cmbxEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxEndTime.FormattingEnabled = true;
            this.cmbxEndTime.Items.AddRange(new object[] {
            "08:00 AM",
            "08:30 AM",
            "09:00 AM",
            "09:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "13:00 PM",
            "13:30 PM",
            "14:00 PM",
            "14:30 PM",
            "15:00 PM",
            "15:30 PM",
            "16:00 PM",
            "16:30 PM",
            "17:00 PM",
            "17:30 PM"});
            this.cmbxEndTime.Location = new System.Drawing.Point(395, 632);
            this.cmbxEndTime.Name = "cmbxEndTime";
            this.cmbxEndTime.Size = new System.Drawing.Size(133, 24);
            this.cmbxEndTime.TabIndex = 87;
            // 
            // cmbxStartTime
            // 
            this.cmbxStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxStartTime.FormattingEnabled = true;
            this.cmbxStartTime.Items.AddRange(new object[] {
            "08:00 AM",
            "08:30 AM",
            "09:00 AM",
            "09:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "13:00 PM",
            "13:30 PM",
            "14:00 PM",
            "14:30 PM",
            "15:00 PM",
            "15:30 PM",
            "16:00 PM",
            "16:30 PM",
            "17:00 PM",
            "17:30 PM"});
            this.cmbxStartTime.Location = new System.Drawing.Point(184, 632);
            this.cmbxStartTime.Name = "cmbxStartTime";
            this.cmbxStartTime.Size = new System.Drawing.Size(133, 24);
            this.cmbxStartTime.TabIndex = 86;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(340, 635);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 17);
            this.label13.TabIndex = 85;
            this.label13.Text = "to";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 635);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 17);
            this.label14.TabIndex = 84;
            this.label14.Text = "Available time";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(827, 668);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 37);
            this.btnClear.TabIndex = 83;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(697, 668);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 37);
            this.btnDelete.TabIndex = 82;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(550, 668);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 37);
            this.btnUpdate.TabIndex = 81;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(869, 94);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 88;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnGenerateRank
            // 
            this.btnGenerateRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateRank.Location = new System.Drawing.Point(801, 469);
            this.btnGenerateRank.Name = "btnGenerateRank";
            this.btnGenerateRank.Size = new System.Drawing.Size(128, 31);
            this.btnGenerateRank.TabIndex = 89;
            this.btnGenerateRank.Text = "Generate Rank";
            this.btnGenerateRank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerateRank.UseVisualStyleBackColor = true;
            this.btnGenerateRank.Click += new System.EventHandler(this.btnGenerateRank_Click);
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // lecturerBindingSource1
            // 
            this.lecturerBindingSource1.DataMember = "Lecturer";
            this.lecturerBindingSource1.DataSource = this.modelDataSet;
            // 
            // errorProviderLecName
            // 
            this.errorProviderLecName.ContainerControl = this;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ManageLecturersUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 718);
            this.Controls.Add(this.btnGenerateRank);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbxEndTime);
            this.Controls.Add(this.cmbxStartTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chkbxWednesday);
            this.Controls.Add(this.chkbxThursday);
            this.Controls.Add(this.chkbxSaturday);
            this.Controls.Add(this.chkbxTuesday);
            this.Controls.Add(this.chkbxSunday);
            this.Controls.Add(this.chkbxFriday);
            this.Controls.Add(this.chkbxMonday);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox8ByCenter);
            this.Controls.Add(this.comboBox7ByFaculty);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.cmbBuilding);
            this.Controls.Add(this.cmbCenter);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.txbRank);
            this.Controls.Add(this.tbxLecName);
            this.Controls.Add(this.tbxEmpID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageLecturersUI";
            this.Text = "ManageLecturers";
            this.Load += new System.EventHandler(this.ManageLecturersUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLecName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbxWednesday;
        private System.Windows.Forms.CheckBox chkbxThursday;
        private System.Windows.Forms.CheckBox chkbxSaturday;
        private System.Windows.Forms.CheckBox chkbxTuesday;
        private System.Windows.Forms.CheckBox chkbxSunday;
        private System.Windows.Forms.CheckBox chkbxFriday;
        private System.Windows.Forms.CheckBox chkbxMonday;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox8ByCenter;
        private System.Windows.Forms.ComboBox comboBox7ByFaculty;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.ComboBox cmbBuilding;
        private System.Windows.Forms.ComboBox cmbCenter;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.TextBox txbRank;
        private System.Windows.Forms.TextBox tbxLecName;
        private System.Windows.Forms.TextBox tbxEmpID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbxEndTime;
        private System.Windows.Forms.ComboBox cmbxStartTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnGenerateRank;
        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private ModelDataSetTableAdapters.LecturerTableAdapter lecturerTableAdapter;
        private System.Windows.Forms.BindingSource lecturerBindingSource1;
        private System.Windows.Forms.ErrorProvider errorProviderLecName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

namespace TimeTable_management_System.views_UI_
{
    partial class AddNewLecturerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewLecturerUI));
            this.cbEndTime = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cbStartTime = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chckbxWednesday = new System.Windows.Forms.CheckBox();
            this.chckbxThursday = new System.Windows.Forms.CheckBox();
            this.chckbxSaturday = new System.Windows.Forms.CheckBox();
            this.chckbxTuesday = new System.Windows.Forms.CheckBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.chckbxSunday = new System.Windows.Forms.CheckBox();
            this.chckbxFriday = new System.Windows.Forms.CheckBox();
            this.chkbxMonday = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGenerateRank = new System.Windows.Forms.Button();
            this.cbBuilding = new System.Windows.Forms.ComboBox();
            this.cbCenter = new System.Windows.Forms.ComboBox();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.tbRank = new System.Windows.Forms.TextBox();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.tbLecName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProviderLecName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFacultyEmpty = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLecName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFacultyEmpty)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEndTime
            // 
            this.cbEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEndTime.FormattingEnabled = true;
            this.cbEndTime.Items.AddRange(new object[] {
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
            this.cbEndTime.Location = new System.Drawing.Point(430, 518);
            this.cbEndTime.Name = "cbEndTime";
            this.cbEndTime.Size = new System.Drawing.Size(133, 28);
            this.cbEndTime.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(361, 521);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 25);
            this.label12.TabIndex = 64;
            this.label12.Text = "to";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 139);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label9.Size = new System.Drawing.Size(120, 30);
            this.label9.TabIndex = 42;
            this.label9.Text = "Employee Id";
            this.toolTip1.SetToolTip(this.label9, " This should be 6 digit number.");
            // 
            // cbStartTime
            // 
            this.cbStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStartTime.FormattingEnabled = true;
            this.cbStartTime.Items.AddRange(new object[] {
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
            this.cbStartTime.Location = new System.Drawing.Point(193, 518);
            this.cbStartTime.Name = "cbStartTime";
            this.cbStartTime.Size = new System.Drawing.Size(133, 28);
            this.cbStartTime.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 517);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 25);
            this.label11.TabIndex = 63;
            this.label11.Text = "Available time";
            // 
            // chckbxWednesday
            // 
            this.chckbxWednesday.AutoSize = true;
            this.chckbxWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbxWednesday.Location = new System.Drawing.Point(617, 399);
            this.chckbxWednesday.Name = "chckbxWednesday";
            this.chckbxWednesday.Size = new System.Drawing.Size(140, 29);
            this.chckbxWednesday.TabIndex = 62;
            this.chckbxWednesday.Text = "Wednesday";
            this.chckbxWednesday.UseVisualStyleBackColor = true;
            // 
            // chckbxThursday
            // 
            this.chckbxThursday.AutoSize = true;
            this.chckbxThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbxThursday.Location = new System.Drawing.Point(798, 399);
            this.chckbxThursday.Name = "chckbxThursday";
            this.chckbxThursday.Size = new System.Drawing.Size(117, 29);
            this.chckbxThursday.TabIndex = 61;
            this.chckbxThursday.Text = "Thursday";
            this.chckbxThursday.UseVisualStyleBackColor = true;
            // 
            // chckbxSaturday
            // 
            this.chckbxSaturday.AutoSize = true;
            this.chckbxSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbxSaturday.Location = new System.Drawing.Point(408, 452);
            this.chckbxSaturday.Name = "chckbxSaturday";
            this.chckbxSaturday.Size = new System.Drawing.Size(113, 29);
            this.chckbxSaturday.TabIndex = 60;
            this.chckbxSaturday.Text = "Saturday";
            this.chckbxSaturday.UseVisualStyleBackColor = true;
            // 
            // chckbxTuesday
            // 
            this.chckbxTuesday.AutoSize = true;
            this.chckbxTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbxTuesday.Location = new System.Drawing.Point(408, 399);
            this.chckbxTuesday.Name = "chckbxTuesday";
            this.chckbxTuesday.Size = new System.Drawing.Size(111, 29);
            this.chckbxTuesday.TabIndex = 59;
            this.chckbxTuesday.Text = "Tuesday";
            this.chckbxTuesday.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(663, 598);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 45);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip2.SetToolTip(this.btnClear, "Clear above details");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbLevel
            // 
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbLevel.Location = new System.Drawing.Point(663, 251);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(286, 28);
            this.cbLevel.TabIndex = 50;
            this.toolTip3.SetToolTip(this.cbLevel, "Professor 1, Assistant Professor 2,Senior Lecturer(HG) 3,Senior Lecturer 4,Lectur" +
        "er 5 ,Assistant Lecturer 6");
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Level";
            this.toolTip4.SetToolTip(this.label5, "Professor 1, Assistant Professor 2,Senior Lecturer(HG) 3,Senior Lecturer 4,Lectur" +
        "er 5 ,Assistant Lecturer 6");
            // 
            // chckbxSunday
            // 
            this.chckbxSunday.AutoSize = true;
            this.chckbxSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbxSunday.Location = new System.Drawing.Point(617, 452);
            this.chckbxSunday.Name = "chckbxSunday";
            this.chckbxSunday.Size = new System.Drawing.Size(102, 29);
            this.chckbxSunday.TabIndex = 58;
            this.chckbxSunday.Text = "Sunday";
            this.chckbxSunday.UseVisualStyleBackColor = true;
            // 
            // chckbxFriday
            // 
            this.chckbxFriday.AutoSize = true;
            this.chckbxFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbxFriday.Location = new System.Drawing.Point(191, 452);
            this.chckbxFriday.Name = "chckbxFriday";
            this.chckbxFriday.Size = new System.Drawing.Size(88, 29);
            this.chckbxFriday.TabIndex = 57;
            this.chckbxFriday.Text = "Friday";
            this.chckbxFriday.UseVisualStyleBackColor = true;
            // 
            // chkbxMonday
            // 
            this.chkbxMonday.AutoSize = true;
            this.chkbxMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxMonday.Location = new System.Drawing.Point(191, 399);
            this.chkbxMonday.Name = "chkbxMonday";
            this.chkbxMonday.Size = new System.Drawing.Size(105, 29);
            this.chkbxMonday.TabIndex = 56;
            this.chkbxMonday.Text = "Monday";
            this.chkbxMonday.UseVisualStyleBackColor = true;
            this.chkbxMonday.CheckedChanged += new System.EventHandler(this.chkbxMonday_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 55;
            this.label10.Text = "Active Days";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(819, 598);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 45);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGenerateRank
            // 
            this.btnGenerateRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateRank.Location = new System.Drawing.Point(819, 299);
            this.btnGenerateRank.Name = "btnGenerateRank";
            this.btnGenerateRank.Size = new System.Drawing.Size(130, 45);
            this.btnGenerateRank.TabIndex = 51;
            this.btnGenerateRank.Text = "Generate Rank";
            this.btnGenerateRank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerateRank.UseVisualStyleBackColor = true;
            this.btnGenerateRank.Click += new System.EventHandler(this.btnGenerateRank_Click);
            // 
            // cbBuilding
            // 
            this.cbBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuilding.FormattingEnabled = true;
            this.cbBuilding.Items.AddRange(new object[] {
            "New building",
            "D-block "});
            this.cbBuilding.Location = new System.Drawing.Point(663, 198);
            this.cbBuilding.Name = "cbBuilding";
            this.cbBuilding.Size = new System.Drawing.Size(286, 28);
            this.cbBuilding.TabIndex = 49;
            this.cbBuilding.SelectedIndexChanged += new System.EventHandler(this.cbBuilding_SelectedIndexChanged);
            // 
            // cbCenter
            // 
            this.cbCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCenter.FormattingEnabled = true;
            this.cbCenter.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Matara",
            "Kandy",
            "Kurunagala",
            "Jaffna"});
            this.cbCenter.Location = new System.Drawing.Point(663, 146);
            this.cbCenter.Name = "cbCenter";
            this.cbCenter.Size = new System.Drawing.Size(286, 28);
            this.cbCenter.TabIndex = 48;
            this.cbCenter.SelectedIndexChanged += new System.EventHandler(this.cbCenter_SelectedIndexChanged);
            // 
            // cbDept
            // 
            this.cbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Items.AddRange(new object[] {
            "Department of IT",
            "Department of CSE",
            "Department of CSNE"});
            this.cbDept.Location = new System.Drawing.Point(189, 299);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(286, 28);
            this.cbDept.TabIndex = 47;
            this.cbDept.SelectedIndexChanged += new System.EventHandler(this.cbDept_SelectedIndexChanged);
            // 
            // cbFaculty
            // 
            this.cbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities & Sciences"});
            this.cbFaculty.Location = new System.Drawing.Point(189, 249);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(286, 28);
            this.cbFaculty.TabIndex = 46;
            this.cbFaculty.SelectedIndexChanged += new System.EventHandler(this.cbFaculty_SelectedIndexChanged);
            this.cbFaculty.Validating += new System.ComponentModel.CancelEventHandler(this.cbFaculty_Validating);
            // 
            // tbRank
            // 
            this.tbRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRank.Location = new System.Drawing.Point(663, 317);
            this.tbRank.Name = "tbRank";
            this.tbRank.ReadOnly = true;
            this.tbRank.Size = new System.Drawing.Size(107, 27);
            this.tbRank.TabIndex = 45;
            this.tbRank.TextChanged += new System.EventHandler(this.tbRank_TextChanged);
            // 
            // tbEmpID
            // 
            this.tbEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpID.Location = new System.Drawing.Point(189, 146);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.ReadOnly = true;
            this.tbEmpID.Size = new System.Drawing.Size(286, 27);
            this.tbEmpID.TabIndex = 44;
            this.tbEmpID.TextChanged += new System.EventHandler(this.tbEmpID_TextChanged);
            // 
            // tbLecName
            // 
            this.tbLecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLecName.Location = new System.Drawing.Point(189, 202);
            this.tbLecName.Name = "tbLecName";
            this.tbLecName.Size = new System.Drawing.Size(286, 27);
            this.tbLecName.TabIndex = 43;
            this.tbLecName.TextChanged += new System.EventHandler(this.tbLecName_TextChanged);
            this.tbLecName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLecName_KeyPress);
            this.tbLecName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbLecName_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 242);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label8.Size = new System.Drawing.Size(75, 30);
            this.label8.TabIndex = 41;
            this.label8.Text = "Faculty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 297);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(113, 30);
            this.label7.TabIndex = 40;
            this.label7.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(554, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Rank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Building";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 195);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(140, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "Lecturer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(375, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Add a new lecturer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-9, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 80);
            this.panel1.TabIndex = 54;
            // 
            // errorProviderLecName
            // 
            this.errorProviderLecName.ContainerControl = this;
            // 
            // errorProviderFacultyEmpty
            // 
            this.errorProviderFacultyEmpty.ContainerControl = this;
            // 
            // AddNewLecturerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 718);
            this.Controls.Add(this.cbEndTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbStartTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chckbxWednesday);
            this.Controls.Add(this.chckbxThursday);
            this.Controls.Add(this.chckbxSaturday);
            this.Controls.Add(this.chckbxTuesday);
            this.Controls.Add(this.chckbxSunday);
            this.Controls.Add(this.chckbxFriday);
            this.Controls.Add(this.chkbxMonday);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGenerateRank);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.cbBuilding);
            this.Controls.Add(this.cbCenter);
            this.Controls.Add(this.cbDept);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.tbRank);
            this.Controls.Add(this.tbEmpID);
            this.Controls.Add(this.tbLecName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AddNewLecturerUI";
            this.Text = "Add New Lecturer UI";
            this.Load += new System.EventHandler(this.AddNewLecturerUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLecName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFacultyEmpty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEndTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbStartTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chckbxWednesday;
        private System.Windows.Forms.CheckBox chckbxThursday;
        private System.Windows.Forms.CheckBox chckbxSaturday;
        private System.Windows.Forms.CheckBox chckbxTuesday;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chckbxSunday;
        private System.Windows.Forms.CheckBox chckbxFriday;
        private System.Windows.Forms.CheckBox chkbxMonday;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGenerateRank;
        private System.Windows.Forms.ComboBox cbBuilding;
        private System.Windows.Forms.ComboBox cbCenter;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.TextBox tbRank;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.TextBox tbLecName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProviderLecName;
        private System.Windows.Forms.ErrorProvider errorProviderFacultyEmpty;
    }
}
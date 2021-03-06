
namespace TimeTable_management_System.views_UI_
{
    partial class AddSubjectUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubjectUI));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nUpDwnNoOfEvaluationHours = new System.Windows.Forms.NumericUpDown();
            this.nUpDwnNoOfLabHours = new System.Windows.Forms.NumericUpDown();
            this.nUpDwnNoOfTutorialHours = new System.Windows.Forms.NumericUpDown();
            this.nUpDwnNoOfLecturerHours = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbxSubjCode = new System.Windows.Forms.TextBox();
            this.txbxSubjName = new System.Windows.Forms.TextBox();
            this.radioButton2Sem2 = new System.Windows.Forms.RadioButton();
            this.radioButton1Sem1 = new System.Windows.Forms.RadioButton();
            this.cbxOfferdYear = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProviderSubName = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbSubjectCodeNew = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnNoOfEvaluationHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnNoOfLabHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnNoOfTutorialHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnNoOfLecturerHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(784, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 45);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSave, "save data to system");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(615, 418);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 45);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnClear, "Clear filled details");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(398, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Add Subject";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 80);
            this.panel1.TabIndex = 65;
            // 
            // nUpDwnNoOfEvaluationHours
            // 
            this.nUpDwnNoOfEvaluationHours.Location = new System.Drawing.Point(848, 295);
            this.nUpDwnNoOfEvaluationHours.Name = "nUpDwnNoOfEvaluationHours";
            this.nUpDwnNoOfEvaluationHours.Size = new System.Drawing.Size(73, 22);
            this.nUpDwnNoOfEvaluationHours.TabIndex = 98;
            // 
            // nUpDwnNoOfLabHours
            // 
            this.nUpDwnNoOfLabHours.Location = new System.Drawing.Point(848, 244);
            this.nUpDwnNoOfLabHours.Name = "nUpDwnNoOfLabHours";
            this.nUpDwnNoOfLabHours.Size = new System.Drawing.Size(73, 22);
            this.nUpDwnNoOfLabHours.TabIndex = 97;
            // 
            // nUpDwnNoOfTutorialHours
            // 
            this.nUpDwnNoOfTutorialHours.Location = new System.Drawing.Point(848, 193);
            this.nUpDwnNoOfTutorialHours.Name = "nUpDwnNoOfTutorialHours";
            this.nUpDwnNoOfTutorialHours.Size = new System.Drawing.Size(73, 22);
            this.nUpDwnNoOfTutorialHours.TabIndex = 96;
            // 
            // nUpDwnNoOfLecturerHours
            // 
            this.nUpDwnNoOfLecturerHours.Location = new System.Drawing.Point(848, 138);
            this.nUpDwnNoOfLecturerHours.Name = "nUpDwnNoOfLecturerHours";
            this.nUpDwnNoOfLecturerHours.Size = new System.Drawing.Size(73, 22);
            this.nUpDwnNoOfLecturerHours.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 185);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(218, 30);
            this.label3.TabIndex = 94;
            this.label3.Text = "Number of tutorial hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(575, 235);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(187, 30);
            this.label4.TabIndex = 93;
            this.label4.Text = "Number of lab hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 287);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(250, 30);
            this.label5.TabIndex = 92;
            this.label5.Text = "Number of evaluation hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 131);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(219, 30);
            this.label6.TabIndex = 91;
            this.label6.Text = "Number of lecture hours";
            // 
            // txbxSubjCode
            // 
            this.txbxSubjCode.Location = new System.Drawing.Point(209, 139);
            this.txbxSubjCode.Name = "txbxSubjCode";
            this.txbxSubjCode.ReadOnly = true;
            this.txbxSubjCode.Size = new System.Drawing.Size(252, 22);
            this.txbxSubjCode.TabIndex = 90;
            this.toolTip1.SetToolTip(this.txbxSubjCode, "You can\'t edit this");
            // 
            // txbxSubjName
            // 
            this.txbxSubjName.Location = new System.Drawing.Point(209, 193);
            this.txbxSubjName.Name = "txbxSubjName";
            this.txbxSubjName.Size = new System.Drawing.Size(252, 22);
            this.txbxSubjName.TabIndex = 89;
            this.toolTip1.SetToolTip(this.txbxSubjName, "Enter subject name");
            this.txbxSubjName.TextChanged += new System.EventHandler(this.txbxSubjName_TextChanged);
            this.txbxSubjName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbxSubjName_KeyPress);
            // 
            // radioButton2Sem2
            // 
            this.radioButton2Sem2.AutoSize = true;
            this.radioButton2Sem2.Location = new System.Drawing.Point(344, 302);
            this.radioButton2Sem2.Name = "radioButton2Sem2";
            this.radioButton2Sem2.Size = new System.Drawing.Size(117, 21);
            this.radioButton2Sem2.TabIndex = 88;
            this.radioButton2Sem2.TabStop = true;
            this.radioButton2Sem2.Text = "2nd Semester";
            this.radioButton2Sem2.UseVisualStyleBackColor = true;
            this.radioButton2Sem2.CheckedChanged += new System.EventHandler(this.radioButton2Sem2_CheckedChanged);
            // 
            // radioButton1Sem1
            // 
            this.radioButton1Sem1.AutoSize = true;
            this.radioButton1Sem1.Location = new System.Drawing.Point(209, 302);
            this.radioButton1Sem1.Name = "radioButton1Sem1";
            this.radioButton1Sem1.Size = new System.Drawing.Size(112, 21);
            this.radioButton1Sem1.TabIndex = 87;
            this.radioButton1Sem1.TabStop = true;
            this.radioButton1Sem1.Text = "1st Semester";
            this.radioButton1Sem1.UseVisualStyleBackColor = true;
            this.radioButton1Sem1.CheckedChanged += new System.EventHandler(this.radioButton1Sem1_CheckedChanged);
            // 
            // cbxOfferdYear
            // 
            this.cbxOfferdYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOfferdYear.FormattingEnabled = true;
            this.cbxOfferdYear.Items.AddRange(new object[] {
            "1st  Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.cbxOfferdYear.Location = new System.Drawing.Point(209, 244);
            this.cbxOfferdYear.Name = "cbxOfferdYear";
            this.cbxOfferdYear.Size = new System.Drawing.Size(252, 24);
            this.cbxOfferdYear.TabIndex = 86;
            this.toolTip1.SetToolTip(this.cbxOfferdYear, "Add offered year of the subject");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 294);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label9.Size = new System.Drawing.Size(155, 30);
            this.label9.TabIndex = 85;
            this.label9.Text = "Offerd Semester";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 186);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label8.Size = new System.Drawing.Size(135, 30);
            this.label8.TabIndex = 84;
            this.label8.Text = "Subject Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 135);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(102, 30);
            this.label7.TabIndex = 83;
            this.label7.Text = "Subject ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 240);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 82;
            this.label2.Text = "Offerd Year";
            // 
            // errorProviderSubName
            // 
            this.errorProviderSubName.ContainerControl = this;
            // 
            // tbSubjectCodeNew
            // 
            this.tbSubjectCodeNew.Location = new System.Drawing.Point(209, 351);
            this.tbSubjectCodeNew.Name = "tbSubjectCodeNew";
            this.tbSubjectCodeNew.Size = new System.Drawing.Size(252, 22);
            this.tbSubjectCodeNew.TabIndex = 100;
            this.toolTip1.SetToolTip(this.tbSubjectCodeNew, "Add subject/module code . eg: IT2030 .");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 344);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label10.Size = new System.Drawing.Size(131, 30);
            this.label10.TabIndex = 99;
            this.label10.Text = "Subject Code";
            // 
            // AddSubjectUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 718);
            this.Controls.Add(this.tbSubjectCodeNew);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nUpDwnNoOfEvaluationHours);
            this.Controls.Add(this.nUpDwnNoOfLabHours);
            this.Controls.Add(this.nUpDwnNoOfTutorialHours);
            this.Controls.Add(this.nUpDwnNoOfLecturerHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbxSubjCode);
            this.Controls.Add(this.txbxSubjName);
            this.Controls.Add(this.radioButton2Sem2);
            this.Controls.Add(this.radioButton1Sem1);
            this.Controls.Add(this.cbxOfferdYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel1);
            this.Name = "AddSubjectUI";
            this.Text = "AddSubjectUI";
            this.Load += new System.EventHandler(this.AddSubjectUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnNoOfEvaluationHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnNoOfLabHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnNoOfTutorialHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDwnNoOfLecturerHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nUpDwnNoOfEvaluationHours;
        private System.Windows.Forms.NumericUpDown nUpDwnNoOfLabHours;
        private System.Windows.Forms.NumericUpDown nUpDwnNoOfTutorialHours;
        private System.Windows.Forms.NumericUpDown nUpDwnNoOfLecturerHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbxSubjCode;
        private System.Windows.Forms.TextBox txbxSubjName;
        private System.Windows.Forms.RadioButton radioButton2Sem2;
        private System.Windows.Forms.RadioButton radioButton1Sem1;
        private System.Windows.Forms.ComboBox cbxOfferdYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProviderSubName;
        private System.Windows.Forms.TextBox tbSubjectCodeNew;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}
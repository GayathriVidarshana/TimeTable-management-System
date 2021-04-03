
namespace TimeTable_management_System
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnManageLecturer = new System.Windows.Forms.Button();
            this.btnAddSubjects = new System.Windows.Forms.Button();
            this.btnManageSubjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(93, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 765);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Lecturer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManageLecturer
            // 
            this.btnManageLecturer.Location = new System.Drawing.Point(269, 25);
            this.btnManageLecturer.Name = "btnManageLecturer";
            this.btnManageLecturer.Size = new System.Drawing.Size(141, 42);
            this.btnManageLecturer.TabIndex = 2;
            this.btnManageLecturer.Text = "Manage Lecturer";
            this.btnManageLecturer.UseVisualStyleBackColor = true;
            this.btnManageLecturer.Click += new System.EventHandler(this.btnManageLecturer_Click);
            // 
            // btnAddSubjects
            // 
            this.btnAddSubjects.Location = new System.Drawing.Point(461, 25);
            this.btnAddSubjects.Name = "btnAddSubjects";
            this.btnAddSubjects.Size = new System.Drawing.Size(141, 42);
            this.btnAddSubjects.TabIndex = 3;
            this.btnAddSubjects.Text = "Add Subjects";
            this.btnAddSubjects.UseVisualStyleBackColor = true;
            this.btnAddSubjects.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnManageSubjects
            // 
            this.btnManageSubjects.Location = new System.Drawing.Point(655, 25);
            this.btnManageSubjects.Name = "btnManageSubjects";
            this.btnManageSubjects.Size = new System.Drawing.Size(141, 42);
            this.btnManageSubjects.TabIndex = 4;
            this.btnManageSubjects.Text = "Manage Subjects";
            this.btnManageSubjects.UseVisualStyleBackColor = true;
            this.btnManageSubjects.Click += new System.EventHandler(this.btnManageSubjects_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 853);
            this.Controls.Add(this.btnManageSubjects);
            this.Controls.Add(this.btnAddSubjects);
            this.Controls.Add(this.btnManageLecturer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnManageLecturer;
        private System.Windows.Forms.Button btnAddSubjects;
        private System.Windows.Forms.Button btnManageSubjects;
    }
}


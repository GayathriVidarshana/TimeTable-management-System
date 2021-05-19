
namespace TimeTable_management_System.views_UI_
{
    partial class tag
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDBindingSource = new System.Windows.Forms.BindingSource(this.components);
           // this.tTMSDataSet1 = new TimeTable_management_System.TTMSDataSet1();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tagBindingSource = new System.Windows.Forms.BindingSource(this.components);
          //  this.tTMSDataSet = new TimeTable_management_System.TTMSDataSet();
          //  this.tagTableAdapter = new TimeTable_management_System.TTMSDataSetTableAdapters.TagTableAdapter();
            this.tTMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
           // this.tag_DTableAdapter = new TimeTable_management_System.TTMSDataSet1TableAdapters.Tag_DTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagDBindingSource)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.tTMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.tTMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTMSDataSetBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtTag);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 766);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tagCodeDataGridViewTextBoxColumn,
            this.tagNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tagDBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(116, 166);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(577, 345);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // tagCodeDataGridViewTextBoxColumn
            // 
            this.tagCodeDataGridViewTextBoxColumn.DataPropertyName = "Tag_Code";
            this.tagCodeDataGridViewTextBoxColumn.HeaderText = "Tag_Code";
            this.tagCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tagCodeDataGridViewTextBoxColumn.Name = "tagCodeDataGridViewTextBoxColumn";
            this.tagCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tagCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tagNameDataGridViewTextBoxColumn
            // 
            this.tagNameDataGridViewTextBoxColumn.DataPropertyName = "Tag_Name";
            this.tagNameDataGridViewTextBoxColumn.HeaderText = "Tag_Name";
            this.tagNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tagNameDataGridViewTextBoxColumn.Name = "tagNameDataGridViewTextBoxColumn";
            this.tagNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tagNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // tagDBindingSource
            // 
            this.tagDBindingSource.DataMember = "Tag_D";
            //this.tagDBindingSource.DataSource = this.tTMSDataSet1;
            // 
            // tTMSDataSet1
            // 
           // this.tTMSDataSet1.DataSetName = "TTMSDataSet1";
           // this.tTMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::TimeTable_management_System.Properties.Resources.clear;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(719, 596);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::TimeTable_management_System.Properties.Resources.Save;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(719, 530);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "ADD TAG";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::TimeTable_management_System.Properties.Resources.update;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(719, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::TimeTable_management_System.Properties.Resources.Delete;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(719, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(297, 585);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 30);
            this.txtName.TabIndex = 2;
            // 
            // txtTag
            // 
            this.txtTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTag.Location = new System.Drawing.Point(297, 535);
            this.txtTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(159, 30);
            this.txtTag.TabIndex = 2;
            this.txtTag.TextChanged += new System.EventHandler(this.txtTag_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tag Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tag Code";
            // 
            // tagBindingSource
            // 
            this.tagBindingSource.DataMember = "Tag";
            //this.tagBindingSource.DataSource = this.tTMSDataSet;
            // 
            // tTMSDataSet
            // 
           // this.tTMSDataSet.DataSetName = "TTMSDataSet";
           // this.tTMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tagTableAdapter
            // 
         //   this.tagTableAdapter.ClearBeforeFill = true;
            // 
            // tTMSDataSetBindingSource
            // 
     //       this.tTMSDataSetBindingSource.DataSource = this.tTMSDataSet;
            this.tTMSDataSetBindingSource.Position = 0;
            // 
            // tag_DTableAdapter
            // 
      //      this.tag_DTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 63);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(232, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tag Management";
            // 
            // tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 766);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "tag";
            this.Text = "tag";
            this.Load += new System.EventHandler(this.tag_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagDBindingSource)).EndInit();
         //   ((System.ComponentModel.ISupportInitialize)(this.tTMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.tTMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTMSDataSetBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
      //  private TTMSDataSet tTMSDataSet;
        private System.Windows.Forms.BindingSource tagBindingSource;
       // private TTMSDataSetTableAdapters.TagTableAdapter tagTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tTMSDataSetBindingSource;
       // private TTMSDataSet1 tTMSDataSet1;
        private System.Windows.Forms.BindingSource tagDBindingSource;
        //private TTMSDataSet1TableAdapters.Tag_DTableAdapter tag_DTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}
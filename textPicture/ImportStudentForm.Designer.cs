namespace textPicture
{
    partial class ImportStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_StudentList = new System.Windows.Forms.DataGridView();
            this.sTUDENTDETAILBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.universityManageDataSet5 = new textPicture.UniversityManageDataSet5();
            this.sTUDENTDETAILBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.universityManageDataSet1 = new textPicture.UniversityManageDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Import = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentManageDataSet = new textPicture.StudentManageDataSet();
            this.studentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDetailTableAdapter = new textPicture.StudentManageDataSetTableAdapters.StudentDetailTableAdapter();
            this.universityManageDataSet = new textPicture.UniversityManageDataSet();
            this.universityManageDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityManageDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTDETAILTableAdapter1 = new textPicture.UniversityManageDataSet1TableAdapters.STUDENTDETAILTableAdapter();
            this.sTUDENTDETAILTableAdapter2 = new textPicture.UniversityManageDataSet5TableAdapters.STUDENTDETAILTableAdapter();
            this.btn_CheckData = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDETAILBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDETAILBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Import Student";
            // 
            // dgv_StudentList
            // 
            this.dgv_StudentList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_StudentList.ColumnHeadersHeight = 30;
            this.dgv_StudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Address,
            this.Column7,
            this.Column8});
            this.dgv_StudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_StudentList.Location = new System.Drawing.Point(0, 50);
            this.dgv_StudentList.Name = "dgv_StudentList";
            this.dgv_StudentList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_StudentList.RowHeadersWidth = 70;
            this.dgv_StudentList.RowTemplate.Height = 50;
            this.dgv_StudentList.Size = new System.Drawing.Size(1034, 461);
            this.dgv_StudentList.TabIndex = 6;
            // 
            // sTUDENTDETAILBindingSource2
            // 
            this.sTUDENTDETAILBindingSource2.DataMember = "STUDENTDETAIL";
            this.sTUDENTDETAILBindingSource2.DataSource = this.universityManageDataSet5;
            // 
            // universityManageDataSet5
            // 
            this.universityManageDataSet5.DataSetName = "UniversityManageDataSet5";
            this.universityManageDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTDETAILBindingSource1
            // 
            this.sTUDENTDETAILBindingSource1.DataMember = "STUDENTDETAIL";
            this.sTUDENTDETAILBindingSource1.DataSource = this.universityManageDataSet1;
            // 
            // universityManageDataSet1
            // 
            this.universityManageDataSet1.DataSetName = "UniversityManageDataSet1";
            this.universityManageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btn_CheckData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 50);
            this.panel2.TabIndex = 5;
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(526, 3);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(81, 36);
            this.btn_Import.TabIndex = 3;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.btn_Import);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 50);
            this.panel1.TabIndex = 4;
            // 
            // studentManageDataSet
            // 
            this.studentManageDataSet.DataSetName = "StudentManageDataSet";
            this.studentManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailBindingSource
            // 
            this.studentDetailBindingSource.DataMember = "StudentDetail";
            this.studentDetailBindingSource.DataSource = this.studentManageDataSet;
            // 
            // studentDetailTableAdapter
            // 
            this.studentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // universityManageDataSet
            // 
            this.universityManageDataSet.DataSetName = "UniversityManageDataSet";
            this.universityManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // universityManageDataSetBindingSource
            // 
            this.universityManageDataSetBindingSource.DataSource = this.universityManageDataSet;
            this.universityManageDataSetBindingSource.Position = 0;
            // 
            // universityManageDataSetBindingSource1
            // 
            this.universityManageDataSetBindingSource1.DataSource = this.universityManageDataSet;
            this.universityManageDataSetBindingSource1.Position = 0;
            // 
            // sTUDENTDETAILTableAdapter1
            // 
            this.sTUDENTDETAILTableAdapter1.ClearBeforeFill = true;
            // 
            // sTUDENTDETAILTableAdapter2
            // 
            this.sTUDENTDETAILTableAdapter2.ClearBeforeFill = true;
            // 
            // btn_CheckData
            // 
            this.btn_CheckData.Location = new System.Drawing.Point(371, 3);
            this.btn_CheckData.Name = "btn_CheckData";
            this.btn_CheckData.Size = new System.Drawing.Size(81, 36);
            this.btn_CheckData.TabIndex = 4;
            this.btn_CheckData.Text = "Check";
            this.btn_CheckData.UseVisualStyleBackColor = true;
            this.btn_CheckData.Click += new System.EventHandler(this.btn_CheckData_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(509, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(81, 36);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "First";
            this.Column2.HeaderText = "First Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 121;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Last";
            this.Column3.HeaderText = "Last Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "Birth";
            this.Column4.HeaderText = "DOB";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 76;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "Gender";
            this.Column5.HeaderText = "Gender";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 93;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "NewPhone";
            this.Column6.HeaderText = "Phone";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 85;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "Email";
            this.Column7.HeaderText = "Email";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.DataPropertyName = "ImageFromPath";
            this.Column8.HeaderText = "Image";
            this.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 83;
            // 
            // ImportStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.dgv_StudentList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImportStudentForm";
            this.Text = "ImportStudentForm";
            this.Load += new System.EventHandler(this.ImportStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDETAILBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDETAILBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_StudentList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Panel panel1;
        private StudentManageDataSet studentManageDataSet;
        private System.Windows.Forms.BindingSource studentDetailBindingSource;
        private StudentManageDataSetTableAdapters.StudentDetailTableAdapter studentDetailTableAdapter;
        private System.Windows.Forms.BindingSource universityManageDataSetBindingSource1;
        private UniversityManageDataSet universityManageDataSet;
        private System.Windows.Forms.BindingSource universityManageDataSetBindingSource;
        private UniversityManageDataSet1 universityManageDataSet1;
        private System.Windows.Forms.BindingSource sTUDENTDETAILBindingSource1;
        private UniversityManageDataSet1TableAdapters.STUDENTDETAILTableAdapter sTUDENTDETAILTableAdapter1;
        private UniversityManageDataSet5 universityManageDataSet5;
        private System.Windows.Forms.BindingSource sTUDENTDETAILBindingSource2;
        private UniversityManageDataSet5TableAdapters.STUDENTDETAILTableAdapter sTUDENTDETAILTableAdapter2;
        private System.Windows.Forms.Button btn_CheckData;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
    }
}
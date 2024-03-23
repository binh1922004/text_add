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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Import = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentManageDataSet = new textPicture.StudentManageDataSet();
            this.studentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDetailTableAdapter = new textPicture.StudentManageDataSetTableAdapters.StudentDetailTableAdapter();
            this.universityManageDataSet = new textPicture.UniversityManageDataSet();
            this.universityManageDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityManageDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.universityManageDataSet1 = new textPicture.UniversityManageDataSet1();
            this.sTUDENTDETAILBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTDETAILTableAdapter1 = new textPicture.UniversityManageDataSet1TableAdapters.STUDENTDETAILTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faceDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDETAILBindingSource1)).BeginInit();
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
            this.dgv_StudentList.AutoGenerateColumns = false;
            this.dgv_StudentList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_StudentList.ColumnHeadersHeight = 30;
            this.dgv_StudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.faceDataGridViewImageColumn});
            this.dgv_StudentList.DataSource = this.sTUDENTDETAILBindingSource1;
            this.dgv_StudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_StudentList.Location = new System.Drawing.Point(0, 50);
            this.dgv_StudentList.Name = "dgv_StudentList";
            this.dgv_StudentList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_StudentList.RowHeadersWidth = 70;
            this.dgv_StudentList.RowTemplate.Height = 50;
            this.dgv_StudentList.Size = new System.Drawing.Size(935, 461);
            this.dgv_StudentList.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 50);
            this.panel2.TabIndex = 5;
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(496, 5);
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
            this.panel1.Size = new System.Drawing.Size(935, 50);
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
            // universityManageDataSet1
            // 
            this.universityManageDataSet1.DataSetName = "UniversityManageDataSet1";
            this.universityManageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTDETAILBindingSource1
            // 
            this.sTUDENTDETAILBindingSource1.DataMember = "STUDENTDETAIL";
            this.sTUDENTDETAILBindingSource1.DataSource = this.universityManageDataSet1;
            // 
            // sTUDENTDETAILTableAdapter1
            // 
            this.sTUDENTDETAILTableAdapter1.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 117;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 121;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 93;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // faceDataGridViewImageColumn
            // 
            this.faceDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.faceDataGridViewImageColumn.DataPropertyName = "Face";
            this.faceDataGridViewImageColumn.HeaderText = "Face";
            this.faceDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.faceDataGridViewImageColumn.MinimumWidth = 6;
            this.faceDataGridViewImageColumn.Name = "faceDataGridViewImageColumn";
            // 
            // ImportStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 561);
            this.Controls.Add(this.dgv_StudentList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImportStudentForm";
            this.Text = "ImportStudentForm";
            this.Load += new System.EventHandler(this.ImportStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDETAILBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn faceDataGridViewImageColumn;
    }
}
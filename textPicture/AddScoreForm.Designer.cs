namespace textPicture
{
    partial class AddScoreForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SID = new System.Windows.Forms.TextBox();
            this.txt_Score = new System.Windows.Forms.TextBox();
            this.txt_Des = new System.Windows.Forms.TextBox();
            this.dgv_DataStudent = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTDETAILBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.universityManageDataSet4 = new textPicture.UniversityManageDataSet4();
            this.studentManageDataSet = new textPicture.StudentManageDataSet();
            this.studentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDetailTableAdapter = new textPicture.StudentManageDataSetTableAdapters.StudentDetailTableAdapter();
            this.universityManageDataSet3 = new textPicture.UniversityManageDataSet3();
            this.sTUDENTDETAILBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTDETAILTableAdapter1 = new textPicture.UniversityManageDataSet3TableAdapters.STUDENTDETAILTableAdapter();
            this.sTUDENTDETAILTableAdapter2 = new textPicture.UniversityManageDataSet4TableAdapters.STUDENTDETAILTableAdapter();
            this.cbb_Course = new System.Windows.Forms.ComboBox();
            this.btn_AddScore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDETAILBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDETAILBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select course:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description:";
            // 
            // txt_SID
            // 
            this.txt_SID.Location = new System.Drawing.Point(237, 112);
            this.txt_SID.Name = "txt_SID";
            this.txt_SID.Size = new System.Drawing.Size(215, 27);
            this.txt_SID.TabIndex = 6;
            // 
            // txt_Score
            // 
            this.txt_Score.Location = new System.Drawing.Point(237, 216);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(215, 27);
            this.txt_Score.TabIndex = 7;
            // 
            // txt_Des
            // 
            this.txt_Des.Location = new System.Drawing.Point(237, 268);
            this.txt_Des.Multiline = true;
            this.txt_Des.Name = "txt_Des";
            this.txt_Des.Size = new System.Drawing.Size(215, 153);
            this.txt_Des.TabIndex = 8;
            // 
            // dgv_DataStudent
            // 
            this.dgv_DataStudent.AutoGenerateColumns = false;
            this.dgv_DataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dgv_DataStudent.DataSource = this.sTUDENTDETAILBindingSource2;
            this.dgv_DataStudent.Location = new System.Drawing.Point(508, 112);
            this.dgv_DataStudent.Name = "dgv_DataStudent";
            this.dgv_DataStudent.RowHeadersWidth = 51;
            this.dgv_DataStudent.RowTemplate.Height = 24;
            this.dgv_DataStudent.Size = new System.Drawing.Size(342, 349);
            this.dgv_DataStudent.TabIndex = 9;
            this.dgv_DataStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DataStudent_CellClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 112;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // sTUDENTDETAILBindingSource2
            // 
            this.sTUDENTDETAILBindingSource2.DataMember = "STUDENTDETAIL";
            this.sTUDENTDETAILBindingSource2.DataSource = this.universityManageDataSet4;
            // 
            // universityManageDataSet4
            // 
            this.universityManageDataSet4.DataSetName = "UniversityManageDataSet4";
            this.universityManageDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // universityManageDataSet3
            // 
            this.universityManageDataSet3.DataSetName = "UniversityManageDataSet3";
            this.universityManageDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTDETAILBindingSource1
            // 
            this.sTUDENTDETAILBindingSource1.DataMember = "STUDENTDETAIL";
            this.sTUDENTDETAILBindingSource1.DataSource = this.universityManageDataSet3;
            // 
            // sTUDENTDETAILTableAdapter1
            // 
            this.sTUDENTDETAILTableAdapter1.ClearBeforeFill = true;
            // 
            // sTUDENTDETAILTableAdapter2
            // 
            this.sTUDENTDETAILTableAdapter2.ClearBeforeFill = true;
            // 
            // cbb_Course
            // 
            this.cbb_Course.FormattingEnabled = true;
            this.cbb_Course.Location = new System.Drawing.Point(237, 163);
            this.cbb_Course.Name = "cbb_Course";
            this.cbb_Course.Size = new System.Drawing.Size(215, 28);
            this.cbb_Course.TabIndex = 10;
            this.cbb_Course.SelectedIndexChanged += new System.EventHandler(this.cbb_Course_SelectedIndexChanged);
            // 
            // btn_AddScore
            // 
            this.btn_AddScore.Location = new System.Drawing.Point(359, 449);
            this.btn_AddScore.Name = "btn_AddScore";
            this.btn_AddScore.Size = new System.Drawing.Size(93, 41);
            this.btn_AddScore.TabIndex = 11;
            this.btn_AddScore.Text = "Add score";
            this.btn_AddScore.UseVisualStyleBackColor = true;
            this.btn_AddScore.Click += new System.EventHandler(this.btn_AddScore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(382, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add score";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 61);
            this.panel1.TabIndex = 1;
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 511);
            this.Controls.Add(this.btn_AddScore);
            this.Controls.Add(this.cbb_Course);
            this.Controls.Add(this.dgv_DataStudent);
            this.Controls.Add(this.txt_Des);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.txt_SID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDETAILBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDETAILBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SID;
        private System.Windows.Forms.TextBox txt_Score;
        private System.Windows.Forms.TextBox txt_Des;
        private System.Windows.Forms.DataGridView dgv_DataStudent;
        private StudentManageDataSet studentManageDataSet;
        private System.Windows.Forms.BindingSource studentDetailBindingSource;
        private StudentManageDataSetTableAdapters.StudentDetailTableAdapter studentDetailTableAdapter;
        private UniversityManageDataSet3 universityManageDataSet3;
        private System.Windows.Forms.BindingSource sTUDENTDETAILBindingSource1;
        private UniversityManageDataSet3TableAdapters.STUDENTDETAILTableAdapter sTUDENTDETAILTableAdapter1;
        private UniversityManageDataSet4 universityManageDataSet4;
        private System.Windows.Forms.BindingSource sTUDENTDETAILBindingSource2;
        private UniversityManageDataSet4TableAdapters.STUDENTDETAILTableAdapter sTUDENTDETAILTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbb_Course;
        private System.Windows.Forms.Button btn_AddScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
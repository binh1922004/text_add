﻿namespace textPicture
{
    partial class AdminForm
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
            this.btn_Refesh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_AC = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_StudentList = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgv_DataUser = new System.Windows.Forms.DataGridView();
            this.idTbl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityManageDataSet = new textPicture.UniversityManageDataSet();
            this.dataUserTableAdapter = new textPicture.UniversityManageDataSetTableAdapters.DataUserTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.btn_Refesh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 50);
            this.panel1.TabIndex = 4;
            // 
            // btn_Refesh
            // 
            this.btn_Refesh.Location = new System.Drawing.Point(564, 3);
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(81, 36);
            this.btn_Refesh.TabIndex = 3;
            this.btn_Refesh.Text = "Refesh";
            this.btn_Refesh.UseVisualStyleBackColor = true;
            this.btn_Refesh.Click += new System.EventHandler(this.btn_Refesh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 50);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.panel3.Controls.Add(this.btn_AC);
            this.panel3.Controls.Add(this.btn_Del);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 50);
            this.panel3.TabIndex = 6;
            // 
            // btn_AC
            // 
            this.btn_AC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_AC.Location = new System.Drawing.Point(127, 3);
            this.btn_AC.Name = "btn_AC";
            this.btn_AC.Size = new System.Drawing.Size(90, 38);
            this.btn_AC.TabIndex = 1;
            this.btn_AC.Text = "Accept";
            this.btn_AC.UseVisualStyleBackColor = false;
            this.btn_AC.Click += new System.EventHandler(this.btn_AC_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Del.Location = new System.Drawing.Point(12, 3);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(90, 38);
            this.btn_Del.TabIndex = 0;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgv_StudentList
            // 
            this.dgv_StudentList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_StudentList.ColumnHeadersHeight = 30;
            this.dgv_StudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.Column1,
            this.Column2,
            this.BirthDate,
            this.Sex,
            this.Phone,
            this.Column3,
            this.Column4});
            this.dgv_StudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_StudentList.Location = new System.Drawing.Point(0, 0);
            this.dgv_StudentList.Name = "dgv_StudentList";
            this.dgv_StudentList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_StudentList.RowHeadersWidth = 70;
            this.dgv_StudentList.RowTemplate.Height = 50;
            this.dgv_StudentList.Size = new System.Drawing.Size(677, 439);
            this.dgv_StudentList.TabIndex = 6;
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 117;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "FirstName";
            this.Column1.HeaderText = "First Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 121;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "LastName";
            this.Column2.HeaderText = "Last name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 117;
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Birth Date";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Width = 115;
            // 
            // Sex
            // 
            this.Sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Gender";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.Width = 93;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 85;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Address";
            this.Column3.HeaderText = "Address";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "Face";
            this.Column4.HeaderText = "Face";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 52;
            // 
            // dgv_DataUser
            // 
            this.dgv_DataUser.AllowUserToAddRows = false;
            this.dgv_DataUser.AllowUserToDeleteRows = false;
            this.dgv_DataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTbl,
            this.Column6,
            this.Column7,
            this.userid,
            this.Column5,
            this.stt});
            this.dgv_DataUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DataUser.Location = new System.Drawing.Point(0, 50);
            this.dgv_DataUser.Name = "dgv_DataUser";
            this.dgv_DataUser.ReadOnly = true;
            this.dgv_DataUser.RowHeadersWidth = 51;
            this.dgv_DataUser.RowTemplate.Height = 24;
            this.dgv_DataUser.Size = new System.Drawing.Size(677, 339);
            this.dgv_DataUser.TabIndex = 7;
            this.dgv_DataUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DataUser_CellClick);
            // 
            // idTbl
            // 
            this.idTbl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idTbl.DataPropertyName = "id";
            this.idTbl.HeaderText = "ID";
            this.idTbl.MinimumWidth = 6;
            this.idTbl.Name = "idTbl";
            this.idTbl.ReadOnly = true;
            this.idTbl.Width = 55;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "fname";
            this.Column6.HeaderText = "First name";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 118;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "lname";
            this.Column7.HeaderText = "Last name";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 117;
            // 
            // userid
            // 
            this.userid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "User id";
            this.userid.MinimumWidth = 6;
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Width = 92;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "role";
            this.Column5.HeaderText = "Role";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 72;
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stt.DataPropertyName = "stt";
            this.stt.HeaderText = "Status";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // dataUserBindingSource
            // 
            this.dataUserBindingSource.DataMember = "DataUser";
            this.dataUserBindingSource.DataSource = this.universityManageDataSet;
            // 
            // universityManageDataSet
            // 
            this.universityManageDataSet.DataSetName = "UniversityManageDataSet";
            this.universityManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataUserTableAdapter
            // 
            this.dataUserTableAdapter.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 439);
            this.Controls.Add(this.dgv_DataUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_StudentList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityManageDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Refesh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_StudentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridView dgv_DataUser;
        private UniversityManageDataSet universityManageDataSet;
        private System.Windows.Forms.BindingSource dataUserBindingSource;
        private UniversityManageDataSetTableAdapters.DataUserTableAdapter dataUserTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_AC;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
    }
}
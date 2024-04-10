namespace textPicture
{
    partial class PrinterForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtp_Max = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Min = new System.Windows.Forms.DateTimePicker();
            this.rbtn_RangeNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_RangeYes = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.rbtn_Female = new System.Windows.Forms.RadioButton();
            this.rbtn_All = new System.Windows.Forms.RadioButton();
            this.dgv_StudentList = new System.Windows.Forms.DataGridView();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.face = new System.Windows.Forms.DataGridViewImageColumn();
            this.select = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 50);
            this.panel2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(587, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(295, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save to file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(878, 29);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(81, 36);
            this.btn_Check.TabIndex = 3;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_Check);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 82);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Purple;
            this.panel4.Controls.Add(this.dtp_Max);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dtp_Min);
            this.panel4.Controls.Add(this.rbtn_RangeNo);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.rbtn_RangeYes);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(241, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(603, 82);
            this.panel4.TabIndex = 5;
            // 
            // dtp_Max
            // 
            this.dtp_Max.CustomFormat = "mm/dd/yyyy";
            this.dtp_Max.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Max.Location = new System.Drawing.Point(373, 42);
            this.dtp_Max.Name = "dtp_Max";
            this.dtp_Max.Size = new System.Drawing.Size(200, 27);
            this.dtp_Max.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(316, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "From";
            // 
            // dtp_Min
            // 
            this.dtp_Min.CustomFormat = "dd/MM/yyyy";
            this.dtp_Min.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Min.Location = new System.Drawing.Point(89, 40);
            this.dtp_Min.Name = "dtp_Min";
            this.dtp_Min.Size = new System.Drawing.Size(200, 27);
            this.dtp_Min.TabIndex = 8;
            // 
            // rbtn_RangeNo
            // 
            this.rbtn_RangeNo.AutoSize = true;
            this.rbtn_RangeNo.Checked = true;
            this.rbtn_RangeNo.ForeColor = System.Drawing.Color.White;
            this.rbtn_RangeNo.Location = new System.Drawing.Point(409, 6);
            this.rbtn_RangeNo.Name = "rbtn_RangeNo";
            this.rbtn_RangeNo.Size = new System.Drawing.Size(51, 24);
            this.rbtn_RangeNo.TabIndex = 7;
            this.rbtn_RangeNo.TabStop = true;
            this.rbtn_RangeNo.Text = "No";
            this.rbtn_RangeNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use datetime range?";
            // 
            // rbtn_RangeYes
            // 
            this.rbtn_RangeYes.AutoSize = true;
            this.rbtn_RangeYes.ForeColor = System.Drawing.Color.White;
            this.rbtn_RangeYes.Location = new System.Drawing.Point(330, 6);
            this.rbtn_RangeYes.Name = "rbtn_RangeYes";
            this.rbtn_RangeYes.Size = new System.Drawing.Size(58, 24);
            this.rbtn_RangeYes.TabIndex = 0;
            this.rbtn_RangeYes.Text = "Yes";
            this.rbtn_RangeYes.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.rbtn_Male);
            this.panel3.Controls.Add(this.rbtn_Female);
            this.panel3.Controls.Add(this.rbtn_All);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 82);
            this.panel3.TabIndex = 4;
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.ForeColor = System.Drawing.Color.White;
            this.rbtn_Male.Location = new System.Drawing.Point(154, 43);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(66, 24);
            this.rbtn_Male.TabIndex = 11;
            this.rbtn_Male.Text = "Male";
            this.rbtn_Male.UseVisualStyleBackColor = true;
            // 
            // rbtn_Female
            // 
            this.rbtn_Female.AutoSize = true;
            this.rbtn_Female.ForeColor = System.Drawing.Color.White;
            this.rbtn_Female.Location = new System.Drawing.Point(14, 43);
            this.rbtn_Female.Name = "rbtn_Female";
            this.rbtn_Female.Size = new System.Drawing.Size(85, 24);
            this.rbtn_Female.TabIndex = 12;
            this.rbtn_Female.Text = "Female";
            this.rbtn_Female.UseVisualStyleBackColor = true;
            // 
            // rbtn_All
            // 
            this.rbtn_All.AutoSize = true;
            this.rbtn_All.Checked = true;
            this.rbtn_All.ForeColor = System.Drawing.Color.White;
            this.rbtn_All.Location = new System.Drawing.Point(95, 13);
            this.rbtn_All.Name = "rbtn_All";
            this.rbtn_All.Size = new System.Drawing.Size(49, 24);
            this.rbtn_All.TabIndex = 10;
            this.rbtn_All.TabStop = true;
            this.rbtn_All.Text = "All";
            this.rbtn_All.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_All.UseVisualStyleBackColor = true;
            // 
            // dgv_StudentList
            // 
            this.dgv_StudentList.AllowUserToAddRows = false;
            this.dgv_StudentList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_StudentList.ColumnHeadersHeight = 50;
            this.dgv_StudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.fn,
            this.ln,
            this.dob,
            this.gender,
            this.Phone,
            this.add,
            this.email,
            this.face,
            this.select});
            this.dgv_StudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_StudentList.Location = new System.Drawing.Point(0, 82);
            this.dgv_StudentList.MultiSelect = false;
            this.dgv_StudentList.Name = "dgv_StudentList";
            this.dgv_StudentList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_StudentList.RowHeadersWidth = 20;
            this.dgv_StudentList.RowTemplate.Height = 50;
            this.dgv_StudentList.Size = new System.Drawing.Size(1000, 430);
            this.dgv_StudentList.TabIndex = 44;
            this.dgv_StudentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StudentList_CellClick);
            // 
            // sid
            // 
            this.sid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sid.DataPropertyName = "StudentID";
            this.sid.HeaderText = "Student ID";
            this.sid.MinimumWidth = 6;
            this.sid.Name = "sid";
            this.sid.Width = 108;
            // 
            // fn
            // 
            this.fn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fn.DataPropertyName = "FirstName";
            this.fn.HeaderText = "Fname";
            this.fn.MinimumWidth = 6;
            this.fn.Name = "fn";
            this.fn.Width = 89;
            // 
            // ln
            // 
            this.ln.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ln.DataPropertyName = "LastName";
            this.ln.HeaderText = "Lname";
            this.ln.MinimumWidth = 6;
            this.ln.Name = "ln";
            this.ln.Width = 89;
            // 
            // dob
            // 
            this.dob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dob.DataPropertyName = "BirthDate";
            this.dob.HeaderText = "DOB";
            this.dob.MinimumWidth = 6;
            this.dob.Name = "dob";
            this.dob.Width = 76;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gender.DataPropertyName = "Sex";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Width = 93;
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
            // add
            // 
            this.add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.add.DataPropertyName = "Address";
            this.add.HeaderText = "Address";
            this.add.MinimumWidth = 6;
            this.add.Name = "add";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 80;
            // 
            // face
            // 
            this.face.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.face.DataPropertyName = "Face";
            this.face.HeaderText = "Face";
            this.face.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.face.MinimumWidth = 6;
            this.face.Name = "face";
            this.face.Width = 52;
            // 
            // select
            // 
            this.select.HeaderText = "Select course";
            this.select.Image = global::textPicture.Properties.Resources._checked;
            this.select.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.select.MinimumWidth = 30;
            this.select.Name = "select";
            this.select.Width = 30;
            // 
            // PrinterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.dgv_StudentList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrinterForm";
            this.Text = "PrinterForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtn_Male;
        private System.Windows.Forms.RadioButton rbtn_Female;
        private System.Windows.Forms.RadioButton rbtn_All;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtn_RangeYes;
        private System.Windows.Forms.RadioButton rbtn_RangeNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Max;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_StudentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ln;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn add;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewImageColumn face;
        private System.Windows.Forms.DataGridViewImageColumn select;
    }
}
namespace textPicture
{
    partial class StudentModuleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.dtp_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.rbtn_Female = new System.Windows.Forms.RadioButton();
            this.pic_Face = new System.Windows.Forms.PictureBox();
            this.btn_Image = new System.Windows.Forms.Button();
            this.btn_FindID = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_AddCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Face)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthdate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Picture";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Address:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(157, 44);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 27);
            this.txt_ID.TabIndex = 8;
            // 
            // txt_Fname
            // 
            this.txt_Fname.Location = new System.Drawing.Point(157, 110);
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.Size = new System.Drawing.Size(207, 27);
            this.txt_Fname.TabIndex = 9;
            // 
            // txt_Lname
            // 
            this.txt_Lname.Location = new System.Drawing.Point(157, 180);
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(207, 27);
            this.txt_Lname.TabIndex = 10;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(157, 373);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(207, 27);
            this.txt_Phone.TabIndex = 11;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(472, 44);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(225, 90);
            this.txt_Address.TabIndex = 12;
            // 
            // dtp_Birthdate
            // 
            this.dtp_Birthdate.CustomFormat = "yyyy/MM/dd";
            this.dtp_Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Birthdate.Location = new System.Drawing.Point(157, 248);
            this.dtp_Birthdate.Name = "dtp_Birthdate";
            this.dtp_Birthdate.Size = new System.Drawing.Size(207, 27);
            this.dtp_Birthdate.TabIndex = 13;
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.Location = new System.Drawing.Point(157, 321);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(66, 24);
            this.rbtn_Male.TabIndex = 14;
            this.rbtn_Male.TabStop = true;
            this.rbtn_Male.Text = "Male";
            this.rbtn_Male.UseVisualStyleBackColor = true;
            // 
            // rbtn_Female
            // 
            this.rbtn_Female.AutoSize = true;
            this.rbtn_Female.Location = new System.Drawing.Point(279, 319);
            this.rbtn_Female.Name = "rbtn_Female";
            this.rbtn_Female.Size = new System.Drawing.Size(85, 24);
            this.rbtn_Female.TabIndex = 15;
            this.rbtn_Female.TabStop = true;
            this.rbtn_Female.Text = "Female";
            this.rbtn_Female.UseVisualStyleBackColor = true;
            // 
            // pic_Face
            // 
            this.pic_Face.Location = new System.Drawing.Point(472, 187);
            this.pic_Face.Name = "pic_Face";
            this.pic_Face.Size = new System.Drawing.Size(225, 168);
            this.pic_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Face.TabIndex = 16;
            this.pic_Face.TabStop = false;
            // 
            // btn_Image
            // 
            this.btn_Image.Location = new System.Drawing.Point(513, 373);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(169, 27);
            this.btn_Image.TabIndex = 17;
            this.btn_Image.Text = "Upload";
            this.btn_Image.UseVisualStyleBackColor = true;
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // btn_FindID
            // 
            this.btn_FindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_FindID.Location = new System.Drawing.Point(274, 44);
            this.btn_FindID.Name = "btn_FindID";
            this.btn_FindID.Size = new System.Drawing.Size(90, 27);
            this.btn_FindID.TabIndex = 18;
            this.btn_FindID.Text = "Find";
            this.btn_FindID.UseVisualStyleBackColor = false;
            this.btn_FindID.Click += new System.EventHandler(this.btn_FindID_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Remove.Location = new System.Drawing.Point(122, 446);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(116, 30);
            this.btn_Remove.TabIndex = 19;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Edit.Location = new System.Drawing.Point(305, 446);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(116, 30);
            this.btn_Edit.TabIndex = 20;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_AddCourse
            // 
            this.btn_AddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_AddCourse.Location = new System.Drawing.Point(494, 446);
            this.btn_AddCourse.Name = "btn_AddCourse";
            this.btn_AddCourse.Size = new System.Drawing.Size(116, 30);
            this.btn_AddCourse.TabIndex = 21;
            this.btn_AddCourse.Text = "Add course";
            this.btn_AddCourse.UseVisualStyleBackColor = false;
            this.btn_AddCourse.Click += new System.EventHandler(this.btn_AddCourse_Click);
            // 
            // StudentModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(709, 508);
            this.Controls.Add(this.btn_AddCourse);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_FindID);
            this.Controls.Add(this.btn_Image);
            this.Controls.Add(this.pic_Face);
            this.Controls.Add(this.rbtn_Female);
            this.Controls.Add(this.rbtn_Male);
            this.Controls.Add(this.dtp_Birthdate);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_Lname);
            this.Controls.Add(this.txt_Fname);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentModuleForm";
            this.Text = "StudentModuleForm";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Face)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Fname;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.DateTimePicker dtp_Birthdate;
        private System.Windows.Forms.RadioButton rbtn_Male;
        private System.Windows.Forms.RadioButton rbtn_Female;
        private System.Windows.Forms.PictureBox pic_Face;
        private System.Windows.Forms.Button btn_Image;
        private System.Windows.Forms.Button btn_FindID;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_AddCourse;
    }
}
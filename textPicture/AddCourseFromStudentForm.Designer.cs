namespace textPicture
{
    partial class AddCourseFromStudentForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_Semester = new System.Windows.Forms.ComboBox();
            this.lsb_Available = new System.Windows.Forms.ListBox();
            this.lsb_Selected = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 50);
            this.panel1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(225, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Add student";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(120, 74);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 27);
            this.txt_ID.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Available course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Selected course";
            // 
            // cbb_Semester
            // 
            this.cbb_Semester.FormattingEnabled = true;
            this.cbb_Semester.Location = new System.Drawing.Point(426, 73);
            this.cbb_Semester.Name = "cbb_Semester";
            this.cbb_Semester.Size = new System.Drawing.Size(59, 28);
            this.cbb_Semester.TabIndex = 29;
            this.cbb_Semester.SelectedIndexChanged += new System.EventHandler(this.cbb_Semester_SelectedIndexChanged);
            // 
            // lsb_Available
            // 
            this.lsb_Available.FormattingEnabled = true;
            this.lsb_Available.ItemHeight = 20;
            this.lsb_Available.Location = new System.Drawing.Point(30, 178);
            this.lsb_Available.Name = "lsb_Available";
            this.lsb_Available.Size = new System.Drawing.Size(226, 224);
            this.lsb_Available.TabIndex = 30;
            // 
            // lsb_Selected
            // 
            this.lsb_Selected.FormattingEnabled = true;
            this.lsb_Selected.ItemHeight = 20;
            this.lsb_Selected.Location = new System.Drawing.Point(330, 178);
            this.lsb_Selected.Name = "lsb_Selected";
            this.lsb_Selected.Size = new System.Drawing.Size(226, 224);
            this.lsb_Selected.TabIndex = 31;
            this.lsb_Selected.SelectedIndexChanged += new System.EventHandler(this.lsb_Selected_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(255, 419);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(81, 34);
            this.btn_Add.TabIndex = 32;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(255, 459);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(81, 34);
            this.btn_Save.TabIndex = 33;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(229, 71);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(91, 30);
            this.btn_Find.TabIndex = 34;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // AddCourseFromStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 525);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lsb_Selected);
            this.Controls.Add(this.lsb_Available);
            this.Controls.Add(this.cbb_Semester);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCourseFromStudentForm";
            this.Text = "AddCourseFromStudentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_Semester;
        private System.Windows.Forms.ListBox lsb_Available;
        private System.Windows.Forms.ListBox lsb_Selected;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Find;
    }
}
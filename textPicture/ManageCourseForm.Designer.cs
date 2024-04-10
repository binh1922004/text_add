namespace textPicture
{
    partial class ManageCourseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Label = new System.Windows.Forms.TextBox();
            this.neud_Hours = new System.Windows.Forms.NumericUpDown();
            this.txt_Des = new System.Windows.Forms.TextBox();
            this.lsb_Data = new System.Windows.Forms.ListBox();
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Pre = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.txt_Semester = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neud_Hours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 61);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(150, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hours number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(126, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Label:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(81, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Description:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(207, 107);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 27);
            this.txt_ID.TabIndex = 14;
            // 
            // txt_Label
            // 
            this.txt_Label.Location = new System.Drawing.Point(207, 171);
            this.txt_Label.Name = "txt_Label";
            this.txt_Label.Size = new System.Drawing.Size(201, 27);
            this.txt_Label.TabIndex = 15;
            // 
            // neud_Hours
            // 
            this.neud_Hours.Location = new System.Drawing.Point(207, 235);
            this.neud_Hours.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.neud_Hours.Name = "neud_Hours";
            this.neud_Hours.Size = new System.Drawing.Size(62, 27);
            this.neud_Hours.TabIndex = 16;
            this.neud_Hours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txt_Des
            // 
            this.txt_Des.Location = new System.Drawing.Point(207, 339);
            this.txt_Des.Multiline = true;
            this.txt_Des.Name = "txt_Des";
            this.txt_Des.Size = new System.Drawing.Size(201, 130);
            this.txt_Des.TabIndex = 17;
            // 
            // lsb_Data
            // 
            this.lsb_Data.FormattingEnabled = true;
            this.lsb_Data.ItemHeight = 20;
            this.lsb_Data.Location = new System.Drawing.Point(467, 105);
            this.lsb_Data.Name = "lsb_Data";
            this.lsb_Data.Size = new System.Drawing.Size(257, 324);
            this.lsb_Data.TabIndex = 18;
            this.lsb_Data.DoubleClick += new System.EventHandler(this.lsb_Data_DoubleClick);
            // 
            // btn_First
            // 
            this.btn_First.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_First.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_First.ForeColor = System.Drawing.Color.White;
            this.btn_First.Location = new System.Drawing.Point(45, 475);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(85, 33);
            this.btn_First.TabIndex = 19;
            this.btn_First.Text = "<<";
            this.btn_First.UseVisualStyleBackColor = false;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_Pre
            // 
            this.btn_Pre.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Pre.ForeColor = System.Drawing.Color.White;
            this.btn_Pre.Location = new System.Drawing.Point(162, 475);
            this.btn_Pre.Name = "btn_Pre";
            this.btn_Pre.Size = new System.Drawing.Size(85, 33);
            this.btn_Pre.TabIndex = 20;
            this.btn_Pre.Text = "<";
            this.btn_Pre.UseVisualStyleBackColor = false;
            this.btn_Pre.Click += new System.EventHandler(this.btn_Pre_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Location = new System.Drawing.Point(279, 475);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(85, 33);
            this.btn_Next.TabIndex = 21;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Last.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Last.ForeColor = System.Drawing.Color.White;
            this.btn_Last.Location = new System.Drawing.Point(396, 475);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(85, 33);
            this.btn_Last.TabIndex = 22;
            this.btn_Last.Text = ">>";
            this.btn_Last.UseVisualStyleBackColor = false;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Green;
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(128, 526);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(85, 30);
            this.btn_Add.TabIndex = 23;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Green;
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(262, 526);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(85, 30);
            this.btn_Edit.TabIndex = 24;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.Green;
            this.btn_Remove.ForeColor = System.Drawing.Color.White;
            this.btn_Remove.Location = new System.Drawing.Point(396, 526);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(85, 30);
            this.btn_Remove.TabIndex = 25;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // txt_Semester
            // 
            this.txt_Semester.Location = new System.Drawing.Point(207, 277);
            this.txt_Semester.Name = "txt_Semester";
            this.txt_Semester.Size = new System.Drawing.Size(62, 27);
            this.txt_Semester.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(95, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Semester:";
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(736, 569);
            this.Controls.Add(this.txt_Semester);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Pre);
            this.Controls.Add(this.btn_First);
            this.Controls.Add(this.lsb_Data);
            this.Controls.Add(this.txt_Des);
            this.Controls.Add(this.neud_Hours);
            this.Controls.Add(this.txt_Label);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageCourseForm";
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neud_Hours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Label;
        private System.Windows.Forms.NumericUpDown neud_Hours;
        private System.Windows.Forms.TextBox txt_Des;
        private System.Windows.Forms.ListBox lsb_Data;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Button btn_Pre;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.TextBox txt_Semester;
        private System.Windows.Forms.Label label6;
    }
}
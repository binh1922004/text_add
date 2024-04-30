namespace textPicture
{
    partial class StudentMainForm
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
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.btn_Score = new System.Windows.Forms.Button();
            this.btn_CourseReg = new System.Windows.Forms.Button();
            this.pnl_StdName = new System.Windows.Forms.Panel();
            this.lbl_StdName = new System.Windows.Forms.Label();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnl_Info.SuspendLayout();
            this.pnl_StdName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 50);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Page";
            // 
            // pnl_Info
            // 
            this.pnl_Info.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_Info.Controls.Add(this.btn_Score);
            this.pnl_Info.Controls.Add(this.btn_CourseReg);
            this.pnl_Info.Controls.Add(this.pnl_StdName);
            this.pnl_Info.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Info.Location = new System.Drawing.Point(0, 50);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(200, 581);
            this.pnl_Info.TabIndex = 6;
            // 
            // btn_Score
            // 
            this.btn_Score.BackColor = System.Drawing.Color.Navy;
            this.btn_Score.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Score.FlatAppearance.BorderSize = 0;
            this.btn_Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Score.ForeColor = System.Drawing.Color.White;
            this.btn_Score.Location = new System.Drawing.Point(0, 95);
            this.btn_Score.Name = "btn_Score";
            this.btn_Score.Size = new System.Drawing.Size(200, 55);
            this.btn_Score.TabIndex = 3;
            this.btn_Score.Text = "Score";
            this.btn_Score.UseVisualStyleBackColor = false;
            this.btn_Score.Click += new System.EventHandler(this.btn_Score_Click);
            // 
            // btn_CourseReg
            // 
            this.btn_CourseReg.BackColor = System.Drawing.Color.Navy;
            this.btn_CourseReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CourseReg.FlatAppearance.BorderSize = 0;
            this.btn_CourseReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CourseReg.ForeColor = System.Drawing.Color.White;
            this.btn_CourseReg.Location = new System.Drawing.Point(0, 40);
            this.btn_CourseReg.Name = "btn_CourseReg";
            this.btn_CourseReg.Size = new System.Drawing.Size(200, 55);
            this.btn_CourseReg.TabIndex = 2;
            this.btn_CourseReg.Text = "Course register";
            this.btn_CourseReg.UseVisualStyleBackColor = false;
            this.btn_CourseReg.Click += new System.EventHandler(this.btn_CourseReg_Click);
            // 
            // pnl_StdName
            // 
            this.pnl_StdName.Controls.Add(this.lbl_StdName);
            this.pnl_StdName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_StdName.Location = new System.Drawing.Point(0, 0);
            this.pnl_StdName.Name = "pnl_StdName";
            this.pnl_StdName.Size = new System.Drawing.Size(200, 40);
            this.pnl_StdName.TabIndex = 1;
            // 
            // lbl_StdName
            // 
            this.lbl_StdName.AutoSize = true;
            this.lbl_StdName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_StdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_StdName.ForeColor = System.Drawing.Color.White;
            this.lbl_StdName.Location = new System.Drawing.Point(0, 0);
            this.lbl_StdName.Name = "lbl_StdName";
            this.lbl_StdName.Size = new System.Drawing.Size(127, 29);
            this.lbl_StdName.TabIndex = 1;
            this.lbl_StdName.Text = "Welcome: ";
            // 
            // pnl_Main
            // 
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(200, 50);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(736, 581);
            this.pnl_Main.TabIndex = 7;
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 631);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Info);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            this.Load += new System.EventHandler(this.StudentMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Info.ResumeLayout(false);
            this.pnl_StdName.ResumeLayout(false);
            this.pnl_StdName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Panel pnl_StdName;
        private System.Windows.Forms.Label lbl_StdName;
        private System.Windows.Forms.Button btn_CourseReg;
        private System.Windows.Forms.Button btn_Score;
        private System.Windows.Forms.Panel pnl_Main;
    }
}
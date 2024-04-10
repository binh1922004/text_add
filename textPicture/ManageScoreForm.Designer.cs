namespace textPicture
{
    partial class ManageScoreForm
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
            this.btn_AddScore = new System.Windows.Forms.Button();
            this.cbb_Course = new System.Windows.Forms.ComboBox();
            this.dgv_DataStudent = new System.Windows.Forms.DataGridView();
            this.txt_Des = new System.Windows.Forms.TextBox();
            this.txt_Score = new System.Windows.Forms.TextBox();
            this.txt_SID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_ShowStudent = new System.Windows.Forms.Button();
            this.btn_ShowScore = new System.Windows.Forms.Button();
            this.dgv_DataScore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataStudent)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataScore)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddScore
            // 
            this.btn_AddScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_AddScore.Location = new System.Drawing.Point(78, 459);
            this.btn_AddScore.Name = "btn_AddScore";
            this.btn_AddScore.Size = new System.Drawing.Size(93, 41);
            this.btn_AddScore.TabIndex = 22;
            this.btn_AddScore.Text = "Add score";
            this.btn_AddScore.UseVisualStyleBackColor = false;
            // 
            // cbb_Course
            // 
            this.cbb_Course.FormattingEnabled = true;
            this.cbb_Course.Location = new System.Drawing.Point(173, 168);
            this.cbb_Course.Name = "cbb_Course";
            this.cbb_Course.Size = new System.Drawing.Size(215, 28);
            this.cbb_Course.TabIndex = 21;
            // 
            // dgv_DataStudent
            // 
            this.dgv_DataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataStudent.Location = new System.Drawing.Point(438, 139);
            this.dgv_DataStudent.Name = "dgv_DataStudent";
            this.dgv_DataStudent.RowHeadersWidth = 51;
            this.dgv_DataStudent.RowTemplate.Height = 24;
            this.dgv_DataStudent.Size = new System.Drawing.Size(356, 349);
            this.dgv_DataStudent.TabIndex = 20;
            this.dgv_DataStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DataStudent_CellClick);
            // 
            // txt_Des
            // 
            this.txt_Des.Location = new System.Drawing.Point(173, 273);
            this.txt_Des.Multiline = true;
            this.txt_Des.Name = "txt_Des";
            this.txt_Des.Size = new System.Drawing.Size(215, 153);
            this.txt_Des.TabIndex = 19;
            // 
            // txt_Score
            // 
            this.txt_Score.Location = new System.Drawing.Point(173, 221);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(215, 27);
            this.txt_Score.TabIndex = 18;
            // 
            // txt_SID
            // 
            this.txt_SID.Location = new System.Drawing.Point(173, 117);
            this.txt_SID.Name = "txt_SID";
            this.txt_SID.Size = new System.Drawing.Size(215, 27);
            this.txt_SID.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Student ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 61);
            this.panel1.TabIndex = 12;
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
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.Yellow;
            this.btn_Remove.Location = new System.Drawing.Point(214, 459);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(93, 41);
            this.btn_Remove.TabIndex = 23;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_ShowStudent
            // 
            this.btn_ShowStudent.BackColor = System.Drawing.Color.Yellow;
            this.btn_ShowStudent.Location = new System.Drawing.Point(438, 92);
            this.btn_ShowStudent.Name = "btn_ShowStudent";
            this.btn_ShowStudent.Size = new System.Drawing.Size(175, 41);
            this.btn_ShowStudent.TabIndex = 24;
            this.btn_ShowStudent.Text = "Show students";
            this.btn_ShowStudent.UseVisualStyleBackColor = false;
            this.btn_ShowStudent.Click += new System.EventHandler(this.btn_ShowStudent_Click);
            // 
            // btn_ShowScore
            // 
            this.btn_ShowScore.BackColor = System.Drawing.Color.Yellow;
            this.btn_ShowScore.Location = new System.Drawing.Point(619, 92);
            this.btn_ShowScore.Name = "btn_ShowScore";
            this.btn_ShowScore.Size = new System.Drawing.Size(175, 41);
            this.btn_ShowScore.TabIndex = 25;
            this.btn_ShowScore.Text = "Show score";
            this.btn_ShowScore.UseVisualStyleBackColor = false;
            this.btn_ShowScore.Click += new System.EventHandler(this.btn_ShowScore_Click);
            // 
            // dgv_DataScore
            // 
            this.dgv_DataScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataScore.Location = new System.Drawing.Point(438, 139);
            this.dgv_DataScore.Name = "dgv_DataScore";
            this.dgv_DataScore.RowHeadersWidth = 51;
            this.dgv_DataScore.RowTemplate.Height = 24;
            this.dgv_DataScore.Size = new System.Drawing.Size(356, 349);
            this.dgv_DataScore.TabIndex = 26;
            this.dgv_DataScore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DataScore_CellClick);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 593);
            this.Controls.Add(this.dgv_DataScore);
            this.Controls.Add(this.btn_ShowScore);
            this.Controls.Add(this.btn_ShowStudent);
            this.Controls.Add(this.btn_Remove);
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
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddScore;
        private System.Windows.Forms.ComboBox cbb_Course;
        private System.Windows.Forms.DataGridView dgv_DataStudent;
        private System.Windows.Forms.TextBox txt_Des;
        private System.Windows.Forms.TextBox txt_Score;
        private System.Windows.Forms.TextBox txt_SID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_ShowStudent;
        private System.Windows.Forms.Button btn_ShowScore;
        private System.Windows.Forms.DataGridView dgv_DataScore;
    }
}
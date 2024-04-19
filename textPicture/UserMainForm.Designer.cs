﻿namespace textPicture
{
    partial class UserMainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AddGroupName = new System.Windows.Forms.TextBox();
            this.txt_AddGroupID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_EditGroup = new System.Windows.Forms.ComboBox();
            this.txt_EditGroupName = new System.Windows.Forms.TextBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.cbb_RemoveGroup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 61);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remove course";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(405, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 563);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Group name:";
            // 
            // txt_AddGroupName
            // 
            this.txt_AddGroupName.Location = new System.Drawing.Point(588, 105);
            this.txt_AddGroupName.Name = "txt_AddGroupName";
            this.txt_AddGroupName.Size = new System.Drawing.Size(189, 27);
            this.txt_AddGroupName.TabIndex = 13;
            // 
            // txt_AddGroupID
            // 
            this.txt_AddGroupID.Location = new System.Drawing.Point(588, 148);
            this.txt_AddGroupID.Name = "txt_AddGroupID";
            this.txt_AddGroupID.Size = new System.Drawing.Size(64, 27);
            this.txt_AddGroupID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Group id:";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Add.Location = new System.Drawing.Point(562, 195);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(119, 28);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "New group name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Select group name:";
            // 
            // cbb_EditGroup
            // 
            this.cbb_EditGroup.FormattingEnabled = true;
            this.cbb_EditGroup.Location = new System.Drawing.Point(588, 274);
            this.cbb_EditGroup.Name = "cbb_EditGroup";
            this.cbb_EditGroup.Size = new System.Drawing.Size(189, 28);
            this.cbb_EditGroup.TabIndex = 19;
            // 
            // txt_EditGroupName
            // 
            this.txt_EditGroupName.Location = new System.Drawing.Point(588, 320);
            this.txt_EditGroupName.Name = "txt_EditGroupName";
            this.txt_EditGroupName.Size = new System.Drawing.Size(189, 27);
            this.txt_EditGroupName.TabIndex = 20;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Edit.Location = new System.Drawing.Point(562, 383);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(119, 28);
            this.btn_Edit.TabIndex = 21;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            // 
            // cbb_RemoveGroup
            // 
            this.cbb_RemoveGroup.FormattingEnabled = true;
            this.cbb_RemoveGroup.Location = new System.Drawing.Point(588, 472);
            this.cbb_RemoveGroup.Name = "cbb_RemoveGroup";
            this.cbb_RemoveGroup.Size = new System.Drawing.Size(189, 28);
            this.cbb_RemoveGroup.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Select group name:";
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Remove.Location = new System.Drawing.Point(562, 546);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(119, 28);
            this.btn_Remove.TabIndex = 24;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(27, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(27, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 28);
            this.button2.TabIndex = 25;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(802, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.cbb_RemoveGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.txt_EditGroupName);
            this.Controls.Add(this.cbb_EditGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_AddGroupID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_AddGroupName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserMainForm";
            this.Text = "UserMainForm";
            this.Load += new System.EventHandler(this.UserMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AddGroupName;
        private System.Windows.Forms.TextBox txt_AddGroupID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_EditGroup;
        private System.Windows.Forms.TextBox txt_EditGroupName;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.ComboBox cbb_RemoveGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
namespace textPicture
{
    partial class RegisterForm
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tt_User = new System.Windows.Forms.ToolTip(this.components);
            this.tt_Pass = new System.Windows.Forms.ToolTip(this.components);
            this.err_User = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_Repass = new System.Windows.Forms.TextBox();
            this.btn_Code = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_User)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(171, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Account Register";
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::textPicture.Properties.Resources.logofit;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Image = global::textPicture.Properties.Resources.logofit;
            this.picLogo.Location = new System.Drawing.Point(67, 69);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(69, 53);
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // tt_User
            // 
            this.tt_User.IsBalloon = true;
            this.tt_User.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_User.ToolTipTitle = "Login";
            // 
            // tt_Pass
            // 
            this.tt_Pass.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_Pass.ToolTipTitle = "Password";
            // 
            // err_User
            // 
            this.err_User.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Re-password";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(101, 163);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(283, 27);
            this.txt_Mail.TabIndex = 16;
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(101, 195);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(105, 27);
            this.txt_Code.TabIndex = 17;
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(142, 260);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(283, 27);
            this.txt_User.TabIndex = 18;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(142, 297);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(283, 27);
            this.txt_Pass.TabIndex = 19;
            // 
            // txt_Repass
            // 
            this.txt_Repass.Location = new System.Drawing.Point(142, 338);
            this.txt_Repass.Name = "txt_Repass";
            this.txt_Repass.Size = new System.Drawing.Size(283, 27);
            this.txt_Repass.TabIndex = 20;
            // 
            // btn_Code
            // 
            this.btn_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Code.Location = new System.Drawing.Point(390, 163);
            this.btn_Code.Name = "btn_Code";
            this.btn_Code.Size = new System.Drawing.Size(102, 27);
            this.btn_Code.TabIndex = 21;
            this.btn_Code.Text = "Send code";
            this.btn_Code.UseVisualStyleBackColor = false;
            this.btn_Code.Click += new System.EventHandler(this.btn_Code_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(207, 383);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(96, 38);
            this.btn_Enter.TabIndex = 22;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 464);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.btn_Code);
            this.Controls.Add(this.txt_Repass);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip tt_Pass;
        private System.Windows.Forms.ErrorProvider err_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ToolTip tt_User;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Repass;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Button btn_Code;
        private System.Windows.Forms.Button btn_Enter;
    }
}
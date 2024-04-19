namespace textPicture
{
    partial class Loginform
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
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tt_User = new System.Windows.Forms.ToolTip(this.components);
            this.tt_Pass = new System.Windows.Forms.ToolTip(this.components);
            this.err_User = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Reg = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.rbtn_User = new System.Windows.Forms.RadioButton();
            this.rbtn_Std = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.err_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(166, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Login";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(57, 154);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(53, 25);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "User";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(57, 228);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(98, 25);
            this.lbPass.TabIndex = 3;
            this.lbPass.Text = "Password";
            // 
            // txtUser
            // 
            this.err_User.SetError(this.txtUser, "Please enter your user");
            this.txtUser.Location = new System.Drawing.Point(242, 156);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(175, 30);
            this.txtUser.TabIndex = 4;
            this.tt_User.SetToolTip(this.txtUser, "Blank is not valid");
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(242, 223);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(175, 30);
            this.txtPass.TabIndex = 5;
            this.tt_Pass.SetToolTip(this.txtPass, "Blank is not valid");
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(119, 334);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 41);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(281, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 41);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            // btn_Reg
            // 
            this.btn_Reg.Location = new System.Drawing.Point(202, 390);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(102, 41);
            this.btn_Reg.TabIndex = 8;
            this.btn_Reg.Text = "Register";
            this.btn_Reg.UseVisualStyleBackColor = true;
            this.btn_Reg.Click += new System.EventHandler(this.btn_Reg_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::textPicture.Properties.Resources.logofit;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Image = global::textPicture.Properties.Resources.logofit;
            this.picLogo.Location = new System.Drawing.Point(62, 37);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(69, 53);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // rbtn_User
            // 
            this.rbtn_User.AutoSize = true;
            this.rbtn_User.Location = new System.Drawing.Point(118, 284);
            this.rbtn_User.Name = "rbtn_User";
            this.rbtn_User.Size = new System.Drawing.Size(74, 29);
            this.rbtn_User.TabIndex = 9;
            this.rbtn_User.TabStop = true;
            this.rbtn_User.Text = "User";
            this.rbtn_User.UseVisualStyleBackColor = true;
            // 
            // rbtn_Std
            // 
            this.rbtn_Std.AutoSize = true;
            this.rbtn_Std.Location = new System.Drawing.Point(281, 284);
            this.rbtn_Std.Name = "rbtn_Std";
            this.rbtn_Std.Size = new System.Drawing.Size(101, 29);
            this.rbtn_Std.TabIndex = 10;
            this.rbtn_Std.TabStop = true;
            this.rbtn_Std.Text = "Student";
            this.rbtn_Std.UseVisualStyleBackColor = true;
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 463);
            this.Controls.Add(this.rbtn_Std);
            this.Controls.Add(this.rbtn_User);
            this.Controls.Add(this.btn_Reg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Loginform";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip tt_User;
        private System.Windows.Forms.ToolTip tt_Pass;
        private System.Windows.Forms.ErrorProvider err_User;
        private System.Windows.Forms.Button btn_Reg;
        private System.Windows.Forms.RadioButton rbtn_Std;
        private System.Windows.Forms.RadioButton rbtn_User;
    }
}


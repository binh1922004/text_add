using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class Loginform : Form
    {
        User user = new User();
        public Loginform()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) 
        {
            string userid = txtUser.Text;
            string pass = txtPass.Text;
            if (rbtn_Admin.Checked)
                GlobalClass.role = "admin";
            else if (rbtn_Std.Checked)
                GlobalClass.role = "std";
            else
                GlobalClass.role = "hr";


            if (!user.loginCheck(userid, pass))
            {
                return;
            }

            if (rbtn_Std.Checked)
            {
                StudentMainForm stdMainForm = new StudentMainForm();   
                this.Hide();
                stdMainForm.ShowDialog();
                this.Close();
            }
            else if (rbtn_User.Checked)
            {
                UserMainForm mainUserForm = new UserMainForm();
                mainUserForm.ShowDialog();
                this.Close();
            }
            else
            {
                MainForm main = new MainForm("admin");
                main.ShowDialog();
                this.Close();
            }
            //timer1.Start();
        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
            if (rbtn_Std.Checked)
            {
                GlobalClass.role = "std";
            }
            else if (rbtn_Admin.Checked)
            {
                GlobalClass.role = "admin";
            }
            else
            {
                GlobalClass.role = "hr";
                
            }
            RegisterUserForm registerForm = new RegisterUserForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}

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
            if (rbtn_Std.Checked)
            {
                MyDB db = new MyDB();

                SqlCommand sqlCmd = new SqlCommand("select * from DataUser " +
      "where(ID = @ID AND Pass = @Pass)", db.SqlCon);
                sqlCmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.NChar)).Value = userid;
                sqlCmd.Parameters.Add(new SqlParameter("@Pass", SqlDbType.NChar)).Value = pass;
                db.OpenConnection();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    string stt = reader.GetString(2).Trim();
                    if (stt != "waiting")
                    {
                        MainForm mainForm = new MainForm(stt);
                        mainForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("This account is not accept");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid user or password, please enter again");
                }
                reader.Close();
                db.CloseConnection();
            }
            else if (rbtn_User.Checked)
            {
                if (user.loginCheck(userid, pass))
                {
                    UserMainForm mainUserForm = new UserMainForm();
                    mainUserForm.ShowDialog();
                    this.Close();
                }
            }
            //timer1.Start();
        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
            if (rbtn_Std.Checked)
            {
                RegisterForm registerForm = new RegisterForm();
                this.Hide();
                registerForm.ShowDialog();
                this.Show();
            }
            else
            {
                RegisterUserForm registerForm = new RegisterUserForm();
                this.Hide();
                registerForm.ShowDialog();
                this.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}

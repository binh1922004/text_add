using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class RegisterForm : Form
    {
        SendMail mailforcode = new SendMail();
        int otp = -1;
        MyDB db = new MyDB();
        public RegisterForm()
        {
            InitializeComponent();
        }
        

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Code_Click(object sender, EventArgs e)
        {
            otp = mailforcode.Work(txt_Mail.Text);
            btn_Enter.Enabled = true;

            
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (txt_Code.Text == otp.ToString())
            {
                if (verif())
                {
                    string user = txt_User.Text.Trim();
                    string query = "select * from DataUser where ID = '" + user + "'";
                    SqlCommand cmd = new SqlCommand(query, db.SqlCon);
                    db.OpenConnection();
                    SqlDataReader reader = cmd.ExecuteReader();
                    int t = 0;
                    while (reader.Read())
                    {
                        t++;
                    }

                    reader.Close();
                    db.CloseConnection();   
                    if (t > 0)
                    {
                        MessageBox.Show("This user is used");
                    }
                    else
                    {
                        if (inserDataUser(user, txt_Pass.Text))
                        {
                            MessageBox.Show("Successfull Register");
                        }
                        else
                            MessageBox.Show("Failed");
                    }
                }
            }
            else
                MessageBox.Show("Wrong code, please enter again");
            
        }

        private bool inserDataUser(string user, string pass)
        {
            string query = "insert into DataUser values(@id, @pass, 'waiting')";
            SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
            sqlCmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Char)).Value = user;
            sqlCmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.Char)).Value = pass;
            
            db.OpenConnection();
            int k = sqlCmd.ExecuteNonQuery();
            if (k > 0)
                return true;
            return false;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            btn_Enter.Enabled = false;
        }

        bool verif()
        {
            if (txt_User.Text.Trim() is null || txt_Pass.Text.Trim() is null)
            {
                MessageBox.Show("Invalid user or password");
                return false;
            }
            else if (txt_Pass.Text != txt_Repass.Text)
            {
                MessageBox.Show("Pass is diffirent Re-pass");
                return false;
            }
            return true;
        }
    }
}

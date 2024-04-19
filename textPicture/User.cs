using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    internal class User
    {
        MyDB db = new MyDB();

        #region check data
        public bool verif(string id, string fn, string ln, string user, string pass)
        {
            if (id.Trim() == "" || fn.Trim() == "" || ln.Trim() == "" || user.Trim() == "" || pass.Trim() == "")
            {
                MessageBox.Show("Please enter character");
                return false;
            }
            else if (fn.Any(char.IsDigit) || fn.Any(char.IsDigit))
            {
                MessageBox.Show("Please dont enter number in last name or first name");
                return false;
            }
            else if (!id.All(char.IsDigit))
            {
                MessageBox.Show("Please enter number in id");
                return false;
            }
            else if (existUser(id, user))
            {
                MessageBox.Show("This user or id have already exist");
                return false;
            }

            return true;
        }

        public bool existUser(string id, string user)
        {
            string query = "select * from UserData where id = @id and userid = @user";
            SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
            sqlCmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;
            sqlCmd.Parameters.Add(new SqlParameter("@user", System.Data.SqlDbType.VarChar)).Value = user;
            db.OpenConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            db.CloseConnection();
            return dt.Rows.Count > 0;

        }
        #endregion check data

        public void insertUser(string id, string fn, string ln, string user, string pass, MemoryStream pic)
        {
            try
            {
                if (verif(id, fn, ln, user, pass))
                {
                    string query = "insert into UserData values(@id, @fn, @ln, @user, @pass, @img)";
                    SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
                    sqlCmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = id;
                    sqlCmd.Parameters.Add(new SqlParameter("@fn", SqlDbType.VarChar)).Value = fn;
                    sqlCmd.Parameters.Add(new SqlParameter("@ln", SqlDbType.VarChar)).Value = ln ;
                    sqlCmd.Parameters.Add(new SqlParameter("@user", SqlDbType.VarChar)).Value = user;
                    sqlCmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar)).Value = pass;
                    sqlCmd.Parameters.Add(new SqlParameter("@img", SqlDbType.Image)).Value = pic.ToArray();
                    db.OpenConnection();
                    int k = sqlCmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        MessageBox.Show("Successfully reg");
                        
                    }
                    else
                    {
                        MessageBox.Show("Something wrong");
                    }
                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool loginCheck(string user, string pas)
        {
            string query = "select * from UserData where pass = @pas and userid = @user";
            SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
            sqlCmd.Parameters.Add(new SqlParameter("@pas", System.Data.SqlDbType.VarChar)).Value = pas;
            sqlCmd.Parameters.Add(new SqlParameter("@user", System.Data.SqlDbType.VarChar)).Value = user;
            db.OpenConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            db.CloseConnection();
            if (dt.Rows.Count > 0)
            {
                GlobalClass.userID = dt.Rows[0]["id"].ToString();
                GlobalClass.userName = dt.Rows[0]["fname"].ToString();
                var data = (byte[])dt.Rows[0]["Img"];
                var pic = new MemoryStream(data);
                GlobalClass.img = Image.FromStream(pic);
                return true;
            }
            else
            {
                MessageBox.Show("User id or password is not correct");
                return false;
            }

        }
        
    }
}

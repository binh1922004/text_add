using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace textPicture
{
    internal class Group
    {

        MyDB db = new MyDB();
        private bool verif(string id, string name)
        {
            if (id.Trim() == "" || name.Trim() == "")
            {
                MessageBox.Show("Please dont enter empty character");
                return false;
            }
            else if (id.All(char.IsDigit) == false)
            {
                MessageBox.Show("Please enter number in ID");
                return false;
            }
            

            return true;
        }

        private bool existGroup(string id)
        {
            string query = "select * from [Group] where id = " + id;
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.SqlCon);
            db.OpenConnection();
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt .Rows.Count > 0;
        }

        public void insertGroup(string id, string name)
        {
            try
            {
                if (!verif(id, name))
                    return;
                else if (existGroup(id))
                {
                    MessageBox.Show("This group id already exists");
                    return;
                }
                string query = "insert into [Group] values(@id, @gname, @userid)";
                SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
                db.OpenConnection();
                sqlCmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;
                sqlCmd.Parameters.Add(new SqlParameter("@userid", System.Data.SqlDbType.Int)).Value = GlobalClass.userID;
                sqlCmd.Parameters.Add(new SqlParameter("@gname", System.Data.SqlDbType.VarChar)).Value = name;
                int k = sqlCmd.ExecuteNonQuery();
                if (k == 1)
                {
                    MessageBox.Show("Successfully added");

                }
                else
                {
                    MessageBox.Show("Something wrong");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.CloseConnection();

        }

        public void updateGroup(string id, string name)
        {
            try
            {
                if (!verif(id, name))
                    return;
                string query = "update [Group] set name = @name where id = @id and userid = @userid";
                SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
                db.OpenConnection();

                sqlCmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;
                sqlCmd.Parameters.Add(new SqlParameter("@userid", System.Data.SqlDbType.Int)).Value = GlobalClass.userID;
                sqlCmd.Parameters.Add(new SqlParameter("@gname", System.Data.SqlDbType.VarChar)).Value = name;

                int k = sqlCmd.ExecuteNonQuery();
                if (k == 1)
                {
                    MessageBox.Show("Successfully edit");
                }
                else
                {
                    MessageBox.Show("Something wrong");
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         
        public void deleteGroup(string id)
        {
            try
            {
                string query = "delete from [Group] where id = @id, userid = @userid";
                SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
                db.OpenConnection();

                sqlCmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;
                sqlCmd.Parameters.Add(new SqlParameter("@userid", System.Data.SqlDbType.Int)).Value = GlobalClass.userID;
                int k = sqlCmd.ExecuteNonQuery();
                if (k == 1)
                {
                    MessageBox.Show("Successfully remove");
                }
                else
                {
                    MessageBox.Show("Something wrong");
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable getAllGroup()
        {
            string query = "select * from [Group] where userid = @userid";
            SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);

            sqlCmd.Parameters.Add(new SqlParameter("@userid", System.Data.SqlDbType.Int)).Value = GlobalClass.userID;
            db.OpenConnection();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }
    }
}

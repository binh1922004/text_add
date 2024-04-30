using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    internal class Contact
    {
        MyDB db = new MyDB();
        public bool verif(string id, string fname, string lname, string gr, string phone, string mail, string add)
        {
            if (id.Trim() == "" || fname.Trim() == "" || lname.Trim() == "" || gr.Trim() == "" || phone.Trim() == "" || mail.Trim() == "" || add.Trim() == "")
            {
                MessageBox.Show("Please dont empty");
                return false;
            }
            else if (!id.All(char.IsDigit))
            {
                MessageBox.Show("Please enter only number in ID");
                return false;
            }
            else if (fname.Any(char.IsDigit) || lname.Any(char.IsDigit))
            {
                MessageBox.Show("Please dont enter number in last name or first name");
                return false;
            }
            else if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Please enter only number in phone number");
                return false;
            }
            else if (phone.Length < 10)
            {
                MessageBox.Show("Please enter 10 number in ID");
                return false;
            }
            return true;
        }

        private bool contactEXist(string id)
        {
            string query = "select * from Contact where id = " + id;
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.SqlCon);
            db.OpenConnection();

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt.Rows.Count > 0;
        }

        public void insertContact(string id, string fname, string lname, string gr, string phone, string mail, string add, MemoryStream pic)
        {
            try
            {
                if (!verif(id, fname, lname, gr, phone, mail, add))
                {
                    return;
                }
                else if (contactEXist(id))
                {
                    MessageBox.Show("Contact already exist");
                    return;
                }
                string query = "insert into Contact values(@id, @fn, @ln, @gr, @phone, @mail, @add, @pic, @userid)";
                SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
                db.OpenConnection();

                sqlCmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;
                sqlCmd.Parameters.Add(new SqlParameter("@fn", System.Data.SqlDbType.VarChar)).Value = fname;
                sqlCmd.Parameters.Add(new SqlParameter("@ln", System.Data.SqlDbType.VarChar)).Value = lname;
                sqlCmd.Parameters.Add(new SqlParameter("@gr", System.Data.SqlDbType.Int)).Value = gr;
                sqlCmd.Parameters.Add(new SqlParameter("@phone", System.Data.SqlDbType.VarChar)).Value = phone;
                sqlCmd.Parameters.Add(new SqlParameter("@mail", System.Data.SqlDbType.VarChar)).Value = mail;
                sqlCmd.Parameters.Add(new SqlParameter("@add", System.Data.SqlDbType.Text)).Value = add;
                sqlCmd.Parameters.Add(new SqlParameter("@pic", System.Data.SqlDbType.Image)).Value = pic.ToArray();
                sqlCmd.Parameters.Add(new SqlParameter("@userid", System.Data.SqlDbType.Int)).Value = GlobalClass.ID;

                int k = sqlCmd.ExecuteNonQuery();
                db.CloseConnection();
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
        }

        public void updateContact(string id, string fname, string lname, string gr, string phone, string mail, string add, MemoryStream pic)
        {
            try
            {
                if (!verif(id, fname, lname, gr, phone, mail, add))
                {
                    return;
                }
                string query = "update Contact set fname = @fn, lname = @ln, groupid = @gr, phone = @phone, email = @mail, address = @add, " +
                    "pic = @pic where id = @id";
                SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
                db.OpenConnection();

                sqlCmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;
                sqlCmd.Parameters.Add(new SqlParameter("@fn", System.Data.SqlDbType.VarChar)).Value = fname;
                sqlCmd.Parameters.Add(new SqlParameter("@ln", System.Data.SqlDbType.VarChar)).Value = lname;
                sqlCmd.Parameters.Add(new SqlParameter("@gr", System.Data.SqlDbType.Int)).Value = gr;
                sqlCmd.Parameters.Add(new SqlParameter("@phone", System.Data.SqlDbType.VarChar)).Value = phone;
                sqlCmd.Parameters.Add(new SqlParameter("@mail", System.Data.SqlDbType.VarChar)).Value = mail;
                sqlCmd.Parameters.Add(new SqlParameter("@add", System.Data.SqlDbType.Text)).Value = add;
                sqlCmd.Parameters.Add(new SqlParameter("@pic", System.Data.SqlDbType.Image)).Value = pic.ToArray();

                int k = sqlCmd.ExecuteNonQuery();
                db.CloseConnection();
                if (k == 1)
                {
                    MessageBox.Show("Successfully edit");
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
        }
        public void removeContact(string id)
        {
            try
            {
                string query = "delete from Contact where id = " + id;
                SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
                db.OpenConnection();

                int k = sqlCmd.ExecuteNonQuery();
                if (k == 1)
                {
                    MessageBox.Show("Successfully remove");
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
        }

        public DataTable getAllContact()
        {
            string query = "select * from Contact where userid = " + GlobalClass.ID;
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.SqlCon);
            db.OpenConnection();
            DataTable dt = new DataTable();
            adapter.Fill(dt); 
            
            db.CloseConnection();
            return dt;
        }

        public DataTable getContactByID(string id)
        {
            string query = "select * from Contact where id = " + id;
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.SqlCon);
            db.OpenConnection();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        internal DataTable getCOntactByGrID(string grid)
        {
            string query = "select id, fname, lname, phone, address, pic from Contact where groupid = " + grid;
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.SqlCon);
            db.OpenConnection();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }
    }
}

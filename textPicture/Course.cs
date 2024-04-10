using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    internal class Course
    {
        private MyDB db = new MyDB();
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        DataSet ds;
        #region checkdata
        public bool checkCourseName(string id, string courseName)
        {
            string query = "select * from Course where (label = @cName and id <> @cid)";
            SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
            sqlCmd.Parameters.Add(new SqlParameter("@cName", System.Data.SqlDbType.NVarChar)).Value = courseName;
            sqlCmd.Parameters.Add(new SqlParameter("@cid", System.Data.SqlDbType.Int)).Value = id;
            db.OpenConnection();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            bool ck = true;
            while (reader.Read())
            {
                ck = false;
                break;
            }
            reader.Close();
            db.CloseConnection();
            return ck;

        }
        public bool verif(string id, string courseName, int period, string des)
        {
            if (id.Trim() == "" || courseName.Trim() == "" || des.Trim() == "")
                return false;

            return true;
        }
        #endregion checkdata
        public bool insertCourse(string id, string courseName, int period, string des, string semester)
        {
            if (!checkCourseName(id, courseName))
            {
                MessageBox.Show("Please not enter duplicated course");
                return false;
            }
            else if (verif(id, courseName, period, des) == false)
            {
                MessageBox.Show("Invalid value input");
                return false;
            }
            string query = "insert into Course values(@cid, @cname, @cperiod, @cdes, @semester)";
            SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
            sqlCmd.Parameters.Add(new SqlParameter("@cid", System.Data.SqlDbType.Char)).Value = id;
            sqlCmd.Parameters.Add(new SqlParameter("@cname", System.Data.SqlDbType.NVarChar)).Value = courseName;
            sqlCmd.Parameters.Add(new SqlParameter("@cperiod", System.Data.SqlDbType.Int)).Value = period;
            sqlCmd.Parameters.Add(new SqlParameter("@cdes", System.Data.SqlDbType.Text)).Value = des;
            sqlCmd.Parameters.Add(new SqlParameter("@semester", System.Data.SqlDbType.Int)).Value = semester;

            db.OpenConnection();
            int k = sqlCmd.ExecuteNonQuery();
            if (k > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void deleteCourse(string id)
        {
            try
            {
                string query = "delete from Course where id = @cid";
                SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
                sqlCmd.Parameters.Add(new SqlParameter("@cid", System.Data.SqlDbType.Int)).Value = id;
                db.OpenConnection();
                int k = sqlCmd.ExecuteNonQuery();
                if (k > 0)
                {
                    MessageBox.Show("Successfully delete");
                }
                else
                {
                    MessageBox.Show("failed");
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool updateCourse(string id, string courseName, int period, string des)
        {
            if (!checkCourseName(id, courseName))
            {
                MessageBox.Show("Please not enter duplicated course");
                return false;
            }
            string query = "update Course set label = @cname, period = @cperiod, description = @cdes where id = @cid";
            SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
            sqlCmd.Parameters.Add(new SqlParameter("@cid", System.Data.SqlDbType.Char)).Value = id;
            sqlCmd.Parameters.Add(new SqlParameter("@cname", System.Data.SqlDbType.NVarChar)).Value = courseName;
            sqlCmd.Parameters.Add(new SqlParameter("@cperiod", System.Data.SqlDbType.Int)).Value = period;
            sqlCmd.Parameters.Add(new SqlParameter("@cdes", System.Data.SqlDbType.Text)).Value = des;

            db.OpenConnection();
            int k = sqlCmd.ExecuteNonQuery();
            if (k > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet getAllCourse(string query = "select * from Course")
        {
            adapter = new SqlDataAdapter(query, db.SqlCon);
            builder = new SqlCommandBuilder(adapter);
            db.OpenConnection();
            ds = new DataSet();
            adapter.Fill(ds, "tblCourse");

            return ds;
        }

        public void editCourseWithBinding()
        {
            builder.GetInsertCommand();
            int k = adapter.Update(ds.Tables["tblCourse"]);
            if (k > 0)
            {
                MessageBox.Show("da luu du lieu thanh cong");
            }
            else
            {
                MessageBox.Show("Da co loi");
            }
        }
        public void deleteCourseWithBinding()
        {
            builder.GetDeleteCommand();
            int k = adapter.Update(ds.Tables["tblCourse"]);
            if (k > 0)
            {
                MessageBox.Show("Da xoa thanh cong du lieu");
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }
    }
}

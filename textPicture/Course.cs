using System;
using System.Collections.Generic;
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

        #endregion checkdata
        public bool insertCourse(string id, string courseName, int period, string des)
        {
            if (!checkCourseName(id, courseName))
            {
                MessageBox.Show("Please not enter duplicated course");
                return false;
            }
            string query = "insert into Course values(@cid, @cname, @cperiod, @cdes)";
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

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textPicture
{
    internal class CourseRegister
    {
        MyDB db = new MyDB();

        public bool insertCourseAndStudent(string stID, string cID)
        {
            string query = "insert into CourseRegister values(@stid, @cid)";
            SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
            sqlCmd.Parameters.Add(new SqlParameter("@stid", System.Data.SqlDbType.VarChar)).Value = stID;
            sqlCmd.Parameters.Add(new SqlParameter("@cid", System.Data.SqlDbType.Int)).Value = cID;
            db.OpenConnection();
            int k = sqlCmd.ExecuteNonQuery();
            db.CloseConnection();
            if (k > 0)
            {
                return true;
            }
            else return false;
        }
    }
}

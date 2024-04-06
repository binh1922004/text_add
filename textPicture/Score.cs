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
    internal class Score
    {
        MyDB db = new MyDB();   
        bool studentScoreExist(string sid, int cid)
        {
            string query = "select * from Score where student_id = @sid and course_id = @cid";
            SqlCommand sqlcmd = new SqlCommand(query, db.SqlCon);
            db.OpenConnection();
            sqlcmd.Parameters.Add(new SqlParameter("@sid", System.Data.SqlDbType.VarChar)).Value = sid;
            sqlcmd.Parameters.Add(new SqlParameter("@cid", System.Data.SqlDbType.Int)).Value = cid;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();
            return dt.Rows.Count > 0;
        }

        public bool insertScore(string sid, int cid, float score, string des)
        {
            if (studentScoreExist(sid, cid))
            {
                MessageBox.Show("Student have had point in course");
                return false;
            }
            string query = "insert into Score values(@sid, @cid, @score, @des)";
            SqlCommand sqlcmd = new SqlCommand(query, db.SqlCon);
            db.OpenConnection();

            sqlcmd.Parameters.Add(new SqlParameter("@sid", System.Data.SqlDbType.VarChar)).Value = sid;
            sqlcmd.Parameters.Add(new SqlParameter("@cid", System.Data.SqlDbType.Int)).Value = cid;
            sqlcmd.Parameters.Add(new SqlParameter("@score", System.Data.SqlDbType.Real)).Value = score;
            sqlcmd.Parameters.Add(new SqlParameter("@des", System.Data.SqlDbType.Text)).Value = des;

            if (sqlcmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Add score success");
                return true;
            }
            else
            {
                MessageBox.Show("Fail");
                return false;
            }
        }
        public bool deleteScore(string sid, string cid)
        {
            string query = "delete from Score where student_id = @sid and course_id = @cid";
            SqlCommand sqlcmd = new SqlCommand(query, db.SqlCon);
            sqlcmd.Parameters.Add(new SqlParameter("@sid", SqlDbType.VarChar)).Value = sid;
            sqlcmd.Parameters.Add(new SqlParameter("@cid", SqlDbType.Int)).Value = cid;

            db.OpenConnection();

            return sqlcmd.ExecuteNonQuery() > 0;
        }
        public DataTable getAvgScoreByCouse()
        {
            string query = "select c.label, AVG(s.score) from Score s, Course c where s.course_id = c.id group by c.label";
        
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.SqlCon);
            db.OpenConnection();

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    
        public DataTable getScoreTable(string query = "select * from Score")
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.SqlCon);
            db.OpenConnection();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

    }
}

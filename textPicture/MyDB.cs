using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textPicture
{
    internal class MyDB
    {
        SqlConnection sqlCon = null;
        public MyDB()
        {
            sqlCon = new SqlConnection(@"Data Source=binh0109\SQLEXPRESS;Initial Catalog=UniversityManage;Integrated Security=True");
        }

        public SqlConnection SqlCon 
        { 
            get { return sqlCon; } 
        }

        public void OpenConnection()
        {
            if (sqlCon.State == ConnectionState.Closed)  
            {
                sqlCon.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
    }
}

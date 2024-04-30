using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
            LoadData();
        }

        public StudentListForm(string query)
        {
            InitializeComponent();
            LoadData(query);
            dgv_StudentList.Enabled = false;
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void LoadData(string query = "select * from StudentDetail")
        {
            MyDB myDB = new MyDB();
            myDB.OpenConnection();

            SqlDataAdapter adapter  = new SqlDataAdapter(query, myDB.SqlCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_StudentList.DataSource = dt;
            myDB.CloseConnection();
        }

        private void dgv_StudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            string ID = dgv_StudentList.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
            this.Hide();
            StudentModuleForm studentModuleForm = new StudentModuleForm(ID);
            studentModuleForm.ShowDialog();
            this.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchGoal = txt_Search.Text;
            string query = "select * from StudentDetail where CONCAT(FirstName,LastName) LIKE '%" + searchGoal + "%'";
            LoadData(query);
        }

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

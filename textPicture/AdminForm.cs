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
    public partial class AdminForm : Form
    {
        MyDB db = new MyDB();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityManageDataSet.DataUser' table. You can move, or remove it, as needed.
            this.dataUserTableAdapter.Fill(this.universityManageDataSet.DataUser);
            LoadData("select * from DataUser where Status != 'admin'");
        }

        private void LoadData(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.SqlCon);
            DataTable dt =  new DataTable();
            adapter.Fill(dt);
            db.OpenConnection();
            dgv_DataUser.DataSource = dt;
            db.CloseConnection();
        }
        string id = null;
        private void dgv_DataUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string stt = dgv_DataUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (stt == "user")
                {
                    btn_AC.Enabled = false;
                }
                id = dgv_DataUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
            if (dgv_DataUser.SelectedCells.Count > 0)
            {
                try
                {
                    string query = "update DataUser set Status = 'user' where ID = '" + id + "'";
                    SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
                    db.OpenConnection();
                    int k = sqlCmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        MessageBox.Show("successfull update");
                        LoadData("select * from DataUser where Status != 'admin'");
                    }
                    else
                    {
                        MessageBox.Show("failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (dgv_DataUser.SelectedCells.Count > 0)
            {
                try
                {
                    string query = "delete from DataUser where ID = '" + id + "'";
                    SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
                    db.OpenConnection();
                    int k = sqlCmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        MessageBox.Show("successfull delete");
                        LoadData("select * from DataUser where Status != 'admin'");
                    }
                    else
                    {
                        MessageBox.Show("failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
    }
}

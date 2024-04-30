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
        string query = "select id, fname, lname, userid, role, stt from UserData where id != " + GlobalClass.ID;
        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadData(query);
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
                string stt = dgv_DataUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (stt == "ok")
                {
                    btn_AC.Enabled = false;
                }
                else
                    btn_AC.Enabled = true;
                id = dgv_DataUser.Rows[e.RowIndex].Cells["idTbl"].Value.ToString();
            }
        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
            if (dgv_DataUser.SelectedCells.Count > 0)
            {
                try
                {
                    string query = "update UserData set stt = 'ok' where id = '" + id + "'";
                    SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
                    db.OpenConnection();
                    int k = sqlCmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        MessageBox.Show("successfull update");
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
                        LoadData(query);
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

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            LoadData(query);
        }
    }
}

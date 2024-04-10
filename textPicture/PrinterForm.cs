using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class PrinterForm : Form
    {
        MyDB db = new MyDB();
        public PrinterForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            string query = "select * from StudentDetail ";
            if (rbtn_Female.Checked)
            {
                query += "where Sex = 'Female' ";
                if (rbtn_RangeYes.Checked)
                {
                    string left = dtp_Min.Value.ToString("yyyy/MM/dd");
                    string right = dtp_Max.Value.ToString("yyyy/MM/dd");
                    query += "and BirthDate between '" + left +"' and '" + right + "'";
                }
            }
            else if (rbtn_Male.Checked)
            {
                query += "where Sex = 'Male' ";
                if (rbtn_RangeYes.Checked)
                {
                    string left = dtp_Min.Value.ToString("yyyy/MM/dd");
                    string right = dtp_Max.Value.ToString("yyyy/MM/dd");
                    query += "and BirthDate between '" + left + "' and '" + right + "'";
                }
            }
            else
            {
                if (rbtn_RangeYes.Checked)
                {
                    string left = dtp_Min.Value.ToString("yyyy/MM/dd");
                    string right = dtp_Max.Value.ToString("yyyy/MM/dd");
                    query += "where BirthDate between '" + left + "' and '" + right + "'";
                }
            }


            LoadData(query);
        }

        private void LoadData(string query = "select * from StudentDetail")
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.SqlCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_StudentList.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgv_StudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dtr = dgv_StudentList.Rows[e.RowIndex];
            if (e.ColumnIndex == 0)
            {
                string id = dtr.Cells["sid"].Value.ToString();
                AddCourseFromStudentForm addCourseFromStudentForm = new AddCourseFromStudentForm(id);
                this.Hide();
                addCourseFromStudentForm.ShowDialog();
                this.Show();
            }
        }
    }
}

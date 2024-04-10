using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class ImportStudentForm : Form
    {
        MyDB db = new MyDB();
        Student std = new Student();
        System.Data.DataTable Exceldt;
        public ImportStudentForm()
        {
            InitializeComponent();
        }

        private void ImportStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityManageDataSet5.STUDENTDETAIL' table. You can move, or remove it, as needed.
            //this.sTUDENTDETAILTableAdapter2.Fill(this.universityManageDataSet5.STUDENTDETAIL);
            //// TODO: This line of code loads data into the 'universityManageDataSet1.STUDENTDETAIL' table. You can move, or remove it, as needed.
            //this.sTUDENTDETAILTableAdapter1.Fill(this.universityManageDataSet1.STUDENTDETAIL);
            //// TODO: This line of code loads data into the 'studentManageDataSet.StudentDetail' table. You can move, or remove it, as needed.
            //this.studentDetailTableAdapter.Fill(this.studentManageDataSet.StudentDetail);

        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Filter = "Excell|*.xls;*.xlsx;";
                od.FileName = "EmployeeList.xlsx";
                DialogResult dr = od.ShowDialog();
                if (dr == DialogResult.Abort)
                    return;
                if (dr == DialogResult.Cancel)
                    return;
                string _path = od.FileName.ToString();
                string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""", _path);
                OleDbConnection Econ = new OleDbConnection(constr);
                string Query = string.Format("Select [ID], [First], [Last], [Birth], [Gender], [Phone], [Address], [Email], [Image] FROM [{0}]", "Sheet1$");
                OleDbCommand Ecom = new OleDbCommand(Query, Econ);
                Econ.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);
                Econ.Close();//close Excel connection after adding to data set
                oda.Fill(ds);
                ds.Tables[0].Columns.Add("ImageFromPath", typeof(byte[]));
                ds.Tables[0].Columns.Add("NewPhone", typeof(string));
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ds.Tables[0].Rows[i]["Email"] = ds.Tables[0].Rows[i]["ID"] + "@hcmute.edu.vn";
                    string path = ds.Tables[0].Rows[i]["Image"].ToString();
                    ds.Tables[0].Rows[i]["ImageFromPath"] = File.ReadAllBytes(path);
                    ds.Tables[0].Rows[i]["NewPhone"] ="0" + ds.Tables[0].Rows[i]["Phone"].ToString();
                }
                ds.Tables[0].Columns.Remove("Image");
                ds.Tables[0].Columns.Remove("Phone");

                Exceldt = ds.Tables[0];
                dgv_StudentList.DataSource = Exceldt;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData(string query)
        {
            //try
            //{
            //    SqlDataAdapter adapter = new SqlDataAdapter(query, db.SqlCon);
            //    DataTable dt = new DataTable();
            //    db.OpenConnection();
            //    adapter.Fill(dt);
            //    dgv_StudentList.DataSource = dt;
            //    db.CloseConnection();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btn_CheckData_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Exceldt.Rows.Count; i++)
            {
                string id = Exceldt.Rows[i]["ID"].ToString();
                string fn = Exceldt.Rows[i]["First"].ToString();
                string ln = Exceldt.Rows[i]["Last"].ToString();
                string phone = Exceldt.Rows[i]["NewPhone"].ToString();
                string birt = Exceldt.Rows[i]["Birth"].ToString();
                string add = Exceldt.Rows[i]["Address"].ToString();
                if (!Student.verif(id, fn, ln, birt, phone, add, i + 1))
                {
                    btn_Save.Enabled = false;
                    return;
                }
            }
            MessageBox.Show("Valid value");
            btn_Save.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Exceldt.Rows.Count; i++)
            {
                string id = Exceldt.Rows[i]["ID"].ToString();
                string fn = Exceldt.Rows[i]["First"].ToString();
                string ln = Exceldt.Rows[i]["Last"].ToString();
                string phone = Exceldt.Rows[i]["NewPhone"].ToString();
                string birt = Exceldt.Rows[i]["Birth"].ToString();
                string add = Exceldt.Rows[i]["Address"].ToString();
                string email = Exceldt.Rows[i]["Email"].ToString();
                string gender = Exceldt.Rows[i]["Gender"].ToString();
                var data = (Byte[])Exceldt.Rows[i]["ImageFromPath"];
                var pic = new MemoryStream(data);

                if (std.searchStudent(id) == true)
                {
                    Student.deleteStudent(id);
                }
                Student.InsertStudent(id, fn, ln, birt, gender, phone, add, pic, "import");
            }
            MessageBox.Show("Successfully import");
        }
    }
}

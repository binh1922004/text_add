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
        public ImportStudentForm()
        {
            InitializeComponent();
        }

        private void ImportStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityManageDataSet5.STUDENTDETAIL' table. You can move, or remove it, as needed.
            this.sTUDENTDETAILTableAdapter2.Fill(this.universityManageDataSet5.STUDENTDETAIL);
            // TODO: This line of code loads data into the 'universityManageDataSet1.STUDENTDETAIL' table. You can move, or remove it, as needed.
            this.sTUDENTDETAILTableAdapter1.Fill(this.universityManageDataSet1.STUDENTDETAIL);
            // TODO: This line of code loads data into the 'studentManageDataSet.StudentDetail' table. You can move, or remove it, as needed.
            this.studentDetailTableAdapter.Fill(this.studentManageDataSet.StudentDetail);

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
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ds.Tables[0].Rows[i]["Email"] = ds.Tables[0].Rows[i]["ID"] + "@hcmute.edu.vn";
                    string path = ds.Tables[0].Rows[i]["Image"].ToString();
                    ds.Tables[0].Rows[i]["ImageFromPath"] = File.ReadAllBytes(path);
                }
                System.Data.DataTable Exceldt = ds.Tables[0];


                Exceldt.AcceptChanges();
                //creating object of SqlBulkCopy
                SqlConnection con = db.SqlCon;
                SqlBulkCopy objbulk = new SqlBulkCopy(con);
                //assigning Destination table name
                objbulk.DestinationTableName = "STUDENTDETAIL";
                //Mapping Table column
                objbulk.ColumnMappings.Add("ID", "StudentID");
                objbulk.ColumnMappings.Add("First", "FirstName");
                objbulk.ColumnMappings.Add("Last", "LastName");
                objbulk.ColumnMappings.Add("Birth", "BirthDate");
                objbulk.ColumnMappings.Add("Gender", "Sex");
                objbulk.ColumnMappings.Add("Phone", "Phone");
                objbulk.ColumnMappings.Add("Address", "Address");
                objbulk.ColumnMappings.Add("Email", "Email");
                objbulk.ColumnMappings.Add("ImageFromPath", "Face");

                //inserting Datatable Records to DataBase
                SqlConnection sqlConnection = db.SqlCon;
                con.Open();
                objbulk.WriteToServer(Exceldt);
                con.Close();
                MessageBox.Show("Data has been Imported successfully.", "Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData("select * from STUDENTDETAIL");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData(string query)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, db.SqlCon);
                DataTable dt = new DataTable();
                db.OpenConnection();
                adapter.Fill(dt);
                dgv_StudentList.DataSource = dt;
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

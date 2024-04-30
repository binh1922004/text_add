using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
            LoadData();
        }
        public ManageStudentForm(string query)
        {
            InitializeComponent();
            LoadData(query);
            pnl_Edit.Visible = false;   
        }
        private void LoadData(string query = "select * from StudentDetail")
        {
            MyDB myDB = new MyDB();
            myDB.OpenConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(query, myDB.SqlCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_StudentList.DataSource = dt;
            lblTotal.Text = "Total student: " + dt.Rows.Count.ToString();
            myDB.CloseConnection();
        }

        private void dgv_StudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 )
            {
                DataGridViewRow dtr = dgv_StudentList.Rows[e.RowIndex];
                if (e.ColumnIndex == 0)
                {
                    string id = dtr.Cells["sid"].Value.ToString();
                    CourseList courseList = new CourseList(id);
                    this.Hide();
                    courseList.ShowDialog();
                    this.Show();
                    return;
                }
                txtID.Text = dtr.Cells["sid"].Value.ToString();
                txtFirstName.Text = dtr.Cells["fn"].Value.ToString();
                txtLastName.Text = dtr.Cells["ln"].Value.ToString();
                dtpBirth.Value = (DateTime)dtr.Cells["dob"].Value;
                txtPhone.Text = dtr.Cells["Phone"].Value.ToString();
                txtAddress.Text = dtr.Cells["add"].Value.ToString();

                string gender = dtr.Cells["gender"].Value.ToString().Trim();
                if (gender == "Male")
                {
                    rbtnMale.Checked = true;
                }
                else
                    rbtnFemale.Checked = true;
                var data = (Byte[])(dtr.Cells["face"].Value);
                var stream = new MemoryStream(data);
                picFace.Image = Image.FromStream(stream);

            }
            else
            {
            }
        }

        #region Function

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text.Trim();
            string FirstName = txtFirstName.Text.Trim();
            string LastName = txtLastName.Text.Trim();
            string BirthDate = dtpBirth.Text.Trim();
            string Gender = "Male";
            if (rbtnFemale.Checked)
            {
                Gender = "Female";
            }

            string Phone = txtPhone.Text;
            string Address = txtAddress.Text;
            MemoryStream pic = new MemoryStream();
            picFace.Image.Save(pic, picFace.Image.RawFormat);
            int yearbith = dtpBirth.Value.Year;
            int yearnow = DateTime.Now.Year;
            if (yearnow - yearbith < 10 || yearnow - yearbith > 100)
            {
                MessageBox.Show("Age must be between 10 and 100");
            }
            else
            {
                Student.InsertStudent(ID, FirstName, LastName, BirthDate, Gender, Phone, Address, pic);
            }
            LoadData();
        }

        private void btnUpLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select image (*.jpg;*.png;*.gif)|*.jpg;*.png;*gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picFace.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Please enter valid value");
                txtID.Focus();
                return;
            }

            try
            {
                string studentID = txtID.Text;
                DialogResult kq = MessageBox.Show("Do you want to delete this student?", "Delete student", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    if (Student.deleteStudent(studentID))
                    {
                        MessageBox.Show("Student deleteed successfully");
                        Clear();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Student not deleted");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid ID");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string fname = txtFirstName.Text;
                string lname = txtLastName.Text;
                string bdate = dtpBirth.Text;
                string phone = txtPhone.Text;
                string adr = txtAddress.Text;
                string gender = "Male";
                if (rbtnFemale.Checked)
                {
                    gender = "Female";
                }

                MemoryStream pic = new MemoryStream();
                picFace.Image.Save(pic, picFace.Image.RawFormat);
                int bonyear = dtpBirth.Value.Year;
                int thisyear = DateTime.Now.Year;
                if ((thisyear - bonyear) > 100 || (thisyear - bonyear) < 0)
                {
                    MessageBox.Show("Age must be between 10 and 100");
                }
                else
                {
                    if (Student.updateStudent(id, fname, lname, bdate, gender, phone, adr, pic))
                    {
                        MessageBox.Show("Update successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadData();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchGoal = txt_Search.Text;
            string query = "select * from StudentDetail where CONCAT(FirstName,LastName, Address) LIKE '%" + searchGoal + "%'";
            LoadData(query);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion Fucntion

        private void Clear()
        {
            txtAddress.Text = "";
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            dtpBirth.Value = DateTime.Now;
            picFace.Image = null;
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}

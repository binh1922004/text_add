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
    public partial class StudentModuleForm : Form
    {

        public StudentModuleForm(string ID)
        {
            InitializeComponent();
            txt_ID.Text = ID;
            addData(txt_ID.Text);
        }
        public StudentModuleForm()
        {
            InitializeComponent();
        }

        private void btn_FindID_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            try
            {
                addData(id);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can not find this student ID");
            }
        }

        private void addData(string id)
        {
            MyDB myDB = new MyDB();
            myDB.OpenConnection();
            string query = "select * from StudentDetail where StudentID = '" + id + "'";
            SqlCommand sqlCmd = new SqlCommand(query, myDB.SqlCon);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                txt_Fname.Text = reader.GetString(1);
                txt_Lname.Text = reader.GetString(2);
                dtp_Birthdate.Value = (DateTime)reader.GetValue(3);
                string gender = reader.GetString(4);
                if (gender == "Male")
                    rbtn_Male.Checked = true;
                else rbtn_Female.Checked = true;
                txt_Phone.Text = reader.GetString(5);
                txt_Address.Text = reader.GetString(6);
                byte[] pic = (byte[])reader.GetValue(8);
                MemoryStream picture = new MemoryStream(pic);
                pic_Face.Image = Image.FromStream(picture);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Please enter valid value");
                txt_ID.Focus();
                return;
            }

            try
            {
                string studentID = txt_ID.Text;
                DialogResult kq = MessageBox.Show("Do you want to delete this student?", "Delete student", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    if (Student.deleteStudent(studentID))
                    {
                        MessageBox.Show("Student deleteed successfully");
                        Clear();
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

        private void Clear()
        {
            txt_Address.Text = "";
            txt_ID.Text = "";
            txt_Fname.Text = "";
            txt_Lname.Text = "";
            txt_Phone.Text = "";
            dtp_Birthdate.Value = DateTime.Now;
            pic_Face.Image = null;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string fname = txt_Fname.Text;
            string lname = txt_Lname.Text;
            string bdate = dtp_Birthdate.Text;
            string phone = txt_Phone.Text;
            string adr = txt_Address.Text;
            string gender = "Male";
            if (rbtn_Female.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            pic_Face.Image.Save(pic, pic_Face.Image.RawFormat);
            int bonyear = dtp_Birthdate.Value.Year;
            int thisyear = DateTime.Now.Year;
            if ((thisyear -  bonyear) > 100 || (thisyear  - bonyear) < 0)
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

        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            AddCourseFromStudentForm courseRegister = new AddCourseFromStudentForm(id);
            this.Hide();
            courseRegister.ShowDialog();
            this.Show();
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select image (*.jpg;*.png;*.gif)|*.jpg;*.png;*gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_Face.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
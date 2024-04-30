using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class AddCourseFromStudentForm : Form
    {
        List<string> idSelected = new List<string>();
        List<string> labelSelected = new List<string>();   
        List<List<int>> deleted = new List<List<int>>();
        List<DataTable> avaiCourse = new List<DataTable>();
        List<DataTable> backupavaiCourse = new List<DataTable>();
        int ky;
        string stid = "";

        Course course = new Course();
        CourseRegister courseRegister = new CourseRegister();
        Student student = new Student();    
        public AddCourseFromStudentForm()
        {
            InitializeComponent();
            LoadData();
        }
        public AddCourseFromStudentForm(string stID)
        {
            InitializeComponent();
            this.stid = stID;
            txt_ID.Text = stID;
            txt_ID.ReadOnly = true;
            btn_Find.Enabled = false;
            LoadData();
        }

        void LoadData()
        {
            
            List<int> semester = new List<int>();
            semester.Add(1);
            semester.Add(2);
            semester.Add(3);
            //tao list san
            for (int i = 0; i < 3; i++)
            {
                string query = "select c.id, c.label" +
                " from Course c left join (select * from CourseRegister cg where cg.StudentID = '" + stid + "') detail on c.id = detail.CourseID where detail.StudentID is null and c.semester = " + (i+1).ToString();
                avaiCourse.Add((course.getAllCourse(query).Tables["tblCourse"]));
                backupavaiCourse.Add((course.getAllCourse(query).Tables["tblCourse"]));
            }
            
            cbb_Semester.DataSource = semester;
        }

        private void cbb_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Semester.SelectedItem == null)
            {
                return;
            }
            ky = Int32.Parse(cbb_Semester.SelectedItem.ToString());
            if (ky <= 0)
                return;
            
            
            lsb_Available.DataSource = avaiCourse[ky - 1];
            lsb_Available.DisplayMember = "label";
            lsb_Available.ValueMember = "id";
            lsb_Selected.DisplayMember = "label";
            lsb_Selected.ValueMember = "id";
        }
        int cnt = 0;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (lsb_Available.SelectedIndex < 0)
                return;
            idSelected.Add(lsb_Available.SelectedValue.ToString());
            labelSelected.Add(lsb_Available.Text.ToString());
            lsb_Selected.Items.Add(lsb_Available.SelectedItem);

            //xoa trong datatable va luu lai trong deleted

            string id = lsb_Available.SelectedValue.ToString();
            int pos = 0;
            for (int i = 0; i < backupavaiCourse[ky - 1].Rows.Count; i++)
            {

                if (backupavaiCourse[ky - 1].Rows[i]["id"].ToString() == id)
                {
                    avaiCourse[ky - 1].Rows[i].Delete();
                    break;
                }
            }
            
        }

        private void lsb_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsb_Selected.SelectedIndex < 0)
                return; 
            //MessageBox.Show(lsb_Selected)
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (idSelected.Count <= 0)
            {
                MessageBox.Show("please choose course");
                return;
            }
            else
            {
                if (txt_ID.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your studentID");
                }
            }
            try
            {
                for (int i = 0; i < idSelected.Count; i++)
                {
                    
                    string cid = idSelected[i];
                    string label = labelSelected[i];
                    courseRegister.insertCourseAndStudent(stid, cid, label);
                }
                MessageBox.Show("Successfully added");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your studentID");
            }
            else
            {
                if (student.searchStudent(txt_ID.Text.Trim()))
                {
                    cbb_Semester.SelectedItem = null;
                    stid = txt_ID.Text.Trim();
                    clear();
                }
                else
                {
                    MessageBox.Show("Can not find your student ID");
                }
            }
        }

        private void clear()
        {
        }
    }
}

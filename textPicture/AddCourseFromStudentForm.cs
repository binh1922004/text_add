using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class AddCourseFromStudentForm : Form
    {
        List<string> idSelected = new List<string>();
        List<List<int>> deleted = new List<List<int>>();
        DataTable avaiCourse = new DataTable();
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
                deleted.Add(new List<int>());

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
            string query = "select c.id, c.label" +
                " from Course c left join (select * from CourseRegister cg where cg.StudentID = '" + stid +"') detail on c.id = detail.CourseID where detail.StudentID is null and c.semester = " + ky.ToString();
            avaiCourse = (course.getAllCourse(query).Tables["tblCourse"]);
            foreach (int pos in deleted[ky - 1])
            {
                avaiCourse.Rows[pos].Delete();
            }
            lsb_Available.DataSource = avaiCourse;
            lsb_Available.DisplayMember = "label";
            lsb_Available.ValueMember = "id";
            lsb_Selected.DisplayMember = "label";
            lsb_Selected.ValueMember = "id";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (lsb_Available.SelectedIndex < 0)
                return;

            idSelected.Add(lsb_Available.SelectedValue.ToString());
            lsb_Selected.Items.Add(lsb_Available.SelectedItem);
            
            //xoa trong datatable va luu lai trong deleted
            int pos = lsb_Available.SelectedIndex;
            avaiCourse.Rows[pos].Delete();
            deleted[ky - 1].Add(pos);
        }

        private void lsb_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsb_Selected.SelectedIndex < 0)
                return;
            MessageBox.Show(lsb_Selected.GetItemText(lsb_Selected.SelectedValue));
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
                foreach (string cid in idSelected)
                {
                    if (!courseRegister.insertCourseAndStudent(stid, cid))
                    {
                        MessageBox.Show("Failed");
                        return;
                    }
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
            for (int i = 0; i < 3; i++)
                deleted[i].Clear();
            lsb_Selected.Items.Clear();
            cbb_Semester.SelectedIndex = 0;
        }
    }
}

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
        DataTable dt = new DataTable();
        Course course = new Course();
        DataTable avaiCourse;
        public AddCourseFromStudentForm()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            List<int> semester = new List<int>();
            semester.Add(1);
            semester.Add(2);
            semester.Add(3);
            cbb_Semester.DataSource = semester; 
        }

        private void cbb_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ky = cbb_Semester.SelectedItem.ToString();
            avaiCourse = course.getAllCourse("select * from Course where Semester = '" + ky + "'").Tables["tblCourse"];
            lsb_Available.DataSource = avaiCourse;
            lsb_Available.DisplayMember = "label";
            lsb_Available.ValueMember = "id";
            lsb_Selected.DisplayMember = "label";
            lsb_Selected.ValueMember = "id";
            dt.Columns.Add("label");
            dt.Columns.Add("id");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (lsb_Available.SelectedIndex < 0)
                return;

            dt.Rows.Add();
            lsb_Selected.Items.Add(lsb_Available.SelectedItem);
            int pos = lsb_Available.SelectedIndex;
            avaiCourse.Rows[pos].Delete();
        }

        private void lsb_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsb_Selected.SelectedIndex < 0)
                return;
            MessageBox.Show(lsb_Selected.GetItemText(lsb_Selected.SelectedValue));
            //MessageBox.Show(lsb_Selected)
        }
    }
}

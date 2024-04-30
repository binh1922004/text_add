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
    public partial class ShowCourseForm : Form
    {
        Course course = new Course();
        public ShowCourseForm()
        {
            InitializeComponent();
            loadData();
        }


        private void loadData()
        {
            DataTable dt = new DataTable();
            string query = "select id, label, period, description from Course where contactID = " + GlobalClass.contactID;
            dt = course.getAllCourse(query).Tables["tblCourse"];
            dgv_CourseData.DataSource = dt;

            //load name contact
            lbl_ContactName.Text += GlobalClass.contactName;
        }

        private void dgv_CourseData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            string cID = dgv_CourseData.Rows[e.RowIndex].Cells[0].Value.ToString();
            //list ra student in course
            string query = "select std.StudentID, std.FirstName, std.LastName, std.BirthDate, std.Sex, std.Phone, " +
                "std.[Address], std.Email, std.Face " +
                "from STUDENTDETAIL std " +
                "join CourseRegister cg on cg.StudentID = std.StudentID " +
                "where cg.CourseID = " + cID;

            StudentListForm stdListForm = new StudentListForm(query);
            this.Hide();
            stdListForm.ShowDialog();
            this.Show();
        }
    }
}

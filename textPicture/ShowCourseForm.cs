using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class ShowCourseForm : Form
    {
        Course course = new Course();
        Student std = new Student();
        Score score = new Score();  
        public ShowCourseForm()
        {
            InitializeComponent();
            //load name contact
            lbl_ContactName.Text += GlobalClass.contactName;
            loadDataListBox();
        }

        private void loadDataDGV(string courseID)
        {
            string query = "select s.StudentID, s.FirstName, s.LastName from STUDENTDETAIL s\r\njoin CourseRegister cg on s.StudentID = cg.StudentID\r\nwhere cg.CourseID = " + courseID;
            DataTable dt = new DataTable();
            dt = std.getAllStudent(query);
            dt.Columns.Add("STT");
            dt.Columns.Add("Score");



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["STT"] = i + 1;
                string sid = dt.Rows[i]["StudentID"].ToString();
                string small_query = "select course_id, score from Score where student_id = '" + sid + "' and course_id = '" + courseID + "'";
                DataTable small_dt = score.getScoreTable(small_query);
                dt.Rows[i]["Score"] = small_dt.Rows[0]["score"];
            }
            dgv_Data.DataSource = dt;
        }

        private void loadDataListBox()
        {
            string query = "select id, label, period, semester, description from Course where contactID = " + GlobalClass.contactID;
            DataTable dt = new DataTable();
            dt = course.getAllCourse(query).Tables["tblCourse"];
            lsb_Course.ValueMember = "id";
            lsb_Course.DisplayMember = "label";
            lsb_Course.SelectedValue = null;
            lsb_Course.DataSource = dt;

        }


        private void lsb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsb_Course.SelectedItems.Count <= 0)
                return;

            string cid = lsb_Course.SelectedValue.ToString();
            loadDataDGV(cid);
            //foreach (DataRow row in dt.Rows)
            //{
            //    if (row["id"].ToString() == cid)
            //    {
            //        string label = row["label"].ToString();
            //        string semester = row["semester"].ToString();

            //        break;
            //    }
            //}
        }
    }
}

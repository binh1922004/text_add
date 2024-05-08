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
    public partial class CourseStudentListForm : Form
    {
        Student std = new Student();
        Score score = new Score();

        string courseID;
        public CourseStudentListForm()
        {
            InitializeComponent();
        }
        public CourseStudentListForm(string cid, string label, string semester)
        {
            InitializeComponent();

            courseID = cid;

            loadData(cid);
            loadScore();
            txt_CourseID.Text = label;    
            lbl_Semester.Text = "Semester: " + semester;
        }

        private void loadScore()
        {
        }

        void loadData(string courseID)
        {
            string query = "select s.StudentID, s.FirstName, s.LastName, s.BirthDate\r\nfrom STUDENTDETAIL s\r\njoin CourseRegister cg on s.StudentID = cg.StudentID\r\nwhere cg.CourseID = " + courseID;
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
        private void CourseStudentListForm_Load(object sender, EventArgs e)
        {


        }
    }
}

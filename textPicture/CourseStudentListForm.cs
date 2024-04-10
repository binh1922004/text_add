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
    public partial class CourseStudentListForm : Form
    {
        Student std = new Student();
        public CourseStudentListForm()
        {
            InitializeComponent();
        }
        public CourseStudentListForm(string cid, string label, string semester)
        {
            InitializeComponent();
            loadData(cid);
            txt_CourseID.Text = label;    
            lbl_Semester.Text = "Semester: " + semester;
        }
        void loadData(string courseID)
        {
            string query = "select s.StudentID, s.FirstName, s.LastName, s.BirthDate\r\nfrom STUDENTDETAIL s\r\njoin CourseRegister cg on s.StudentID = cg.StudentID\r\nwhere cg.CourseID = " + courseID;
            DataTable dt = new DataTable();
            dt = std.getAllStudent(query);
            dt.Columns.Add("STT");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["STT"] = i + 1;
            }
            dgv_Data.DataSource = dt;
            
        }
        private void CourseStudentListForm_Load(object sender, EventArgs e)
        {


        }
    }
}

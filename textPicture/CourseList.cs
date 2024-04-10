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
    public partial class CourseList : Form
    {
        public CourseList()
        {
            InitializeComponent();
            
        }
        Course course = new Course();
        public CourseList(string stid)
        {
            InitializeComponent();
            string query = "select c.id, c.label, c.period, c.semester\r\nfrom Course c\r\njoin CourseRegister cg on c.id = cg.CourseID\r\nwhere cg.StudentID = '" + stid +"'"; 
            loadData(query);
        }
        void loadData(string query)
        {
            DataTable dt = new DataTable();
            dt = course.getAllCourse(query).Tables["tblCourse"];
            dgv_CourseList.DataSource = dt;

        }
    }
}

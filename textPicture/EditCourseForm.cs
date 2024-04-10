using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class EditCourseForm : Form
    {
        MyDB db = new MyDB();
        Course course = new Course();
        public EditCourseForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            //numeric 
            neud_pe.Minimum = 10;

            DataTable dt = new DataTable();
            dt = course.getAllCourse().Tables["tblCourse"];
            cbb_ID.DataSource = dt;
            //cbb_ID.SelectedItem = null;
            cbb_ID.DisplayMember = "label";
            cbb_ID.ValueMember = "id";
        }

        private void cbb_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_ID.SelectedIndex < 0 || cbb_ID.SelectedValue.ToString().Any(char.IsLetter))
                return;
            string id = cbb_ID.SelectedValue.ToString();
            string query = "select * from Course where id = " + id;
            DataTable dt = new DataTable();
            dt = course.getAllCourse(query).Tables["tblCourse"];

            txt_CName.Text = dt.Rows[0]["label"].ToString();
            txt_Des.Text = dt.Rows[0]["description"].ToString();
            txt_Semester.Text = dt.Rows[0]["semester"].ToString();


        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string id = cbb_ID.SelectedItem.ToString();
            string cName = txt_CName.Text;
            string cDes = txt_Des.Text;
            int pe = (int)neud_pe.Value;
            course.updateCourse(id, cName, pe, cDes);
        }
    }
}

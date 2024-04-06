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
    public partial class ManageCourseForm : Form
    {
        Course course = new Course();
        BindingSource bs;
        int c = 0;
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            DataSet ds = course.getAllCourse();
            //lsb_Data.DataSource = ds.Tables["tblCourse"];
            lsb_Data.DisplayMember = "label";
            lsb_Data.ValueMember = "id";
            lsb_Data.SelectedItem = null;

            bs = new BindingSource(ds, "tblCourse");
            txt_ID.DataBindings.Add("Text", bs, "id");
            txt_Des.DataBindings.Add("Text", bs, "description");
            txt_Label.DataBindings.Add("Text", bs, "label");
            neud_Hours.DataBindings.Add("Text", bs, "period");

            lsb_Data.DataSource = bs;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (bs.Position < bs.Count - 1)
            {
                bs.Position++;
            }
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            bs.Position = 0;
        }

        private void btn_Pre_Click(object sender, EventArgs e)
        {
            if (bs.Position > 0)
            {
                bs.Position--;
            }
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Count - 1;
        }
       

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                bs.AddNew();
                c = 1;
            }
            else
            {
                btn_Edit.PerformClick();
                c = 0;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string cname = txt_Label.Text;
            string des = txt_Des.Text;
            int period = (int)neud_Hours.Value;
            if (course.checkCourseName(id, cname) && course.verif(id, cname, period, des))
            {
                bs.EndEdit();
                course.editCourseWithBinding();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
            course.deleteCourseWithBinding();
        }
    }
}

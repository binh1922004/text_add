using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class DeleteCourseForm : Form
    {
        Course course = new Course();
        public DeleteCourseForm()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            course.deleteCourse(txt_ID.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

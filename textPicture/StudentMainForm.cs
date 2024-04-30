using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class StudentMainForm : Form
    {
        Student student = new Student();
        User user = new User();
        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            lbl_StdName.Text += GlobalClass.userName;
        }


        private void loadChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_CourseReg_Click(object sender, EventArgs e)
        {
            string userID = GlobalClass.userID;
            AddCourseFromStudentForm form = new AddCourseFromStudentForm(userID);
            loadChildForm(form);
        }

        private void btn_Score_Click(object sender, EventArgs e)
        {
            PrintScoreForm printScore = new PrintScoreForm();
            loadChildForm(printScore);
        }
    }
}

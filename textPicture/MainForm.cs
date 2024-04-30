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
    public partial class MainForm : Form
    {
        string role = "";
        public MainForm(string Role)
        {
            InitializeComponent();
            role = Role;
            if (role == "std")
            {
                menu_Admin.Enabled = false;
            }
        }
        

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            this.Hide();
            addStudentForm.ShowDialog();
            this.Show();
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            StudentListForm studentListForm = new StudentListForm();
            this.Hide();
            studentListForm.ShowDialog();
            this.Show();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentModuleForm stdModuleForm = new StudentModuleForm();
            this.Hide();
            stdModuleForm.ShowDialog();
            this.Show();
        }

        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm stForm = new StaticForm();
            this.Hide();
            stForm.ShowDialog();
            this.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrinterForm printerForm = new PrinterForm();
            this.Hide();
            printerForm.ShowDialog();
            this.Show();
        }

        private void menu_Admin_Click(object sender, EventArgs e)
        {
            AdminForm aForm = new AdminForm();
            this.Hide();
            aForm.ShowDialog();
            this.Show();
        }

        private void imporStudentLítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportStudentForm importStudentForm = new ImportStudentForm();
            this.Hide();
            importStudentForm.ShowDialog();
            this.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse addCourse = new AddCourse();
            this.Hide();
            addCourse.ShowDialog();
            this.Show();
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCourseForm delCourseForm = new DeleteCourseForm();
            this.Hide();
            delCourseForm.ShowDialog();
            this.Show();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editForm = new EditCourseForm();
            this.Hide();
            editForm.ShowDialog();
            this.Show();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm manageCourse = new ManageCourseForm();
            this.Hide();
            manageCourse.ShowDialog();
            this.Show();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm printCourse = new PrintCourseForm();
            this.Hide();
            printCourse.ShowDialog();
            this.Show();
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addScoreForm = new AddScoreForm();
            this.Hide();
            addScoreForm.ShowDialog();
            this.Show();
        }

        private void avgScoreByCouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreByCouse avgScoreByCouse = new AvgScoreByCouse();
            this.Hide();
            avgScoreByCouse.ShowDialog();
            this.Show();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm manageScoreForm = new ManageScoreForm();
            this.Hide();
            manageScoreForm.ShowDialog();
                this.Show();
        }

        private void selectCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseFromStudentForm addCourseFromStudentForm = new AddCourseFromStudentForm();
            this.Hide();
            addCourseFromStudentForm.ShowDialog();
            this.Show();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentForm manageStudentForm = new ManageStudentForm();
            this.Hide();
            manageStudentForm.ShowDialog();
            this.Show();
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgResultByScore avgResultByScore = new AvgResultByScore();
            this.Hide();
            avgResultByScore.ShowDialog();
                this.Show();
        }

        private void avgResultByScoreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AvgResultByScore avgResultByScore = new AvgResultByScore();
            this.Hide();
            avgResultByScore.ShowDialog();
            this.Show();
        }

        private void staticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResult staticResult = new StaticResult();
            this.Hide();
            staticResult.ShowDialog();
            this.Show();
        }
    }
}

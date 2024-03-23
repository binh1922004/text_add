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
            if (role == "user")
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

        }
    }
}

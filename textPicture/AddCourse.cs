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
    public partial class AddCourse : Form
    {
        private Course course = new Course();
        public AddCourse()
        {
            InitializeComponent();
            List<int> semester = new List<int>();
            semester.Add(1);
            semester.Add(2);
            semester.Add(3);
            cbb_Semester.DataSource = semester;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string cname = txt_CName.Text;
            string des = txt_Des.Text;
            int period;
            if (Int32.TryParse(txt_Period.Text, out period))
            {
                if (period < 10)
                {
                    MessageBox.Show("Period is must greater or equal 10");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Plese enter period is integer");
                return;
            }

            if (course.insertCourse(id, cname, period, des)){
                MessageBox.Show("Successfully added");
            }
            else
            {
                MessageBox.Show("Failed added");
            }
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

        }
    }
}

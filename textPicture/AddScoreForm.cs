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
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }

        Course course = new Course();  
        Score score = new Score();
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityManageDataSet4.STUDENTDETAIL' table. You can move, or remove it, as needed.
            this.sTUDENTDETAILTableAdapter2.Fill(this.universityManageDataSet4.STUDENTDETAIL);
            // TODO: This line of code loads data into the 'universityManageDataSet3.STUDENTDETAIL' table. You can move, or remove it, as needed.
            this.sTUDENTDETAILTableAdapter1.Fill(this.universityManageDataSet3.STUDENTDETAIL);
            // TODO: This line of code loads data into the 'studentManageDataSet.StudentDetail' table. You can move, or remove it, as needed.
            this.studentDetailTableAdapter.Fill(this.studentManageDataSet.StudentDetail);
            cbb_Course.DataSource = course.getAllCourse().Tables["tblCourse"];
            cbb_Course.DisplayMember = "Label";
            cbb_Course.ValueMember = "id";
            
            cbb_Course.SelectedIndex = 0;
        }

        private void cbb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Course.SelectedIndex > -1)
            {
                DataTable dt = cbb_Course.DataSource as DataTable;
                txt_Des.Text = dt.Rows[cbb_Course.SelectedIndex]["description"].ToString();
            }
        }

        private void dgv_DataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgv_DataStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_SID.Text = id;
            }
        }

        private void btn_AddScore_Click(object sender, EventArgs e)
        {
            string sid = txt_SID.Text;
            int cid = (int)cbb_Course.SelectedValue;
            float scoreval;
            if (!float.TryParse(txt_Score.Text, out scoreval))
            {
                MessageBox.Show("Enter float number");
                return;
            }
            else if (scoreval < 0 || scoreval > 10)
            {
                MessageBox.Show("Score need between 0 and 10");
                return;
            }
            string des = txt_Des.Text;

            if (score.insertScore(sid, cid, scoreval, des))
            {

            }
        }
    }
}

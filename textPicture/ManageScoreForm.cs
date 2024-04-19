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
    public partial class ManageScoreForm : Form
    {
        Score score = new Score();
        Course course = new Course();
        public ManageScoreForm()
        {
            InitializeComponent();
            cbb_Course.DataSource = course.getAllCourse().Tables["tblCourse"];
            cbb_Course.DisplayMember = "Label";
            cbb_Course.ValueMember = "id";

            cbb_Course.SelectedIndex = 0;
        }
        private void btn_ShowStudent_Click(object sender, EventArgs e)
        {
            clear();
            dgv_DataStudent.Visible = true;
            dgv_DataStudent.DataSource = score.getScoreTable("select studentid, firstname, lastname from StudentDetail");
            dgv_DataScore.Visible = false;
        }

        private void clear()
        {
            txt_Des.Text = "";
            txt_Score.Text = "";
            txt_SID.Text = "";
            cbb_Course.SelectedItem = null;
        }

        private void btn_ShowScore_Click(object sender, EventArgs e)
        {
            clear();
            dgv_DataScore.Visible = true;
            dgv_DataScore.DataSource = score.getScoreTable();
            dgv_DataStudent.Visible = false;

        }

        private void dgv_DataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgv_DataStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_SID.Text = id;
            }
        }
        private void dgv_DataScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgv_DataScore.Rows[e.RowIndex].Cells[0].Value.ToString();
                string cid = dgv_DataScore.Rows[e.RowIndex].Cells[1].Value.ToString();
                string scoreval = dgv_DataScore.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_SID.Text = id;
                txt_Score.Text = scoreval;
                cbb_Course.SelectedValue = cid;
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dgv_DataScore.Visible == true)
            {
                string sid = txt_SID.Text;
                string cid = cbb_Course.SelectedValue.ToString();
               
                string des = txt_Des.Text;
                if (score.deleteScore(sid, cid))
                {
                    MessageBox.Show("Delete success");
                }
            }
            else
            {

            }
        }
    }
}

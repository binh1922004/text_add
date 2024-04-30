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
    public partial class AvgResultByScore : Form
    {
        Course course = new Course();
        Student std = new Student();
        Score score = new Score();
        DataTable dtofCourse = new DataTable();
        public AvgResultByScore()
        {
            InitializeComponent();
        }

        private void AvgResultByScore_Load(object sender, EventArgs e)
        {
            addDataStudent();
            addCourseToDGV();
            AddScore();
        }

        private void AddScore()
        {
            for (int i = 0; i < dgv_stdResult.Rows.Count; i++)
            {
                string sid = dgv_stdResult.Rows[i].Cells["id"].Value.ToString();
                string query = "select course_id, score from Score where student_id = '" + sid + "'";
                DataTable dt = score.getScoreTable(query);
                double sum = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    string name = dr["course_id"].ToString();
                    string score = dr["score"].ToString();

                    sum += double.Parse(score);

                    dgv_stdResult.Rows[i].Cells[name].Value = score;
                }
                double len = dt.Rows.Count;
                double avg = Math.Round(sum / len, 2);
                dgv_stdResult.Rows[i].Cells["result"].Value = avg;
            }
        }

        private void addDataStudent(string query = "select StudentID, FirstName, LastName from StudentDetail")
        {
            DataTable dt = std.getAllStudent(query);
            dgv_stdResult.DataSource = dt;
        }

        private void addCourseToDGV()
        {
            DataTable dtofCourse = course.getAllCourse().Tables["tblCourse"];
            foreach (DataRow dr in dtofCourse.Rows)
            {
                string name = dr["id"].ToString();
                string header = dr["Label"].ToString();
                dgv_stdResult.Columns.Add(name, header);
                dgv_stdResult.Columns[name].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgv_stdResult.Columns.Add("result", "Result");
            dgv_stdResult.Columns["result"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgv_stdResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txt_ID.Text = dgv_stdResult.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Fn.Text = dgv_stdResult.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Lname.Text = dgv_stdResult.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            addDataStudent("select StudentID, FirstName, LastName from StudentDetail where concat(StudentID, FirstName, LastName) like '%" + txt_Search.Text + "%'");
            AddScore();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Trim() == "")
            {
                MessageBox.Show("Please select student to print");
            }
            else
            {
                PrintScoreForm printScoreForm = new PrintScoreForm(txt_ID.Text);
                this.Hide();
                printScoreForm.ShowDialog();
                this.Show();
            }
        }
    }
}

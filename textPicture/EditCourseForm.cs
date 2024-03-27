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
            neud_pe.Minimum = 10;

            string query = "select id from Course";
            SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
            db.OpenConnection();
            
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                cbb_ID.Items.Add(id.ToString());
            }
            reader.Close();
            db.CloseConnection();
        }

        private void cbb_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_ID.SelectedIndex < 0)
                return;
            string id = cbb_ID.SelectedItem.ToString();
            string query = "select label, period, description from Course where id = '" + id + "'";
            SqlCommand sqlCmd = new SqlCommand(query, db.SqlCon);
            db.OpenConnection();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                txt_CName.Text = reader.GetString(0);
                int pe = reader.GetInt32(1);
                neud_pe.Value = pe;
                txt_Des.Text = reader.GetString(2);
            }
            reader.Close();
            db.CloseConnection();
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

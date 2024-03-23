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
    public partial class StaticForm : Form
    {
        MyDB db = new MyDB();
        public StaticForm()
        {
            InitializeComponent();
        }

        private void StaticForm_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "select Sex from studentdetail";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, db.SqlCon);
                db.OpenConnection();
                adapter.Fill(dt);

                int toltal = dt.Rows.Count;
                lbl_Total.Text = "Total: " + toltal.ToString();
                int female = 0;
                for (int i = 0; i < toltal; i++)
                {
                    string gender = dt.Rows[i][0].ToString();
                    if (gender.Trim() == "Female")
                    {
                        female++;
                    }
                }
                female = female * 100 / toltal;
                lbl_Female.Text = "Femle: " + female.ToString() + "%";
                lbl_Male.Text = "Male: " + (100 - female).ToString() + "%";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

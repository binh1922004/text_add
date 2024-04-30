using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class ShowFullListByGroupForm : Form
    {
        Group group = new Group();
        Contact contact = new Contact();
        public ShowFullListByGroupForm()
        {
            InitializeComponent();
        }

        private void ShowFullListByGroupForm_Load(object sender, EventArgs e)
        {
            DataTable dt = group.getAllGroup();
            lsb_Group.DisplayMember = "name";
            lsb_Group.ValueMember = "id";
            lsb_Group.DataSource = dt;
            
        }

        private void lsb_Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grid = lsb_Group.SelectedValue.ToString();
            DataTable dt = contact.getCOntactByGrID(grid);
            dgv_DataContact.DataSource = dt;
        }

        private void dgv_DataContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            GlobalClass.contactID = dgv_DataContact.Rows[e.RowIndex].Cells[0].Value.ToString();
            GlobalClass.contactName = dgv_DataContact.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dgv_DataContact.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
            ShowCourseForm showCourseForm = new ShowCourseForm();
            this.Hide();
            showCourseForm.ShowDialog();
            this.Show();
        }
    }
}

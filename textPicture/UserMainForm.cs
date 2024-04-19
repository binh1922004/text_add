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
    public partial class UserMainForm : Form
    {
        Group group = new Group();
        public UserMainForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string id = txt_AddGroupID.Text;
            string gname = txt_AddGroupName.Text;
            group.insertGroup(id, gname);
            loadDataToCBB();
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            loadDataToCBB();
        }

        private void loadDataToCBB()
        {
            DataTable dt = group.getAllGroup();
            cbb_EditGroup.DataSource = dt;
            cbb_EditGroup.DisplayMember = "name";
            cbb_EditGroup.ValueMember = "id";

            cbb_RemoveGroup.DataSource = dt;
            cbb_RemoveGroup.DisplayMember = "name";
            cbb_RemoveGroup.ValueMember = "id";
        }

        private void btn_AddContact_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();
        }

        private void btn_EditContact_Click(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();
            this.Hide();
            editContactForm.ShowDialog();
            this.Show();
        }

        private void btn_RemoveContactSelect_Click(object sender, EventArgs e)
        {
            EditContactModuleForm editContactModuleForm = new EditContactModuleForm();
            if (editContactModuleForm.ShowDialog() == DialogResult.OK)
            {
                txt
            }
        }
    }
}

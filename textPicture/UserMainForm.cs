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
        Contact contact = new Contact();
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
            lbl_Welcome.Text += GlobalClass.userName + "(" + GlobalClass.ID + ")";
            pic_Avatar.Image = GlobalClass.img;
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
                txt_contactID.Text = GlobalClass.contactID;
            }
        }

        private void btn_RemoveContact_Click(object sender, EventArgs e)
        {
            contact.removeContact(txt_contactID.Text);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            string id = cbb_EditGroup.SelectedValue.ToString();
            group.deleteGroup(id);
            loadDataToCBB();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string id = cbb_EditGroup.SelectedValue.ToString();
            string name = txt_EditGroupName.Text;
            group.updateGroup(id, name);
            txt_EditGroupName.Text = "";
            loadDataToCBB();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowFullListByGroupForm showFullListByGroupForm = new ShowFullListByGroupForm();
            showFullListByGroupForm.ShowDialog();
        }
    }
}

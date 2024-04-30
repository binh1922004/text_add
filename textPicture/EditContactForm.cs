using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class EditContactForm : Form
    {
        Contact contact = new Contact();
        Group group = new Group();
        public EditContactForm()
        {
            InitializeComponent();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            EditContactModuleForm editContactModuleForm = new EditContactModuleForm();
            if (editContactModuleForm.ShowDialog() == DialogResult.OK)
            {
                string id = GlobalClass.contactID;
                txt_ID.Text = id;
                DataTable dt = new DataTable();
                dt = contact.getContactByID(id);

                txt_Fname.Text = dt.Rows[0]["fname"].ToString();
                txt_Lname.Text = dt.Rows[0]["lname"].ToString();
                txt_Add.Text = dt.Rows[0]["address"].ToString();
                txt_Phone.Text = dt.Rows[0]["phone"].ToString();
                cbb_Group.SelectedValue = dt.Rows[0]["groupid"];
                txt_Mail.Text = dt.Rows[0]["email"].ToString();

                var data = (byte[])dt.Rows[0]["pic"];
                var pic = new MemoryStream(data);
                pic_Face.Image = Image.FromStream(pic);
            }
        }

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            DataTable dt = group.getAllGroup();
            cbb_Group.DataSource = dt;
            cbb_Group.DisplayMember = "name";
            cbb_Group.ValueMember = "id";
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string fn = txt_Fname.Text;
            string ln = txt_Lname.Text;
            string gr = cbb_Group.SelectedValue.ToString();
            string phone = txt_Phone.Text;
            string mail = txt_Mail.Text;
            string add = txt_Add.Text;

            MemoryStream pic = new MemoryStream();
            pic_Face.Image.Save(pic, pic_Face.Image.RawFormat);

            contact.updateContact(id, fn, ln, gr, phone, mail, add, pic);
        }
    }
}

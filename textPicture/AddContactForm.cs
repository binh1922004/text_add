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
    public partial class AddContactForm : Form
    {
        Group group = new Group();
        Contact contact = new Contact();
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            DataTable dt = group.getAllGroup();
            cbb_Group.DataSource = dt;
            cbb_Group.DisplayMember = "name";
            cbb_Group.ValueMember = "id";
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select image (*.jpg;*.png;*.gif)|*.jpg;*.png;*gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_Face.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
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

            contact.insertContact(id, fn, ln, gr, phone, mail, add, pic);
        }
    }
}

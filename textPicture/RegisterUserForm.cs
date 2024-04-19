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
    public partial class RegisterUserForm : Form
    {
        User user = new User();
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select image (*.jpg;*.png;*.gif)|*.jpg;*.png;*gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_Face.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string fn = txt_fname.Text;
            string ln = txt_lname.Text;
            string userid = txt_User.Text;
            string pass = txt_Pass.Text;
            MemoryStream pic = new MemoryStream();
            pic_Face.Image.Save(pic, pic_Face.Image.RawFormat);

            user.insertUser(id, fn, ln, userid, pass, pic);
        }
    }
}

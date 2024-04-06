using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text.Trim();
            string FirstName = txtFirstName.Text.Trim();
            string LastName = txtLastName.Text.Trim();
            string BirthDate = dtpBirth.Text.Trim();
            MessageBox.Show(BirthDate);
            string Gender = "Male";
            if (rbtnFemale.Checked)
            {
                Gender = "Female";
            }

            string Phone = txtPhone.Text;
            string Address = txtAddress.Text;
            MemoryStream pic = new MemoryStream();
            pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
            int yearbith = dtpBirth.Value.Year;
            int yearnow = DateTime.Now.Year;
            if (yearnow -yearbith < 10 || yearnow - yearbith > 100)
            {
                MessageBox.Show("Age must be between 10 and 100");
            }
            else
            {
                Student.InsertStudent(ID, FirstName, LastName, BirthDate, Gender, Phone, Address, pic);
            }
        }

        private void btnUpLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select image (*.jpg;*.png;*.gif)|*.jpg;*.png;*gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

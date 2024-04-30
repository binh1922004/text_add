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
    public partial class EditContactModuleForm : Form
    {
        Contact contact = new Contact();
        public EditContactModuleForm()
        {
            InitializeComponent();
        }

        private void EditContactModuleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityManageDataSet7.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.universityManageDataSet7.Contact);
            dgv_ContactData.DataSource = contact.getAllContact();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            GlobalClass.contactID = dgv_ContactData.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_ContactData.SelectedRows.Count <= 0)
                return;

        }
    }
}

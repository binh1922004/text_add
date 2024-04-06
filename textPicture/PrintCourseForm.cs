using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityManageDataSet2.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.universityManageDataSet2.Course);

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\binh\HCMUTE\WF" + @"\course_list.txt";
                using (var writer = new StreamWriter(path))
                {
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }
                    int sotiet;
                    for (int i = 0; i < dgv_Data.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgv_Data.Columns.Count; j++)
                        {
                            if (j == 2)
                            {
                                sotiet = Convert.ToInt32(dgv_Data.Rows[i].Cells[j].Value.ToString());
                                writer.Write("\t" + sotiet.ToString() + "\t" + "|");
                            }
                            else if (j == dgv_Data.Columns.Count - 1)
                            {
                                writer.Write("\t" + dgv_Data.Rows[i].Cells[j].Value.ToString());
                            }
                            else
                            {
                                writer.Write("\t" + dgv_Data.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                            }
                        }
                        writer.WriteLine("");
                        writer.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                    }
                }
                MessageBox.Show("Lưu file thành công!! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }
    }
}

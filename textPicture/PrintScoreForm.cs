using Microsoft.Reporting.WinForms;
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
    public partial class PrintScoreForm : Form
    {
        Score score = new Score();
        Student student = new Student();
        string stID = GlobalClass.userID;
        public PrintScoreForm()
        {
            InitializeComponent();
        }
        public PrintScoreForm(string SID)
        {
            stID = SID;
            InitializeComponent();
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {

            DataTable dtScore = score.getScoreTable("select label, score from GetScore where student_id = '" + stID + "'");

            rp_Score.LocalReport.ReportEmbeddedResource = "textPicture.StudentScoreRP.rdlc";
            ReportDataSource rdsScore = new ReportDataSource();
            rdsScore.Name = "DataSet1";
            rdsScore.Value = dtScore;

            rp_Score.LocalReport.DataSources.Add(rdsScore);

            DataTable dtInfo = student.getAllStudent("select * from info where StudentID = '" + stID + "'");

            ReportDataSource rdsInfo = new ReportDataSource();
            rdsInfo.Name = "DataSet2";
            rdsInfo.Value = dtInfo;

            rp_Score.LocalReport.DataSources.Add(rdsInfo);


            this.rp_Score.RefreshReport();
        }
    }
}

using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textPicture
{
    public partial class StaticResult : Form
    {
        public StaticResult()
        {
            InitializeComponent();
        }
        int x = 30, y = 50, delta = 20;
        Score score = new Score();
        private void StaticResult_Load(object sender, EventArgs e)
        {
            staticPass();
            avgCourse();
        }
        private void staticPass()
        {
            DataTable dt = score.getAvgScoreByStudent();
            double sum = dt.Rows.Count;
            double pass = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (double.Parse(dr[0].ToString()) >= 5)
                {
                    pass++;
                }
            }

            double percentPass = Math.Round(pass / sum, 2);
            double percentFail = 100 - percentPass;

            lbl_Fail.Text += percentFail.ToString();
            lbl_Pass.Text += percentPass.ToString();
        }
        private void avgCourse()
        {
            DataTable dt = score.getAvgScoreByCouse();
            Label lbl_current = new Label() { Location = new Point(x, y) };
            foreach (DataRow dataRow in dt.Rows)
            {
                double score = double.Parse(dataRow[1].ToString());
                score = Math.Round(score, 2);

                string txt = dataRow[0].ToString() + ": " + score.ToString();
                Label lbl_new = new Label() { Location = new Point(x, lbl_current.Location.Y + delta) };
                lbl_new.Text = txt;
                pnl_Score.Controls.Add(lbl_new);
                lbl_current = lbl_new;
            }
        }
    }
}

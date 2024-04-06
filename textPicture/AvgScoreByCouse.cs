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
    public partial class AvgScoreByCouse : Form
    {
        public AvgScoreByCouse()
        {
            InitializeComponent();
        }
        Score score = new Score();  
        private void AvgScoreByCouse_Load(object sender, EventArgs e)
        {
            DataTable tableAvg = score.getAvgScoreByCouse();
            dgv_DataAvg.DataSource = tableAvg;  
        }
    }
}

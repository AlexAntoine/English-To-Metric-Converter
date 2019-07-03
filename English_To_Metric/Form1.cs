using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_To_Metric
{
    public partial class frmEnglishToMetric : Form
    {
        public frmEnglishToMetric()
        {
            InitializeComponent();
        }

        private void optMetricToEnglish_CheckedChanged(object sender, EventArgs e)
        {
            grpMetricToEnglish.Visible = true;
            grpMetricToEnglish.Enabled = true;
            grpEnglishToMetric.Visible = true;
            grpEnglishToMetric.Enabled = false;
          
            
        }

        private void optEnglishToMetric_CheckedChanged(object sender, EventArgs e)
        {
            grpEnglishToMetric.Visible = true;
            grpEnglishToMetric.Enabled = true;
            grpMetricToEnglish.Visible = true;
            grpMetricToEnglish.Enabled = false;
            
        }

        private void frmEnglishToMetric_Load(object sender, EventArgs e)
        {
            
        }

        private void grpEnglishToMetric_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

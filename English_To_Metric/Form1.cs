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

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(optEnglishToMetric.Checked)
            {
                EnglishToMetric metric = new EnglishToMetric(txtMiles.Text, txtYards.Text, txtFeet.Text, txtInches.Text);

                txtCentimeters.Text = metric.getCentimeters();
                txtMeters.Text = metric.getMeters();
                txtKilometers.Text = metric.getKilometers();

            }
            else
            {
                MetricToEnglish english = new MetricToEnglish(txtMeters.Text, txtKilometers.Text, txtCentimeters.Text);

                txtInches.Text = english.getInches();
                txtFeet.Text = english.getFeet();
                txtYards.Text = english.getYards();
                txtMiles.Text = english.getMiles();

            }
           
        }

        private void btnEnglishClear_Click(object sender, EventArgs e)
        {
            txtMiles.Clear();
            txtFeet.Clear();
            txtInches.Clear();
            txtYards.Clear();
        }

        private void btnMetricClear_Click(object sender, EventArgs e)
        {
            txtKilometers.Clear();
            txtMeters.Clear();
            txtCentimeters.Clear();
        }

        private void txtInches_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

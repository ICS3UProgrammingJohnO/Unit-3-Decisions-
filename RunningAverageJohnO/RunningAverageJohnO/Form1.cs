using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningAverageJohnO
{
    public partial class frmRunningAverage : Form
    {
        // set the variables
        double sum = 0;
        double numbersByNumbers = 0;

        public frmRunningAverage()
        {
            InitializeComponent();
            // hide the labels
            lblAverageAnswer.Hide();
        }

        private void frmRunningAverage_Load(object sender, EventArgs e)
        {

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            // Show the labels
            lblAverageAnswer.Show();

            // declare local variables
            double userValue;
            double average;

            // get the number from the textbox 
            userValue = double.Parse(txtNumber.Text);

            // increment the number
            numbersByNumbers++;

            // calculate the average
            sum = sum + userValue;
            average = sum / numbersByNumbers;

            // display the average of the running
            lblAverageAnswer.Text = Convert.ToString(average);

            // if the user enters -1, display a Goodbye message and disable buttons
            if (userValue == -1)
            {
                MessageBox.Show("Running average ended.", "Running Average");
                this.btnAverage.Enabled = false;
                this.txtNumber.Visible = false;
                this.Close();
            }
        }
    }
}

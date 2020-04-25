using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialDoWhileJohnO
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
            lblAnswer.Hide();
        }

        private void lstFactorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmFactorial_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            // clear the items from the listbox
            this.lstFactorial.Items.Clear();

            // initialize the final answer to 1
            factorialAnswer = 1;

            // get the number from the user
            factorialNumber = Convert.ToDouble(this.txtNumber.Text);

            // set the counter to 0
            factorialCounter = 0;

            // multiply the counter by the next incremented number until it reaches the user's number
            do
            {
                // increment the counter by 1
                factorialCounter = factorialCounter + 1;

                // list the counter number in the listbox for the user to see
                lstFactorial.Items.Add(factorialCounter);

                // multiply the counter by the answer
                factorialAnswer = factorialAnswer * factorialCounter;

            } while (factorialCounter < factorialNumber);

            // convert the factorialAnswer to a String and insert it into the label
            this.lblAnswer.Text = this.txtNumber.Text + "! = " + Convert.ToString(factorialAnswer);

            // show the label answer
            lblAnswer.Show();
        }
    }
}

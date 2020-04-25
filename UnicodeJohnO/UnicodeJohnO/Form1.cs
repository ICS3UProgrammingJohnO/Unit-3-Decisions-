using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeJohnO
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void frmUnicode_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            string letters;
            int letterCounter;

            // Clear the items in listbox
            this.lstUnicode.Items.Clear();

            // Create loop to convert each number
            for (letterCounter = 65; letterCounter <= 90; letterCounter++)
            {
                // convert the counter to unicode letter
                letters = Char.ConvertFromUtf32(letterCounter);

                // add letter with its value to the listbox
                this.lstUnicode.Items.Add(letters + " -> " + letterCounter);
            }
        }
    }
}

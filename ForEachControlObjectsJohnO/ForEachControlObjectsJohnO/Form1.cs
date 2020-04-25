using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachControlObjectsJohnO
{
    public partial class frmForEachControl : Form
    {
        public frmForEachControl()
        {
            InitializeComponent();
        }

        private void frmForEachControl_Load(object sender, EventArgs e)
        {

        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            // loop through each object on the form and make it blue
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Blue;
            }
        }

        private void lblColour_Click(object sender, EventArgs e)
        {
            // loop through each object on the form and make it red
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Red;

                //  if the object is a label, make it brown
                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Brown;
                }
            }
        }
    }
}

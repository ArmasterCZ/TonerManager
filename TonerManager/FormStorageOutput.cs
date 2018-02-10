using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TonerManager
{
    public partial class FormStorageOutput : Form
    {
        public FormStorageOutput()
        {
            InitializeComponent();
        }

        private void increaseTextBoxNumber(object sender, EventArgs e)
        {
            try
            {
                MaskedTextBox maskedTextBox = ((MaskedTextBox)sender);
                int number;
                try 
	            {
                    number = Convert.ToInt16(maskedTextBox.Text);
	            }
	            catch
	            {
		            number = 0;
	            }

                if (number < 5)
                {
                    number++;
                }
                else
                {
                    number = 0;
                }
                maskedTextBox.Text = number.ToString();
            }
            catch (Exception exc)
            {
                
                //throw (exc => exc.Message = "error"; return exc);
            }
        }
    }
}

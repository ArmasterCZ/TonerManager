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
    public partial class FormSaveToner : Form
    {
        public FormSaveToner()
        {
            InitializeComponent();
        }

        public List<Toner> tonerList = new List<Toner>();

        private void bWrite_Click(object sender, EventArgs e)
        {
            saveNewToner();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bErase_Click(object sender, EventArgs e)
        {
            try
            {
                Toner newToner = createTonerFromUi();
                if (tonerList.Contains(newToner))
                {
                    tonerList.Remove(newToner);
                    MessageBox.Show("Toner smazán.");
                }
                else
                {
                    MessageBox.Show("Toner v databázi neexistuje.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(@"Error. {0}. Toner nemohl být smazán.", exc.Message);
            }
        }

        private void saveNewToner()
        {
            try
            {
                Toner newToner = createTonerFromUi();
                tonerList.Add(newToner);
                MessageBox.Show("Toner uložen.");
            }
            catch (Exception exc)
            {
                MessageBox.Show(@"Error. {0}. Toner nebyl uložen.", exc.Message);
            }
        }

        private Toner createTonerFromUi()
        {
            Toner newToner = new Toner();
            newToner.name = tbType.Text;
            newToner.bareCode = tbBareCode.Text;

            if (cbColor.SelectedItem == null)
            {
                throw new Exception("Nebyla vybrána položka barvy.");
            }
            else if (tbType.Text == "")
            {
                throw new Exception("Nebyl vyplněn typ.");
            }
            else
            {
                switch (cbColor.SelectedItem.ToString())
                {
                    case "Cyan":
                        newToner.color = Color.Cyan;
                        break;
                    case "Magenta":
                        newToner.color = Color.Magenta;
                        break;
                    case "Yellow":
                        newToner.color = Color.Yellow;
                        break;
                    case "Black":
                        newToner.color = Color.Black;
                        break;
                    default:
                        throw new Exception("Nebyla vybrána položka barvy.");
                        break;
                }
            }
            return newToner;
        }

    }
}

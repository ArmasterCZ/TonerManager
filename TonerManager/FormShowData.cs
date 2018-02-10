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
    public partial class FormSave : Form
    {
        public FormSave()
        {
            InitializeComponent();
        }

        public List<Printer> listPrinter = new List<Printer>();
        public List<Place> listPlace = new List<Place>();
        public List<Toner> listToner = new List<Toner>();
        
        private void createTonerLayout()
        {

        }

        private void createTestData()
        {
            Toner toner1 = new Toner
            {
                name = "DesignJet 711",
                color = Color.Black,

            };
            Toner toner2 = new Toner
            {
                name = "DesignJet 711",
                color = Color.Magenta,

            };
            Toner toner3 = new Toner
            {
                name = "LaserJet 125A",
                color = Color.Black,

            };

            listToner.Add(toner1);
            listToner.Add(toner2);
            listToner.Add(toner3);

            Printer printer1 = new Printer()
            {
                multicolor = true,
                type = "Ploter M520",
                numberOfPrinters = 1,
                note = "kuchinka",
                //placeList
                //tonerList
                
            };
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbClass.SelectedItem.ToString())
            {
                case "Tonery":

                    break;
                case "Tiskarny":

                    break;
                case "Místa":

                    break;
                default:
                    MessageBox.Show("Error. Zadejte seznam co si přejete zobrazit?." );
                    break;
            }
        }

        private void createDataTableFrom()
        {

        }
    }
}

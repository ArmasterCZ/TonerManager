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
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }

        private void getPath()
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            string startupPath2 = Environment.CurrentDirectory;

        }
    }
}

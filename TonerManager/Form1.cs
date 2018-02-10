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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bStorageOutput_Click(object sender, EventArgs e)
        {
            FormStorageOutput formStorageOutput = new FormStorageOutput();
            formStorageOutput.Show();
        }

        private void bStorageInput_Click(object sender, EventArgs e)
        {
            FormStorageInput formStorageInput = new FormStorageInput();
            formStorageInput.Show();
        }

        private void tsmiSetData_Click(object sender, EventArgs e)
        {
            FormSaveToner formSave = new FormSaveToner();
            formSave.Show();
        }


    }
}

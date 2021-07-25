using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addVendorButton_Click(object sender, EventArgs e)
        {
            //open the new vendor form, when saving the vendor, colse the new vendor form
            var addVendorForm = new AddVendorForm();
            addVendorForm.Show();
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {

        }
    }
}

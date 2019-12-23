// Adrián Navarro Gabino

using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    partial class About : Form
    {
        private Main main;

        public About(Main main)
        {
            InitializeComponent();
            this.main = main;
            main.SetStatus("Status");
        }

        private void Accept(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

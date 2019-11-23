using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Accept(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

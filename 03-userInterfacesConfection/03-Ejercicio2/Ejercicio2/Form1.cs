using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
        }

        private void GoForm2(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }
    }
}

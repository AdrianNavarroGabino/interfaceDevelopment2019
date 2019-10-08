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
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void GoForm1(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void GoForm1(object sender, FormClosedEventArgs e)
        {
            form1.Close();
        }
    }
}

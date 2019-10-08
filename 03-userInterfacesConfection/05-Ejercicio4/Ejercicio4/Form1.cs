using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert(object sender, EventArgs e)
        {
            int num = (int)number.Value;

            if (octalBtn.Checked)
            {
                resultLbl.Text = System.Convert.ToString(num, 8);
            }
            else if (decimalBtn.Checked)
            {
                resultLbl.Text = System.Convert.ToString(num, 10);
            }
            else if (hexadecimalBtn.Checked)
            {
                resultLbl.Text = System.Convert.ToString(num, 16);
            }
        }

        private void Reset(object sender, KeyPressEventArgs e)
        {
            Reset();
        }

        private void Reset(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            resultLbl.Text = "";
            octalBtn.Checked = false;
            decimalBtn.Checked = false;
            hexadecimalBtn.Checked = false;
        }
    }
}

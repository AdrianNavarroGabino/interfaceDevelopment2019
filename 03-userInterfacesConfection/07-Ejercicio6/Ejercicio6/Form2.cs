using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form2 : Form
    {
        private int numberOfDays;
        private Form1 form1;

        public Form2(decimal month, Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1;

            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    numberOfDays = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    numberOfDays = 30;
                    break;
                case 2:
                    numberOfDays = 28;
                    break;
            }

            for(int i = 1; i <= numberOfDays; i++)
            {
                TextBox tb = new TextBox();
                tb.Text = i + "";
                tableLayoutPanel1.Controls.Add(tb);
                int row = i >= 1 && i <= 7 ? 0 :
                    (i >= 8 && i <= 14 ? 1 :
                    (i >= 15 && i <= 21 ? 2 :
                    (i >= 22 && i <= 28 ? 3 : 4)));
                tableLayoutPanel1.SetRow(tb, row);
                tableLayoutPanel1.SetColumn(tb, (i - 1) % 7);
            }
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            form1.Close();
        }
    }
}

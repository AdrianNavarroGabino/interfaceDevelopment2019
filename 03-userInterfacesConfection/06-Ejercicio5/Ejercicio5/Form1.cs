using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Add(object sender, EventArgs e)
        {
            Add();
        }

        private void SelectItem(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox1.Text =
                    listBox1.Items[listBox1.SelectedIndex].ToString();
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void Delete(object sender, EventArgs e)
        {
            if(listBox1.Items.Contains(textBox1.Text))
            {
                listBox1.Items.Remove(textBox1.Text);
            }
        }

        private void Add(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Add();
            }
        }

        private void Add()
        {
            if (textBox1.Text != "" && !listBox1.Items.Contains(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void ShowItem(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBox1.Text))
            {
                form2 = new Form2(this, textBox1.Text);
                this.Hide();
                form2.Show();
            }
        }
    }
}

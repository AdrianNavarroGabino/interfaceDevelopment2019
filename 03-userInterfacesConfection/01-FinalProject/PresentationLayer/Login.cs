using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using EntityLayer;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        private Bussiness buss;

        public Login()
        {
            buss = new Bussiness();
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectAllPass(object sender, EventArgs e)
        {
            if(textBox2.Text == "Password")
                textBox2.SelectAll();
        }

        private void selectAllUser(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
                textBox1.SelectAll();
        }

        private void Validate(object sender, EventArgs e)
        {
            errorLabel.ForeColor = Color.Red;
            if (textBox1.Text == "Username" || textBox2.Text == "Password")
            {
                errorLabel.Text = "Debes introducir usuario y contraseña";
            }
            else
            {
                if (buss.Validate(textBox1.Text, textBox2.Text))
                {
                    errorLabel.ForeColor = Color.FromArgb(76,148,144);
                    errorLabel.Text = "Acceso permitido";
                }
                else
                {
                    errorLabel.Text = "Acceso denegado";
                }
            }
        }

        private void NewUser(object sender, EventArgs e)
        {
            /*if (buss.NewUser(textBox1.Text, textBox2.Text))
            {
                errorLabel.ForeColor = Color.FromArgb(76, 148, 144);
                errorLabel.Text = "Usuario creado";
            }
            else
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = "Error al crear el usuario";
            }*/
        }
    }
}

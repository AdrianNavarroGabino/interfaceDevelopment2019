// Adrián Navarro Gabino

using System;
using System.Drawing;
using System.Windows.Forms;
using BussinessLayer;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        private static int attempts;
        private Business buss;
        private Main main;

        public Login()
        {
            buss = new Business();
            InitializeComponent();
            attempts = 3;
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
                    attempts = 3;
                    errorLabel.ForeColor = Color.FromArgb(76,148,144);
                    errorLabel.Text = "Acceso permitido";
                    main = new Main(textBox1.Text, buss);
                    this.Hide();
                    main.Show();

                }
                else
                {
                    attempts--;
                    if (attempts > 0)
                    {
                        errorLabel.Text = "Access denied. You have " +
                            attempts + " attempts left";
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void PressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Validate(sender, e);
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

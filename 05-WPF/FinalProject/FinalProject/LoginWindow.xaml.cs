using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Lógica de interacción para LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private static int attempts;
        private Business buss;
        private MainWindow main;

        public LoginWindow()
        {
            buss = new Business();
            InitializeComponent();
            attempts = 3;

            // Borrar
            // -----------------------------------------------------------
            main = new MainWindow(buss, buss.GetUser("1"));
            this.Hide();
            main.Show();
            // -----------------------------------------------------------
        }

        private void Validate(object sender, RoutedEventArgs e)
        {
            errorLabel.Foreground = Brushes.Red;
            if (mailBox.Text == "" || passBox.Password == "")
            {
                errorLabel.Content = "User and password must not be empty";
            }
            else
            {
                Usuario user = buss.Validate(mailBox.Text, passBox.Password);
                if (user != null)
                {
                    attempts = 3;
                    errorLabel.Foreground = new SolidColorBrush(Color.FromRgb(76, 148, 144));
                    errorLabel.Content = "Access granted";
                    /*main = new Main(textBox1.Text, buss);
                    this.Hide();
                    main.Show();*/
                    main = new MainWindow(buss, user);
                    this.Hide();
                    main.Show();

                }
                else
                {
                    attempts--;
                    if (attempts > 0)
                    {
                        errorLabel.Content = "Access denied. You have " +
                            attempts + " attempts left";
                    }
                    else
                    {
                        //Application.Exit();
                    }
                }
            }
        }
    }
}

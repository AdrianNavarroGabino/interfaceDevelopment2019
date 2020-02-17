// Adrián Navarro Gabino

using BusinessLayer;
using EntityLayer;
using System.Windows;
using System.Windows.Media;

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
                        Close();
                    }
                }
            }
        }
    }
}

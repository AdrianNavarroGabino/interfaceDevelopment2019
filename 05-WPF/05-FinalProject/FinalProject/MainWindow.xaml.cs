using BusinessLayer;
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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Business buss;

        public MainWindow(Business buss)
        {
            InitializeComponent();
            this.buss = buss;
        }

        private void InsertUser(object sender, RoutedEventArgs e)
        {
            User user = new User(buss, 0);
            user.HorizontalAlignment = HorizontalAlignment.Center;
            user.VerticalAlignment = VerticalAlignment.Center;

            panel2.Children.Clear();
            panel2.Children.Add(user);
        }

        private void ModifyUser(object sender, RoutedEventArgs e)
        {
            User user = new User(buss, 1);
            user.HorizontalAlignment = HorizontalAlignment.Center;
            user.VerticalAlignment = VerticalAlignment.Center;

            panel2.Children.Clear();
            panel2.Children.Add(user);
        }

        private void DeleteUser(object sender, RoutedEventArgs e)
        {
            User user = new User(buss, 2);
            user.HorizontalAlignment = HorizontalAlignment.Center;
            user.VerticalAlignment = VerticalAlignment.Center;

            panel2.Children.Clear();
            panel2.Children.Add(user);
        }
    }
}

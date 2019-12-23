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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tabcontrol
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeCar(object sender, RoutedEventArgs e)
        {
            string uri = null;

            if(cochazo.IsChecked == true)
            {
                uri = "cochazo.jpg";
            }
            else if(regular.IsChecked == true)
            {
                uri = "regular.jpg";
            }
            else if(realidad.IsChecked == true)
            {
                uri = "realidad.jpg";
            }

            BitmapImage im = new BitmapImage();
            im.BeginInit();
            im.UriSource = new Uri(uri, UriKind.Relative);
            im.EndInit();
            car.Source = im;
        }

        private void ChangeTeam(object sender, SelectionChangedEventArgs e)
        {
            string uri = null;

            switch(teams.SelectedIndex)
            {
                case 0: uri = "madrid.jpg"; break;
                case 1: uri = "barcelona.jpg"; break;
                case 2: uri = "elche.png"; break;
                case 3: uri = "hercules.jpg"; break;
            }

            BitmapImage im = new BitmapImage();
            im.BeginInit();
            im.UriSource = new Uri(uri, UriKind.Relative);
            im.EndInit();
            team.Source = im;
        }
    }
}

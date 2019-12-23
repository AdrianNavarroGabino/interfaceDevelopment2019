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

namespace DynamicElements
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button b1 = null;
        Button b2 = null;
        Calendar ca = null;
        ComboBox cb = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            ClearScreen();
            FillScreen1();
        }

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            ClearScreen();
            FillScreen2();
        }

        private void FillScreen1()
        {
            b1 = new Button();
            b1.Content = "Boton b1";
            b1.Margin = new Thickness(-300, -180, 0, 0);
            b1.Height = 50;
            b1.Width = 100;
            b1.Name = "b1";
            b1.Click += ShowMessage;
            area.Children.Add(b1);

            b2 = new Button();
            b2.Content = "Boton b2";
            b2.Name = "b2";
            b2.Margin = new Thickness(-300, -50, 0, 0);
            b2.Height = 50;
            b2.Width = 100;
            b2.Click += ShowMessage;
            area.Children.Add(b2);

            ca = new Calendar();
            ca.Name = "dp";
            ca.Margin = new Thickness(200, -100, 0, 0);
            ca.Height = 200;
            ca.Width = 300;
            area.Children.Add(ca);
        }

        private void FillScreen2()
        {
            cb = new ComboBox();
            for(int i = 1; i <= 4; i++)
                cb.Items.Add("Opcion" + i);
            cb.Margin = new Thickness(-300, -180, 0, 0);
            cb.Width = 150;
            cb.Height = 25;
            area.Children.Add(cb);
        }

        private void ClearScreen()
        {
            if(b1 != null)
            {
                area.Children.Remove(b1);
            }
            if (b2 != null)
            {
                area.Children.Remove(b2);
            }
            if (ca != null)
            {
                area.Children.Remove(ca);
            }
            if (cb != null)
            {
                area.Children.Remove(cb);
            }
        }
        private void ShowMessage(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Has pulsado el " + ((Button)sender).Content,
                "Information",
                MessageBoxButton.OK);
        }
    }
}

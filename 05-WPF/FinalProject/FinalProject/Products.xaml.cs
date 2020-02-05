using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FinalProject
{
    /// <summary>
    /// Lógica de interacción para Products.xaml
    /// </summary>
    public partial class Products : UserControl
    {
        private MainWindow main;
        private Business buss;
        private ObservableCollection<ArticuloAux> productsList;
        private CollectionViewSource myView;

        public Products(MainWindow main, Business buss)
        {
            InitializeComponent();

            this.main = main;
            this.buss = buss;

            myView = (CollectionViewSource)this.Resources["products-list"];
            productsList =
                new ObservableCollection<ArticuloAux>(MainWindow.productsAux);

            myView.Source = productsList;
        }

        private void CheckColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "nombreAux":
                    e.Column.Header = "Name";
                    e.Column.DisplayIndex = 0;
                    break;
                case "pvpAux":
                    e.Column.Header = "PVP";
                    e.Column.DisplayIndex = 1;
                    break;
                case "marcaIDAux":
                    e.Column.Header = "Brand";
                    e.Column.DisplayIndex = 2;
                    break;
                case "tipoNombre":
                    e.Column.Header = "Type";
                    e.Column.DisplayIndex = 3;
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private void ConsultProduct(object sender, RoutedEventArgs e)
        {
        }

        private void ModifyPrice(object sender, RoutedEventArgs e)
        {
        }

        private void FillFields(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Filter(object sender, RoutedEventArgs e)
        {
        }

        private void FilterEvent(object sender, FilterEventArgs e)
        {
        }
    }
}

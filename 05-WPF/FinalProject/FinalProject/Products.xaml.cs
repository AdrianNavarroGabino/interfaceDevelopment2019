// Adrián Navarro Gabino

using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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
        private ObservableCollection<string> typesNames;

        public Products(MainWindow main, Business buss)
        {
            InitializeComponent();

            this.main = main;
            this.buss = buss;
            main.SetStatus("Status");

            myView = (CollectionViewSource)this.Resources["products-list"];
            productsList =
                new ObservableCollection<ArticuloAux>(MainWindow.productsAux);

            myView
                .SortDescriptions
                .Add(new System.ComponentModel.SortDescription(
                    "nombreAux", System.ComponentModel.ListSortDirection.Ascending));
            myView.Source = productsList;

            typesNames = new ObservableCollection<string>();
            typesNames.Add("");
            foreach (TipoArticulo t in MainWindow.types)
            {
                typesNames.Add(t.Descripcion);
            }
            typeSearchBox.ItemsSource = typesNames;
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
            CreateProductControls((ArticuloAux)productsDataGrid.SelectedItem, false);
        }

        private void CreateProductControls(ArticuloAux product, bool canEdit)
        {
            RemoveControls();

            switch (product.tipoNombre)
            {
                case "TV": FillTV(product, canEdit); break;
                case "Memoria": FillMemory(product, canEdit); break;
                case "Camara": FillCamera(product, canEdit); break;
                case "Objetivo": FillObjective(product, canEdit); break;
            }
            if (canEdit)
            {
                modifyProduct.Visibility = Visibility.Visible;
            }
            else
            {
                modifyProduct.Visibility = Visibility.Hidden;
            }
        }

        private void FillTV(ArticuloAux product, bool canEdit)
        {
            Tv tv = buss.GetTv(product.articuloIDAux);

            RowDefinition r1 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r1);
            RowDefinition r2 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r2);
            RowDefinition r3 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r3);
            RowDefinition r4 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r4);
            RowDefinition r5 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r5);
            RowDefinition r6 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r6);

            CreateField(tv.panel, "Panel:", 200, 20, new Thickness(67, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 0);

            CreateField(tv.pantalla, "Screen:", 200, 20,
                new Thickness(60, 0, 0, 0), new Thickness(150, 0, 0, 0), 1);

            CreateField(tv.resolucion, "Resolution:", 200, 20,
                new Thickness(40, 0, 0, 0), new Thickness(150, 0, 0, 0), 2);

            CreateField(tv.hdreadyfullhd, "HD/Full HD:", 200, 20,
                new Thickness(37, 0, 0, 0), new Thickness(150, 0, 0, 0), 3);

            CreateField(tv.tdt, "TDT:", 200, 20, new Thickness(75, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 4);

            CreateField(product.pvpAux, "Price:", 200, 20, new Thickness(70, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 5, canEdit);
        }

        private void FillMemory(ArticuloAux product, bool canEdit)
        {
            Memoria memory = buss.GetMemory(product.articuloIDAux);

            RowDefinition r1 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r1);
            RowDefinition r2 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r2);

            CreateField(memory.tipo, "Type:", 200, 20, new Thickness(67, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 0);
            CreateField(product.pvpAux, "Price:", 200, 20, new Thickness(70, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 1, canEdit);
        }

        private void FillCamera(ArticuloAux product, bool canEdit)
        {
            Camara camera = buss.GetCamera(product.articuloIDAux);

            RowDefinition r1 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r1);
            RowDefinition r2 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r2);
            RowDefinition r3 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r3);
            RowDefinition r4 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r4);
            RowDefinition r5 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r5);
            RowDefinition r6 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r6);
            RowDefinition r7 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r7);
            RowDefinition r8 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r8);

            CreateField(camera.resolucion, "Resolution:", 200, 20, new Thickness(65, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 0);
            CreateField(camera.sensor, "Sensor:", 200, 20, new Thickness(83, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 1);
            CreateField(camera.tipo, "Type:", 200, 20, new Thickness(93, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 2);
            CreateField(camera.factor, "Factor:", 200, 20, new Thickness(85, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 3);
            CreateField(camera.objetivo, "Objective:", 200, 20, new Thickness(74, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 4);
            CreateField(camera.pantalla, "Screen:", 200, 20, new Thickness(83, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 5);
            CreateField(camera.zoom, "Zoom:", 200, 20, new Thickness(84, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 6);
            CreateField(product.pvpAux, "Price:", 200, 20, new Thickness(93, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 7, canEdit);
        }

        private void FillObjective(ArticuloAux product, bool canEdit)
        {
            Objetivo objective = buss.GetObjective(product.articuloIDAux);

            RowDefinition r1 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r1);
            RowDefinition r2 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r2);
            RowDefinition r3 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r3);
            RowDefinition r4 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r4);
            RowDefinition r5 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r5);
            RowDefinition r6 = new RowDefinition();
            productsGrid.RowDefinitions.Add(r6);

            CreateField(objective.tipo, "Type:", 200, 20, new Thickness(83, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 0);
            CreateField(objective.montura, "Mount:", 200, 20, new Thickness(75, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 1);
            CreateField(objective.focal, "Focal:", 200, 20, new Thickness(82, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 2);
            CreateField(objective.apertura, "Opening:", 200, 20, new Thickness(67, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 3);
            CreateField(objective.especiales, "Specials:", 200, 20, new Thickness(70, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 4);
            CreateField(product.pvpAux, "Price:", 200, 20, new Thickness(89, 0, 0, 0),
                new Thickness(150, 0, 0, 0), 5, canEdit);
        }

        private void CreateField(
            String tbText, string labelContent, int tbWidth,
            int tbHeight, Thickness tbMargin, Thickness spMargin, int gridRow,
            bool canEdit = false)
        {
            StackPanel sp = new StackPanel();
            sp.Orientation = Orientation.Horizontal;
            Label lbl = new Label();
            lbl.Content = labelContent;
            TextBox tb = new TextBox();
            tb.Text = tbText;
            tb.Width = tbWidth;
            tb.Height = tbHeight;
            tb.Margin = tbMargin;
            if (!canEdit)
            {
                tb.IsEnabled = false;
            }
            else
            {
                tb.IsEnabled = true;
                sp.Name = "stackPanelProducts";
                tb.Name = "pvp";
            }
            sp.Children.Add(lbl);
            sp.Children.Add(tb);
            sp.Margin = spMargin;
            Grid.SetRow(sp, gridRow);
            productsGrid.Children.Add(sp);
        }

        private void RemoveControls()
        {
            productsGrid.Children.Clear();
            productsGrid.RowDefinitions.Clear();
        }

        private void ModifyPrice(object sender, RoutedEventArgs e)
        {
            CreateProductControls((ArticuloAux)productsDataGrid.SelectedItem, true);
        }

        private void Filter(object sender, RoutedEventArgs e)
        {
            myView.Filter += FilterEvent;
        }

        private void FilterEvent(object sender, FilterEventArgs e)
        {
            ArticuloAux prod = (ArticuloAux)e.Item;

            if (prod != null)
            {
                if (prod.nombreAux.ToUpper().Contains(nameSearchBox.Text.ToUpper()) &&
                    (typeSearchBox.SelectedItem == null || prod.tipoNombre == typeSearchBox.SelectedItem.ToString() || typeSearchBox.SelectedItem.ToString() == ""))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void Filter(object sender, SelectionChangedEventArgs e)
        {
            myView.Filter += FilterEvent;
        }

        private void ModifyProduct(object sender, RoutedEventArgs e)
        {
            StackPanel sp = (StackPanel)productsGrid.Children[productsGrid.Children.Count - 1];
            TextBox pvp = (TextBox)sp.Children[sp.Children.Count - 1];
            
            string newPrice = pvp.Text;

            ArticuloAux p = (ArticuloAux)productsDataGrid.SelectedItem;

            try
            {
                Articulo p1 = buss.GetProduct(p.articuloIDAux);
                p.pvpAux = newPrice;
                p1.pvp = newPrice;
                if (buss.ModifyProduct(p1.articuloID, p1))
                {
                    MainWindow.products = buss.GetProducts();
                    MainWindow.productsAux.Clear();
                    foreach (Articulo pr in MainWindow.products)
                    {
                        MainWindow.productsAux.Add(new ArticuloAux(pr, MainWindow.types));
                    }
                    productsList =
                        new ObservableCollection<ArticuloAux>(MainWindow.productsAux);
                    productsDataGrid.Items.Refresh();
                    main.SetStatus("Price changed");
                }
            }
            catch (Exception)
            {
                main.SetStatus("Enter a valid price", true);
            }
        }
    }
}

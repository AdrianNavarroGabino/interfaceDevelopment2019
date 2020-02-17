// Adrián Navarro Gabino

using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace FinalProject
{
    /// <summary>
    /// Lógica de interacción para NewOrder.xaml
    /// </summary>
    public partial class NewOrder : UserControl
    {
        private MainWindow main;
        private Business buss;
        private double pvp;
        private long orderPK;

        private ObservableCollection<Usuario> usersList;
        private CollectionViewSource usersView;

        private ObservableCollection<ArticuloAux> productsList;
        private CollectionViewSource productsView;
        private ObservableCollection<string> typesNames;

        private List<Articulo> orderRows;
        private ObservableCollection<Articulo> orderRowsList;
        private CollectionViewSource orderView;
        private Dictionary<Articulo, int> ordersDictionary;

        public NewOrder(MainWindow main, Business buss)
        {
            InitializeComponent();
            this.main = main;
            this.buss = buss;
            main.SetStatus("Status");
            pvp = 0;

            usersView = (CollectionViewSource)this.Resources["users-list"];
            usersList = new ObservableCollection<Usuario>(MainWindow.users);
            usersView
                .SortDescriptions
                .Add(new System.ComponentModel.SortDescription(
                    "nombre", System.ComponentModel.ListSortDirection.Ascending));
            usersView.Source = usersList;

            productsView = (CollectionViewSource)this.Resources["products-list"];
            productsList =
                new ObservableCollection<ArticuloAux>(MainWindow.productsAux);
            productsView
                .SortDescriptions
                .Add(new System.ComponentModel.SortDescription(
                    "nombreAux", System.ComponentModel.ListSortDirection.Ascending));
            productsView.Source = productsList;

            typesNames = new ObservableCollection<string>();
            typesNames.Add("");
            foreach (TipoArticulo t in MainWindow.types)
            {
                typesNames.Add(t.Descripcion);
            }
            typeSearchBox.ItemsSource = typesNames;

            orderRows = new List<Articulo>();
            orderView = (CollectionViewSource)this.Resources["orders-list"];
            orderRowsList =
                new ObservableCollection<Articulo>(orderRows);
            orderView.Source = orderRowsList;
            ordersDictionary = new Dictionary<Articulo, int>();

            orderPK = Convert.ToInt64(
                MainWindow.orders[MainWindow.orders.Count - 1].PedidoID);
        }

        private void CheckUserColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "nombre":
                    e.Column.Header = "Name";
                    e.Column.DisplayIndex = 0;
                    break;
                case "apellidos":
                    e.Column.Header = "Surname";
                    e.Column.DisplayIndex = 1;
                    break;
                case "email":
                    e.Column.Header = "E-mail";
                    e.Column.DisplayIndex = 2;
                    break;
                case "dni":
                    e.Column.Header = "Id Card";
                    e.Column.DisplayIndex = 3;
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private void CheckProductColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
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

        private void CheckOrdersColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "nombre":
                    e.Column.Header = "Name";
                    e.Column.DisplayIndex = 0;
                    break;
                case "pvp":
                    e.Column.Header = "PVP";
                    e.Column.DisplayIndex = 1;
                    break;
                case "marcaID":
                    e.Column.Header = "Brand";
                    e.Column.DisplayIndex = 2;
                    break;
                case "cantidad":
                    e.Column.Header = "Amount";
                    e.Column.DisplayIndex = 3;
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private void FilterUser(object sender, RoutedEventArgs e)
        {
            usersView.Filter += FilterEvent;
        }

        private void FilterEvent(object sender, FilterEventArgs e)
        {
            Usuario usu = (Usuario)e.Item;

            if (usu != null)
            {
                if (usu.nombre.ToUpper().Contains(nameSearchBox.Text.ToUpper()) &&
                    usu.apellidos.ToUpper().Contains(surnameSearchBox.Text.ToUpper()) &&
                    usu.dni.ToUpper().Contains(idSearchBox.Text.ToUpper()) &&
                    usu.email.ToUpper().Contains(mailSearchBox.Text.ToUpper()))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void FilterProductName(object sender, RoutedEventArgs e)
        {
            productsView.Filter += FilterProductEvent;
        }
        private void FilterProductType(object sender, SelectionChangedEventArgs e)
        {
            productsView.Filter += FilterProductEvent;
        }

        private void FilterProductEvent(object sender, FilterEventArgs e)
        {
            ArticuloAux prod = (ArticuloAux)e.Item;

            if (prod != null)
            {
                if (prod.nombreAux.ToUpper().Contains(productNameSearchBox.Text.ToUpper()) &&
                    (prod.tipoNombre == typeSearchBox.SelectedItem.ToString() || typeSearchBox.SelectedItem.ToString() == ""))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            ArticuloAux productAux = (ArticuloAux)productsDataGrid.SelectedItem;

            if(productAux != null)
            {
                Articulo product = new Articulo(productAux.articuloIDAux,
                    productAux.nombreAux, productAux.pvpAux,
                    productAux.marcaIDAux, productAux.imagenAux,
                    productAux.urlimagenAux, productAux.especificacionesAux,
                    productAux.tipoArticuloIDAux);
                
                if (ordersDictionary.ContainsKey(product))
                {
                    ordersDictionary[product] += 1;
                    product.cantidad = ordersDictionary[product].ToString();
                }
                else
                {
                    orderRowsList.Add(product);
                    ordersDictionary.Add(product, 1);
                    product.cantidad = "1";
                }

                if (product.pvp != null)
                {
                    pvp += Convert.ToDouble(product.pvp);
                    noIvaLbl.Content = pvp + " €";
                    finalPriceLbl.Content = (pvp * 1.21).ToString("#.##") + " €";
                }
            }
        }

        private void SelectOrder(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Articulo product = (Articulo)orderGrid.SelectedItem;
                amountBox.Text = ordersDictionary[product].ToString();
            }
            catch(Exception)
            { }
        }

        private void UpdateAmount(object sender, RoutedEventArgs e)
        {
            Articulo product = (Articulo)orderGrid.SelectedItem;
            if(product != null)
            {
                if (amountBox.Text == "0")
                {
                    pvp -= ordersDictionary[product] * Convert.ToDouble(product.pvp);
                    noIvaLbl.Content = pvp + " €";
                    if (pvp == 0)
                    {
                        finalPriceLbl.Content = "0 €";
                    }
                    else
                    {
                        finalPriceLbl.Content = (pvp * 1.21).ToString("#.##") +
                            " €";
                    }
                    orderRowsList.Remove(product);
                    ordersDictionary.Remove(product);
                }
                else
                {
                    try
                    {
                        int amount = Convert.ToInt32(amountBox.Text);

                        pvp += (amount - ordersDictionary[product]) *
                            Convert.ToDouble(product.pvp);
                        noIvaLbl.Content = pvp + " €";
                        finalPriceLbl.Content = (pvp * 1.21).ToString("#.##") + " €";

                        ordersDictionary[product] = amount;
                        product.cantidad = amount.ToString();
                    }
                    catch
                    {
                        amountBox.Text = ordersDictionary[product].ToString();
                    }
                }
                orderGrid.Items.Refresh();
            }
        }

        private void Order(object sender, RoutedEventArgs e)
        {
            Usuario selectedUser = (Usuario)usersDataGrid.SelectedItem;

            if (selectedUser != null && orderRowsList.Count > 0)
            {
                orderPK++;
                string pkAux = orderPK.ToString();

                int affectedRows = 0;

                bool orderInserted =
                    buss.InsertOrder(new Pedido(
                        pkAux, selectedUser.usuarioID,
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                int row = 1;

                foreach (KeyValuePair<Articulo, int> kvp in ordersDictionary)
                {
                    bool rowInserted =
                        buss.InsertOrderRow(new Linped(pkAux,
                        row.ToString(), kvp.Key.articuloID, (Convert.ToDouble(
                            buss.GetProduct(kvp.Key.articuloID).pvp) * kvp.Value).ToString(),
                        kvp.Value.ToString()));
                    if (rowInserted)
                    {
                        affectedRows++;
                    }
                    row++;
                }

                if (orderInserted && affectedRows == ordersDictionary.Count)
                {
                    main.SetStatus("Order sent");
                    ClearFields();
                }
                else
                {
                    main.SetStatus("Something went wrong", true);
                }
            }
            else if(selectedUser == null)
            {
                main.SetStatus("You must select a user", true);
            }
            else
            {
                main.SetStatus("You must select some products", true);
            }
        }

        private void ClearFields()
        {
            usersDataGrid.SelectedIndex = -1;
            productsDataGrid.SelectedIndex = -1;
            amountBox.Text = "";
            pvp = 0;
            noIvaLbl.Content = "0 €";
            finalPriceLbl.Content = "0 €";
            orderRowsList.Clear();
        }
    }
}

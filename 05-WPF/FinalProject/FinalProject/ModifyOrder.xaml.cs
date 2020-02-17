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
    /// Lógica de interacción para Orders.xaml
    /// </summary>
    public partial class ModifyOrder : UserControl
    {
        private MainWindow main;
        private Business buss;

        private ObservableCollection<PedidoAux> ordersList;
        private CollectionViewSource ordersView;

        private ObservableCollection<LinpedAux> orderRowsList;
        private CollectionViewSource orderRowsView;

        List<Linped> orderRows;
        List<LinpedAux> orderRowsAux;
        private Dictionary<LinpedAux, int> ordersDictionary;

        private ObservableCollection<ArticuloAux> productsList;
        private CollectionViewSource productsView;
        private ObservableCollection<string> typesNames;

        private double pvp;
        private long orderPK;
        private PedidoAux selectedOrder;
        private LinpedAux selectedRow;

        private int rowNumber;

        public ModifyOrder(MainWindow main, Business buss)
        {
            InitializeComponent();
            this.main = main;
            this.buss = buss;
            main.SetStatus("Status");

            orderRows = buss.GetLinpeds();

            orderPK = Convert.ToInt64(
                MainWindow.ordersAux[MainWindow.ordersAux.Count - 1].PedidoIDAux);

            ordersView = (CollectionViewSource)this.Resources["orders-list"];
            ordersList = new ObservableCollection<PedidoAux>(MainWindow.ordersAux);
            ordersView
                .SortDescriptions
                .Add(new System.ComponentModel.SortDescription(
                    "fechaAux", System.ComponentModel.ListSortDirection.Ascending));
            ordersView.Source = ordersList;

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

            orderRowsAux = new List<LinpedAux>();
            orderRowsView = (CollectionViewSource)this.Resources["orders-rows-list"];
            orderRowsList = new ObservableCollection<LinpedAux>(orderRowsAux);
            orderRowsView
                .SortDescriptions
                .Add(new System.ComponentModel.SortDescription(
                    "nombre", System.ComponentModel.ListSortDirection.Ascending));
            orderRowsView.Source = orderRowsList;

            selectedOrder = null;
            ordersDictionary = new Dictionary<LinpedAux, int>();

            rowNumber = 1;
        }

        private void CheckOrderColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "fechaAux":
                    e.Column.Header = "Order date";
                    e.Column.DisplayIndex = 0;
                    break;
                case "nombreAux":
                    e.Column.Header = "Name";
                    e.Column.DisplayIndex = 1;
                    break;
                case "apellidosAux":
                    e.Column.Header = "Surname";
                    e.Column.DisplayIndex = 2;
                    break;
                case "dniAux":
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

        private void SelectOrder(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                pvp = 0;
                selectedOrder = (PedidoAux)ordersDataGrid.SelectedItem;

                orderRowsAux.Clear();
                orderRowsList.Clear();
                ordersDictionary.Clear();

                foreach (Linped or in orderRows)
                {
                    if (or.PedidoID == selectedOrder.PedidoIDAux)
                    {
                        LinpedAux row = new LinpedAux(or, buss.GetProduct(or.articuloID));
                        orderRowsList.Add(row);
                        orderRowsAux.Add(row);
                        pvp += Convert.ToDouble(row.pvp);
                        ordersDictionary.Add(row, Convert.ToInt32(or.cantidad));
                    }
                }

                noIvaLbl.Content = pvp + " €";
                finalPriceLbl.Content = (pvp * 1.21) + " €";

                rowNumber = orderRowsList.Count;
            }
            catch(Exception)
            {
                noIvaLbl.Content = pvp + " €";
                finalPriceLbl.Content = (pvp * 1.21) + " €";
            }
        }

        private void CheckOrderRowColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "nombre":
                    e.Column.Header = "Name";
                    e.Column.DisplayIndex = 0;
                    break;
                case "pvp":
                    e.Column.Header = "Price";
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
                case "total":
                    e.Column.Header = "Total";
                    e.Column.DisplayIndex = 4;
                    break;
                default:
                    e.Cancel = true;
                    break;
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

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            ArticuloAux productAux = (ArticuloAux)productsDataGrid.SelectedItem;

            if (productAux != null)
            {
                Articulo product = new Articulo(productAux.articuloIDAux,
                    productAux.nombreAux, productAux.pvpAux,
                    productAux.marcaIDAux, productAux.imagenAux,
                    productAux.urlimagenAux, productAux.especificacionesAux,
                    productAux.tipoArticuloIDAux);

                LinpedAux rowAdd = new LinpedAux(
                    selectedOrder.PedidoIDAux, (rowNumber + 1).ToString(),
                    product.articuloID, (Convert.ToDouble(product.pvp) *
                    Convert.ToInt32(product.cantidad)).ToString(), "1",
                    product.nombre, product.pvp, product.marcaID);

                if (ordersDictionary.ContainsKey(rowAdd))
                {
                    ordersDictionary[rowAdd] += 1;
                    rowAdd.cantidad = ordersDictionary[rowAdd].ToString();
                }
                else
                {
                    orderRowsList.Add(rowAdd);
                    ordersDictionary.Add(rowAdd, 1);
                    rowAdd.cantidad = "1";
                }

                if (rowAdd.pvp != null)
                {
                    pvp += Convert.ToDouble(product.pvp);
                    noIvaLbl.Content = pvp + " €";
                    finalPriceLbl.Content = (pvp * 1.21).ToString("#.##") + " €";
                }

                rowNumber++;
            }
        }

        private void Filter(object sender, RoutedEventArgs e)
        {
            ordersView.Filter += FilterEvent;
        }

        private void FilterDate(object sender, SelectionChangedEventArgs e)
        {
            ordersView.Filter += FilterEvent;
        }

        private void FilterEvent(object sender, FilterEventArgs e)
        {
            PedidoAux orderFilter = (PedidoAux)e.Item;

            string date = orderDate.SelectedDate != null ?
                orderDate.SelectedDate.ToString() : "";

            if (orderFilter != null)
            {
                if (orderFilter.nombreAux.ToUpper().Contains(nameSearchBox.Text.ToUpper())
                    && orderFilter.fechaAux.Split(' ')[0].Contains(date.Split(' ')[0]))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void ResetFilters(object sender, RoutedEventArgs e)
        {
            nameSearchBox.Clear();
            orderDate.SelectedDate = null;
            Filter(null, null);
        }

        private void SelectOrderRow(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                LinpedAux or = (LinpedAux)ordersRowDataGrid.SelectedItem;
                amountBox.Text = or.cantidad;
            }
            catch(Exception)
            {
                amountBox.Text = "";
            }
        }

        private void UpdateAmount(object sender, RoutedEventArgs e)
        {
            selectedRow = (LinpedAux)ordersRowDataGrid.SelectedItem;
            if (selectedRow != null)
            {
                if (amountBox.Text == "0")
                {
                    pvp -= ordersDictionary[selectedRow] * Convert.ToDouble(selectedRow.importe);
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
                    orderRowsList.Remove(selectedRow);
                    ordersDictionary.Remove(selectedRow);
                }
                else
                {
                    try
                    {
                        int amount = Convert.ToInt32(amountBox.Text);

                        pvp += (amount - ordersDictionary[selectedRow]) *
                            Convert.ToDouble(selectedRow.importe);
                        noIvaLbl.Content = pvp + " €";
                        finalPriceLbl.Content = (pvp * 1.21).ToString("#.##") + " €";

                        ordersDictionary[selectedRow] = amount;
                        selectedRow.cantidad = amount.ToString();
                    }
                    catch
                    {
                        amountBox.Text = ordersDictionary[selectedRow].ToString();
                    }
                    selectedRow.cantidad = amountBox.Text;
                }
                ordersRowDataGrid.Items.Refresh();
            }
        }

        private void Modify(object sender, RoutedEventArgs e)
        {
            foreach (Linped l in MainWindow.orderRows)
            {
                if (l.PedidoID == selectedOrder.PedidoIDAux)
                {
                    buss.DeleteRow(selectedOrder.PedidoIDAux, Convert.ToInt32(l.linea));
                }
            }

            int linea = 1;

            foreach (LinpedAux r in orderRowsList)
            {
                buss.InsertOrderRow(new Linped(selectedOrder.PedidoIDAux,
                    linea.ToString(), r.articuloID, r.importe, r.cantidad));
                linea++;
            }

            MainWindow.orders = buss.GetOrders();
            MainWindow.orderRows = buss.GetLinpeds();
            main.SetStatus("Order modified");
        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            foreach(Linped l in MainWindow.orderRows)
            {
                if(l.PedidoID == selectedOrder.PedidoIDAux)
                {
                    buss.DeleteRow(selectedOrder.PedidoIDAux, Convert.ToInt32(l.linea));
                }
            }

            buss.DeleteOrder(selectedOrder.PedidoIDAux);

            ordersList.Remove(selectedOrder);

            foreach(LinpedAux r in orderRowsList)
            {
                orderRowsList.Remove(r);
            }
            MainWindow.orders = buss.GetOrders();
            MainWindow.orderRows = buss.GetLinpeds();
            main.SetStatus("Order deleted");
        }
    }
}

// Adrián Navarro Gabino

using BusinessLayer;
using EntityLayer;
using Syncfusion.Windows.Reports;
using Syncfusion.Windows.Reports.Viewer;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace FinalProject
{
    /// <summary>
    /// Lógica de interacción para Reports.xaml
    /// </summary>
    public partial class Reports : UserControl
    {
        private MainWindow main;
        private Business buss;

        private ObservableCollection<PedidoAux> ordersList;
        private CollectionViewSource ordersView;

        private PedidoAux selectedOrder;

        private ReportViewer reportViewer1;

        private List<LinpedAux> l_bills;
        private List<Usuario> l_user;
        private List<Pedido> l_order;

        public Reports(MainWindow main, Business buss)
        {
            InitializeComponent();
            this.main = main;
            this.buss = buss;
            main.SetStatus("Status");

            ordersView = (CollectionViewSource)this.Resources["orders-list"];
            ordersList = new ObservableCollection<PedidoAux>(MainWindow.ordersAux);
            ordersView
                .SortDescriptions
                .Add(new System.ComponentModel.SortDescription(
                    "fechaAux", System.ComponentModel.ListSortDirection.Ascending));
            ordersView.Source = ordersList;

            selectedOrder = null;
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

        private void SelectOrder(object sender, SelectionChangedEventArgs e)
        {
            selectedOrder = (PedidoAux)ordersDataGrid.SelectedItem;

            g1.Children.Clear();

            l_bills = new List<LinpedAux>();
            l_order = new List<Pedido>();
            l_user = new List<Usuario>();
            l_user.Add(buss.GetUser(selectedOrder.usuarioIDAux));
            l_order.Add(buss.GetOrder(selectedOrder.PedidoIDAux));

            foreach (Linped lp in buss.GetLinpeds())
            {
                if (lp.PedidoID == selectedOrder.PedidoIDAux)
                {
                    Articulo product = buss.GetProduct(lp.articuloID);

                    l_bills.Add(new LinpedAux(
                        lp.PedidoID, lp.linea, lp.articuloID,
                        lp.importe, lp.cantidad, product.nombre,
                        product.pvp, product.marcaID));
                }
            }

            string ruta = System.IO.Directory.GetCurrentDirectory() +
                          "\\..\\..\\Bill.rdlc";
            reportViewer1 = new ReportViewer();
            reportViewer1.ReportPath = ruta;
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            reportViewer1.DataSources.Clear();
            reportViewer1.DataSources.Add(new ReportDataSource("Linped", l_bills));
            reportViewer1.DataSources.Add(new ReportDataSource("Order", l_order));
            reportViewer1.DataSources.Add(new ReportDataSource("User", l_user));

            reportViewer1.RefreshReport();
            g1.Children.Add(reportViewer1);
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
            PedidoAux order = (PedidoAux)e.Item;

            string date = orderDate.SelectedDate != null ?
                orderDate.SelectedDate.ToString() : "";

            if (order != null)
            {
                if (order.nombreAux.ToUpper().Contains(nameSearchBox.Text.ToUpper())
                    && order.fechaAux.Split(' ')[0].Contains(date.Split(' ')[0]))
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
    }
}

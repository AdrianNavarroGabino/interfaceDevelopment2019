// Adrián Navarro Gabino

using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace FinalProject
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Business buss;
        public Usuario userLogged;
        public static List<Usuario> users;
        public static List<Localidad> towns;
        public static List<Provincia> provinces;
        public static List<Pedido> orders;
        public static List<PedidoAux> ordersAux;
        public static List<Articulo> products;
        public static List<ArticuloAux> productsAux;
        public static List<TipoArticulo> types;
        public static List<Linped> orderRows;
        private int time;

        public MainWindow(Business buss, Usuario userLogged)
        {
            InitializeComponent();
            this.buss = buss;
            users = buss.GetUsers();
            towns = buss.GetTowns();
            provinces = buss.GetProvinces();
            orders = buss.GetOrders();
            ordersAux = new List<PedidoAux>();
            orderRows = buss.GetLinpeds();

            foreach(Pedido o in orders)
            {
                ordersAux.Add(new PedidoAux(o, buss.GetUser(o.usuarioID)));
            }

            products = buss.GetProducts();
            types = buss.GetProductTypes();
            productsAux = new List<ArticuloAux>();
            foreach(Articulo p in products)
            {
                productsAux.Add(new ArticuloAux(p, types));
            }
            this.userLogged = userLogged;
            userNameLbl.Text = userLogged.nombre;
            hourLbl.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 5);
            time = 0;
            timerLbl.Text = (time / 60).ToString("00") + ":" +
                (time % 60).ToString("00");

            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += IncreaseTimer;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void IncreaseTimer(object sender, EventArgs e)
        {
            time++;
            timerLbl.Text = (time / 60).ToString("00") + ":"
                + (time % 60).ToString("00");
            hourLbl.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 5);
            CommandManager.InvalidateRequerySuggested();
        }

        public void SetStatus(string status, bool error = false)
        {
            statusLbl.Text = status;
            if (error)
            {
                statusLbl.Foreground = Brushes.Red;
            }
            else
            {
                statusLbl.Foreground = Brushes.Black;
            }
        }

        public void UsersScreen(object sender, RoutedEventArgs e)
        {
            User user = new User(this, buss);
            user.HorizontalAlignment = HorizontalAlignment.Center;
            user.VerticalAlignment = VerticalAlignment.Center;

            panel21.Children.Clear();
            panel21.Children.Add(user);
        }

        public void ProductsScreen(object sender, RoutedEventArgs e)
        {
            Products products = new Products(this, buss);
            products.HorizontalAlignment = HorizontalAlignment.Center;
            products.VerticalAlignment = VerticalAlignment.Center;

            panel21.Children.Clear();
            panel21.Children.Add(products);
        }

        public void NewOrderScreen(object sender, RoutedEventArgs e)
        {
            NewOrder newOrder = new NewOrder(this, buss);
            newOrder.HorizontalAlignment = HorizontalAlignment.Center;
            newOrder.VerticalAlignment = VerticalAlignment.Center;

            panel21.Children.Clear();
            panel21.Children.Add(newOrder);
        }

        private void ModifyOrderScreen(object sender, RoutedEventArgs e)
        {
            ModifyOrder modifyOrder = new ModifyOrder(this, buss);
            modifyOrder.HorizontalAlignment = HorizontalAlignment.Center;
            modifyOrder.VerticalAlignment = VerticalAlignment.Center;

            panel21.Children.Clear();
            panel21.Children.Add(modifyOrder);
        }

        private void StatisticsScreen(object sender, RoutedEventArgs e)
        {
            Statistics statistics = new Statistics(this, buss);
            statistics.HorizontalAlignment = HorizontalAlignment.Center;
            statistics.VerticalAlignment = VerticalAlignment.Center;

            panel21.Children.Clear();
            panel21.Children.Add(statistics);
        }

        private void ReportsScreen(object sender, RoutedEventArgs e)
        {
            Reports reports = new Reports(this, buss);
            reports.HorizontalAlignment = HorizontalAlignment.Center;
            reports.VerticalAlignment = VerticalAlignment.Center;

            panel21.Children.Clear();
            panel21.Children.Add(reports);
        }

        private void StockScreen(object sender, RoutedEventArgs e)
        {
            Stock stock = new Stock(this, buss);
            stock.HorizontalAlignment = HorizontalAlignment.Center;
            stock.VerticalAlignment = VerticalAlignment.Center;

            panel21.Children.Clear();
            panel21.Children.Add(stock);
        }

        private void Close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Do you really want to exit?",
                "Exit",
                MessageBoxButton.YesNo);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

using BusinessLayer;
using EntityLayer;
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
        public static List<Articulo> products;
        public static List<ArticuloAux> productsAux;
        public static List<TipoArticulo> types;
        private int time;

        public MainWindow(Business buss, Usuario userLogged)
        {
            InitializeComponent();
            this.buss = buss;
            users = buss.GetUsers();
            towns = buss.GetTowns();
            provinces = buss.GetProvinces();
            orders = buss.GetOrders();
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
                statusLbl.Foreground = Brushes.Red;
            }
        }

        private void UsersScreen(object sender, RoutedEventArgs e)
        {
            User user = new User(this, buss);
            user.HorizontalAlignment = HorizontalAlignment.Center;
            user.VerticalAlignment = VerticalAlignment.Center;

            panel21.Children.Clear();
            panel21.Children.Add(user);
        }

        private void ProductsScreen(object sender, RoutedEventArgs e)
        {
            Products products = new Products(this, buss);
            products.HorizontalAlignment = HorizontalAlignment.Center;
            products.VerticalAlignment = VerticalAlignment.Center;

            panel21.Children.Clear();
            panel21.Children.Add(products);
        }
    }
}

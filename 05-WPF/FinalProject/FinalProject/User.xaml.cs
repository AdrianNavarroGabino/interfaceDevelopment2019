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
    /// Lógica de interacción para User.xaml
    /// </summary>
    public partial class User : UserControl
    {
        private MainWindow main;
        private Business buss;
        private ObservableCollection<Usuario> usersList;
        private CollectionViewSource myView;
        private List<Localidad> selectedTowns;
        private ObservableCollection<string> provinceNames;
        private ObservableCollection<string> townNames;

        public User(MainWindow main, Business buss)
        {
            InitializeComponent();

            this.main = main;
            this.buss = buss;
            provinceNames = new ObservableCollection<string>();
            foreach(Provincia p in MainWindow.provinces)
            {
                provinceNames.Add(p.nombre);
            }
            provinceBox.ItemsSource = provinceNames;

            myView = (CollectionViewSource)this.Resources["users-list"];
            usersList = new ObservableCollection<Usuario>(MainWindow.users);

            myView.Source = usersList;
        }

        private void CheckColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
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
        private void FillFields(object sender, SelectionChangedEventArgs e)
        {
            Usuario selectedUser = (Usuario)dataGrid.SelectedItem;
            if (selectedUser != null)
            {
                mailBox.Text = selectedUser.email;
                surnameBox.Text = selectedUser.apellidos;
                nameBox.Text = selectedUser.nombre;
                idBox.Text = selectedUser.dni;
                postalCodeBox.Text = selectedUser.codpos;
                bornBox.Text = selectedUser.nacido;
                provinceBox.SelectedItem = buss.GetProvince(selectedUser.provinciaID).nombre;
                townBox.SelectedItem = buss.GetTown(selectedUser.provinciaID, selectedUser.puebloID).nombre;
                phoneBox.Text = selectedUser.telefono;
                addressBox.Text = selectedUser.calle;
                passBox.IsEnabled = false;
                againBox.IsEnabled = false;
                passBox.Password = "______";
                againBox.Password = "______";
            }
            else
            {
                mailBox.Text = "";
                surnameBox.Text = "";
                nameBox.Text = "";
                idBox.Text = "";
                postalCodeBox.Text = "";
                bornBox.Text = "";
                provinceBox.SelectedItem = null;
                townBox.SelectedItem = null;
                phoneBox.Text = "";
                addressBox.Text = "";
                passBox.IsEnabled = true;
                againBox.IsEnabled = true;
                passBox.Password = "";
                againBox.Password = "";
            }

        }

        private void Filter(object sender, RoutedEventArgs e)
        {
            myView.Filter += FilterEvent;
        }

        private void FilterEvent(object sender, FilterEventArgs e)
        {
            Usuario usu = (Usuario)e.Item;

            if (usu != null)
            {
                if (usu.nombre.ToUpper().Contains(nameSearchBox.Text.ToUpper()) &&
                    usu.apellidos.ToUpper().Contains(surnameSearchBox.Text.ToUpper()) &&
                    usu.dni.ToUpper().Contains(idBox.Text.ToUpper()) &&
                    usu.email.ToUpper().Contains(mailBox.Text.ToUpper()))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void FillTowns(object sender, SelectionChangedEventArgs e)
        {
            selectedTowns = new List<Localidad>();
            townNames = new ObservableCollection<string>();
            int index = provinceBox.SelectedIndex;
            string provinceId = MainWindow.provinces[index].provinciaID;
            
            foreach(Localidad t in MainWindow.towns)
            {
                if(t.provinciaID == provinceId)
                {
                    selectedTowns.Add(t);
                    townNames.Add(t.nombre);
                }
            }

            townBox.ItemsSource = townNames;
        }

        private void DeleteUser(object sender, RoutedEventArgs e)
        {
            Usuario selectedUser = (Usuario)dataGrid.SelectedItem;

            bool hasOrders = false;

            foreach(Pedido p in MainWindow.orders)
            {
                if(p.usuarioID == selectedUser.usuarioID)
                {
                    hasOrders = true;
                    break;
                }
            }

            if (!hasOrders)
            {
                MessageBoxResult confirmResult = MessageBox.Show(
                    "Are you sure to delete " +
                    selectedUser.nombre + " " +
                    selectedUser.apellidos + "?",
                                        "Delete user",
                                        MessageBoxButton.YesNo);
                if (confirmResult == MessageBoxResult.Yes)
                {
                    if (buss.DeleteUser(selectedUser.usuarioID))
                    {
                        MainWindow.users.Remove(selectedUser);
                        usersList = new ObservableCollection<Usuario>(MainWindow.users);
                        myView.Source = usersList;
                    }
                    else
                    {
                        main.SetStatus("Something went wrong", true);
                    }
                }
            }
            else
            {
                main.SetStatus("This user has orders", true);
            }
        }
    }
}

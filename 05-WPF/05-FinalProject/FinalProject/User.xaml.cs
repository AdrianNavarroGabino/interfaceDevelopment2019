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
        private Business buss;
        private ObservableCollection<Usuario> usersList;
        private CollectionViewSource myView;
        private int mode;

        public User(Business buss, int mode)
        {
            InitializeComponent();

            this.mode = mode;
            this.buss = buss;

            if (mode == 0)
            {
                form.Visibility = Visibility.Visible;
                search.Visibility = Visibility.Collapsed;
            }
            else
            {
                form.Visibility = Visibility.Collapsed;
                search.Visibility = Visibility.Visible;

                myView = (CollectionViewSource)this.Resources["users-list"];
                usersList = new ObservableCollection<Usuario>(buss.GetUsers());

                myView.Source = usersList;

                if(mode == 1)
                {
                    searchBtn.Content = "Search";
                }
                else
                {
                    searchBtn.Content = "Delete";
                }
            }
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

        private void Search(object sender, RoutedEventArgs e)
        {
            if(dataGrid.SelectedItem != null)
            {
                Usuario selectedUser = (Usuario)dataGrid.SelectedItem;
                if (mode == 1)
                {
                    form.Visibility = Visibility.Visible;
                    search.Visibility = Visibility.Collapsed;
                    mailBox.Text = selectedUser.email;
                    surnameBox.Text = selectedUser.apellidos;
                    nameBox.Text = selectedUser.nombre;
                    idBox.Text = selectedUser.dni;
                    postalCodeBox.Text = selectedUser.codpos;
                    bornBox.Text = selectedUser.nacido;
                    provinceBox.SelectedItem = buss.GetProvince(selectedUser.provinciaID);
                    townBox.SelectedItem = buss.GetTown(selectedUser.provinciaID, selectedUser.puebloID);
                    phoneBox.Text = selectedUser.telefono;
                    addressBox.Text = selectedUser.calle;
                    passBox.IsEnabled = false;
                    againBox.IsEnabled = false;
                }
                else
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
                            searchBtn.Content = "holaaa";
                            usersList = new ObservableCollection<Usuario>(buss.GetUsers());
                            myView.Source = usersList;
                        }
                        else
                        {
                            MessageBox.Show("Hello to you too! " + selectedUser.usuarioID, "My App");
                        }
                    }
                }
            }
        }
    }
}

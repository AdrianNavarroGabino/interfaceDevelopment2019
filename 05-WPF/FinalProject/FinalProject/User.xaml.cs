// Adrián Navarro Gabino

using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
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
        private const string mailRegex =
            @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$";
        private char[] idCardLetter = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F',
            'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C',
            'K', 'E' };
        private const string passRegex =
            @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{3,}$";

        private const string postalCodeRegex = @"^[0-9]{5}$";
        private const string idRegex = @"^[0-9A-Z][0-9]{7}[A-Z]$";

        private MainWindow main;
        private Business buss;
        private ObservableCollection<Usuario> usersList;
        private CollectionViewSource myView;
        private List<Localidad> selectedTowns;
        private ObservableCollection<string> provinceNames;
        private ObservableCollection<string> townNames;
        private long currentUserId;

        public User(MainWindow main, Business buss)
        {
            InitializeComponent();

            this.main = main;
            this.buss = buss;
            main.SetStatus("Status");

            provinceNames = new ObservableCollection<string>();
            foreach(Provincia p in MainWindow.provinces)
            {
                provinceNames.Add(p.nombre);
            }
            provinceBox.ItemsSource = provinceNames;

            myView = (CollectionViewSource)this.Resources["users-list"];
            usersList = new ObservableCollection<Usuario>(MainWindow.users);

            myView
                .SortDescriptions
                .Add(new System.ComponentModel.SortDescription(
                    "nombre", System.ComponentModel.ListSortDirection.Ascending));
            myView.Source = usersList;

            currentUserId =
                Convert.ToInt64(MainWindow.users[MainWindow.users.Count - 1].usuarioID) + 1;
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
                try
                {
                    string provinceAux;
                    if (selectedUser.provinciaID.Length > 1)
                        provinceAux = selectedUser.provinciaID;
                    else
                        provinceAux = "0" + selectedUser.provinciaID;
                    provinceBox.SelectedItem = buss.GetProvince(provinceAux).nombre;
                    string townAux = "";
                    if (selectedUser.puebloID.Length == 4)
                    {
                        townAux = selectedUser.puebloID;
                    }
                    else
                    {
                        for (int i = 0; i < 4 - selectedUser.puebloID.Length; i++)
                            townAux += "0";
                        townAux += selectedUser.puebloID;
                    }

                    townBox.SelectedItem = buss.GetTown(provinceAux, townAux).nombre;
                }
                catch (Exception) { }
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

        private void FillTowns(object sender, SelectionChangedEventArgs e)
        {
            selectedTowns = new List<Localidad>();
            townNames = new ObservableCollection<string>();
            int index = provinceBox.SelectedIndex;
            if (index != -1)
            {
                string provinceId = MainWindow.provinces[index].provinciaID;

                foreach (Localidad t in MainWindow.towns)
                {
                    if (t.provinciaID == provinceId)
                    {
                        selectedTowns.Add(t);
                        townNames.Add(t.nombre);
                    }
                }

                townBox.ItemsSource = townNames;
            }
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
                        ClearFields();
                        dataGrid.SelectedIndex = -1;
                        MainWindow.users = buss.GetUsers();
                        usersList.Remove(selectedUser);
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

        private void Register(object sender, RoutedEventArgs e)
        {
            bool valId = ValidateId();
            bool valMail = ValidatingMail();
            bool valName = ValidatingName();
            bool valTown = ValidateTown();
            bool valProvince = ValidateProvince();
            bool valPass = ValidatingPassword();
            bool valAgain = ValidatingPasswordAgain();
            bool valZip = ValidatePostalCode();

            if (valId && valMail && valName && valTown && valProvince
                    && valPass && valAgain && valZip)
            {
                string provinceId = GetProvinceByName(
                    provinceBox.SelectedItem.ToString()).provinciaID;
                Usuario us = new Usuario(currentUserId.ToString(), mailBox.Text, passBox.Password, nameBox.Text,
                    surnameBox.Text, idBox.Text, phoneBox.Text,
                    addressBox.Text, null, postalCodeBox.Text, provinceId,
                    GetTownByName(townBox.SelectedItem.ToString(),
                    provinceId).localidadID,
                    bornBox.SelectedDate.Value.ToString("yyyy-MM-dd"));
                bool inserted = buss.InsertUser(
                    currentUserId.ToString(), mailBox.Text, nameBox.Text,
                    surnameBox.Text, passBox.Password, idBox.Text, phoneBox.Text,
                    addressBox.Text, postalCodeBox.Text, provinceId,
                    GetTownByName(townBox.SelectedItem.ToString(),
                    provinceId).localidadID,
                    bornBox.SelectedDate.Value.ToString("yyyy-MM-dd"));
                if (inserted)
                {
                    ClearFields();
                    currentUserId++;
                    main.SetStatus("User inserted");
                    MainWindow.users = buss.GetUsers();
                    usersList.Add(us);
                    myView
                        .SortDescriptions
                        .Add(new System.ComponentModel.SortDescription(
                            "nombre", System.ComponentModel.ListSortDirection.Ascending));
                }
                else
                {
                    foreach (Usuario u in MainWindow.users)
                    {
                        if (u.email == mailBox.Text)
                        {
                            main.SetStatus(
                                "This mail already exists", true);
                            return;
                        }
                        else if (u.dni == idBox.Text)
                        {
                            main.SetStatus(
                                "This ID Card already exists", true);
                            return;
                        }
                    }
                    main.SetStatus(
                        "Something went wrong", true);
                }
            }
        }

        private void ModifyUser(object sender, RoutedEventArgs e)
        {
            bool valId = ValidateId();
            bool valMail = ValidatingMail();
            bool valName = ValidatingName();
            bool valTown = ValidateTown();
            bool valProvince = ValidateProvince();
            bool valZip = ValidatePostalCode();

            if (valId && valMail && valName && valTown && valProvince
                    && valZip)
            {
                Usuario selectedUser = (Usuario)dataGrid.SelectedItem;

                string provinceId = GetProvinceByName(
                    provinceBox.SelectedItem.ToString()).provinciaID;

                selectedUser.email = mailBox.Text;
                selectedUser.nombre = nameBox.Text;
                selectedUser.apellidos = surnameBox.Text;
                selectedUser.dni = idBox.Text;
                selectedUser.telefono = phoneBox.Text;
                selectedUser.calle = addressBox.Text;
                selectedUser.codpos = postalCodeBox.Text;
                selectedUser.provinciaID = provinceId;
                selectedUser.puebloID = GetTownByName(
                    townBox.SelectedItem.ToString(),
                    provinceId).localidadID;
                selectedUser.nacido = bornBox.SelectedDate.Value.ToString("yyyy-MM-dd");

                bool modified = buss.ModifyUser(selectedUser);

                if (modified)
                {
                    ClearFields();
                    main.SetStatus("User modified");
                    MainWindow.users = buss.GetUsers();
                    dataGrid.Items.Refresh();
                }
                else
                {
                    main.SetStatus(
                        "Something went wrong", true);
                }
            }
        }

        private bool ValidatingMail()
        {
            if (mailBox.Text.Trim().Length == 0)
            {
                mailLbl.Content = "Mail cannot be empty";
                return false;
            }

            else if (!Regex.IsMatch(mailBox.Text, mailRegex))
            {
                mailLbl.Content = "Wrong mail";
                return false;
            }
            else
            {
                mailLbl.Content = "";
                return true;
            }
        }

        private bool ValidatingName()
        {
            if (nameBox.Text == "")
            {
                nameLbl.Content = "Name can no be empty";
                return false;
            }
            else
            {
                nameLbl.Content = "";
                return true;
            }
        }

        private bool ValidatingPassword()
        {
            if (!Regex.IsMatch(passBox.Password, passRegex))
            {
                passLbl.Content = 
                    "At least 1 number, 1 capital, " +
                    "1 non-alphanumeric";
                return false;
            }
            else
            {
                passLbl.Content = "";
                return true;
            }
        }

        private bool ValidatingPasswordAgain()
        {
            if (passBox.Password != againBox.Password)
            {
                againLbl.Content = "Passwords don't match";
                return false;
            }
            else
            {
                againLbl.Content = "";
                return true;
            }
        }

        public bool ValidateId()
        {
            if (!Regex.IsMatch(idBox.Text, idRegex))
            {
                idLbl.Content =
                    "Badly formed id";
                return false;
            }

            int aux;
            bool wrong = false;

            if (idBox.Text.Replace("_", "").Length < 9)
            {
                idLbl.Content = "ID Card cannot be empty";
                return false;
            }
            else if ((idBox.Text[0] >= 'A' && idBox.Text[0] <= 'Z') ||
                (idBox.Text[0] >= 'a' && idBox.Text[0] <= 'z'))
            {
                aux = Convert.ToInt32(idBox.Text.Substring(1, 7));
                if (idBox.Text[0] == 'X' || idBox.Text[0] == 'x')
                {
                    if (idBox.Text[8] != idCardLetter[aux % 23])
                    {
                        wrong = true;
                    }
                }
                else if (idBox.Text[0] == 'Y' || idBox.Text[0] == 'y')
                {
                    aux += 10000000;
                    if (idBox.Text[8] != idCardLetter[aux % 23])
                    {
                        wrong = true;
                    }
                }
                else if (idBox.Text[0] == 'Z' || idBox.Text[0] == 'z')
                {
                    aux += 20000000;
                    if (idBox.Text[8] != idCardLetter[aux % 23])
                    {
                        wrong = true;
                    }
                }
                else
                {
                    wrong = true;
                }
            }
            else
            {
                aux = Convert.ToInt32(idBox.Text.Substring(0, 8));
                if (idBox.Text[8] != idCardLetter[aux % 23])
                {
                    wrong = true;
                }
            }

            if (wrong)
            {
                idLbl.Content = "Wrong ID card";
                return false;
            }
            else if (!wrong && idBox.Text.Replace("_", "").Length >= 9)
            {
                idLbl.Content = "";
                return true;
            }
            return false;
        }

        private bool ValidateTown()
        {
            if (townBox.SelectedItem == null)
            {
                townLbl.Content = "You must select a town";
                return false;
            }
            else
            {
                townLbl.Content = "";
                return true;
            }
        }

        private bool ValidateProvince()
        {
            if (provinceBox.SelectedItem == null)
            {
                provinceLbl.Content = "You must select a province";
                return false;
            }
            else
            {
                provinceLbl.Content = "";
                return true;
            }
        }

        private bool ValidatePostalCode()
        {
            if (!Regex.IsMatch(postalCodeBox.Text, postalCodeRegex))
            {
                postalCodeLbl.Content = "Badly formed postal code";
                return false;
            }
            else
            {
                postalCodeLbl.Content = "";
                return true;
            }
        }

        private Provincia GetProvinceByName(String provinceName)
        {
            foreach (Provincia p in MainWindow.provinces)
            {
                if (p.nombre == provinceName)
                {
                    return p;
                }
            }
            return null;
        }

        private Localidad GetTownByName(string townName, string provinceId)
        {
            foreach (Localidad l in MainWindow.towns)
            {
                if (l.nombre == townName && l.provinciaID == provinceId)
                {
                    return l;
                }
            }
            return null;
        }

        private void ClearFields()
        {
            mailBox.Clear();
            nameBox.Clear();
            surnameBox.Clear();
            idBox.Clear();
            phoneBox.Clear();
            addressBox.Clear();
            postalCodeBox.Clear();
            passBox.Clear();
            againBox.Clear();
            provinceBox.SelectedIndex = -1;
            townBox.SelectedIndex = -1;
            bornBox.SelectedDate = null;
        }
    }
}

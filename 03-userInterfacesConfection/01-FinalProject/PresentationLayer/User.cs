// Adrián Navarro Gabino

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BussinessLayer;
using EntityLayer;

namespace PresentationLayer
{
    public partial class User : Form
    {
        private bool validated;
        private const string mailRegex =
            @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$";
        private char[] idCardLetter = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F',
            'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C',
            'K', 'E' };
        private const string passRegex =
            @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{3,}$";

        private Main main;
        private Business buss;
        private List<Provincia> provinces;
        private List<Localidad> towns;
        private List<Usuario> users;
        private Usuario selectedUser;
        private long currentUserId;

        public User(Main main, Business buss, bool modify, string modifyId)
        {
            InitializeComponent();
            this.main = main;
            main.SetStatus("Status");
            this.buss = buss;
            provinces = buss.GetProvinces();
            users = buss.GetUsers();
            towns = buss.GetTowns();
            currentUserId =
                Convert.ToInt64(users[users.Count - 1].usuarioID) + 1;
            foreach (Provincia p in provinces)
            {
                provinceBox.Items.Add(p.nombre);
            }

            if(modify)
            {
                registerLbl.Text = "Modify";
                registerBtn.Text = "MODIFY";
                selectedUser = buss.GetUser(modifyId);
                FillFields();
                bornDate.Value = DateTime.ParseExact(
                    bornDate.Value.ToString().Substring(0,10),
                    "dd/MM/yyyy", null);
                passBox.ReadOnly = true;
                passAgainBox.ReadOnly = true;
            }

            bornDate.MaxDate = DateTime.Now;
        }

        private void FillTowns(object sender, EventArgs e)
        {
            townBox.Items.Clear();
            string provinceId = GetProvinceByName(provinceBox.Text).provinciaID;
            
            foreach(Localidad l in towns)
                if(l.provinciaID == provinceId)
                    townBox.Items.Add(l.nombre);
        }

        private void FillFields()
        {
            mailBox.Text = selectedUser.email;
            nameBox.Text = selectedUser.nombre;
            surnameBox.Text = selectedUser.apellidos;
            passBox.Text = "--------";
            passAgainBox.Text = "--------";
            idBox.Text = selectedUser.dni;
            phoneBox.Text = selectedUser.telefono;
            addressBox.Text = selectedUser.calle;
            postalCodeBox2.Text = selectedUser.codpos;
            provinceBox.Text =
                buss.GetProvince(selectedUser.provinciaID).nombre;
            townBox.Text = GetTown(selectedUser.provinciaID,
                selectedUser.puebloID).nombre;
            bornDate.Text = selectedUser.nacido.Substring(0, 10);
        }

        private Localidad GetTown(String provinceId, String townId)
        {
            foreach(Localidad l in towns)
            {
                if(l.provinciaID == provinceId && l.localidadID == townId)
                {
                    return l;
                }
            }
            return null;
        }

        private Localidad GetTownByName(string townName, string provinceId)
        {
            foreach (Localidad l in towns)
            {
                if (l.nombre == townName && l.provinciaID == provinceId)
                {
                    return l;
                }
            }
            return null;
        }

        private Provincia GetProvinceById(String provinceId)
        {
            return buss.GetProvince(provinceId);
        }

        private Provincia GetProvinceByName(String provinceName)
        {
            foreach (Provincia p in provinces)
            {
                if (p.nombre == provinceName)
                {
                    return p;
                }
            }
            return null;
        }

        private void RegisterOrModify(object sender, EventArgs e)
        {
            errorProvider.Clear();
            validated = true;

            ValidateId(null, null);
            ValidatingMail(null, null);
            ValidatingName(null, null);
            ValidateTown(null, null);
            if (registerBtn.Text == "REGISTER")
            {
                ValidatingPassword(null, null);
            }

            if(!validated)
            {
                ((Main)this.MdiParent).SetStatus("Fields are not correct", true);
                return;
            }

            string provinceId = GetProvinceByName(provinceBox.SelectedItem.ToString()).provinciaID;

            if (registerBtn.Text == "REGISTER")
            {
                bool inserted = buss.InsertUser(
                    currentUserId.ToString(), mailBox.Text, nameBox.Text,
                    surnameBox.Text, passBox.Text, idBox.Text, phoneBox.Text,
                    addressBox.Text, postalCodeBox2.Text, provinceId,
                    GetTownByName(townBox.SelectedItem.ToString(), provinceId).localidadID,
                    bornDate.Text);
                if (inserted)
                {
                    currentUserId++;
                    ((Main)this.MdiParent).SetStatus("User inserted");
                }
                else
                {
                    ((Main)this.MdiParent).SetStatus("Something went wrong", true);
                }
            }
            else if(registerBtn.Text == "MODIFY")
            {
                selectedUser.email = mailBox.Text;
                selectedUser.nombre = nameBox.Text;
                selectedUser.apellidos = surnameBox.Text;
                selectedUser.dni = idBox.Text;
                selectedUser.telefono = phoneBox.Text;
                selectedUser.calle = addressBox.Text;
                selectedUser.codpos = postalCodeBox2.Text;
                selectedUser.provinciaID = provinceId;
                selectedUser.puebloID =GetTownByName(
                    townBox.SelectedItem.ToString(),
                    provinceId).localidadID;
                selectedUser.nacido = bornDate.Text;

                bool modified = buss.ModifyUser(selectedUser);

                if(modified)
                {
                    ((Main)this.MdiParent).SetStatus("User modified");
                }
                else
                {
                    ((Main)this.MdiParent).SetStatus("Something went wrong", true);
                }
            }
        }

        private void ValidatingMail(object sender, CancelEventArgs e)
        {
            if (mailBox.Text.Trim().Length == 0)
            {
                validated = false;
                errorProvider.SetError(mailBox, "Mail cannot be empty");
            }
            
            else if (!Regex.IsMatch(mailBox.Text, mailRegex))
            {
                validated = false;
                errorProvider.SetError(mailBox, "Wrong mail");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void ValidatingName(object sender, CancelEventArgs e)
        {
            if (nameBox.Text == "")
            {
                validated = false;
                errorProvider.SetError(nameBox, "Name can no be empty");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void ValidatingPassword(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(passBox.Text, passRegex))
            {
                validated = false;
                errorProvider.SetError(passBox,
                    "The password must have at least 1 number, a capital " +
                    "letter and a non-alphanumeric character");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void ValidatingPasswordAgain(object sender, CancelEventArgs e)
        {
            if(passBox.Text != passAgainBox.Text)
            {
                validated = false;
                errorProvider.SetError(passAgainBox,
                    "Passwords don't match");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        public void ValidateId(object sender, CancelEventArgs e)
        {
            int aux;
            bool wrong = false;

            if (idBox.Text.Replace("_", "").Length < 9)
            {
                validated = false;
                errorProvider.SetError(idBox, "ID Card cannot be empty");
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
                validated = false;
                errorProvider.SetError(idBox, "Wrong ID card");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        
        private void ValidateTown(object sender, CancelEventArgs e)
        {
            if (townBox.SelectedItem.ToString() == "")
            {
                errorProvider.SetError(townBox, "You must select a town");
                validated = false;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void PlaceCursor(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                ((MaskedTextBox)sender).SelectionStart = ((MaskedTextBox)sender).Text.Length;
            });
        }
    }
}

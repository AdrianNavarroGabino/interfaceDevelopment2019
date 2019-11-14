using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            @"^(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d\s])[A-Za-z\d@$!%*?&]{4,}$";

        Bussiness buss;
        List<Provincia> provinces;
        List<Localidad> towns;
        List<Usuario> users;
        private int nextId;
        private Usuario selectedUser;

        public User(Bussiness buss, bool modify, string idCard)
        {
            InitializeComponent();
            this.buss = buss;
            provinces = buss.GetProvinces();
            users = buss.GetUsers();
            towns = buss.GetTowns();
            GetNextId();
            foreach (Provincia p in provinces)
            {
                provinceBox.Items.Add(p.nombre);
            }

            if(modify)
            {
                registerLbl.Text = "Modify";
                registerBtn.Text = "MODIFY";
                selectedUser = Utils.SearchUserByIdCard(users, idCard);
                FillFields(selectedUser);
                bornDate.Value = DateTime.ParseExact(bornDate.Value.ToString().Substring(0,10), "dd/MM/yyyy", null);
            }

            bornDate.MaxDate = DateTime.Now;
        }

        private void IDLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "ID";
        }

        private void TownLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "Town";
        }

        private void ProvinceLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "Province";
        }

        private void BornLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "Born";
        }

        private void FillTowns(object sender, EventArgs e)
        {
            townBox.Items.Clear();
            string provinceId = GetProvinceByName(provinceBox.Text).provinciaID;
            
            foreach(Localidad l in towns)
            {
                if(l.provinciaID == provinceId)
                {
                    townBox.Items.Add(l.nombre);
                }
            }
        }

        private void FillFields(Usuario user)
        {
            mailBox.Text = user.email;
            nameBox.Text = user.nombre;
            surnameBox.Text = user.apellidos;
            passBox.Text = "--------";
            passAgainBox.Text = "--------";
            idBox.Text = user.dni;
            phoneBox.Text = user.telefono;
            addressBox.Text = user.calle;
            postalCodeBox2.Text = user.codpos;
            provinceBox.Text = GetProvinceById(user.provinciaID).nombre;
            townBox.Text = GetTown(user.provinciaID, user.puebloID).nombre;
            bornDate.Text = user.nacido.Substring(0, 10);
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
            foreach(Provincia p in provinces)
            {
                if(p.provinciaID == provinceId)
                {
                    return p;
                }
            }
            return null;
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

            ValidateId();
            ValidatingMail(null, null);
            ValidatingName(null, null);
            ValidateId();
            ValidateTown();
            if (registerBtn.Text == "REGISTER")
            {
                ValidatingPassword(null, null);
            }

            if(!validated)
            {
                return;
            }

            string provinceId = GetProvinceByName(provinceBox.SelectedText).provinciaID;

            if (registerBtn.Text == "REGISTER")
            {
                bool inserted = buss.InsertUser(
                    nextId, mailBox.Text, nameBox.Text,
                    surnameBox.Text, passBox.Text, idBox.Text, phoneBox.Text,
                    addressBox.Text, postalCodeBox2.Text, provinceId,
                    GetTownByName(townBox.SelectedText, provinceId).localidadID,
                    bornDate.Text);
                if (inserted)
                {
                    nextId++;
                    MessageBox.Show("User inserted");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            else if(registerBtn.Text == "MODIFY")
            {
                bool modified = buss.ModifyUser(
                    selectedUser.usuarioID, mailBox.Text, nameBox.Text,
                    surnameBox.Text, passBox.Text, idBox.Text, phoneBox.Text,
                    addressBox.Text, postalCodeBox2.Text, provinceId,
                    GetTownByName(townBox.SelectedText, provinceId).localidadID,
                    bornDate.Text);

                if(modified)
                {
                    MessageBox.Show("User modified");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }

        private void GetNextId()
        {
            int auxId = -1;

            foreach(Usuario u in users)
            {
                auxId = u.usuarioID > auxId ?
                    u.usuarioID : auxId;
            }

            nextId = auxId + 1;
        }

        private void ValidatingMail(object sender, CancelEventArgs e)
        {
            if (mailBox.Text.Trim().Length == 0 || mailBox.Text == "Mail")
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
            if (nameBox.Text == "Name")
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
                errorProvider.SetError(passBox,
                    "The password must have at least 1 number, a capital " +
                    "letter and a non-alphanumeric character");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        public void ValidateId()
        {
            int aux;
            bool wrong = false;

            if (idBox.Text.Replace("_", "").Length < 9)
            {
                MessageBox.Show(idBox.Text);
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
        }
        
        private void ValidateTown()
        {
            if (townBox.SelectedText == "Town")
            {
                errorProvider.SetError(townBox, "You must select a town");
                validated = false;
            }
        }
    }
}

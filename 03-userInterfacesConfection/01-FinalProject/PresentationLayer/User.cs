using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using EntityLayer;

namespace PresentationLayer
{
    public partial class User : Form
    {
        Bussiness buss;
        List<Provincia> provinces;
        List<Localidad> towns;
        List<Usuario> users;
        private int nextId;

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
                Usuario selectedUser = Utils.SearchUserByIdCard(users, idCard);
                FillFields(selectedUser);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void HidePassword(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).PasswordChar = '•';
        }

        private void Hide(object sender, EventArgs e)
        {

        }

        private void HidePassword(object sender, EventArgs e)
        {
            SetEmpty(sender, e);
            ((TextBox)sender).PasswordChar = '•';
        }

        private void ShowPassword(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                if(tb.Name == "passBox")
                {
                    tb.Text = "Password";
                }
                else if(tb.Name == "passAgainBox")
                {
                    tb.Text = "Password again";
                }
                tb.PasswordChar = '\0';
            }
        }

        private void SetEmpty(object sender, EventArgs e)
        {
            Utils.SetEmpty(sender);
        }

        private void MailLeave(object sender, EventArgs e)
        {
            Utils.MailLeave(sender);
        }

        private void NameLeave(object sender, EventArgs e)
        {
            Utils.NameLeave(sender);
        }

        private void SurnameLeave(object sender, EventArgs e)
        {
            Utils.SurnameLeave(sender);
        }

        private void IDLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "ID";
        }

        private void PhoneLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "Phone";
        }

        private void AddressLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "Address";
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

        private void ValidateSignUp(object sender, EventArgs e)
        {

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

        private void PostalCodeEnter(object sender, EventArgs e)
        {
            postalCodeBox.Visible = false;
            postalCodeBox2.Visible = true;
            postalCodeBox2.Focus();
        }

        private void PostalCodeLostFocus(object sender, EventArgs e)
        {
            if (((MaskedTextBox)sender).Text == "")
            {
                postalCodeBox2.Visible = false;
                postalCodeBox.Visible = true;
            }
        }

        private void IdLostFocus(object sender, EventArgs e)
        {
            Utils.IdLostFocus(sender, idBox, idBox2);
        }

        private void IdEnter(object sender, EventArgs e)
        {
            Utils.IdEnter(idBox, idBox2);
        }

        private void BornEnter(object sender, EventArgs e)
        {
            bornBox.Visible = false;
            bornDate.Visible = true;
            bornDate.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void DateChange(object sender, EventArgs e)
        {
            bornDate.Visible = false;
            bornBox.Visible = true;
            bornBox.Text = bornDate.Value.ToString("dd/MM/yyyy");
        }

        private void FillFields(Usuario user)
        {
            mailBox.Text = user.email;
            nameBox.Text = user.nombre;
            surnameBox.Text = user.apellidos;
            passBox.PasswordChar = '•';
            passBox.Text = "--------";
            passAgainBox.PasswordChar = '•';
            passAgainBox.Text = "--------";
            Utils.IdEnter(idBox, idBox2);
            idBox2.Text = user.dni;
            phoneBox.Text = user.telefono;
            addressBox.Text = user.calle;
            postalCodeBox.Visible = false;
            postalCodeBox2.Visible = true;
            postalCodeBox2.Text = user.codpos;
            provinceBox.Text = GetProvinceById(user.provinciaID).nombre;
            townBox.Text = GetTown(user.provinciaID, user.puebloID).nombre;
            bornBox.Text = user.nacido.Substring(0, 10);
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
            if (registerBtn.Text == "REGISTER")
            {
                string provinceId = GetProvinceByName(provinceBox.Text).provinciaID;
                bool inserted = buss.InsertUser(
                    nextId, mailBox.Text, nameBox.Text,
                    surnameBox.Text, passBox.Text, idBox2.Text, phoneBox.Text,
                    addressBox.Text, postalCodeBox2.Text, provinceId,
                    GetTownByName(townBox.Text, provinceId).localidadID,
                    bornBox.Text);
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
    }
}

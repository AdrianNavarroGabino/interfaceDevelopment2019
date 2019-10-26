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

        public User(Bussiness buss, bool modify)
        {
            InitializeComponent();
            this.buss = buss;
            provinces = buss.GetProvinces();
            foreach(Provincia p in provinces)
            {
                provinceBox.Items.Add(p.nombre);
            }

            if(modify)
            {
                registerLbl.Text = "Modify";
                registerBtn.Text = "MODIFY";
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
            bool isValidated = true;

            if (mailBox.Text == "")
            {
                mailError.Text = "Mail cannot be empty";
                isValidated = false;
            }
            if (nameBox.Text == "")
            {
                nameError.Text = "Name cannot be empty";
                isValidated = false;
            }
            if (surnameBox.Text == "")
            {
                surnameError.Text = "Surname cannot be empty";
                isValidated = false;
            }
            if (passBox.Text == "")
            {
                passError.Text = "Password cannot be empty";
                isValidated = false;
            }
            if (passAgainBox.Text == passBox.Text)
            {
                passAgainError.Text = "Password don't match";
                isValidated = false;
            }
            if (idBox.Text == "")
            {
                IDError.Text = "ID cannot be empty";
                isValidated = false;
            }
            if (phoneBox.Text == "")
            {
                phoneError.Text = "Phone cannot be empty";
                isValidated = false;
            }
            if (addressBox.Text == "")
            {
                addressError.Text = "Address cannot be empty";
                isValidated = false;
            }
            if (postalCodeBox.Text == "")
            {
                postalCodeError.Text = "Postal code cannot be empty";
                isValidated = false;
            }
            if (townBox.Text == "")
            {
                townError.Text = "Town cannot be empty";
                isValidated = false;
            }
            /*if (provinceBox.Text == "")
            {
                provinceError.Text = "Province cannot be empty";
                isValidated = false;
            }*/
            if (bornBox.Text == "")
            {
                bornError.Text = "Born cannot be empty";
                isValidated = false;
            }
        }

        private void FillTowns(object sender, EventArgs e)
        {
            townBox.Items.Clear();
            int id = provinceBox.SelectedIndex + 1;
            towns = buss.GetTowns();
            
            foreach(Localidad l in towns)
            {
                if(Convert.ToInt32(l.provinciaID) == id)
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
    }
}

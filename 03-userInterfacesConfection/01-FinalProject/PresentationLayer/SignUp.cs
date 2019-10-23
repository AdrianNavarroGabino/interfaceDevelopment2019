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
    public partial class SignUp : Form
    {
        Bussiness buss;
        List<Provincia> provinces;
        List<Localidad> towns; 

        public SignUp(Bussiness buss)
        {
            InitializeComponent();
            this.buss = buss;
            provinces = buss.GetProvinces();
            foreach(Provincia p in provinces)
            {
                provinceBox.Items.Add(p.nombre);
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
            ((TextBox)sender).Text = "";
        }

        private void MailLeave(object sender, EventArgs e)
        {
            if(((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "Mail";
        }

        private void NameLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "Name";
        }

        private void SurnameLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "Surname";
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

        private void PostalCodeLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "Postal code";
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
    }
}

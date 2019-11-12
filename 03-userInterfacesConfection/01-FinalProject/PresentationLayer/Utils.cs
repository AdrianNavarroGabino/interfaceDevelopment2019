using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    class Utils
    {
        public static void SetEmpty(object sender)
        {
            switch(((TextBox)sender).Text)
            {
                case "Mail":
                case "Name":
                case "Surname":
                case "Password":
                case "Password again":
                case "Phone":
                case "Address": ((TextBox)sender).Text = ""; break;
            }
        }

        public static void NameLeave(object sender)
        {
            if (((TextBox)sender).Text.Trim() == "")
                ((TextBox)sender).Text = "Name";
        }

        public static void SurnameLeave(object sender)
        {
            if (((TextBox)sender).Text.Trim() == "")
                ((TextBox)sender).Text = "Surname";
        }

        public static void MailLeave(object sender)
        {
            if (((TextBox)sender).Text.Trim() == "")
                ((TextBox)sender).Text = "Mail";
        }

        public static void IdLostFocus(object sender, TextBox idBox,
                                    MaskedTextBox idBox2)
        {
            if (((MaskedTextBox)sender).Text == "")
            {
                idBox2.Visible = false;
                idBox.Visible = true;
            }
        }

        public static void IdEnter(TextBox idBox, MaskedTextBox idBox2)
        {
            idBox.Visible = false;
            idBox2.Visible = true;
            idBox2.Focus();
        }

        public static Usuario SearchUserByIdCard(List<Usuario> users, String idCard)
        {
            foreach(Usuario u in users)
            {
                if(u.dni == idCard)
                {
                    return u;
                }
            }
            return null;
        }
    }
}

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
            ((TextBox)sender).Text = "";
        }

        public static void NameLeave(object sender)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "Name";
        }

        public static void SurnameLeave(object sender)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "Surname";
        }

        public static void MailLeave(object sender)
        {
            if (((TextBox)sender).Text == "")
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
    }
}

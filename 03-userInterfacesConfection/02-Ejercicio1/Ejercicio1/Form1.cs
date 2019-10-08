using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private string message;
        private string caption;
        private MessageBoxButtons buttons;
        private DialogResult result;

        public Form1()
        {
            InitializeComponent();
        }

        private void IsLoaded(object sender, EventArgs e)
        {
            message = "The form is loaded";
            caption = "Load";
            buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void IsShown(object sender, EventArgs e)
        {
            message = "The form is shown";
            caption = "Shown";
            buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void IsClosing(object sender, FormClosingEventArgs e)
        {
            message = "The form is closing";
            caption = "Closing";
            buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void IsClosed(object sender, FormClosedEventArgs e)
        {
            message = "The form is closed";
            caption = "Closed";
            buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void HaveEntered(object sender, EventArgs e)
        {
            message = "You have entered";
            caption = "Enter";
            buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void IsValidating(object sender, CancelEventArgs e)
        {
            message = "It's validating";
            caption = "Validating";
            buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void IsValidated(object sender, EventArgs e)
        {
            message = "It's validated";
            caption = "Validated";
            buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void IsLeaving(object sender, EventArgs e)
        {
            message = "It's leaving";
            caption = "Leave";
            buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }
    }
}

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

namespace PresentationLayer
{
    public partial class Main : Form
    {
        private SignUp signUp;
        private String user;
        private Bussiness buss;

        public Main(String user, Bussiness buss)
        {
            InitializeComponent();
            this.user = user;
            this.buss = buss;
        }

        private void CloseForms()
        {
            this.Controls.Remove(panel1);

            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                Form f = this.MdiChildren[i];
                f.Close();
            }
        }

        private void InsertUser(object sender, EventArgs e)
        {
            CloseForms();
            
            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            signUp = new SignUp(buss);
            
            signUp.MdiParent = this;
            
            signUp.ControlBox = false;
            
            signUp.FormBorderStyle = FormBorderStyle.None;
            signUp.Show();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you really want to exit?",
                "Exit",
                MessageBoxButtons.YesNo);

            if (result1 == DialogResult.No && e != null)
            {
                e.Cancel = true;
            }
        }
    }
}

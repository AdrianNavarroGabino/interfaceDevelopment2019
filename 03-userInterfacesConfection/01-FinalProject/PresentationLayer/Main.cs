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
        private User userForm;
        private ModifyUser modifyUser;
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
            Controls.Remove(panel1);

            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                Form f = this.MdiChildren[i];
                f.Close();
            }
        }

        public void InsertUser(bool modify = false)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            userForm = new User(buss, modify);

            userForm.MdiParent = this;

            userForm.ControlBox = false;

            userForm.FormBorderStyle = FormBorderStyle.None;
            userForm.Show();
        }

        private void InsertUser(object sender, EventArgs e)
        {
            InsertUser();
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

        private void Modify(object sender, EventArgs e)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            modifyUser = new ModifyUser(buss);

            modifyUser.MdiParent = this;

            modifyUser.ControlBox = false;

            modifyUser.FormBorderStyle = FormBorderStyle.None;
            modifyUser.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Main : Form
    {
        private SignUp signUp;
        private String user;

        public Main(String user)
        {
            InitializeComponent();
            this.user = user;
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

            signUp = new SignUp();
            
            signUp.MdiParent = this;
            
            signUp.ControlBox = false;
            
            signUp.FormBorderStyle = FormBorderStyle.None;
            signUp.Show();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

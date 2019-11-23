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
        private SearchUser searchUser;
        private Products productsForm;
        private NewOrder newOrder;
        private SearchOrder searchOrder;
        private Statistics statistics;
        private String user;
        private Business buss;
        private int time;

        public Main(String user, Business buss)
        {
            InitializeComponent();
            this.user = user;
            this.buss = buss;
            userLbl.Text = user;
            hourLbl.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 5);
            time = 0;
            timerLbl.Text = (time / 60).ToString("00") + ":" +
                (time % 60).ToString("00");
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

        public void InsertUser(bool modify = false, string idCard = null)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            userForm = new User(buss, modify, idCard);

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

            searchUser = new SearchUser(buss);

            searchUser.MdiParent = this;

            searchUser.ControlBox = false;

            searchUser.FormBorderStyle = FormBorderStyle.None;
            searchUser.Show();
        }

        private void RemoveUser(object sender, EventArgs e)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            searchUser = new SearchUser(buss, true);

            searchUser.MdiParent = this;

            searchUser.ControlBox = false;

            searchUser.FormBorderStyle = FormBorderStyle.None;
            searchUser.Show();
        }

        private void IncreaseTimer(object sender, EventArgs e)
        {
            time++;
            timerLbl.Text = (time / 60).ToString("00") + ":"
                + (time % 60).ToString("00");
        }

        private void IncreaseHour(object sender, EventArgs e)
        {
            hourLbl.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 5);
        }

        private void ConsultProducts(object sender, EventArgs e)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            productsForm = new Products(buss, false);

            productsForm.MdiParent = this;

            productsForm.ControlBox = false;

            productsForm.FormBorderStyle = FormBorderStyle.None;
            productsForm.Show();
        }

        private void ModifyProducts(object sender, EventArgs e)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            productsForm = new Products(buss, true);

            productsForm.MdiParent = this;

            productsForm.ControlBox = false;

            productsForm.FormBorderStyle = FormBorderStyle.None;
            productsForm.Show();
        }

        public void NewOrder(object sender, EventArgs e)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            newOrder = new NewOrder(buss);

            newOrder.MdiParent = this;

            newOrder.ControlBox = false;

            newOrder.FormBorderStyle = FormBorderStyle.None;
            newOrder.Show();
        }

        private void ModifyOrder(object sender, EventArgs e)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            searchOrder = new SearchOrder(buss);

            searchOrder.MdiParent = this;

            searchOrder.ControlBox = false;

            searchOrder.FormBorderStyle = FormBorderStyle.None;
            searchOrder.Show();
        }

        private void ShowStatistics(object sender, EventArgs e)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            statistics = new Statistics(buss);

            statistics.MdiParent = this;

            statistics.ControlBox = false;

            statistics.FormBorderStyle = FormBorderStyle.None;
            statistics.Show();
        }

        private void SearchBills(object sender, EventArgs e)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            searchOrder = new SearchOrder(buss, true);

            searchOrder.MdiParent = this;

            searchOrder.ControlBox = false;

            searchOrder.FormBorderStyle = FormBorderStyle.None;
            searchOrder.Show();
        }
    }
}

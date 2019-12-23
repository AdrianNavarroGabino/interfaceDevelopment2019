// Adrián Navarro Gabino

using System;
using System.Drawing;
using System.Linq;
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
        private Stock stock;
        private About about;
        private String user;
        private Business buss;
        private int time;
        private bool hide;

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
            hide = false;
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

        public void InsertUser(bool modify = false, string id = null)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            userForm = new User(this, buss, modify, id);

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
            DialogResult result1 = MessageBox.Show(
                "Do you really want to exit?",
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

            searchUser = new SearchUser(this, buss);

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

            searchUser = new SearchUser(this, buss, true);

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

        public void SetStatus(string status, bool error = false)
        {
            statusLbl.Text = status;
            if(error)
            {
                statusLbl.ForeColor = Color.Red;
            }
            else
            {
                statusLbl.ForeColor = Color.Black;
            }
        }

        private void ConsultProducts(object sender, EventArgs e)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            productsForm = new Products(this, buss, false);

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

            productsForm = new Products(this, buss, true);

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

            newOrder = new NewOrder(this, buss);

            newOrder.MdiParent = this;

            newOrder.ControlBox = false;

            newOrder.FormBorderStyle = FormBorderStyle.None;
            newOrder.Show();
        }

        public void ModifyOrder(object sender, EventArgs e)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            searchOrder = new SearchOrder(this, buss);

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

            statistics = new Statistics(this, buss);

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

            searchOrder = new SearchOrder(this, buss, true);

            searchOrder.MdiParent = this;

            searchOrder.ControlBox = false;

            searchOrder.FormBorderStyle = FormBorderStyle.None;
            searchOrder.Show();
        }

        private void ShowStock(object sender, EventArgs e)
        {
            CloseForms();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            stock = new Stock(this, buss);

            stock.MdiParent = this;

            stock.ControlBox = false;

            stock.FormBorderStyle = FormBorderStyle.None;
            stock.Show();
        }

        private void ShowAbout(object sender, EventArgs e)
        {
            about = new About(this);
            about.Show();
        }

        private void Restore(object sender, MouseEventArgs e)
        {
            if(hide)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }
            hide = !hide;
        }
    }
}

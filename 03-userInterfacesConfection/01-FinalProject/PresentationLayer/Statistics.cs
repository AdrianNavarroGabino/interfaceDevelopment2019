using BussinessLayer;
using EntityLayer;
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
    public partial class Statistics : Form
    {
        private Business buss;
        private List<Pedido> orders;
        private List<string> months;
        private string[] monthList = {"January", "February", "March",
            "April", "May", "June", "July", "August", "September",
            "November", "December"};

        public Statistics(Business buss)
        {
            InitializeComponent();
            this.buss = buss;
            monthChart.Titles.Clear();
            monthChart.Titles.Add("Whatever");
            orders = buss.GetOrders();
            months = new List<string>();
            foreach(Pedido or in orders)
            {
                string month = monthList[DateTime.Parse(or.fecha).Month - 1] +
                    ", " + DateTime.Parse(or.fecha).Year;

                if(!months.Contains(month))
                {
                    months.Add(month);
                    monthBox.Items.Add(month);
                }
            }
        }
    }
}

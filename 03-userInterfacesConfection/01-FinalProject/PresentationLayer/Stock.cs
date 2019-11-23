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
using Microsoft.Reporting.WinForms;

namespace PresentationLayer
{
    public partial class Stock : Form
    {
        private Business buss;
        private List<StockAux> l_stock;
        private List<EntityLayer.Stock> stock;
        private int minProducts;
        public Stock(Business buss)
        {
            InitializeComponent();
            this.buss = buss;
            stock = buss.GetStock();
            l_stock = new List<StockAux>();
            minProducts = 10;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Stock", l_stock));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("minProducts", minProducts.ToString()));
            
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Dock = DockStyle.Fill;
        }

        private void Search(object sender, EventArgs e)
        {
            minProducts = Convert.ToInt32(minNumber.Value);
            //.where
            Stock_Load(null, null);
        }
    }
}

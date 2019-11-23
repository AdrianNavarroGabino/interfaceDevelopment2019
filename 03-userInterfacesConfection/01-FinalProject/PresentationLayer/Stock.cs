// Adrián Navarro Gabino

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BussinessLayer;
using EntityLayer;
using Microsoft.Reporting.WinForms;

namespace PresentationLayer
{
    public partial class Stock : Form
    {
        private Main main;
        private Business buss;
        private List<StockAux> stockAux;
        private List<StockAux> l_stock;
        private List<EntityLayer.Stock> stock;
        private int minProducts;
        public Stock(Main main, Business buss)
        {
            InitializeComponent();
            this.main = main;
            main.SetStatus("Status");
            this.buss = buss;
            stock = buss.GetStock();
            l_stock = new List<StockAux>();
            stockAux = new List<StockAux>();
            foreach(EntityLayer.Stock s in stock)
            {
                Articulo prod = buss.GetProduct(s.articuloID);
                stockAux.Add(new StockAux(s.articuloID,
                    Convert.ToInt64(s.disponible), s.entrega,
                    prod.nombre, prod.marcaID));
            }

            minNumber.Value = 10;
            minProducts = 10;
            Search(null, null);
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Stock", l_stock));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("minProducts", minProducts.ToString()));
            
            this.reportViewer1.RefreshReport();
        }

        private void Search(object sender, EventArgs e)
        {
            minProducts = Convert.ToInt32(minNumber.Value);
            l_stock = stockAux.Where(p => Convert.ToInt32(p.disponible) < minProducts).ToList();
            Stock_Load(null, null);
        }
    }
}

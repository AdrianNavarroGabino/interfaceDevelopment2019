// Adrián Navarro Gabino

using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Syncfusion.Windows.Reports;
using Syncfusion.Windows.Reports.Viewer;

namespace FinalProject
{
    /// <summary>
    /// Lógica de interacción para Stock.xaml
    /// </summary>
    public partial class Stock : UserControl
    {
        private MainWindow main;
        private Business buss;
        private List<StockAux> stockAux;
        private List<StockAux> l_stock;
        private List<EntityLayer.Stock> stock;
        private int minProducts;
        private ReportViewer reportViewer1;
        private ReportParameter[] parameters;

        public Stock(MainWindow main, Business buss)
        {
            InitializeComponent();
            this.main = main;
            this.buss = buss;
            main.SetStatus("Status");

            parameters = new ReportParameter[1];

            stock = buss.GetStock();
            l_stock = new List<StockAux>();
            stockAux = new List<StockAux>();
            foreach (EntityLayer.Stock s in stock)
            {
                Articulo prod = buss.GetProduct(s.articuloID);
                stockAux.Add(new StockAux(s.articuloID,
                    Convert.ToInt64(s.disponible), s.entrega,
                    prod.nombre, prod.marcaID));
            }

            minNumber.Text = "10";
            minProducts = 10;
            SearchStock(null, null);
        }

        private void SearchStock(object sender, RoutedEventArgs e)
        {
            try
            {
                minProducts = Convert.ToInt32(minNumber.Text);
            }
            catch(Exception)
            {
                minNumber.Text = "10";
                minProducts = 10;
            }
            l_stock = stockAux.Where(
                p => Convert.ToInt32(p.disponible) < minProducts).ToList();
            Stock_Load(null, null);
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            string ruta = System.IO.Directory.GetCurrentDirectory() +
                          "\\..\\..\\Stock.rdlc";
            reportViewer1 = new ReportViewer();
            reportViewer1.ReportPath = ruta;
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            reportViewer1.DataSources.Clear();
            reportViewer1.DataSources.Add(new ReportDataSource("Stock", l_stock));
            reportViewer1.DataSources.Add(new ReportDataSource("minProducts", minProducts.ToString()));
            parameters[0] = new ReportParameter();
            parameters[0].Name = "minProducts";
            parameters[0].Values.Add(minProducts.ToString());
            reportViewer1.SetParameters(parameters);

            reportViewer1.RefreshReport();
            g2.Children.Add(reportViewer1);
        }
    }
}

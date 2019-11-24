// Adrián Navarro Gabino

using BussinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PresentationLayer
{
    public partial class Bill : Form
    {
        private Main main;
        private Business buss;
        private List<LinpedAux> l_bills;
        private List<Usuario> l_user;
        private List<Pedido> l_order;

        public Bill(Main main, Business buss, Pedido order)
        {
            InitializeComponent();
            this.main = main;
            main.SetStatus("Status");
            this.buss = buss;
            
            l_bills = new List<LinpedAux>();
            l_order = new List<Pedido>();
            l_user = new List<Usuario>();
            l_user.Add(buss.GetUser(order.usuarioID));
            l_order.Add(order);

            foreach(Linped lp in buss.GetLinpeds())
            {
                if(lp.PedidoID == order.PedidoID)
                {
                    Articulo product = buss.GetProduct(lp.articuloID);

                    l_bills.Add(new LinpedAux(
                        lp.PedidoID, lp.linea, lp.articuloID,
                        lp.importe, lp.cantidad, product.nombre,
                        product.pvp, product.marcaID));
                }
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("Linped", l_bills));
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("Order", l_order));
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("User", l_user));

            this.reportViewer1.RefreshReport();
            this.reportViewer1.Dock = DockStyle.Fill;
        }
    }
}

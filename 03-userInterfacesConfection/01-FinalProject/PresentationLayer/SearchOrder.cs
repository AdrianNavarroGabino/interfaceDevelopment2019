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
    public partial class SearchOrder : Form
    {
        private Business buss;
        private List<Pedido> orders;
        public SearchOrder(Business buss)
        {
            InitializeComponent();
            this.buss = buss;
            orders = buss.GetOrders();
            FillTable();
            orderDate.MaxDate = DateTime.Now;
            orderDate.Value = DateTime.Now;
            orderDate.CustomFormat = " ";
        }

        public void FillTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Surname");
            dataTable.Columns.Add("ID Card");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("ID");

            foreach (Pedido order in orders)
            {
                Usuario user = buss.GetUser(order.usuarioID);

                DataRow productRow = dataTable.NewRow();

                productRow["Name"] = user.nombre;
                productRow["Surname"] = user.apellidos;
                productRow["ID Card"] = user.dni;
                productRow["Date"] = order.fecha;
                productRow["ID"] = order.PedidoID;
                dataTable.Rows.Add(productRow);
            }

            DataView dataView = dataTable.DefaultView;

            dataGridViewOrders.DataSource = dataView;
            dataGridViewOrders.Columns["ID"].Visible = false;
        }

        private void FilterName(object sender, KeyEventArgs e)
        {
            Filter();
        }

        private void FilterDate(object sender, EventArgs e)
        {
            orderDate.CustomFormat = "dd/MM/yyyy";
            Filter();
        }

        private void Filter()
        {
            DataView dataView = (DataView)dataGridViewOrders.DataSource;

            dataView.RowFilter = "Name LIKE '%" + nameBox.Text + "%'";

            if(orderDate.Value.ToString() != " ")
                dataView.RowFilter += " AND Date LIKE '" + orderDate.Value.ToString("dd/MM/yyyy") + "%'";

            dataGridViewOrders.DataSource = dataView;
        }
    }
}

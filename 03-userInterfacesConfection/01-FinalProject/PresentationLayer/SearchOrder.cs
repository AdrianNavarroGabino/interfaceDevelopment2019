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
        private NewOrder newOrder;
        private Bill orderBill;
        private bool bill;

        public SearchOrder(Business buss, bool bill = false)
        {
            InitializeComponent();
            this.buss = buss;
            this.bill = bill;
            orders = buss.GetOrders();
            FillTable();
            orderDate.MaxDate = DateTime.Now;
            orderDate.CustomFormat = " ";
            if(bill)
            {
                titleLbl.Text = "Search bill";
                modifyBtn.Text = "Search";
            }
        }

        public void FillTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Surname");
            dataTable.Columns.Add("ID Card");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("IDProduct");
            dataTable.Columns.Add("IDUser");

            foreach (Pedido order in orders)
            {
                Usuario user = buss.GetUser(order.usuarioID);

                DataRow productRow = dataTable.NewRow();

                productRow["Name"] = user.nombre;
                productRow["Surname"] = user.apellidos;
                productRow["ID Card"] = user.dni;
                productRow["Date"] = order.fecha;
                productRow["IDProduct"] = order.PedidoID;
                productRow["IDUser"] = user.usuarioID;
                dataTable.Rows.Add(productRow);
            }

            DataView dataView = dataTable.DefaultView;

            dataGridViewOrders.DataSource = dataView;
            dataGridViewOrders.Columns["IDProduct"].Visible = false;
            dataGridViewOrders.Columns["IDUser"].Visible = false;
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

            if(orderDate.CustomFormat != " ")
                dataView.RowFilter += " AND Date LIKE '" + orderDate.Value.ToString("dd/MM/yyyy") + "%'";

            dataGridViewOrders.DataSource = dataView;
        }

        private void Modify(object sender, EventArgs e)
        {
            if (!bill)
            {
                SortedList<string, int> orderRows = new SortedList<string, int>();

                foreach (Linped lp in buss.GetLinpeds())
                {
                    if (lp.PedidoID == dataGridViewOrders.SelectedCells[4].Value.ToString())
                    {
                        orderRows.Add(lp.articuloID, Convert.ToInt32(lp.cantidad));
                    }
                }

                newOrder = new NewOrder(buss, orderRows, dataGridViewOrders.SelectedCells[5].Value.ToString(), dataGridViewOrders.SelectedCells[4].Value.ToString());
                newOrder.MdiParent = this.ParentForm;
                newOrder.StartPosition = FormStartPosition.Manual;
                newOrder.Location = new Point(0, 0);
                this.Hide();
                newOrder.Show();
            }
            else
            {
                orderBill = new Bill(buss, new Pedido(dataGridViewOrders.SelectedCells[4].Value.ToString(),
                    dataGridViewOrders.SelectedCells[5].Value.ToString(), dataGridViewOrders.SelectedCells[3].Value.ToString()));
                orderBill.MdiParent = this.ParentForm;
                orderBill.StartPosition = FormStartPosition.Manual;
                orderBill.Location = new Point(0, 0);
                this.Hide();
                orderBill.Show();
            }
        }

        private void ResetFields(object sender, EventArgs e)
        {
            nameBox.Text = "";
            orderDate.CustomFormat = " ";
            Filter();
        }
    }
}

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
    public partial class OrderSummary : Form
    {
        private Business buss;
        private string userID;
        private SortedList<string, int> orderedProducts;
        private List<Articulo> products;
        private double finalPrice;
        private List<Pedido> currentOrders;
        private long orderPK;

        public OrderSummary(Business buss, string userID,
            SortedList<string, int> orderedProducts)
        {
            InitializeComponent();
            this.buss = buss;
            this.userID = userID;
            this.orderedProducts = orderedProducts;
            products = new List<Articulo>();
            finalPrice = 0;
            FillTable();
            finalPriceLbl.Text = finalPrice.ToString() + "€";
            noIVALbl.Text = buss.CalculatePrice(finalPrice) + "€";
            currentOrders = buss.GetOrders();
            orderPK = Convert.ToInt64(currentOrders[currentOrders.Count - 1].PedidoID);
        }

        public void FillTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Brand");
            dataTable.Columns.Add("PVP");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Amount");
            dataTable.Columns.Add("Id");

            foreach (KeyValuePair<string, int> kvp in orderedProducts)
            {
                Articulo product = buss.GetProduct(kvp.Key);
                double amount = kvp.Value * Convert.ToDouble(product.pvp);
                finalPrice += amount;

                DataRow productRow = dataTable.NewRow();

                productRow["Name"] = product.nombre;
                productRow["Brand"] = product.marcaID;
                productRow["PVP"] = product.pvp;
                productRow["Quantity"] = kvp.Value;
                productRow["Amount"] = amount;
                productRow["Id"] = product.articuloID;
                dataTable.Rows.Add(productRow);
            }

            DataView dataView = dataTable.DefaultView;

            dataGridView1.DataSource = dataView;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void Order(object sender, EventArgs e)
        {
            int affectedRows = 0;
            orderPK++;
            bool orderInserted = 
                buss.InsertOrder(new Pedido(
                    orderPK.ToString(), userID,
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
            int row = 1;

            foreach (KeyValuePair<string, int> kvp in orderedProducts)
            {
                bool rowInserted = 
                    buss.InsertOrderRow(new Linped(orderPK.ToString(),
                    row.ToString(), kvp.Key, (Convert.ToDouble(
                        buss.GetProduct(kvp.Key).pvp) * kvp.Value).ToString(),
                    kvp.Value.ToString()));
                if(rowInserted)
                {
                    affectedRows++;
                }
                row++;
            }

            if(orderInserted && affectedRows == orderedProducts.Count)
            {
                ((Main)MdiParent).NewOrder(null, null);
                this.Hide();
            }
        }
    }
}

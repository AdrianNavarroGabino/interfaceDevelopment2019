// Adrián Navarro Gabino

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
        private Main main;
        private Business buss;
        private string userID;
        private SortedList<string, int> orderedProducts;
        private int numberOfRows;
        private double finalPrice;
        private List<Pedido> currentOrders;
        private long orderPK;
        private bool modify;
        private string oldPK;

        public OrderSummary(
            Main main, Business buss, string userID,
            SortedList<string, int> orderedProducts,
            bool modify = false, string oldPK = null)
        {
            InitializeComponent();
            this.main = main;
            this.buss = buss;
            this.userID = userID;
            this.orderedProducts = orderedProducts;
            FillTable();
            currentOrders = buss.GetOrders();
            orderPK = Convert.ToInt64(
                currentOrders[currentOrders.Count - 1].PedidoID);
            this.modify = modify;

            if(modify)
            {
                orderBtn.Text = "Modify";
                numberOfRows = orderedProducts.Count;
                this.oldPK = oldPK;
            }
        }

        public void FillTable()
        {
            finalPrice = 0;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Brand");
            dataTable.Columns.Add("PVP");
            dataTable.Columns.Add("Amount");
            dataTable.Columns.Add("Total");
            dataTable.Columns.Add("Id");

            foreach (KeyValuePair<string, int> kvp in orderedProducts)
            {
                Articulo product = buss.GetProduct(kvp.Key);
                double total = kvp.Value * Convert.ToDouble(product.pvp);
                finalPrice += total;

                DataRow productRow = dataTable.NewRow();

                productRow["Name"] = product.nombre;
                productRow["Brand"] = product.marcaID;
                productRow["PVP"] = product.pvp;
                productRow["Amount"] = kvp.Value;
                productRow["Total"] = total;
                productRow["Id"] = product.articuloID;
                dataTable.Rows.Add(productRow);
            }

            DataView dataView = dataTable.DefaultView;

            dataGridView1.DataSource = dataView;
            dataGridView1.Columns["Id"].Visible = false;

            finalPriceLbl.Text = finalPrice.ToString() + "€";
            noIVALbl.Text = buss.CalculatePrice(finalPrice) + "€";
        }

        private void Order(object sender, EventArgs e)
        {
            orderPK++;
            string pkAux = orderPK.ToString();
            if (modify)
            {
                pkAux = oldPK;

                int deleted = 0;
                for(int i = 1; i <= numberOfRows; i++)
                {
                    if (buss.DeleteRow(pkAux, i))
                        deleted++;
                }

                if(deleted != numberOfRows)
                {
                    main.SetStatus("Something went wrong", true);
                    return;
                }
            }

            int affectedRows = 0;
            
            bool orderInserted = 
                buss.InsertOrder(new Pedido(
                    pkAux, userID,
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
            int row = 1;

            foreach (KeyValuePair<string, int> kvp in orderedProducts)
            {
                bool rowInserted = 
                    buss.InsertOrderRow(new Linped(pkAux,
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
                if (modify)
                    main.SetStatus("Order modified");
                else
                    main.SetStatus("Order sent");
            }
            else
            {
                main.SetStatus("Order modified");
            }
        }

        private void UpdateAmount(object sender, EventArgs e)
        {
            orderedProducts[dataGridView1.SelectedCells[5].Value.ToString()] =
                Convert.ToInt32(amountBox.Value);
            FillTable();
        }

        private void RemoveProduct(object sender, EventArgs e)
        {
            orderedProducts.Remove(
                dataGridView1.SelectedCells[5].Value.ToString());
            FillTable();

            if(orderedProducts.Count == 0)
            {
                if (modify)
                {
                    for (int i = 1; i <= numberOfRows; i++)
                    {
                        buss.DeleteRow(oldPK, i);
                    }

                    buss.DeleteOrder(oldPK);
                    main.ModifyOrder(null, null);
                }
                else
                {
                    main.NewOrder(null, null);
                }
                this.Hide();
            }
        }
    }
}

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

        public OrderSummary(string userID,
            SortedList<string, int> orderedProducts)
        {
            InitializeComponent();
            this.userID = userID;
            this.orderedProducts = orderedProducts;
            products = new List<Articulo>();
        }

        public void FillTable(List<Articulo> products)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Brand");
            dataTable.Columns.Add("PVP");
            dataTable.Columns.Add("Id");

            foreach (KeyValuePair<string, int> kvp in orderedProducts)
            {
                Articulo product = buss.GetProduct(kvp.Key);
                DataRow productRow = dataTable.NewRow();

                productRow["Name"] = product.nombre;
                productRow["Brand"] = product.marcaID;
                productRow["PVP"] = product.pvp;
                productRow["Amount"] = kvp.Value;
                productRow["Id"] = product.articuloID;
                dataTable.Rows.Add(productRow);
            }

            DataView dataView = dataTable.DefaultView;

            dataGridViewProducts.DataSource = dataView;
            dataGridViewProducts.Columns["Id"].Visible = false;
        }
    }
}

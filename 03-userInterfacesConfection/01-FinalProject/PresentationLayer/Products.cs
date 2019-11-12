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

namespace PresentationLayer
{
    public partial class Products : Form
    {
        private Bussiness buss;
        private List<Articulo> products;
        private List<TipoArticulo> productTypes;
        public Products(Bussiness buss)
        {
            InitializeComponent();
            this.buss = buss;
            products = buss.GetProducts();
            productTypes = buss.GetProductTypes();
            FillTable(products);
        }

        public string GetTypeDescription(String id)
        {
            foreach(TipoArticulo productType in productTypes)
            {
                if(id == null)
                {
                    return null;
                }
                if(productType.tipoArticuloID.ToUpper() == id.ToUpper())
                {
                    return productType.Descripcion;
                }
            }
            return null;
        }

        public void FillTable(List<Articulo> products)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("PVP");
            dataTable.Columns.Add("Brand");
            dataTable.Columns.Add("Type");
            dataTable.Columns.Add("Id");

            foreach (Articulo product in products)
            {
                DataRow productRow = dataTable.NewRow();

                productRow["Name"] = product.nombre;
                productRow["PVP"] = product.pvp;
                productRow["Brand"] = product.marcaID;
                productRow["Type"] = GetTypeDescription(product.tipoArticulo);
                productRow["Brand"] = product.articuloID;
                dataTable.Rows.Add(productRow);
            }

            DataView dataView = dataTable.DefaultView;

            dataGridView1.DataSource = dataView;
            dataGridView1.Columns["Id"].Visible = false;
        }
    }
}

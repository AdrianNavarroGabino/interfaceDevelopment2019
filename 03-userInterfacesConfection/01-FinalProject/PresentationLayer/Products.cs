// Adrián Navarro Gabino

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BussinessLayer;
using EntityLayer;

namespace PresentationLayer
{
    public partial class Products : Form
    {
        private Main main;
        private Business buss;
        private List<Articulo> products;
        private List<TipoArticulo> productTypes;
        private bool modifyMode;

        public Products(Main main, Business buss, bool modifyMode)
        {
            InitializeComponent();
            this.main = main;
            main.SetStatus("Status");
            this.buss = buss;
            this.modifyMode = modifyMode;
            products = buss.GetProducts();
            productTypes = buss.GetProductTypes();
            FillTable(products);

            typeBox.Items.Add("");
            foreach (TipoArticulo t in productTypes)
            {
                typeBox.Items.Add(t.Descripcion);
            }
        }

        public string GetTypeDescription(String type)
        {
            foreach(TipoArticulo t in productTypes)
            {
                if(type == t.tipoArticuloID)
                {
                    return t.Descripcion;
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
                productRow["Type"] = 
                    GetTypeDescription(product.tipoArticuloID);
                productRow["Id"] = product.articuloID;
                dataTable.Rows.Add(productRow);
            }

            DataView dataView = dataTable.DefaultView;

            dataGridView1.DataSource = dataView;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void FilterType(object sender, EventArgs e)
        {
            DataView dataView = (DataView)dataGridView1.DataSource;

            if (typeBox.Text == "")
            {
                dataView.RowFilter = "";
            }
            else
            {
                dataView.RowFilter = "Type = '" + typeBox.Text + "'";
            }

            dataGridView1.DataSource = dataView;
        }

        private void FilterName(object sender, KeyEventArgs e)
        {
            DataView dataView = (DataView)dataGridView1.DataSource;

            dataView.RowFilter = "";

            dataView.RowFilter = "Name LIKE '%" + nameBox.Text + "%'";

            dataGridView1.DataSource = dataView;
        }

        private void GetProduct(object sender, DataGridViewCellEventArgs e)
        {
            string idGet = dataGridView1.SelectedCells[4].Value.ToString();

            Articulo product = buss.GetProduct(idGet);
            String typeGet = buss.GetType(product.tipoArticuloID).Descripcion;

            CreateProductControls(product, typeGet);
        }

        private void CreateProductControls(Articulo product, String typeTable)
        {
            RemoveControls();

            switch (typeTable)
            {
                case "TV": FillTV(product, typeTable); break;
                case "Memoria": FillMemory(product, typeTable); break;
                case "Camara": FillCamera(product, typeTable); break;
                case "Objetivo": FillObjective(product, typeTable); break;
            }
            if(modifyMode)
                CreateModifyButton(product);
        }

        private void FillTV(Articulo product, String typeTable)
        {
            Tv tv = buss.GetTv(product.articuloID);

            CreateField("panel", "Panel:", tv.panel, 10, 10);
            CreateField("screen", "Screen:", tv.pantalla, 10, 70);
            CreateField("resolution", "Resolution:", tv.resolucion, 10, 130);
            CreateField(
                "hdReadyFullHd", "HD/Full HD:", tv.hdreadyfullhd, 10, 190);
            CreateField("tdt", "TDT:", tv.tdt, 10, 250);
            CreateField("pvp", "Price:", product.pvp, 10, 310);
        }

        private void FillMemory(Articulo product, String typeTable)
        {
            Memoria memory = buss.GetMemory(product.articuloID);

            CreateField("type", "Type:", memory.tipo, 10, 10);
            CreateField("pvp", "Price:", product.pvp, 10, 70);
        }

        private void FillCamera(Articulo product, String typeTable)
        {
            Camara camera = buss.GetCamera(product.articuloID);

            CreateField(
                "resolution", "Resolution:", camera.resolucion, 10, 10);
            CreateField("sensor", "Sensor:", camera.sensor, 10, 60);
            CreateField("type", "Type:", camera.tipo, 10, 110);
            CreateField("factor", "Factor:", camera.factor, 10, 160);
            CreateField("objective", "Objective:", camera.objetivo, 10, 210);
            CreateField("screen", "Screen:", camera.pantalla, 10, 260);
            CreateField("zoom", "Zoom:", camera.zoom, 10, 310);
            CreateField("pvp", "Price:", product.pvp, 10, 360);
        }

        private void FillObjective(Articulo product, String typeTable)
        {
            Objetivo objective = buss.GetObjective(product.articuloID);

            CreateField("type", "Type:", objective.tipo, 10, 10);
            CreateField("mount", "Mount:", objective.montura, 10, 70);
            CreateField("focal", "Focal:", objective.focal, 10, 130);
            CreateField("opening", "Opening:", objective.apertura, 10, 190);
            CreateField(
                "specials", "Specials:", objective.especiales, 10, 250);
            CreateField("pvp", "Price:", product.pvp, 10, 310);
        }

        private void CreateField(
            string name, string text, string tbValue, int x, int y)
        {
            Label label = new Label();
            label.Location = new Point(x, y);
            label.ForeColor = Color.FromArgb(247, 252, 250);
            label.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            label.Size = new Size(120, 25);
            label.Text = text;
            splitContainer1.Panel2.Controls.Add(label);

            TextBox textBox = new TextBox();
            textBox.Location = new Point(x + 120, y + 1);
            textBox.BackColor = Color.FromArgb(76, 148, 144);
            textBox.ForeColor = Color.FromArgb(247, 252, 250);
            textBox.Name = name;
            textBox.Font =
                new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            textBox.Size = new Size(150, 30);
            textBox.Text = tbValue;
            if(!modifyMode || name != "pvp")
            {
                textBox.ReadOnly = true;
            }
            splitContainer1.Panel2.Controls.Add(textBox);
        }

        private void RemoveControls()
        {
            splitContainer1.Panel2.Controls.Clear();
        }

        private void CreateModifyButton(Articulo product)
        {
            Button modify = new Button();
            modify.Location = new Point(80, 410);
            modify.ForeColor = Color.FromArgb(110, 175, 169);
            modify.BackColor = Color.FromArgb(247, 252, 250);
            modify.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            modify.Size = new Size(130, 40);
            modify.Text = "Modify price";
            modify.Click += new EventHandler(
                (s, e) => ModifyPrice(s, e, product));
            splitContainer1.Panel2.Controls.Add(modify);
        }

        private void ModifyPrice(object sender, EventArgs e, Articulo product)
        {
            Control pvp =
                splitContainer1.Panel2.Controls.Find("pvp", false)[0];
            string newPrice = pvp.Text;

            try
            {
                double aux = Convert.ToDouble(newPrice);
                Articulo modifiedProduct = new Articulo(
                    product.articuloID, product.nombre, newPrice,
                    product.marcaID, product.imagen, product.urlimagen,
                    product.especificaciones, product.tipoArticuloID);
                if(buss.ModifyProduct(product.articuloID, modifiedProduct))
                {
                    dataGridView1.SelectedCells[1].Value = newPrice;
                    main.SetStatus("Price changed");
                }
            }
            catch(Exception)
            {
                main.SetStatus("Enter a valid price", true);
            }
        }
    }
}
using BussinessLayer;
using EntityLayer;
using System;
using System.Collections;
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
    public partial class NewOrder : Form
    {
        private Main main;
        private Business buss;
        private List<Usuario> users;
        private List<Articulo> products;
        private List<TipoArticulo> productTypes;
        private Usuario selectedUser;
        private SortedList<string, int> selectedProducts;
        private string selectedProductId;
        private bool userIsSelected;
        private OrderSummary orderSummary;
        private string userId;
        private string orderPK;

        public NewOrder(
            Main main, Business buss,
            SortedList<string, int> selectedProducts = null,
            string userId = null, string orderPK = null)
        {
            InitializeComponent();
            this.main = main;
            main.SetStatus("Status");
            this.buss = buss;
            users = buss.GetUsers();
            FillUsersTable(users);

            products = buss.GetProducts();
            productTypes = buss.GetProductTypes();
            FillProductsTable(products);

            typeBox.Items.Add("");
            foreach (TipoArticulo t in productTypes)
            {
                typeBox.Items.Add(t.Descripcion);
            }

            if (selectedProducts == null)
            {
                this.selectedProducts = new SortedList<string, int>();
                orderBtn.Visible = false;
                userIsSelected = false;
            }
            else
            {
                this.selectedProducts = selectedProducts;
                orderBtn.Visible = true;
                userIsSelected = true;
                this.userId = userId;
                usersLbl.Visible = false;
                dataGridViewUsers.Visible = false;
                userNameLbl.Visible = false;
                userSurnameLbl.Visible = false;
                userIdLbl.Visible = false;
                userNameBox.Visible = false;
                surnameBox.Visible = false;
                idBox.Visible = false;
                dataGridViewProducts.Location = new Point(
                    dataGridViewProducts.Location.X - 30,
                    dataGridViewProducts.Location.Y);
                productsLbl.Location = new Point(
                    productsLbl.Location.X - 30,
                    productsLbl.Location.Y);
                nameLbl.Location = new Point(
                    nameLbl.Location.X - 30,
                    nameLbl.Location.Y);
                productNameBox.Location = new Point(
                    productNameBox.Location.X - 30,
                    productNameBox.Location.Y);
                typeLbl.Location = new Point(
                    typeLbl.Location.X - 30,
                    typeLbl.Location.Y);
                typeBox.Location = new Point(
                    typeBox.Location.X - 30,
                    typeBox.Location.Y);
                orderBtn.Text = "Modify";
                titleLbl.Text = "Modify order";
                this.orderPK = orderPK;
            }
            addBtn.Visible = false;
            removeBtn.Visible = false;
            chosenProductBox.Visible = false;
            chosenProductLbl.Visible = false;
            amountBox.Visible = false;
            amountLbl.Visible = false;
        }

        public void FillUsersTable(List<Usuario> users)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Surname");
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("articuloID");

            foreach (Usuario user in users)
            {
                DataRow userRow = dataTable.NewRow();

                userRow["Name"] = user.nombre;
                userRow["Surname"] = user.apellidos;
                userRow["ID"] = user.dni;
                userRow["articuloID"] = user.usuarioID;
                dataTable.Rows.Add(userRow);
            }

            DataView dataView = dataTable.DefaultView;

            dataGridViewUsers.DataSource = dataView;
            dataGridViewUsers.Columns["articuloID"].Visible = false;
        }

        public void FillProductsTable(List<Articulo> products)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Brand");
            dataTable.Columns.Add("PVP");
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Type");

            foreach (Articulo product in products)
            {
                DataRow productRow = dataTable.NewRow();

                productRow["Name"] = product.nombre;
                productRow["Brand"] = product.marcaID;
                productRow["PVP"] = product.pvp;
                productRow["Id"] = product.articuloID;
                productRow["Type"] =
                    GetTypeDescription(product.tipoArticuloID);

                dataTable.Rows.Add(productRow);
            }

            DataView dataView = dataTable.DefaultView;

            dataGridViewProducts.DataSource = dataView;
            dataGridViewProducts.Columns["Id"].Visible = false;
            dataGridViewProducts.Columns["Type"].Visible = false;
        }

        public string GetTypeDescription(String type)
        {
            foreach (TipoArticulo t in productTypes)
            {
                if (type == t.tipoArticuloID)
                {
                    return t.Descripcion;
                }
            }
            return null;
        }

        private void SelectUser(object sender, DataGridViewCellEventArgs e)
        {
            selectedUser = buss.GetUser(
                dataGridViewUsers.SelectedCells[3].Value.ToString());
            userIsSelected = true;
        }

        private void SelectProduct(object sender, DataGridViewCellEventArgs e)
        {
            chosenProductBox.Visible = true;
            chosenProductLbl.Visible = true;
            amountBox.Visible = true;
            amountLbl.Visible = true;

            selectedProductId =
                dataGridViewProducts.SelectedCells[3].Value.ToString();
            String productName =
                dataGridViewProducts.SelectedCells[0].Value.ToString();

            chosenProductBox.Text = productName;
            addBtn.Visible = true;

            if(selectedProducts.ContainsKey(selectedProductId))
            {
                addBtn.Text = "Modify";
                removeBtn.Visible = true;
                amountBox.Value = selectedProducts[selectedProductId];
            }
            else
            {
                addBtn.Text = "Add";
                removeBtn.Visible = false;
                amountBox.Value = 1;
            }
        }

        private void AddProduct(object sender, EventArgs e)
        {
            if(amountBox.Value != 0)
            {
                if (selectedProducts.ContainsKey(selectedProductId))
                {
                    selectedProducts[selectedProductId] = (int)amountBox.Value;
                }
                else
                {
                    selectedProducts.Add(
                        dataGridViewProducts.SelectedCells[3].Value.ToString(),
                        (int)amountBox.Value);
                }

                orderBtn.Visible = true;
                addBtn.Visible = false;
                removeBtn.Visible = false;
                chosenProductBox.Visible = false;
                chosenProductLbl.Visible = false;
                amountBox.Visible = false;
                amountLbl.Visible = false;
            }
        }

        private void RemoveProduct(object sender, EventArgs e)
        {
            selectedProducts.Remove(
                dataGridViewProducts.SelectedCells[3].Value.ToString());

            if(selectedProducts.Count == 0)
            {
                orderBtn.Visible = false;
            }

            addBtn.Visible = false;
            removeBtn.Visible = false;
            chosenProductBox.Visible = false;
            chosenProductLbl.Visible = false;
            amountBox.Visible = false;
            amountLbl.Visible = false;
        }

        private void Order(object sender, EventArgs e)
        {
            if (titleLbl.Text == "New order")
            {
                if (userIsSelected)
                {
                    orderSummary = new OrderSummary(
                        main, buss, selectedUser.usuarioID,
                        selectedProducts, false, orderPK);
                    orderSummary.MdiParent = this.ParentForm;
                    orderSummary.StartPosition = FormStartPosition.Manual;
                    orderSummary.Location = new Point(0, 0);
                    this.Hide();
                    orderSummary.Show();
                }
                else
                {
                    main.SetStatus("You must select the user to order", true);
                }
            }
            else
            {
                orderSummary = new OrderSummary(
                    main, buss, userId,
                    selectedProducts, true, orderPK);
                orderSummary.MdiParent = this.ParentForm;
                orderSummary.StartPosition = FormStartPosition.Manual;
                orderSummary.Location = new Point(0, 0);
                this.Hide();
                orderSummary.Show();
            }
        }

        private void FilterProductName(object sender, KeyEventArgs e)
        {
            DataView dataView = (DataView)dataGridViewProducts.DataSource;

            dataView.RowFilter = "";

            dataView.RowFilter = "Name LIKE '%" + productNameBox.Text + "%'";

            dataGridViewProducts.DataSource = dataView;
        }

        private void FilterType(object sender, EventArgs e)
        {
            DataView dataView = (DataView)dataGridViewProducts.DataSource;

            if (typeBox.Text == "")
            {
                dataView.RowFilter = "";
            }
            else
            {
                dataView.RowFilter = "Type = '" + typeBox.Text + "'";
            }

            dataGridViewProducts.DataSource = dataView;
        }

        private void FilterUser(object sender, KeyEventArgs e)
        {
            DataView dataView = (DataView)dataGridViewUsers.DataSource;

            dataView.RowFilter = "Name LIKE '%" + userNameBox.Text +
                "%' AND " + "ID LIKE '%" + idBox.Text + "%' AND " +
                "Surname LIKE '%" + surnameBox.Text + "%'";

            dataGridViewUsers.DataSource = dataView;
        }
    }
}

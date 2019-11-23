// Adrián Navarro Gabino

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BussinessLayer;
using EntityLayer;

namespace PresentationLayer
{
    public partial class SearchUser : Form
    {
        private Main main;
        private Business buss;
        private List<Usuario> users;
        private bool delete;

        public SearchUser(Main main, Business buss, bool delete = false)
        {
            InitializeComponent();
            this.main = main;
            this.buss = buss;
            main.SetStatus("Status");
            users = buss.GetUsers();
            FillTable(users);
            this.delete = false;
            modifyBtn.Visible = true;

            if (delete)
            {
                this.delete = true;
                modifyBtn.Visible = false;
            }
        }

        public void FillTable(List<Usuario> users)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Surname");
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Mail");
            dataTable.Columns.Add("PK");

            foreach (Usuario user in users)
            {
                DataRow userRow = dataTable.NewRow();

                userRow["Name"] = user.nombre;
                userRow["Surname"] = user.apellidos;
                userRow["ID"] = user.dni;
                userRow["Mail"] = user.email;
                userRow["PK"] = user.usuarioID;
                dataTable.Rows.Add(userRow);
            }

            DataView dataView = dataTable.DefaultView;

            dataGridView1.DataSource = dataView;
            dataGridView1.Columns["PK"].Visible = false;
        }

        private void Filter(object sender, KeyEventArgs e)
        {
            DataView dataView = (DataView)dataGridView1.DataSource;

            dataView.RowFilter = "Name LIKE '%" + nameBox.Text + "%' AND " +
                "ID LIKE '%" + idBox.Text + "%' AND " +
                "Surname LIKE '%" + surnameBox.Text + "%' AND " +
                "Mail LIKE '%" + mailBox.Text + "%'";

            dataGridView1.DataSource = dataView;
        }

        private void GoToUserForm(object sender, EventArgs e)
        {
            string idCard = dataGridView1.SelectedCells[2].Value.ToString();
            ((Main)this.MdiParent).InsertUser(true,
                dataGridView1.SelectedCells[4].Value.ToString());
        }

        private void DeleteUser(object sender, DataGridViewCellEventArgs e)
        {
            main.SetStatus("Status");
            if (delete)
            {
                List<Pedido> orders = buss.GetOrders();
                bool canDelete = true;
                foreach(Pedido o in orders)
                {
                    if(o.usuarioID == dataGridView1.SelectedCells[4].Value.ToString())
                    {
                        canDelete = false;
                        break;
                    }
                }
                if (canDelete)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete " +
                        dataGridView1.SelectedCells[0].Value.ToString() + " " +
                        dataGridView1.SelectedCells[1].Value.ToString() + "?",
                                         "Delete user",
                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        if (buss.DeleteUser(
                            dataGridView1.SelectedCells[4].Value.ToString()))
                        {
                            users = buss.GetUsers();
                            FillTable(users);
                            main.SetStatus("User removed");
                        }
                        else
                        {
                            main.SetStatus("Something went wrong", true);
                        }
                    }
                }
                else
                {
                    main.SetStatus("This user has orders", true);
                }
            }
        }
    }
}

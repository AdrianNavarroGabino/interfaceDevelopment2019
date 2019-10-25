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
    public partial class ModifyUser : Form
    {
        private Bussiness buss;
        private List<Usuario> users;

        public ModifyUser(Bussiness buss)
        {
            InitializeComponent();
            this.buss = buss;
            users = buss.GetUsers();
            FillTable(users);
        }

        public void FillTable(List<Usuario> users)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Surname");
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Mail");

            foreach (Usuario user in users)
            {
                DataRow userRow = dataTable.NewRow();
                
                userRow["Name"] = user.nombre;
                userRow["Surname"] = user.apellidos;
                userRow["ID"] = user.dni;
                userRow["Mail"] = user.email;
                dataTable.Rows.Add(userRow);
            }
            
            DataView dataView = dataTable.DefaultView;

            dataGridView1.DataSource = dataView;

            dataGridView1.Columns["Name"].Width = 180;
            dataGridView1.Columns["Surname"].Width = 200;
            dataGridView1.Columns["ID"].Width = 120;
            dataGridView1.Columns["Mail"].Width = 212;
        }

        private void Filter(object sender, KeyEventArgs e)
        {
            DataView dataView = (DataView)dataGridView1.DataSource;

            dataView.RowFilter = "";

            if (nameBox.Text != "Name")
            {
                dataView.RowFilter += "Name LIKE '%" + nameBox.Text + "%'";
            }
            if (idBox2.Text != "")
            {
                if (dataView.RowFilter.Length != 0)
                {
                    dataView.RowFilter += " AND ";
                }
                dataView.RowFilter += "ID LIKE '%" + idBox2.Text + "%'";
            }
            if (surnameBox.Text != "Surname")
            {
                if (dataView.RowFilter.Length != 0)
                {
                    dataView.RowFilter += " AND ";
                }
                dataView.RowFilter += "Surname LIKE '%" + surnameBox.Text + "%'";
            }
            if (mailBox.Text != "Mail")
            {
                if (dataView.RowFilter.Length != 0)
                {
                    dataView.RowFilter += " AND ";
                }
                dataView.RowFilter += "Mail LIKE '%" + mailBox.Text + "%'";
            }
            dataGridView1.DataSource = dataView;
        }
    }
}

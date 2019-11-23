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
    public partial class Statistics : Form
    {
        private Business buss;
        private List<Pedido> ordersAux;
        private List<string> months;
        private string[] monthList = {"January", "February", "March",
            "April", "May", "June", "July", "August", "September",
            "October", "November", "December"};
        private SortedList<string, List<Linped>> orders;
        private List<Linped> orderRows;
        private List<TipoArticulo> types;
        private SortedList<string, SortedList<int, int>> ordersByDay;

        public Statistics(Business buss)
        {
            InitializeComponent();
            loadingLbl1.Visible = false;
            loadingLbl2.Visible = false;
            this.buss = buss;
            orderRows = buss.GetLinpeds();
            ordersAux = buss.GetOrders();
            types = buss.GetProductTypes();
            months = new List<string>();
            ordersByDay = new SortedList<string, SortedList<int, int>>();

            orders = new SortedList<string, List<Linped>>();
            foreach (Pedido or in ordersAux)
            {
                string month = monthList[DateTime.Parse(or.fecha).Month - 1] +
                    ", " + DateTime.Parse(or.fecha).Year;

                DateTime date = DateTime.Parse(or.fecha);

                if(!ordersByDay.ContainsKey(month))
                {
                    ordersByDay.Add(month, new SortedList<int, int>());
                }
                if(!ordersByDay[month].ContainsKey(date.Day))
                {
                    ordersByDay[month].Add(date.Day, 0);
                }
                ordersByDay[month][date.Day] += 1;
                

                if (!months.Contains(month))
                {
                    orders.Add(month, new List<Linped>());
                    months.Add(month);
                    monthBox.Items.Add(month);
                }

                foreach (Linped lp in orderRows)
                {
                    if (lp.PedidoID == or.PedidoID)
                    {
                        orders[month].Add(lp);
                    }
                }
            }
        }

        private void FillChartByDay()
        {
            int maxY = 0;

            monthChart.Titles.Clear();
            monthChart.Titles.Add(monthBox.SelectedItem.ToString() + " - Orders by day");
            monthChart.Titles[0].ForeColor = Color.FromArgb(247, 252, 250);
            monthChart.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);

            if (monthChart.Series.Count != 0)
            {
                monthChart.Series.Clear();
                monthChart.Legends.Clear();
            }
            
            SortedList<int, int> data = new SortedList<int, int>();

            for(int j = 1; j <= 31; j++)
            {
                data.Add(j, 0);
            }
            
            foreach(KeyValuePair<string, SortedList<int, int>> kvp in ordersByDay)
            {
                if(monthBox.SelectedItem.ToString() == kvp.Key)
                {
                    foreach (KeyValuePair<int, int> kvp2 in kvp.Value)
                    {
                        data[kvp2.Key] += Convert.ToInt32(kvp2.Value);
                        if (data[kvp2.Key] > maxY)
                            maxY = data[kvp2.Key];
                    }
                }
            }

            int i = 0;
            monthChart.Series.Add("Serie");
            monthChart.ChartAreas[0].AxisX.Minimum = 0;
            monthChart.ChartAreas[0].AxisX.Maximum = 32;
            monthChart.ChartAreas[0].AxisX.Interval = 5;
            monthChart.ChartAreas[0].AxisY.Minimum = 0;
            monthChart.ChartAreas[0].AxisY.Maximum = maxY + 2;
            monthChart.ChartAreas[0].AxisY.Interval = 1;

            foreach (KeyValuePair<int, int> kvp in data)
            {
                if (kvp.Value != 0)
                {
                    monthChart.Series[0].Points.Add(kvp.Value);
                    monthChart.Series[0].Points[i].XValue = kvp.Key;
                    monthChart.Series[0].Points[i].IsValueShownAsLabel = true;
                    i++;
                }
            }
            loadingLbl1.Visible = false;
        }

        private void FillType()
        {
            yearChart.Titles.Clear();
            yearChart.Titles.Add(monthBox.SelectedItem.ToString() + " - Products by type");
            yearChart.Titles[0].ForeColor = Color.FromArgb(247, 252, 250);
            yearChart.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);

            if (yearChart.Series.Count != 0)
            {
                yearChart.Series[0].Points.Clear();
            }

            SortedList<string, int> data = new SortedList<string, int>();

            foreach (Linped lp in orders[monthBox.SelectedItem.ToString()])
            {
                String typeId = buss.GetProduct(lp.articuloID).tipoArticuloID;
                if (data.ContainsKey(typeId))
                {
                    data[typeId] += Convert.ToInt32(lp.cantidad);
                }
                else
                {
                    data.Add(typeId, Convert.ToInt32(lp.cantidad));
                }
            }

            int i = 0;

            foreach (KeyValuePair<string, int> kvp in data)
            {
                TipoArticulo type = types[Convert.ToInt32(kvp.Key) - 1];
                yearChart.Series[0].Points.Add(kvp.Value);
                yearChart.Series[0].Points[i].LegendText = type.Descripcion;
                yearChart.Series[0].Points[i].IsValueShownAsLabel = true;
                i++;
            }
            loadingLbl2.Visible = false;
        }

        private void FillCharts(object sender, EventArgs e)
        {
            loadingLbl1.Visible = true;
            loadingLbl2.Visible = true;
            FillChartByDay();
            FillType();
        }
    }
}

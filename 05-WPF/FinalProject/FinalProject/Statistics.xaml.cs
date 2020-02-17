// Adrián Navarro Gabino

using BusinessLayer;
using EntityLayer;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FinalProject
{
    /// <summary>
    /// Lógica de interacción para Statistics.xaml
    /// </summary>
    public partial class Statistics : UserControl
    {
        private MainWindow main;
        private Business buss;
        private List<string> months;
        private string[] monthList = {"January", "February", "March",
            "April", "May", "June", "July", "August", "September",
            "October", "November", "December"};
        private SortedList<string, List<Linped>> orders;
        private SortedList<string, SortedList<int, int>> ordersByDay;
        private List<Linped> orderRows;
        private int[] days;
        private int[] typesAmount;
        private List<TipoArticulo> types;

        public Statistics(MainWindow main, Business buss)
        {
            InitializeComponent();
            this.main = main;
            this.buss = buss;
            main.SetStatus("Status");

            days = new int[31];
            for(int index = 0; index < days.Length; index++)
            {
                days[index] = index + 1;
            }
            typesAmount = new int[4];
            loadingLbl1.Visibility = Visibility.Hidden;
            loadingLbl2.Visibility = Visibility.Hidden;
            months = new List<string>();
            ordersByDay = new SortedList<string, SortedList<int, int>>();
            orders = new SortedList<string, List<Linped>>();
            orderRows = buss.GetLinpeds();
            types = buss.GetProductTypes();

            foreach (Pedido or in MainWindow.orders)
            {
                string month = monthList[DateTime.Parse(or.fecha).Month - 1] +
                    ", " + DateTime.Parse(or.fecha).Year;

                DateTime date = DateTime.Parse(or.fecha);

                if (!ordersByDay.ContainsKey(month))
                {
                    ordersByDay.Add(month, new SortedList<int, int>());
                }
                if (!ordersByDay[month].ContainsKey(date.Day))
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

        private void SelectMonth(object sender, SelectionChangedEventArgs e)
        {
            loadingLbl1.Visibility = Visibility.Visible;
            loadingLbl2.Visibility = Visibility.Visible;
            FillChartByDay();
            FillType();
        }

        private void FillChartByDay()
        {
            monthTitle.Content = monthBox.SelectedItem.ToString() +
                " - Orders by day";
            int maxY = 0;

            SeriesCollection serie1 = new SeriesCollection();
            g2_eje_x.MaxValue = 32;
            g2_eje_x.MinValue = 1;

            SortedList<int, int> data = new SortedList<int, int>();

            for (int j = 1; j <= 31; j++)
            {
                data.Add(j, 0);
            }

            foreach (
                KeyValuePair<string, SortedList<int, int>> kvp in ordersByDay)
            {
                if (monthBox.SelectedItem.ToString() == kvp.Key)
                {
                    foreach (KeyValuePair<int, int> kvp2 in kvp.Value)
                    {
                        data[kvp2.Key] += Convert.ToInt32(kvp2.Value);
                        if (data[kvp2.Key] > maxY)
                            maxY = data[kvp2.Key];
                    }
                }
            }

            g_eje_y.MaxValue = maxY + 1;
            List<int> values1 = new List<int>();
            values1.Add(0);

            foreach (KeyValuePair<int, int> kvp in data)
            {
                values1.Add(kvp.Value);
            }

            serie1.Add(new ColumnSeries
            {
                Title = "Sales",
                Values = new ChartValues<int>(values1)
            });

            yearChart.Series = serie1;

            loadingLbl1.Visibility = Visibility.Hidden;

        }

        private void FillType()
        {
            typeTitle.Content = monthBox.SelectedItem.ToString() +
                " - Products by type";
            SeriesCollection serie2 = new SeriesCollection();

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

            SolidColorBrush[] brushes = new SolidColorBrush[] { Brushes.HotPink, Brushes.Green, Brushes.Aquamarine, Brushes.DarkOrange };
            int brushIndex = 0;

            foreach (KeyValuePair<string, int> kvp in data)
            {
                TipoArticulo type = types[Convert.ToInt32(kvp.Key) - 1];
                serie2.Add(new PieSeries
                {
                    Title = type.Descripcion,
                    Values = new ChartValues<double> { kvp.Value },
                    Stroke = brushes[brushIndex],
                    Fill = brushes[brushIndex]
                });
                brushIndex++;
            }
            monthChart.Series = serie2;
            loadingLbl2.Visibility = Visibility.Hidden;
        }
    }
}

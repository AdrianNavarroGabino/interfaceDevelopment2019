using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string op = "";
        private string saved = "";
        private bool isResult = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WriteButton(object sender, RoutedEventArgs e)
        {
            if(isResult && ((Button)sender).Name != "btnSave")
            {
                op = "";
                isResult = false;
            }

            switch(((Button)sender).Name)
            {
                case "btn1": op += "1"; break;
                case "btn2": op += "2"; break;
                case "btn3": op += "3"; break;
                case "btn4": op += "4"; break;
                case "btn5": op += "5"; break;
                case "btn6": op += "6"; break;
                case "btn7": op += "7"; break;
                case "btn8": op += "8"; break;
                case "btn9": op += "9"; break;
                case "btn0": op += "0"; break;
                case "btnP":
                    if (op.Length == 0 || op[op.Length - 1] == ' ')
                        op += "0,";
                    else
                        op += ",";
                    break;
                case "btnSave":
                    if (op.Length == 0)
                        saved = "";
                    else if(op.Split()[op.Split().Length - 1] != "")
                        saved = op.Split()[op.Split().Length - 1];
                    break;
                case "btnLoad":
                    if (op.Length == 0)
                        op = saved.Length == 0 ? "" : saved;
                    else if(op.Split()[op.Split().Length - 1] == "")
                        op += saved.Length == 0 ? "" : saved;
                    break;
                case "btnEq": Calculate(); break;
                case "btnMinus":
                    if (op.Length != 0 &&
                        op.Split()[op.Split().Length - 1] != "")
                    {
                        if (op[op.Length - 1] == ',')
                            op = op.Substring(0, op.Length - 1);
                        op += " - ";
                    }
                    break;
                case "btnSum":
                    if (op.Length != 0 &&
                        op.Split()[op.Split().Length - 1] != "")
                    {
                        if (op[op.Length - 1] == ',')
                            op = op.Substring(0, op.Length - 1);
                        op += " + ";
                    }
                    break;
                case "btnDiv":
                    if (op.Length != 0 &&
                        op.Split()[op.Split().Length - 1] != "")
                    {
                        if (op[op.Length - 1] == ',')
                            op = op.Substring(0, op.Length - 1);
                        op += " / ";
                    }
                    break;
                case "btnX":
                    if (op.Length != 0 &&
                        op.Split()[op.Split().Length - 1] != "")
                    {
                        if (op[op.Length - 1] == ',')
                            op = op.Substring(0, op.Length - 1);
                        op += " * ";
                    }
                    break;
                case "btnAc": op = ""; break;
                case "btnNeg":
                    op = op.LastIndexOf(" ") < 0 ? "-" + op :
                        op.Substring(0, op.LastIndexOf(" ")) + " -" +
                        op.Substring(op.LastIndexOf(" ") + 1);
                    op = op.Replace("--", "");
                    break;
            }

            resultTB.Text = op.Length == 0 ? "0" : op;
        }

        private void Calculate()
        {
            if (op.Length != 0)
            {
                string[] operators = op.Split();
                double result = Convert.ToDouble(operators[0]);

                for (int i = 1; i < operators.Length; i += 2)
                {
                    switch (operators[i])
                    {
                        case "+":
                            result += Convert.ToDouble(operators[i + 1]);
                            break;
                        case "-":
                            result -= Convert.ToDouble(operators[i + 1]);
                            break;
                        case "*":
                            result *= Convert.ToDouble(operators[i + 1]);
                            break;
                        case "/":
                            result /= Convert.ToDouble(operators[i + 1]);
                            break;
                    }
                }

                op = result.ToString();
                isResult = true;
            }
        }
    }
}

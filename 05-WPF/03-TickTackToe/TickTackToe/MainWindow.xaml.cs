using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// 4C061D
// D17A22

namespace TickTackToe
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int turn = 0;
        private int[,] tokens;
        Button newGame;

        public MainWindow()
        {
            InitializeComponent();
            tokens = new int[3, 3];
            newGame = (Button)MainGrid.FindName("playAgain");

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    tokens[i, j] = 0;
                }
            }
        }

        private void SelectCell(object sender, RoutedEventArgs e)
        {
            int winner;
            turn++;
            Button button = (Button)sender;
            Label label = (Label)MainGrid.FindName("a" +
                ((Button)sender).Name.Substring(1));
            label.Visibility = Visibility.Visible;

            button.Visibility = Visibility.Hidden;

            int position = Convert.ToInt32(button.Name.Substring(1)) - 1;
            int x = position / 3;
            int y = position % 3;

            if (turn % 2 == 1)
            {
                label.Foreground =
                    new SolidColorBrush(Color.FromRgb(76, 6, 29));
                
                label.Content = "X";

                tokens[x, y] = 2;

                winner = CheckWinner(6);

                if(winner == -1)
                {
                    playerLbl.Content = "Player 2";
                }
            }
            else
            {
                label.Foreground =
                    new SolidColorBrush(Color.FromRgb(209, 122, 34));

                label.Content = "O";

                tokens[x, y] = 7;

                winner = CheckWinner(21);

                if(winner == -1)
                {
                    playerLbl.Content = "Player 1";
                }
            }

            if (winner == 0)
            {
                playerLbl.Content = "Tie";
            }
            else if (winner == 1)
            {
                playerLbl.Content = "Winner: " + playerLbl.Content;
                foreach (Object b in MainGrid.Children)
                {
                    if (b is Button)
                        ((Button)b).IsEnabled = false;
                }
            }

            if(winner != -1)
            {
                newGame.Content = "Play again";
                newGame.Margin = new Thickness(130, 200, 0, 0);
                newGame.Height = 100;
                newGame.Width = 200;
                newGame.FontSize = 36;
                newGame.FontWeight = FontWeights.Bold;
                newGame.HorizontalAlignment = HorizontalAlignment.Left;
                newGame.VerticalAlignment = VerticalAlignment.Top;
                newGame.HorizontalContentAlignment = HorizontalAlignment.Center;
                newGame.Foreground =
                    new SolidColorBrush(Color.FromRgb(238, 99, 82));
                newGame.Background =
                    new SolidColorBrush(Color.FromRgb(105, 132, 116));
                newGame.Opacity = 100;
                newGame.IsEnabled = true;
            }
        }

        private int CheckWinner(int result)
        {
            int r1 = 0;
            int r2 = 0;
            int r3 = 0;
            int r4 = 0;
            int r5 = 0;
            int r6 = 0;
            int r7 = 0;
            int r8 = 0;
            bool full = true;

            for (int i = 0; i < 3; i++)
            {
                r1 += tokens[0, i];
                r2 += tokens[1, i];
                r3 += tokens[2, i];
                r4 += tokens[i, 0];
                r5 += tokens[i, 1];
                r6 += tokens[i, 2];
                r7 += tokens[i, i];
                r8 += tokens[i, 2 - i];
                if (tokens[0, i] == 0 || tokens[1, i] == 0 || tokens[2, i] == 0)
                {
                    full = false;
                }
            }

            if(r1 == result || r2 == result || r3 == result || r4 == result ||
                r5 == result || r6 == result || r7 == result || r8 == result)
            {
                return 1;
            }
            if(full)
            {
                return 0;
            }

            return -1;
        }

        private void NewGame(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tokens[i, j] = 0;
                }
            }

            for (int i = 1; i <= 9; i++)
            {
                ((Label)MainGrid.FindName("a" + i)).Visibility = Visibility.Hidden;
                ((Button)this.FindName("b" + i)).IsEnabled = true;
                ((Button)this.FindName("b" + i)).Visibility = Visibility.Visible;
            }

            newGame.Opacity = 0;
            newGame.IsEnabled = false;
            newGame.Width = 0;
            newGame.Height = 0;

            turn = 0;
            playerLbl.Content = "Player 1";
        }
    }
}

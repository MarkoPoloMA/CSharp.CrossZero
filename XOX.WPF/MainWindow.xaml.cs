using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
using XOX.Interface;
using XOX.Models;

namespace XOX.WPF
{
    public partial class MainWindow : Window
    {
        private IBoard board;
        private IPlayer player1;
        private IPlayer player2;
        private IChecker checker;
        private IPlayer curplayer;
        public MainWindow()
        {
            InitializeComponent();

            board = new Board();
            player1 = new HumanPlayer('O');
            player2 = new HumanPlayer('X');
            checker = new Checker();
            curplayer = player1;

            board.InitiazaizBoard();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            curplayer.ExecuteMove(board, button , GetButtonNumber(button));
            button.Content = curplayer.Symbol;

            if (checker.CheckForDraw(board))
            {
                ShowFinallyPage("Ничья!");
                return;
            }

            if (checker.CheckGameOver(board, curplayer))
            {
                ShowFinallyPage($"Победил {curplayer.Symbol}");
                return;
            }

            curplayer = curplayer == player1 ? player2 : player1;
        }
        private void ShowFinallyPage(string result)
        {
            FinallyPage finallyPage = new FinallyPage(result);
            finallyPage.ShowDialog();

            ClearButton();
            board.ResetBoard();
        }

        private void ClearButton()
        {
            One.Content = "";
            Two.Content = "";
            Three.Content = "";
            Four.Content = "";
            Five.Content = "";
            Six.Content = "";
            Seven.Content = "";
            Eight.Content = "";
            Nine.Content = "";

            curplayer = player1;
        }
        private int GetButtonNumber(Button button)
        {
            int i = Grid.GetRow(button);
            int j = Grid.GetColumn(button);

            return i * 3 + j + 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using XOX.Interface;

namespace XOX.Models
{
    internal class HumanPlayer : IPlayer
    {
        public char Symbol { get; }
        public HumanPlayer(char symbol) => Symbol = symbol;
        public void ExecuteMove(IBoard board,Button b, int button)
        { 
            int i = (button - 1) / 3;
            int j = (button - 1) % 3;

            if (board.GetPoint(i, j) == ' ')
                board.SetPoint(i, j, Symbol);
        }
    }
}

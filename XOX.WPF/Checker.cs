using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XOX.Interface;

namespace XOX
{
    internal class Checker : IChecker
    {
        public bool CheckForDraw(IBoard board)
        {
            for (var i = 0; i < 3; i++)
            for (var j = 0; j < 3; j++)
                if (board.GetPoint(i, j) == ' ')
                    return false;
            return true;
        }
        private bool CheckAllLines(IBoard board, char symbol)
        {
            for (var i = 0; i < 3; i++)
                if (board.GetPoint(i, 0) == symbol && board.GetPoint(i, 1) == symbol && board.GetPoint(i, 2) == symbol ||
                    board.GetPoint(0, i) == symbol && board.GetPoint(1, i) == symbol && board.GetPoint(2, i) == symbol ||
                    board.GetPoint(0, 0) == symbol && board.GetPoint(1, 1) == symbol && board.GetPoint(2, 2) == symbol ||
                    board.GetPoint(0, 2) == symbol && board.GetPoint(1, 1) == symbol && board.GetPoint(2, 0) == symbol)
                    return true;

            return false;
        }
        public bool CheckGameOver(IBoard board, IPlayer p)
        {
            if (CheckAllLines(board, p.Symbol))
                return true;
            else if (CheckAllLines(board, p.Symbol))
                return true;

            return false;
        }
    }
}

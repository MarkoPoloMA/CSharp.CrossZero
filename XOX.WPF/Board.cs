using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XOX.Interface;

namespace XOX
{
    internal class Board : IBoard
    {
        private char[,] board ;
        public Board() 
        {
            board = new char[3, 3];

        }
        public char GetPoint(int rows, int cols)
        {
            return board[rows, cols];
        }
        public void SetPoint(int row, int col, char x)
        {
            board[row, col] = x;
        }
        public void InitiazaizBoard()
        {
            for (var i = 0; i < 3; i++)
            for (var j = 0; j < 3; j++)
                board[i, j] = ' ';
        }
        public void ResetBoard()
        {
            InitiazaizBoard();
        }
    }
}

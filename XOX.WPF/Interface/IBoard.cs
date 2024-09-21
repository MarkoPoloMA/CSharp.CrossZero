using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOX.Interface
{
    internal interface IBoard
    {
        char GetPoint(int rows, int cols);
        void SetPoint(int rows, int cols, char x);
        void InitiazaizBoard();
        void ResetBoard();
    }
}

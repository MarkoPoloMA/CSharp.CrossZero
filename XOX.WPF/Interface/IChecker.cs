using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XOX.Interface;

namespace XOX
{
    internal interface IChecker
    {
        bool CheckForDraw(IBoard board);
        bool CheckGameOver(IBoard board, IPlayer p);
    }
}

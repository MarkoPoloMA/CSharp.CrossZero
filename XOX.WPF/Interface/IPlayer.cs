using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace XOX.Interface
{
    internal interface IPlayer
    {
        void ExecuteMove(IBoard board, Button b, int button);
        char Symbol { get; }
    }
}

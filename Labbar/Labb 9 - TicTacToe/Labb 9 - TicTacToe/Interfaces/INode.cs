using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_9___TicTacToe.Interfaces
{
    interface INode
    {
        Node[,] Grid { get; set; }

        void PlaceMarker();
    }
}

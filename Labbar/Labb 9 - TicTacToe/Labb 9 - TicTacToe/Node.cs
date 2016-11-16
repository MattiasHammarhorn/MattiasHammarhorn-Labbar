using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_9___TicTacToe
{
    class Node
    {
        public bool Taken { get; set; }
        public int Player { get; set; } = 0;
        public int PositionX { get; set; } // Ints som tilldelas koordinater I Gameboard.
        public int PositionY { get; set; } // Ints som tilldelas koordinater I Gameboard.
    }
}

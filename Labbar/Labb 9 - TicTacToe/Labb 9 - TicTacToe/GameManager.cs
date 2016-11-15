using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_9___TicTacToe
{
    class GameManager
    {
        GameBoard gameBoard = new GameBoard();

        public void Start()
        {
            gameBoard.initializeGrid();
            gameBoard.Render();
        }
    }
}

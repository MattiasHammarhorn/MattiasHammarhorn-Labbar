using Labb_9___TicTacToe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_9___TicTacToe
{
    class GameBoard : INode
    {
        public Node[,] Grid { get; set; }

        public void initializeGrid()
        {
            int position = 0;

            Grid = new Node[3, 3]; // Initsierar Node-arrayens storlek
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    position++;
                    Grid[row, col] = new Node { Position = position }; // Skapa nodes inom Grid
                }
            }
        }

        public void Render()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    // Referens till variabeln Node
                    var node = Grid[row, col];

                    if (node.Taken) // Ifall det finns något i Taken
                    {
                        if (node.Player == 1) // Ifall det är spelare 1, skriv ut X
                            Console.WriteLine("[X]");
                        else                  // Annars skriv ut O
                            Console.WriteLine("[O]");
                    }
                    else
                    Console.Write("[" + node.Position + "]"); // Ifall det är tomt, skriv ut en tom ruta

                    if (col == 2)   // När col når två så sker ett radbyte
                        Console.WriteLine();
                }
            }
        }

        public void PlaceMarker(int row, int col, int Player)
        {

        }
    }
}

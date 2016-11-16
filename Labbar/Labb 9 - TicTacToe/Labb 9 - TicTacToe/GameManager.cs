using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_9___TicTacToe
{
    public delegate void isTie();
    class GameManager
    {
        GameBoard gameBoard = new GameBoard();
        public bool mainLoop = true;
        public bool isRunning = true;

        public void Start()
        {
            Console.WriteLine("Velkomm to ze TickTackTå game, vere only\nze 1337357 and dankest of players clash in\nan epic fight of memes, X'ses and O's!");

            Console.WriteLine("Press a key to continiue...");
            Console.ReadKey(true);

            while (mainLoop)
            {
                Console.Clear();
                Console.WriteLine("1. Play new game");
                Console.WriteLine("2. Exit");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        GameLoop();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Exit();
                        break;
                }
                
            }
        }

        public void GameLoop() // Lat sätt att göra en loop som pågår tills hela spelet är över
        {
            gameBoard.initializeGrid();

            while (isRunning)
            {
                gameBoard.Render();
                gameBoard.PlaceMarker();
            }
        }

        public void Exit()
        {
            Console.WriteLine("Thanks for running this program!");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

            mainLoop = false;
        }
    }
}

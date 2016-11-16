using Labb_9___TicTacToe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_9___TicTacToe
{
    public delegate void PrintMessage();

    class GameBoard : INode
    {
        private event PrintMessage ApplicationStarted;

        public Node[,] Grid { get; set; }

        int SizeOfGrid = 3; // Property för att dynamiskt kunna ändra storleken på arrayen samt for-looparna
        int PlayerCheck = 0; // Property för att senare kolla vilken spelare som ska spela sen
        int Turns = 0; // Property för att senare kolla hur många vändor som körts/tillgänglas brädet

        public void initializeGrid()
        {
            Grid = new Node[SizeOfGrid, SizeOfGrid]; // Initsierar Node-arrayens storlek

            for (int row = 0; row < SizeOfGrid; row++)
            {
                for (int col = 0; col < SizeOfGrid; col++)
                {
                    Grid[row, col] = new Node { PositionX = row, PositionY = col }; // Tilldelar den koordinater till ints
                }                                                      
            }                                                               
        }

        public void Render()
        {
            Console.Clear();

            if (Turns == 9) // När Turns har ökat till 9
            {
                ApplicationStarted += new PrintMessage(PrintMessage1);
                ApplicationStarted.Invoke(); // Invokerar metoden
                Environment.Exit(0); // Lat sätt att avsluta programmet
            }

            for (int row = 0; row < SizeOfGrid; row++)
            {
                for (int col = 0; col < SizeOfGrid; col++)
                {
                    // Referens till variabeln Node
                    var node = Grid[row, col];

                    if (node.Taken == true) // Ifall det finns något i Taken i en Node
                    {
                        if (node.Player == 1) // Ifall det är spelare 1, skriv ut X
                            Console.Write("[X]");
                        else                  // Annars skriv ut O
                            Console.Write("[O]");
                    }
                    else
                    Console.Write("[" + node.PositionX + node.PositionY + "]"); // Ifall det är tomt, skriv ut en tom ruta

                    if (col == 2)   // När col når två så sker ett radbyte
                        Console.WriteLine();
                }
            }
        }

        public void PlaceMarker()
        {
            Console.WriteLine("Time to choose... 2 digits!");
            int inputX = int.Parse(Console.ReadLine());
            int inputY = int.Parse(Console.ReadLine());


            for (int row = 0; row < SizeOfGrid; row++)
            {
                for (int col = 0; col < SizeOfGrid; col++)
                {
                    var node = Grid[row, col];

                    if (inputX == node.PositionX) // parsad input som kollas ifall den korresponderar till en koordinat på Grid.

                        if (inputY == node.PositionY) // parsad input som kollas ifall den korresponderar till en koordinat på Grid.
                        {
                            while (node.Taken == false) // Itererar ifall noden redan är tagen, turn ökas under
                            {
                                Turns++;
                                if (PlayerCheck == 1) // Ifall spelare när nr 1 så ska den tilldela nr 2s värde
                                {
                                    PlayerCheck = 0;
                                }
                                else // Ifall spelare när nr 0 så ska den tilldelas nr 1s värde
                                {
                                    PlayerCheck = 1;
                                }

                                node.Player = PlayerCheck; // Tilldelar värdet från PlayerCheck till node.Player så att vi kan
                                                           // avgöra vilken "spelare" som satt valt en node
                                node.Taken = true; // Taken blir till true och bryter ut ur while-loopen
                            }
                        }
                }
            }
        }

        public void PrintMessage1() // Metod för att skriva ut 'Game over'-texten
        {
            Console.Clear();
            Console.WriteLine("Game over! Out of nodes!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

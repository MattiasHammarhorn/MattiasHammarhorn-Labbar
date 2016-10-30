using Labb_6___Console_Adventure.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___Console_Adventure
{
    class Runtime
    {
        public void Start()
        {

            //Anropar en metod för grafik
            bool isGameRunning = true;

            while(isGameRunning)
            {
                Menus.DisplayMainMenu();
                var menuInput = Console.ReadKey(true).Key;

                //Switch för att starta eller avsluta programmet
                switch(menuInput)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        StartGame();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        isGameRunning = false;
                        break;
                }
            }
        }

        public static void StartGame()
        {
            //Gör nya instanser utav Room och Yard
            Room room = new Room();
            Yard yard = new Yard();
            Townsquare townsquare = new Townsquare();

            bool GameLoop = true;

            while(GameLoop)
            {
                Menus.AreaMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        room.EnterRoom();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        yard.EnterYard();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        townsquare.EnterTownsquare();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        GameLoop = false;
                        break;
                }
            }
        }
    }
}

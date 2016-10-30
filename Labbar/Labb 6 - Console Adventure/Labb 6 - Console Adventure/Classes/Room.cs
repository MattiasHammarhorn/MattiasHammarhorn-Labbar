using Labb_6___Console_Adventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___Console_Adventure.Classes
{
    class Room : IEnvironment
    {
        public List<INonPlayerCharacter> nonPlayerCharacters { get; set; }

        //Konstruktor för hur en instans av Room ska se ut.
        public Room()
        {
            //Gör en lista av NPC och tilldelar värden till deras properties
            nonPlayerCharacters = new List<INonPlayerCharacter>()
            {
                new Human { Name = "Old woman",
                            Response = "O hello there, come to chat with an old woman like meself?",
                            Appearance = "an old woman" }
            };
        }

        public string AreaName()
        {
            return "Mss.Fairfax's living room";
        }

        //Metod som tar reda på vilka npcs det finns i "rummet" genom en foreach-loop
        //och sedan skriver ut det i Console.WriteLine
        public void Observe()
        {
            Console.WriteLine("The area contains: ");
            foreach (var nonPlayerCharacter in nonPlayerCharacters)
            {
                Console.WriteLine("{0}", nonPlayerCharacter.Appearance);
            }
        }

        public void Interact()
        {
            //For-loop för att skriva ut och ge alla objekt i listan ett nummer.
            for (int i = 1; i <= nonPlayerCharacters.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, nonPlayerCharacters[i - 1].Appearance);
            }

            Console.WriteLine("Choose object: ");
            int index = int.Parse(Console.ReadLine());

            //Anropar properties från npcs och ser till att indexen blir detsamma som positionerna i for-loopen
            Console.WriteLine("{0}: {1}", nonPlayerCharacters[index - 1].Name, nonPlayerCharacters[index - 1].Response);
        }

        public void EnterRoom()
        {
            //put a while and switch here to decide which actions you want to do inside the room
            bool GameLoop = true;

            while (GameLoop)
            {
                Menus.ActionMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Observe();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Interact();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        GameLoop = false;
                        break;
                }
            }
        }
    }
}

using Labb_6___Console_Adventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___Console_Adventure.Classes
{
    class Townsquare : IEnvironment
    {
        public List<INonPlayerCharacter> nonPlayerCharacters { get; set; }

        public Townsquare()
        {
            nonPlayerCharacters = new List<INonPlayerCharacter>()
            {
                new Human { Name = "Alistair",
                            Response = "Good day.",
                            Appearance = "An old man wearing victorian clothes, seemingly in his 50s." },
                new Human { Name = "Alice",
                            Response = "What'cha lookin' at?",
                            Appearance = "A young girl in her late teens, wearing an old fashioned dress."},
                new Animal { Name = "Stray dog",
                            Response = "Woof woof!",
                            Appearance = "A filthy stray dog." }
            };
        }

        public string AreaName()
        {
            return "Townsquare";
        }

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

        public void EnterTownsquare()
        {
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

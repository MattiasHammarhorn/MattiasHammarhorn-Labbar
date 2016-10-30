using Labb_6___Console_Adventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___Console_Adventure.Classes
{
    class Yard : IEnvironment
    {
        public List<INonPlayerCharacter> nonPlayerCharacters { get; set; }

        //Konstruktor för hur en instans av Yard ska se ut.
        public Yard()
        {
            nonPlayerCharacters = new List<INonPlayerCharacter>()
            {
                new Human { Name = "Eric Fairfax",
                            Response = "Huh? What you wan', bruv? Can't you see I'm busy!",
                            Appearance = "A young man in his pre-teens, clad in baggy trousers and a sport jacket." },
                new Animal { Name = "Mr.Nibbles",
                            Response = "Meow!",
                            Appearance = "A black cat stuck in a tree." }
            };
        }

        //Tilldelar ett namn på stringen som jag tänker använda för att ge namn åt varje "area"
        public string AreaName()
        {
            return "Mss.Fairfax's garden";
        }

        //Metod 
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

        public void EnterYard()
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

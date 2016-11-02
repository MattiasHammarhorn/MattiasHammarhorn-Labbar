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
                            Response = "Oh hello there, have you seen Mss.Fairfax or her son, Eric, lately? Maybe something happened to them...",
                            Appearance = "An old man wearing victorian clothes, seemingly in his 50s.",
                            QuestDialogue = "Huh a ladder? Sure! Take the one right next to me!"},
                new Human { Name = "Alice",
                            Response = "What'cha lookin' at? Me boyfriend, Eric's bloody late for our date. He said he'd be 'ere by noon, he's probably up there clinging to his mom, that kid...",
                            Appearance = "A young girl in her late teens, wearing chavy-looking street wear.",
                            QuestDialogue = "Eric's stuck trying to get his cat down from a tree?\nThat good-for-nothing lump of... -Oh forgive me, here, take this ladder!"},
                new Animal { Name = "Stray dog",
                            Response = "Woof woof!",
                            Appearance = "A filthy stray dog.",
                            QuestDialogue = "*The dog points you towards a ladder lying in the middle of the townsquare."}
            };
        }

        public string AreaName()
        {
            return "Townsquare";
        }

        public void Observe()
        {
            //For-loop för att skriva ut och ge alla objekt i listan ett nummer.
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

            if (QuestManager.isQuestStarted == false)
            {
                Console.WriteLine("{0}: {1}", nonPlayerCharacters[index - 1].Name, nonPlayerCharacters[index - 1].Response);
            }

            else
            {
                Console.WriteLine("{0}: {1}", nonPlayerCharacters[index - 1].Name, nonPlayerCharacters[index - 1].QuestDialogue);
                QuestManager.QuestMonologue();
                QuestManager.isLadderTaken = true;
            }
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

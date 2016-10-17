using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv_och_Polymorfism
{
    class Runtime
    {
        public void Start()
        {
            #region# Test
            //Snake mySnake = new Snake
            //{
            //    Name = "Solid Snake",
            //    Age = 42,
            //    Move = "sneaking",
            //    Sound = "speaking",
            //    Weight = 63.5,
            //    Length = 5.4
            //};

            //Dog myDog = new Dog
            //{
            //    Name = "Scheissekopf",
            //    Age = 23,
            //    Move = "moving on all four legs",
            //    Sound = "barking and whining",
            //    Weight = 31.4,
            //    NumberOfLegs = 4,
            //    DoesHunt = "can be used for hunting "
            //};

            //Penguin myPenguin = new Penguin
            //{
            //    Name = "Emperor Penguin",
            //    Age = 22,
            //    Move = "",
            //    Sound = "chirping",
            //    Weight = 21.7,
            //    CanFly = "it cannot fly",
            //    DoesNest = "does not nest, but incubates"
            //};
            //Console.WriteLine(myDog.Introduction());
            //Console.WriteLine(mySnake.Introduction());
            //Console.WriteLine(myPenguin.Introduction());

            //Console.ReadKey();
            #endregion
            DogManager dogManager = new DogManager();
            SnakeManager snakeManager = new SnakeManager();
            PenguinManager penguinManager = new PenguinManager();

            bool mainloop = true;

            while (mainloop)
            {
                Menu.DisplayMainMenu();

                Console.Write("Choose option: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Menu.DisplayAddObject();

                        Console.WriteLine("Choose option: ");
                        int inputcaseone = int.Parse(Console.ReadLine());

                        bool addLoop = true;

                        while(addLoop)
                            switch (inputcaseone)
                            {
                                case 1:
                                    dogManager.AddDog();
                                    addLoop = false;
                                    break;
                                case 2:
                                    snakeManager.AddSnake();
                                    addLoop = false;
                                    break;
                                case 3:
                                    penguinManager.AddPenguin();
                                    addLoop = false;
                                    break;
                                case 4:
                                    addLoop = false;
                                    break;
                                
                            }
                        break;

                    case 2:
                        Menu.DisplayRemoveObject();

                        Console.WriteLine("Choose option: ");
                        int inputcasetwo = int.Parse(Console.ReadLine());

                        bool removeLoop = true;

                        while (removeLoop)
                            switch (inputcasetwo)
                            {
                                case 1:
                                    dogManager.RemoveDog();
                                    removeLoop = false;
                                    break;
                                case 2:
                                    snakeManager.RemoveSnake();
                                    removeLoop = false;
                                    break;
                                case 3:
                                    penguinManager.RemovePenguin();
                                    removeLoop = false;
                                    break;
                                case 4:
                                    removeLoop = false;
                                    break;
                            }
                        break;

                    case 3:
                        Menu.DisplayListOfAnimals();

                        Console.WriteLine("Choose option: ");
                        int inputcasethree = int.Parse(Console.ReadLine());

                        bool listsLoop = true;

                        while (listsLoop)
                            switch (inputcasethree)
                            {
                            case 1:
                                    dogManager.DisplayDogs();
                                    Console.WriteLine("Press a key to continue...");
                                    Console.ReadKey();
                                    listsLoop = false;
                                    break;
                            case 2:
                                    snakeManager.DisplaySnakes();
                                    Console.WriteLine("Press a key to continue...");
                                    Console.ReadKey();
                                    listsLoop = false;
                                    break;
                            case 3:
                                    penguinManager.DisplayPenguins();
                                    Console.WriteLine("Press a key to continue...");
                                    Console.ReadKey();
                                    listsLoop = false;
                                    break;
                            case 4:
                                    listsLoop = false;
                                    break;
                            }
                        break;

                    case 4:
                        mainloop = false;
                        break;
                }

            }
        }
    }
}

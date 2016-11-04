using Labb_7___Store_app.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___Store_app
{
    class Runtime
    {
        public void Start()
        {
            //Skapar en ny instans av ProductManager
            ProductManager productManager = new ProductManager();

            bool isRunning = true;

            while (isRunning)
            {
                Menus.DisplayMainMenu();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        #region Case 1
                        //Visar menyn för kategorierna
                        Menus.DisplayCategories();

                        Console.WriteLine("Choose");
                        var caseOne = Console.ReadKey(true).Key;

                        //Initierar ny bool och switch-sats för yttligare val inom "browse"-delen
                        bool isDisplaying = true;

                        while(isDisplaying)
                        {
                            switch(caseOne)
                            {
                                case ConsoleKey.D1:
                                case ConsoleKey.NumPad1:
                                    productManager.DisplayElectronics();
                                    isDisplaying = false;
                                    break;
                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:
                                    productManager.DisplayFood();
                                    isDisplaying = false;
                                    break;
                                case ConsoleKey.D3:
                                case ConsoleKey.NumPad3:
                                    productManager.DisplayToys();
                                    isDisplaying = false;
                                    break;
                                case ConsoleKey.D4:
                                case ConsoleKey.NumPad4:
                                    isDisplaying = false;
                                    break;
                            }
                        }
                        #endregion

                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        #region Case 2
                        Menus.ProductsToRemove();

                        Console.WriteLine("Choose");
                        var caseTwo = Console.ReadKey(true).Key;

                        //Initierar ny bool och switch-sats för yttligare val inom "remove"-delen
                        bool isRemoving = true;

                        while (isRemoving)
                        {
                            switch (caseTwo)
                            {
                                case ConsoleKey.D1:
                                case ConsoleKey.NumPad1:
                                    productManager.RemoveElectronic();
                                    isRemoving = false;
                                    break;
                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:
                                    productManager.RemoveFood();
                                    isRemoving = false;
                                    break;
                                case ConsoleKey.D3:
                                case ConsoleKey.NumPad3:
                                    productManager.RemoveToy();
                                    isRemoving = false;
                                    break;
                                case ConsoleKey.D4:
                                case ConsoleKey.NumPad4:
                                    isRemoving = false;
                                    break;
                            }
                        }
                        #endregion
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        #region Case 3
                        Menus.ProductsToAdd();

                        Console.WriteLine("Choose");
                        var caseThree = Console.ReadKey(true).Key;

                        //Initierar ny bool och switch-sats för yttligare val inom ""-delen
                        bool isAdding = true;

                        while (isAdding)
                        {
                            switch (caseThree)
                            {
                                case ConsoleKey.D1:
                                case ConsoleKey.NumPad1:
                                    productManager.AddElectronic();
                                    isAdding = false;
                                    break;
                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:
                                    productManager.AddFood();
                                    isAdding = false;
                                    break;
                                case ConsoleKey.D3:
                                case ConsoleKey.NumPad3:
                                    productManager.AddToy();
                                    isAdding = false;
                                    break;
                                case ConsoleKey.D4:
                                case ConsoleKey.NumPad4:
                                    isAdding = false;
                                    break;
                            }
                        }
                        #endregion
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        isRunning = false;
                        break;
                }
            }
        }
    }
}

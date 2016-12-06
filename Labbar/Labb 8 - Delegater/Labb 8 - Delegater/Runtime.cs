using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_8___Delegater
{
    class Runtime
    {
        Lists lists = new Lists();
        public delegate string StringConcatinator(string[] MyStrings);
        public delegate float NumberOperator(float[] MyFloats);
        public delegate double PriceCalculator(double[] Prices);

        public string AllStrings(string[] MyStrings)
        {
            Console.Clear();
            string tempString = null;
            int index = 0;

            foreach (string singleString in MyStrings)
            {
                index++;                            // Limiter för att se till att if-satsen kan fungera
                if (index < MyStrings.Length)
                    tempString += singleString + ", ";  // Lägger in strängen i en temporär string
                else
                    tempString += singleString;     // Lägger till den sista strängen utan komma-tecken
            }
            return tempString;                      // Returnerar tempvärde
        }

        public void Calculator(Func<float[], float> calcFunc)
        {
            Console.Clear();
            float result = calcFunc(lists.MyFloats); // Skriver ut resultatet
            Console.WriteLine(result);
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey(true);
        }

        public void Start()
        {
            ProductManager productManager = new ProductManager();
            StringConcatinator allString = AllStrings; // Instansierar delegat
            StringConcatinator nameFormatter = productManager.FormatProductNames; // Mer instansiering av delegater
            PriceCalculator priceCalculator = productManager.PriceCalculation;

            string[] productNames = productManager.Products. // Gör array utav varje produktnamn
                Select(Product => Product.Name)
                .ToArray();
            double[] productPrices = productManager.Products.
                Select(Product => Product.Price)
                .ToArray();

            Func<float[], float> addFunc = (MyFloats) => // Funcs som returnerar en float
           {
               float tempFloat = 0;

               foreach (float singleFloat in MyFloats)
               {
                   tempFloat += singleFloat;            // Adderar ihopp varje float till en
               }
               return tempFloat;
           };

            Func<float[], float> multiplyFunc = (MyFloats) =>
            {
                float tempFloat = 1;

                foreach (float singleFloat in MyFloats)
                {
                    tempFloat *= singleFloat;       // Multiplicerar ihopp dem till en float
                }
                return tempFloat;
            };

            bool loop = true;

            while (loop)
            {
                Console.Clear();
                UI.PrintMainMenu();
                ConsoleKey input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1: case ConsoleKey.NumPad1:
                        Console.WriteLine(allString(lists.MyStrings));
                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D2: case ConsoleKey.NumPad2:
                        Calculator(addFunc); // Åkallar metoden som tar in func
                        break;
                    case ConsoleKey.D3: case ConsoleKey.NumPad3:
                        Calculator(multiplyFunc);
                        break;
                    case ConsoleKey.D4: case ConsoleKey.NumPad4:
                        Console.WriteLine(nameFormatter(productNames));
                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D5: case ConsoleKey.NumPad5:
                        Console.WriteLine(priceCalculator(productPrices));
                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D6: case ConsoleKey.NumPad6:
                        loop = false;
                        break;
                }
            }
        }
    }
}

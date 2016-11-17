using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___Store_app.Classes
{
    class ProductManager
    {
        //Skapar listor utav produkterna
        public List<Electronics> electronics { get; set; }
        public List<Food> food { get; set; }
        public List<Toys> toys { get; set; }
        public List<Product> boughtProducts { get; set; }

        // Konstruktor
        #region Constructor
        public ProductManager()
        {
            //Skapar hårdkodade listor utav produkter
            electronics = new List<Electronics>()
            {
                new Electronics { ProductName = "Leninov Thinkerpad 110, 15,6'' Portable (Black)",
                                Price = 2699,
                                ProductInformation = "With Leninov Thinkerpad you will have a nimble computer that manages everyday tasks.\nWindows 11, 15,6 inch screen, quick 5th generation's Intel Core i5-processor and a numeric\nkeyboard are some of the specifications which makes for good performance." },
                new Electronics { ProductName = "MacBook Aether 13.3'' MMGF2",
                                Price = 9790,
                                ProductInformation = "MacBook Aether 13,3'' screen with a fifth generation Intel Core i5-processor that delives power which lasts the entire day.\n> Intel Core i5/ 1.6 GHz\n> Intel HD Graphics 6000\n> 8GB RAM/ 128 GB Flashmemory" },
                new Electronics { ProductName = "Interactive Pen Display",
                                Price = 15000,
                                ProductInformation = "A high-performance pen tablet with multi-touch capabilities optimized\nto handle CG Artists and Illustrators daily tasks." }
            };

            food = new List<Food>
            {
                new Food { ProductName = "Fresh Tomato",
                            Price = 5,
                            ProductInformation = "Restores 5 health points." },
                new Food { ProductName = "Felix Pizza",
                            Price = 69,
                            ProductInformation = "A pizza ready to be microwaved at 3 minutes with 50kW." },
                new Food { ProductName = "Reiman's Ramen",
                            Price = 69,
                            ProductInformation = "A cup of ramen ready to be microwaved at 3 minutes with 50kW." }
            };

            toys = new List<Toys>
            {
                new Toys { ProductName = "Jar Jar Binks figurine",
                            Price = 30,
                            ProductInformation = "A plastic figurine of everyone's favorite Star Wars character." },
                new Toys { ProductName = "Light Saber",
                            Price = 34000,
                            ProductInformation = "A deadly light saber that has probably been misplaced. Someone should probably get rid of it before anyone is hurt..." },
                new Toys { ProductName = "T34 toy",
                            Price = 69,
                            ProductInformation = "A toy miniature version of the famous T34-tank model used by the Soviet Union from 1940-58." }
            };
        }
        #endregion

        #region Adding methods
        public void AddElectronic()
        {
            Electronics newElectronics = new Electronics();

            Console.WriteLine("Enter name of new product: ");
            newElectronics.ProductName = Console.ReadLine();

            Console.WriteLine("Enter price of new product: ");
            newElectronics.Price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter information about new product: ");
            newElectronics.ProductInformation = Console.ReadLine();

            electronics.Add(newElectronics);
        }

        public void AddFood()
        {
            Food newFood = new Food();

            Console.WriteLine("Enter name of new product: ");
            newFood.ProductName = Console.ReadLine();

            Console.WriteLine("Enter price of new product: ");
            newFood.Price =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter information about new product: ");
            newFood.ProductInformation = Console.ReadLine();

            food.Add(newFood);
        }

        public void AddToy()
        {
            Toys newToys = new Toys();

            Console.WriteLine("Enter name of new product: ");
            newToys.ProductName = Console.ReadLine();

            Console.WriteLine("Enter price of new product: ");
            newToys.Price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter information about new product: ");
            newToys.ProductInformation = Console.ReadLine();

            toys.Add(newToys);
        }
        #endregion

        #region Removing methods
        public void RemoveElectronic()
        {
            for (int i = 1; i <= electronics.Count; i++)
            {
                Console.WriteLine("\n{0}. {1}", i, electronics[i - 1].ProductName);
            }

            Console.WriteLine("Choice: ");
            int index = int.Parse(Console.ReadLine());

            electronics.RemoveAt(index - 1);
        }

        public void RemoveFood()
        {
            for (int i = 1; i <= food.Count; i++)
            {
                Console.WriteLine("\n{0}. {1}", i, food[i - 1].ProductName);
            }

            Console.WriteLine("Choice: ");
            int index = int.Parse(Console.ReadLine());

            food.RemoveAt(index - 1);
        }

        public void RemoveToy()
        {
            for (int i = 1; i <= toys.Count; i++)
            {
                Console.WriteLine("\n{0}. {1}", i, toys[i - 1].ProductName);
            }

            Console.WriteLine("Choice: ");
            int index = int.Parse(Console.ReadLine());

            toys.RemoveAt(index - 1);
        }
        #endregion

        #region Displaying methods
        public void DisplayElectronics()
        {
            for (int i = 1; i <= electronics.Count; i++)
            {
                Console.WriteLine("\n{0}: {1} Price: {2}\n\n{3}", i, electronics[i - 1].ProductName, electronics[i - 1].Price, electronics[i -1].ProductInformation);
            }
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey(true);
        }

        public void DisplayFood()
        {
            for (int i = 1; i <= food.Count; i++)
            {
                Console.WriteLine("\n{0}: {1} Price: {2}\n\n{3}", i, food[i - 1].ProductName, food[i - 1].Price, food[i - 1].ProductInformation );
            }
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey(true);
        }

        public void DisplayToys()
        {
            for (int i = 1; i <= toys.Count; i++)
            {
                Console.WriteLine("\n{0}: {1} Price: {2}\n\n{3}", i, toys[i - 1].ProductName, toys[i - 1].Price, toys[i - 1].ProductInformation);
            }
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey(true);
        }
        #endregion
    }
}

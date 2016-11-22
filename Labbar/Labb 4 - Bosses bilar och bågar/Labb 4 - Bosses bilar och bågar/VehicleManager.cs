using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Bosses_bilar_och_bågar
{
    class VehicleManager
    {
        public List<Car> cars { get; set; }
        public List<Motorbike> motorbikes { get; set; }
        public List<Fordon> fordon { get; set; }
        public List<Car> buyableCars { get; set; }
        public List<Motorbike> buyableMotorbikes { get; set; }

        public VehicleManager() // Konstruktor där vi instansierar objekt i listorna
        {
            cars = new List<Car>
            {
                new Car { Manufacturer = "Volvo", Model = "S60", Price = 362800, IsUsed = false },
                new Car { Manufacturer = "Subaru", Model = "Impreza", Price = 189900, IsUsed = false },
                new Car { Manufacturer = "Volkswagen", Model = "Beetle Cabriolet", Price = 229900, IsUsed =  false},
                new Car { Manufacturer = "Volvo", Model = "XC60", Price = 299900, IsUsed = false },
                new Car { Manufacturer = "Volvo", Model = "C30", Price = 84900, IsUsed = true },
                new Car { Manufacturer = "Subaru", Model = "XV", Price = 135000, IsUsed = true }
            };
            motorbikes = new List<Motorbike>
            {
                new Motorbike { Manufacturer = "Kawasaki", Model = "Z800", Price = 70000, IsUsed = true },
                new Motorbike { Manufacturer = "Yamaha", Model = "Tracer 700", Price = 79000, IsUsed = false },
                new Motorbike { Manufacturer = "Suzuki", Model = "RMZ 450", Price = 17000, IsUsed = true },
                new Motorbike { Manufacturer = "BMW", Model = "S 1000 RR", Price = 172200, IsUsed = false },
                new Motorbike { Manufacturer = "BMW", Model = "R 1200", Price = 147250, IsUsed = false },
                new Motorbike { Manufacturer = "Suzuki", Model = "Gladius 650", Price = 53900, IsUsed = false }
            };

            // Nya listor för att kunna köpa av
            buyableCars = new List<Car>
            {
                new Car { Manufacturer = "Manufacturer 1", Model = "Model 1", Price = 777, IsUsed = true },
                new Car { Manufacturer = "Manufacturer 2", Model = "Model 2", Price= 666, IsUsed = false },
                new Car { Manufacturer = "Manufacturer 1", Model = "Model 1.1", Price= 777, IsUsed = true },
                new Car { Manufacturer = "Manufacturer 2", Model = "Model 2.1", Price= 666, IsUsed = false }
            };

            buyableMotorbikes = new List<Motorbike>
            {
                new Motorbike { Manufacturer = "Manufacturer 1", Model = "Model 1", Price = 777, IsUsed = true },
                new Motorbike { Manufacturer = "Manufacturer 2", Model = "Model 2", Price = 666, IsUsed = false },
                new Motorbike { Manufacturer = "Manufacturer 1", Model = "Model 1.1", Price = 777, IsUsed = true },
                new Motorbike { Manufacturer = "Manufacturer 2", Model = "Model 2.1", Price = 666, IsUsed = false }
            };
        }

        #region Vehicle Displaying methods
        internal void DisplayOptions()
        {
            Console.Clear();
            Menu.DisplayVehicles();

            bool isChoice = true;
            var input = Console.ReadKey(true).Key;

            while (isChoice)
            {
                switch (input)  //Keeps fucking looping the end!
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        ShowCars(); ;
                        isChoice = false;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        ShowMotorbikes();
                        isChoice = false;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        FilterChoice();
                        isChoice = false;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        isChoice = false;
                        break;
                }
            }
        }

        #region Filter menu
        internal void FilterChoice()
        {
            Console.Clear();
            Menu.FilterVehicles();

            bool isChoice = true;
            var input = Console.ReadKey(true).Key;

            while (isChoice)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        FilterCars();
                        isChoice = false;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        FilterMotorbikes();
                        isChoice = false;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        isChoice = false;
                        break;
                }
            }
        }
        #endregion // Filtrerings meny

        //internal void ShowVehicles()    //Fungerar ej
        //{
        //    for (int i = 1; i <= fordon.Count; i++)
        //    {
        //        Console.WriteLine("{0}. {1}", i, fordon[i - 1].VehicleInfo());
        //    }

        //    Console.WriteLine("Press any key to continue...");
        //    Console.ReadKey();
        //}

        internal void ShowCars()
        {
            for (int i = 1; i <= cars.Count; i++)   // Skriver ut information av alla fordon i listan
            {
                Console.WriteLine("{0}. {1}", i, cars[i - 1].VehicleInfo());
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        internal void ShowMotorbikes()
        {
            for (int i = 1; i <= motorbikes.Count; i++) // Skriver ut information av alla fordon i listan
            {
                Console.WriteLine("{0}. {1}", i, motorbikes[i - 1].VehicleInfo());
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        internal void FilterCars() //Val att bara visa specifika biltillverkare
        {
            Console.WriteLine("Enter manufacturer: ");
            string input = Console.ReadLine();

            Car[] subset = cars
                .Where(cars => cars.Manufacturer.Contains(input))
                .ToArray();

            foreach (var car in subset)
            {
                Console.WriteLine("{0}", car.VehicleInfo()); //Fungerar ej!
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        internal void FilterMotorbikes() //Val att bara visa specifika biltillverkare
        {
            Console.WriteLine("Enter manufacturer: ");
            string input = Console.ReadLine();

            Motorbike[] subset = motorbikes
                .Where(motorbikes => motorbikes.Manufacturer.Contains(input))
                .ToArray();

            foreach (var motorbike in subset)
            {
                Console.WriteLine("{0}", motorbike.VehicleInfo()); //Fungerar ej!
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        #endregion

        #region Adding mechanic
        internal void AddVehicle()
        {
            Console.WriteLine("\n1. Add new car");
            Console.WriteLine("\n2. Add new motorbike");

            bool isChoice = true;
            var input = Console.ReadKey(true).Key;

            while (isChoice)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        AddCar();
                        isChoice = false;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        AddMotorbike();
                        isChoice = false;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        isChoice = false;
                        break;
                }
            }
        }

        internal void AddCar()
        {
            Car newCar = new Car();

            Console.WriteLine("Enter model: ");
            newCar.Model = Console.ReadLine();

            Console.WriteLine("Enter manufacturer: ");
            newCar.Manufacturer = Console.ReadLine();

            Console.WriteLine("Enter price: ");
            newCar.Price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter if new car is used: (Y/N)");
            string NewOrUsed = Console.ReadLine().ToUpper();
            newCar.IsUsed = NewOrUsed == "Y" || NewOrUsed == "Y" ? newCar.IsUsed = true : newCar.IsUsed = false;

            cars.Add(newCar);
        }

        internal void AddMotorbike()
        {
            Motorbike newMotorbike = new Motorbike();

            Console.WriteLine("Enter model: ");
            newMotorbike.Model = Console.ReadLine();

            Console.WriteLine("Enter manufacturer: ");
            newMotorbike.Manufacturer = Console.ReadLine();

            Console.WriteLine("Enter price: ");
            newMotorbike.Price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter if new motorbike is used: (Y/N)");
            string NewOrUsed = Console.ReadLine().ToUpper();
            newMotorbike.IsUsed = NewOrUsed == "Y" || NewOrUsed == "Y" ? newMotorbike.IsUsed = true : newMotorbike.IsUsed = false;

            motorbikes.Add(newMotorbike);
        }
        #endregion

        #region Removing mechanic
        internal void RemoveVehicle()
        {
            Console.Clear();
            Console.WriteLine("1. Remove car");
            Console.WriteLine("2. Remove motorbike");

            bool isChoice = true;
            var input = Console.ReadKey(true).Key;

            while (isChoice)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        RemoveCar();
                        isChoice = false;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        RemoveMotorbike();
                        isChoice = false;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        isChoice = false;
                        break;
                }
            }
        }

        internal void RemoveCar()
        {
            for (int i = 1; i <= cars.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, cars[i - 1].VehicleInfo());
            }

            Console.WriteLine("Choose option: ");
            int index = int.Parse(Console.ReadLine());

            cars.RemoveAt(index - 1);
        }

        internal void RemoveMotorbike()
        {
            for (int i = 1; i <= motorbikes.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, motorbikes[i - 1].VehicleInfo());
            }

            Console.WriteLine("Choose option: ");
            int index = int.Parse(Console.ReadLine());

            motorbikes.RemoveAt(index - 1);
        }
        #endregion

        #region Browsing mechanic

        internal void BrowsingOptions()
        {
            bool isChoice = true;

            while(isChoice)
            {
                Console.Clear();
                Menu.BrowseVehicles();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        BrowseCars();
                        isChoice = false;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        BrowseMotorbikes();
                        isChoice = false;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        BrowseUsedCars();
                        isChoice = false;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        BrowseUsedMotorbikes();
                        isChoice = false;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        isChoice = false;
                        break;
                }
            }
        }

        internal void BrowseCars()
        {
            Console.WriteLine("Buyable cars:");

            for (int i = 1; i < buyableCars.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, buyableCars[i - 1].VehicleInfo());
            }

            Console.WriteLine("Choice: ");
            int index = int.Parse(Console.ReadLine());

            cars.Add(buyableCars[index - 1]);
            buyableCars.Remove(buyableCars[index - 1]);

        }

        internal void BrowseUsedCars() // Letar efter cars i buyableCars-listan vars isUsed bool är true.
        {
            Console.WriteLine("Buyable cars:");
            Car[] subset = buyableCars.
                Where(buyableCars => buyableCars.IsUsed == true)
                .ToArray();

            for (int i = 1; i < subset.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i, buyableCars[i - 1].VehicleInfo());
            }

            Console.WriteLine("Choice: ");
            int index = int.Parse(Console.ReadLine());

            cars.Add(buyableCars[index - 1]);
            buyableCars.Remove(buyableCars[index - 1]);

        }

        internal void BrowseMotorbikes()
        {
            Console.WriteLine("Buyable motorbikes:");

            for (int i = 1; i < buyableMotorbikes.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, buyableMotorbikes[i - 1].VehicleInfo());
            }

            Console.WriteLine("Choice: ");
            int index = int.Parse(Console.ReadLine());

            motorbikes.Add(buyableMotorbikes[index - 1]);
            buyableMotorbikes.Remove(buyableMotorbikes[index - 1]);

        }

        public void BrowseUsedMotorbikes() // Letar efter motorbikes i buyableMotorbikes-listan vars isUsed bool är true.
        {
            Console.WriteLine("Buyable cars:");
            Motorbike[] subset = buyableMotorbikes.
                Where(buyableMotorbikes => buyableMotorbikes.IsUsed == true)
                .ToArray();

            for (int i = 1; i < subset.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i, buyableMotorbikes[i - 1].VehicleInfo());
            }

            Console.WriteLine("Choice: ");
            int index = int.Parse(Console.ReadLine());

            motorbikes.Add(buyableMotorbikes[index - 1]);
            buyableMotorbikes.Remove(buyableMotorbikes[index - 1]);

        }
        #endregion

        #region Selling mechanic
        public void SellingOptions()
        {
            bool isChoice = true;

            while(isChoice)
            {
                Menu.SellVehicles();
                var input = Console.ReadKey(true).Key;
                
                switch(input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        SellCars();
                        isChoice = false;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        SellMotorbikes();
                        isChoice = false;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        SellUsedCars();
                        isChoice = false;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        SellUsedMotorbikes();
                        isChoice = false;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        isChoice = false;
                        break;

                }
            }
        }

        internal void SellCars()
        {
            Console.WriteLine("Sellable cars in store:");
            for (int i = 1; i < cars.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, cars[i - 1].VehicleInfo());
            }

            Console.WriteLine("Car to sell: ");
            int index = int.Parse(Console.ReadLine());

            buyableCars.Add(cars[index - 1]);
            cars.Remove(cars[index - 1]);
        }

        internal void SellMotorbikes()
        {
            Console.WriteLine("Sellable motorbikes in store:");
            for (int i = 1; i < motorbikes.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, motorbikes[i - 1].VehicleInfo());
            }

            Console.WriteLine("Motorbike to sell: ");
            int index = int.Parse(Console.ReadLine());

            buyableMotorbikes.Add(motorbikes[index - 1]);
            motorbikes.Remove(motorbikes[index - 1]);
        }

        internal void SellUsedCars()
        {
            Car[] subset = cars    // Filtrerar och hämtar ut cars vars bool IsUsed är true
                .Where(cars => cars.IsUsed == true)
                .ToArray();

            Console.WriteLine("Sellable used cars in store:");
            for (int i = 1; i < subset.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i, cars[i - 1].VehicleInfo());
            }

            Console.WriteLine("Used motorbike to sell: ");
            int index = int.Parse(Console.ReadLine());

            buyableCars.Add(cars[index - 1]);
            cars.Remove(cars[index - 1]);
        }

        internal void SellUsedMotorbikes()
        {
            Motorbike[] subset = motorbikes    // Filtrerar och hämtar ut motorbikes vars bool IsUsed är true
                .Where(motorbikes => motorbikes.IsUsed == true)
                .ToArray();

            Console.WriteLine("Sellable used motorbikes in store:");
            for (int i = 1; i < subset.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i, motorbikes[i - 1].VehicleInfo());
            }

            Console.WriteLine("Used motorbike to sell: ");
            int index = int.Parse(Console.ReadLine());

            buyableMotorbikes.Add(motorbikes[index - 1]);
            motorbikes.Remove(motorbikes[index - 1]);
        }
        #endregion
    }
}

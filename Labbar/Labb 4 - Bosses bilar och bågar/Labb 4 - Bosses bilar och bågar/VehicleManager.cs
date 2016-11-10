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

        public VehicleManager()
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
            fordon = new List<Fordon>();
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
                        ShowVehicles();
                        isChoice = false;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        ShowCars();
                        isChoice = false;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        ShowMotorbikes();
                        isChoice = false;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        FilterMotorbikes();
                        isChoice = false;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        isChoice = false;
                        break;
                }
            }
        }
        internal void ShowVehicles()    //Fungerar ej
        {
            for (int i = 1; i <= fordon.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, fordon[i - 1].VehicleInfo());
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        internal void ShowCars()
        {
            for (int i = 1; i <= cars.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, cars[i - 1].VehicleInfo());
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        internal void ShowMotorbikes()
        {
            for (int i = 1; i <= motorbikes.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, motorbikes[i - 1].VehicleInfo());
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        internal void FilterMotorbikes() //Val att bara visa specifika biltillverkare
        {
            Fordon[] subset = motorbikes
                .Where(motorbikes => motorbikes.IsUsed= false)
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

            while(isChoice)
            {
                switch(input)
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Bosses_bilar_och_bågar
{
    class Runtime
    {
        VehicleManager vehicleManager = new VehicleManager();
        public bool isProgramRunning = true;

        public void Start() // Loop som tar oss in i en start method
        {
            do
            {
                StartMenu();

            } while (isProgramRunning);
        }

        public void StartMenu()
        {
            Console.Clear();
            Menu.DisplayMainMenu();
            var input = Console.ReadKey(true).Key;

            switch(input)   // Switch-sats gjord för att reagera på användarens input
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    vehicleManager.DisplayOptions();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    vehicleManager.AddVehicle();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    vehicleManager.RemoveVehicle();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    vehicleManager.BrowsingOptions();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    vehicleManager.SellingOptions();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    isProgramRunning = false;
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Klasser_och_Objekt
{
    class Runtime
    {
        public void Start()
        {
            #region Del 1
            Dog dog1 = new Dog
            {
                Name = "Big Barry",
                Age = 5,
                Breed = "Big Dog"
            };

            Dog dog2 = new Dog
            {
                Name = "Lil' Lulu",
                Age = 9,
                Breed = "Little dog"
            };

            Console.WriteLine("Name: {0}, Age: {1}, Breed: {2}", dog1.Name, dog1.Age, dog1.Breed);
            Console.WriteLine("Name: {0}, Age: {1}, Breed: {2}", dog2.Name, dog2.Age, dog2.Breed);
            #endregion
            DogManager dogManager = new DogManager();

            bool shouldRun = true;

            while (shouldRun)
            {
                UserInterface.DisplayMainMenu();

                Console.Write("Choose option: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        dogManager.AddDog();
                        break;
                    case 2:
                        dogManager.RemoveDog();
                        break;
                    case 3:
                        dogManager.DisplayList();
                        break;
                    case 4:
                        shouldRun = false;
                        break;
                }
            }
        }
    }
}

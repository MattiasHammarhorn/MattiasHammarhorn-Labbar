using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Klasser_och_Objekt
{
    class DogManager
    {
        public List<Dog> dogsList { get; set; }

        public DogManager()
        {
            dogsList = new List<Dog>()
            {
                new Dog { Name = "Big Barry", Age = 5, Breed = "Big dog"},
                new Dog { Name = "Lil' Lulu", Age = 9, Breed = "Little dog"}
            };
        }

        public void AddDog()
        {
            Dog newDog = new Dog();

            Console.Write("Enter name: ");
            newDog.Name = Console.ReadLine();

            Console.Write("Enter age: ");
            newDog.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter breed: ");
            newDog.Breed = Console.ReadLine();

            dogsList.Add(newDog);
        }

        public void RemoveDog()
        {
            for (int i = 1; i < dogsList.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, dogsList[i - 1].Name);
            }

            Console.WriteLine("Choose a dog: ");
            int index = int.Parse(Console.ReadLine());

            dogsList.RemoveAt(index - 1);
        }

        public void DisplayList()
        {
            foreach (var dog in dogsList)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Breed: {2}", dog.Name, dog.Age, dog.Breed);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}

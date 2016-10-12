using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Klasser_och_Objekt
{
    class Runtime
    {
        //Console.WriteLine("Name: ");
        string name;

        //Console.WriteLine("Age: ");
        int age;

        //Console.WriteLine("Breed: ");
        string breed;

        public void Start()
        {
            
            Dog newDog = new Dog
            {
                Name = name,
                Age = age,
                Breed = breed
            };

            List<Dog> dogList = new List<Dog>()
            {
                new Dog { Name = "Big Joe", Age = 55, Breed = "Big Dog" },
                new Dog { Name = "Lil' Mike", Age = 7, Breed = "Little Dog" },
                new Dog { Name = "Katyusha", Age = 12, Breed = "Chernobyl Dog" }
            };

            dogList.Add(new Dog { Name = "Fritz", Age = 12, Breed = "German" });

            foreach (var dog in dogList)
            {
                Console.WriteLine(dog.DogInformation());
            }
            Console.ReadKey();
        }
    }
}

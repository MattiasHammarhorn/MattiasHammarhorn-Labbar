using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Klasser_och_Objekt
{
    class Dog
    {
        //Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        //Tom konstruktor
        public Dog()
        {
        }
        //Konstruktor för Dog
        public Dog(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        public string DogInformation()
        {
            return String.Format("Name: {0} Age: {1} Breed: {2}", Name, Age, Breed);
        }
    }
}

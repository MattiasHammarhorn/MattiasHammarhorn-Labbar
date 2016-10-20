using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv_och_Polymorfism
{
    class DogManager
    {
        public List<Dog> dogList { get; set; }

        public DogManager()
        {
            dogList = new List<Dog>()
            {
                new Dog { Name = "Terrarier", Age = 16, Move = "moving on all four legs", Sound = "barking and whining", Weight = 14, NumberOfLegs = 4, DoesHunt = "does not hunt"},
                new Dog { Name = "Golden Receiver", Age = 21, Move = "moving on all four legs", Sound = "barking and whining", Weight = 16, NumberOfLegs = 4, DoesHunt = "does not hunt"},
                new Dog { Name = "Bullpit", Age = 15, Move = "moving on all four legs", Sound = "barking and whining", Weight = 8, NumberOfLegs = 4, DoesHunt = "doesnot hunt"}
            };
        }

        public void AddDog()
        {
            Dog newDog = new Dog();

            Console.WriteLine("Enter name: ");
            newDog.Name = Console.ReadLine();

            Console.WriteLine("Enter age: ");

            newDog.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter way of movement: ");
            newDog.Move = Console.ReadLine();

            Console.WriteLine("Enter sound: ");
            newDog.Sound = Console.ReadLine();

            Console.WriteLine("Enter weight: ");
            newDog.Weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of legs: ");
            newDog.NumberOfLegs = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 'does hunt' or 'does not hunt' :");
            newDog.DoesHunt = Console.ReadLine();

            dogList.Add(newDog);
        }

        public void RemoveDog()
        {
            for (int i = 1; i <= dogList.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, dogList[i -1].Name);
            }

            Console.Write("Choose option: ");
            int index = int.Parse(Console.ReadLine());

            dogList.RemoveAt(index - 1);
        }

        public void DisplayDogs()
        {
            foreach (var dog in dogList)
            {
                Console.WriteLine("{0}: \n\n{1}\n", dog.Name, dog.Introduction());
            }
        }
    }
}

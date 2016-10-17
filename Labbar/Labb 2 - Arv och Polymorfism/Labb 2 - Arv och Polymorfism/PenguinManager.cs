using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv_och_Polymorfism
{
    class PenguinManager
    {
        public List<Penguin> penguinList { get; set; }

        public PenguinManager()
        {
            penguinList = new List<Penguin>()
            {
                new Penguin { Name = "Empress penguin", Age = 20, Move = "shuffling its feet from side to side", Sound = "croaking", Weight = 82, CanFly = "cannot fly", DoesNest = "does not nest but incubates"},
                new Penguin { Name = "Monarchial penguin", Age = 20, Move = "shuffling its feet from side to side", Sound = "croaking", Weight = 8, CanFly = "cannot fly", DoesNest = "nests"},
                new Penguin { Name = "Stonejumper penguin", Age = 25, Move = "shuffling its feet from side to side", Sound = "croaking", Weight = 3, CanFly = "cannot fly", DoesNest = "nests"}
            };
        }
        public void AddPenguin()
        {
            Penguin newPenguin = new Penguin();

            Console.WriteLine("Enter name: ");
            newPenguin.Name = Console.ReadLine();

            Console.WriteLine("Enter age: ");
            newPenguin.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter way of movement: ");
            newPenguin.Move = Console.ReadLine();

            Console.WriteLine("Enter sound: ");
            newPenguin.Sound = Console.ReadLine();

            Console.WriteLine("Enter weight: ");
            newPenguin.Weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of legs: ");
            newPenguin.CanFly = Console.ReadLine();

            Console.WriteLine("Enter 'does hunt' or 'does not hunt' :");
            newPenguin.DoesNest = Console.ReadLine();

            penguinList.Add(newPenguin);
        }

        public void RemovePenguin()
        {
            for (int i = 1; i <= penguinList.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, penguinList[i - 1].Name);
            }

            Console.Write("Choose option: ");
            int index = int.Parse(Console.ReadLine());

            penguinList.RemoveAt(index - 1);
        }

        public void DisplayPenguins()
        {
            foreach (var penguin in penguinList)
            {
                Console.WriteLine("{0}. {1}", penguin.Name, penguin.Introduction());
            }
        }
    }
}

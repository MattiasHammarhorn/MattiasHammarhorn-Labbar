using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv_och_Polymorfism
{
    class SnakeManager
    {
        public List<Snake> snakeList { get; set; }

        public SnakeManager()
        {
            snakeList = new List<Snake>
            {
                new Snake { Name = "Anacondona", Age = 24, Move = "slithering across the ground", Sound = "hissing",
                    Weight = 13, WarmBlooded = "not warm blooded", Length = 13 },
                new Snake { Name = "Cocobra", Age = 15, Move = "slithering across the ground", Sound = "hissing",
                    Weight = 5, WarmBlooded = "not warm blooded", Length = 5 },
                new Snake { Name = "Hancock Boa", Age = 24, Move = "slithering across the ground", Sound = "hissing",
                    Weight = 9, WarmBlooded = "not warm blooded", Length = 4 }
            };
        }

        public void AddSnake()
        {
            Snake newSnake = new Snake();

            Console.WriteLine("Enter Name: ");
            newSnake.Name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            newSnake.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter way of movement: ");
            newSnake.Move = Console.ReadLine();

            Console.WriteLine("Enter methods of making sound: ");
            newSnake.Sound = Console.ReadLine();

            Console.WriteLine("Enter weight: ");
            newSnake.Weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 'coldblooded' or 'warmblooded'");
            newSnake.WarmBlooded = Console.ReadLine();

            Console.WriteLine("Enter length: ");
            newSnake.Length = int.Parse(Console.ReadLine());

            snakeList.Add(newSnake);
        }

        public void RemoveSnake()
        {
            for (int i = 1; i <= snakeList.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, snakeList[i - 1].Name);
            }

            Console.WriteLine("Choose option: ");
            int index = int.Parse(Console.ReadLine());

            snakeList.RemoveAt(index - 1);
        }

        public void DisplaySnakes()
        {
            foreach (var snake in snakeList)
            {
                Console.WriteLine("{0}: \n\n{1}\n", snake.Name, snake.Introduction());
            }
        }
    }
}

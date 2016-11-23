using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_11___Events
{
    //public delegate void AnalyzeNumber(int number);
    //public delegate void InvalidInputMessage();
    public delegate void AnalyzeNumber(int number);

    public class Runtime
    {
        private event AnalyzeNumber NumberInput;

        public Runtime()
        {
            NumberInput += new AnalyzeNumber(IsEven);
            NumberInput += new AnalyzeNumber(IsDivisibleByThree);
            NumberInput += new AnalyzeNumber(IsPrimeNumber);
        }
        public void Start()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            NumberInput.Invoke(number);
        }

        #region Methods
        public void IsEven(int number)
        {
            if (number % 2 == 0)
                Console.WriteLine("The number is even");
            else
                Console.WriteLine("The number is not even");
        }

        public void IsDivisibleByThree(int number)
        {
            if ((number % 3) == 0)
                Console.WriteLine("The number is divisable by three");
            else
                Console.WriteLine("The number is not divisable by three");
        }

        public void IsPrimeNumber(int number)
        {
            for (int i = 2; i <= number; i++)       // Eftersom jag inte studerat matte på länge
            {                                       // så kopierade jag koden för att räkna ut primtal
                for (int j = 2; 2 <= number; j++)   // och för att huvuddelen med uppgiften är att höja events
                {
                    if (i == j)
                        Console.WriteLine("Number is prime number");
                    else if (i % j == 0)
                        Console.WriteLine("Number is not a prime number");
                    break;
                }
            }
        }
        #endregion

        #region Old stuff
        //private event AnalyzeNumber NumberInput;
        //private event InvalidInputMessage InvalidInput;

        //public Runtime()
        //{
        //    NumberInput += new AnalyzeNumber(IsEven); // Skickar in delegatern och metoder
        //    NumberInput += new AnalyzeNumber(IsDivisableByThree);
        //    NumberInput += new AnalyzeNumber(IsPrimeNumber);

        //    InvalidInput += () => Console.WriteLine("Invalid input"); // Tomma parametrar, tar inte in något precis som delegaten
        //}

        //public void Start()
        //{


        //    Console.WriteLine("Write a number: ");
        //    int number;
        //    bool validInput = int.TryParse(Console.ReadLine(), out number);

        //    if (validInput)
        //        NumberInput.Invoke(number);
        //    else
        //    {
        //        InvalidInput.Invoke();
        //    }
        //}

        //private void IsEven(int number) // Ska va void för att delegaten också är det
        //{
        //    if (number % 2 == 0)
        //        Console.WriteLine("Number is even");
        //    else
        //        Console.WriteLine("Number is not even");
        //}

        //private void IsDivisableByThree(int number)
        //{
        //    if (number % 3 == 0)
        //        Console.WriteLine("Number is divisably by three");
        //    else
        //        Console.WriteLine("Number is not divisable by three");
        //}

        //private void IsPrimeNumber(int number)
        //{
        //    for (int j = 2; j <= number; j++)       // Eftersom jag inte studerat matte på länge
        //    {                                       // så kopierade jag koden för att räkna ut primtal
        //        for (int k = 2; 2 <= number; k++)   // och för att huvuddelen med uppgiften är att höja events
        //        {
        //            if (j == k)
        //                Console.WriteLine("Number is prime number");
        //            else if (j % k == 0)
        //                Console.WriteLine("Number is not a prime number");
        //            break;
        //        }
        //    }
        //}
        #endregion
    }
}

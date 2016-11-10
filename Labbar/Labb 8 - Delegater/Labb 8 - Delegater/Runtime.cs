using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_8___Delegater
{
    class Runtime
    {
        // Definierar properties
        public string[] MyArray { get; set; }
        public float[] Collection { get; set; }

        // Konstruktor för arrayerna
        public Runtime()
        {
            MyArray = new string[]
            {
                "String 1",
                "String 2",
                "String 3",
                "String 4",
                "String 5"
            };

            Collection = new float[]
            {
                5,
                5,
                2,
                5,
                4
            };
        }

        // Deklarer delegaterna som tar in en string och float array
        // och returnerar en string och en void
        public delegate string StringConcatinator(string[] MyArray);
        public delegate void NumberOperator(float[] Collection);

        // Definierar en metod som matchar delegaten
        public string ConcatinatorMethod(string[] MyArray)
        {
            string output = ""; //Definierar stringen output

            foreach (string word in MyArray) // För varje string i arrayen så adderas den med komma-tecken
            {
                output += word + ',';
            }

            return output;  // Returnerar output
        }

        // Definierar en metod som matchar delegaten men som också returnerar en float
        public void OperatorMethod(Func<float[], float> calcFunc)
        {
            float result = calcFunc(Collection); // Tar in 

            Console.WriteLine(result);
        }

        public void Start()
        {
            // Instansierar string delegaten som tar in delegat metoden.
            StringConcatinator stringConcatinator = new StringConcatinator(ConcatinatorMethod);
            Console.WriteLine(stringConcatinator(MyArray)); // Skriver ut output

            // Definierar funcs som tar in en float array och returnerar en float
            Func<float[], float> myFunc = (Collection) =>
            {
                float Total = 0;

                for (int i = 0; i < Collection.Length; i++) // För varje position i Collection
                {                                           // så adderas det in i floaten Total
                    Total += Collection[i];
                }

                return Total; // Returnerar Total (summan) av de adderade positionerna
            };

            OperatorMethod(myFunc); // Kallar på metoden med hjälp av funcen

            // Definierar funcs som tar in en float array och returnerar en float
            Func<float[], float> myFunc2 = (Collection) =>
            {
                float Total = 1;

                for (int i = 0; i < Collection.Length; i++) // Förvarje position i Collection
                {                                           // så multipliceras det in i Total
                    Total *= Collection[i];
                }

                return Total; // Returnerar Total (summan) av de multiplicerade positonerna
            };

            OperatorMethod(myFunc2); // Kallar på metoden med hjälp av funcen
        }
    }
}

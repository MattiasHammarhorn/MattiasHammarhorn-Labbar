using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_8___Delegater
{
    class ProductManager
    {
        public List<Product> Products { get; set; }

        public ProductManager()
        {
            Products = new List<Product>
            {
                new Product { Name = "Product 1", Id = 1, Price = 999 },
                new Product { Name = "Product 2", Id = 2, Price = 1000 },
                new Product { Name = "Product 3", Id = 3, Price = 999 },
                new Product { Name = "Product 4", Id = 4, Price = 1000 },
                new Product { Name = "Product 5", Id = 5, Price = 999 },
            };
        }

        public string FormatProductNames(string[] productNames)
        {
            Console.Clear();
            Console.WriteLine("Products: ");
            string tempString = null;
            int index = 0;

            foreach (string singleString in productNames)
            {
                index++;
                if (index < productNames.Length)
                    tempString += singleString + ", ";
                else
                    tempString += singleString;
            }
            return tempString;
        }

        public double PriceCalculation(double[] productPrices)
        {
            double tempPrice1 = 0;
            double tempPrice2 = 0;

            foreach (double singlePrice in productPrices)
            {
                if (singlePrice < 1000)
                    tempPrice1 += singlePrice;
                else
                    tempPrice2 += singlePrice;
            }
            return tempPrice1 * 1.2 + tempPrice2 * 0.9;
        }
    }
}

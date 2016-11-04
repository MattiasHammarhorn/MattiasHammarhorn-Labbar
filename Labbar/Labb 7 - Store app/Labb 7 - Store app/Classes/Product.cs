using Labb_7___Store_app.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___Store_app.Classes
{
    class Product   :   ISellable
    {
        //Implementerar interface och ger dem properties
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string ProductInformation { get; set; }
    }
}

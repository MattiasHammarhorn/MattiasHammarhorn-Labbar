using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___Store_app.Interface
{
    interface ISellable
    {
        //Skapar interface och ger dem properties
        string ProductName { get; set; }
        int Price { get; set; }
        string ProductInformation { get; set; }
    }
}

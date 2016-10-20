using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb_2___Arv_och_Polymorfism
{
    public class Snake : Reptile
    {
        public double Length { get; set; }

        public override string Introduction()
        {
            return String.Format("{0} A {1} can grow up to {2} meters long.", base.Introduction(), Name, Length);
        }
    }
}
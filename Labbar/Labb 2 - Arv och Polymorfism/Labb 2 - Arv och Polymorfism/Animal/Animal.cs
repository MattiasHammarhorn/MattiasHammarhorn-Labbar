using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb_2___Arv_och_Polymorfism
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Move { get; set; }
        public string Sound { get; set; }
        public double Weight { get; set; }

        public virtual string Introduction()
        {
            return String.Format("The {0} can live up to {1} years and it moves by {2}. It produces sounds by {3} and can weigh up to {4} kg.", Name, Age, Move, Sound, Weight);
        }
    }
}
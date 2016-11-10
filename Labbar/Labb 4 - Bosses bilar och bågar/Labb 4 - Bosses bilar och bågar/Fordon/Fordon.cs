using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb_4___Bosses_bilar_och_bågar
{
    public abstract class Fordon
    {
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public bool IsUsed { get; set; }

        public virtual string VehicleInfo()
        {
            return String.Format("Model: {0}\tManufacturer: {1}\tPrice: {2}\tCondition: {3}",
                Model,
                Manufacturer,
                Price,
                IsUsed == true ? "Used" : "New");
        }
    }
}
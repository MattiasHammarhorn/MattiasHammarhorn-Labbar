using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb_4___Bosses_bilar_och_bågar
{
    public class Car : Fordon
    {
        public override string VehicleInfo() // Override string som returnerar den hårdkodade "informations-sträng"
        {
            return String.Format("{0}", base.VehicleInfo());
        }
    }
}
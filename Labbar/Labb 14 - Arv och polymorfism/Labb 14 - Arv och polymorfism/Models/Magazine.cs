using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_14___Arv_och_polymorfism.Models
{
    class Magazine : Publication
    {
        public int Volume { get; set; }

        public override string PrintInfo()
        {
            return String.Format("{0}\tVolume: {1}", base.PrintInfo(), Volume);
        }
    }
}

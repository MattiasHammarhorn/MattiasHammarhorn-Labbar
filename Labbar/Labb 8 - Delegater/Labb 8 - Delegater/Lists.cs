using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_8___Delegater
{
    class Lists
    {
        public string[] MyStrings { get; set; }
        public float[] MyFloats { get; set; }


        public Lists()
        {
            MyStrings = new string[]
            {
                "Hej",
                "Privet",
                "Nĭ hăo",
                "Kon'nichiwa",
                "Chaírete"
            };

            MyFloats = new float[]
            {
                1.0f,
                1.1f,
                1.2f,
                1.3f,
                1.4f
            };
        }
    }
}

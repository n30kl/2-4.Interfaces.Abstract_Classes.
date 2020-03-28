using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2сем_4лаб
{
    class Strun: IMuzInstr
    {
        public string zvuk()
        {
            return "(брынчит)";
        }
        public string name { get; set; }
        public int kilk { get; set; }
    }
}

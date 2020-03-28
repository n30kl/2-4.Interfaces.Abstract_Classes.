using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2сем_4лаб
{
    class Duh: IMuzInstr
    {
        public string zvuk()
        {
            return "(дудит)";
        }
        public string name { get; set; }
        public int kilk { get; set; }
    }
}

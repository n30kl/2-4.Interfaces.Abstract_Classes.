using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2сем_4лаб
{
    class Udarn: IMuzInstr
    {
        public string zvuk()
        {
            return "(стучит)";
        }
        public string name { get; set; }
        public int kilk { get; set; }
    }
}

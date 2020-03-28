using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2сем_4лаб
{
    interface IMuzInstr
    {
        string zvuk();
        string name{ get; set; }
        int kilk { get; set; }
    }
}

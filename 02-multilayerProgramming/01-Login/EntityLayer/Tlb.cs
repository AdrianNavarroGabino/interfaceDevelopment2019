using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Tlb
    {
        public long a { get; set; }
        public long b { get; set; }

        public Tlb(long a, long b)
        {
            this.a = a;
            this.b = b;
        }
    }
}

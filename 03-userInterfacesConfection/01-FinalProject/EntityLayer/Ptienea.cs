using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Ptienea
    {
        public string pack { get; set; }
        public string articulo { get; set; }

        public Ptienea(string pack, string articulo)
        {
            this.pack = pack;
            this.articulo = articulo;
        }
    }
}

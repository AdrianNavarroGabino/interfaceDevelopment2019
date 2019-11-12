using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Memoria
    {
        public string MemoriaID { get; set; }
        public string tipo { get; set; }

        public Memoria(string memoriaID, string tipo)
        {
            MemoriaID = memoriaID;
            this.tipo = tipo;
        }
    }
}

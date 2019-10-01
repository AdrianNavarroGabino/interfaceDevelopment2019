using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Provincia
    {
        public string provinciaID { get; set; }
        public string nombre { get; set; }

        public Provincia(string provinciaID, string nombre)
        {
            this.provinciaID = provinciaID;
            this.nombre = nombre;
        }
    }
}

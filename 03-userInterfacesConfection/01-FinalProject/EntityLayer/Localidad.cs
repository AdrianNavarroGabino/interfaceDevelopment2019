using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Localidad
    {
        public string localidadID { get; set; }
        public string nombre { get; set; }
        public string provinciaID { get; set; }

        public Localidad(string localidadID, string nombre, string provinciaID)
        {
            this.localidadID = localidadID;
            this.nombre = nombre;
            this.provinciaID = provinciaID;
        }
    }
}

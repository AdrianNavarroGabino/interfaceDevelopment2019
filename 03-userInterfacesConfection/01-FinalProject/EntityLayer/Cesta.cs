using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Cesta
    {
        public string articuloID { get; set; }
        public string usuarioID { get; set; }
        public string fecha { get; set; }

        public Cesta(string articuloID, string usuarioID, string fecha)
        {
            this.articuloID = articuloID;
            this.usuarioID = usuarioID;
            this.fecha = fecha;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class StockAux
    {
        public string articuloID { get; set; }
        public long disponible { get; set; }
        public string entrega { get; set; }
        public string nombre { get; set; }
        public string marcaID { get; set; }

        public StockAux(string articuloID, long disponible, string entrega, string nombre, string marcaID)
        {
            this.articuloID = articuloID;
            this.disponible = disponible;
            this.entrega = entrega;
            this.nombre = nombre;
            this.marcaID = marcaID;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Stock
    {
        public string articuloID { get; set; }
        public string disponible { get; set; }
        public string entrega { get; set; }

        public Stock(string articuloID, string disponible, string entrega)
        {
            this.articuloID = articuloID;
            this.disponible = disponible;
            this.entrega = entrega;
        }
    }
}

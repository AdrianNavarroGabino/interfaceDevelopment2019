using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Linped
    {
        public long PedidoID { get; set; }
        public long linea { get; set; }
        public string articuloID { get; set; }
        public double importe { get; set; }
        public long cantidad { get; set; }

        public Linped(long pedidoID, long linea, string articuloID,
            double importe, long cantidad)
        {
            PedidoID = pedidoID;
            this.linea = linea;
            this.articuloID = articuloID;
            this.importe = importe;
            this.cantidad = cantidad;
        }
    }
}

// Adrián Navarro Gabino

using System;

namespace EntityLayer
{
    public class LinpedAux
    {
        public string PedidoID { get; set; }
        public string linea { get; set; }
        public string articuloID { get; set; }
        public string importe { get; set; }
        public string cantidad { get; set; }
        public string nombre { get; set; }
        public string pvp { get; set; }
        public string marcaID { get; set; }
        public double total { get; set; }

        public LinpedAux(string pedidoID, string linea, string articuloID,
            string importe, string cantidad, string nombre, string pvp, string marcaID)
        {
            PedidoID = pedidoID;
            this.linea = linea;
            this.articuloID = articuloID;
            this.importe = importe;
            this.cantidad = cantidad;
            this.nombre = nombre;
            this.pvp = pvp;
            this.marcaID = marcaID;
            total = Convert.ToInt32(cantidad) * Convert.ToDouble(pvp);
        }

        public LinpedAux(Linped l, Articulo p)
        {
            PedidoID = l.PedidoID;
            this.linea = l.linea;
            this.articuloID = p.articuloID;
            this.importe = l.importe;
            this.cantidad = l.cantidad;
            this.nombre = p.nombre;
            this.pvp = p.pvp;
            this.marcaID = p.marcaID;
            total = Convert.ToInt32(l.cantidad) * Convert.ToDouble(p.pvp);
        }
    }
}

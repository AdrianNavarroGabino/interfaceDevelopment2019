// Adrián Navarro Gabino

namespace EntityLayer
{
    public class Linped
    {
        public string PedidoID { get; set; }
        public string linea { get; set; }
        public string articuloID { get; set; }
        public string importe { get; set; }
        public string cantidad { get; set; }

        public Linped(string pedidoID, string linea, string articuloID,
            string importe, string cantidad)
        {
            PedidoID = pedidoID;
            this.linea = linea;
            this.articuloID = articuloID;
            this.importe = importe;
            this.cantidad = cantidad;
        }
    }
}

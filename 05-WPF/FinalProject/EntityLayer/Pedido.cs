// Adrián Navarro Gabino

namespace EntityLayer
{
    public class Pedido
    {
        public string PedidoID { get; set; }
        public string usuarioID { get; set; }
        public string fecha { get; set; }

        public Pedido(string pedidoID, string usuarioID, string fecha)
        {
            PedidoID = pedidoID;
            this.usuarioID = usuarioID;
            this.fecha = fecha;
        }
    }
}

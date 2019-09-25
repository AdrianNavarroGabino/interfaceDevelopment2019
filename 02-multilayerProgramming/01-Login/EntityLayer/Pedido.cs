using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Pedido
    {
        public long PedidoID { get; set; }
        public long usuarioID { get; set; }
        public string fecha { get; set; }

        public Pedido(long pedidoID, long usuarioID, string fecha)
        {
            PedidoID = pedidoID;
            this.usuarioID = usuarioID;
            this.fecha = fecha;
        }
    }
}

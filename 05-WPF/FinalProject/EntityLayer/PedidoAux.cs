using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class PedidoAux
    {
        public string PedidoIDAux { get; set; }
        public string usuarioIDAux { get; set; }
        public string fechaAux { get; set; }
        public string nombreAux { get; set; }
        public string apellidosAux { get; set; }
        public string dniAux { get; set; }

        public PedidoAux(Pedido pedido, Usuario usuario)
        {
            PedidoIDAux = pedido.PedidoID;
            usuarioIDAux = pedido.usuarioID;
            fechaAux = pedido.fecha;
            nombreAux = usuario.nombre;
            apellidosAux = usuario.apellidos;
            dniAux = usuario.dni;
        }
    }
}

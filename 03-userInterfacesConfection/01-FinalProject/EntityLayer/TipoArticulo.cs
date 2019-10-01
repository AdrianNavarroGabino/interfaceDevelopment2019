using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class TipoArticulo
    {
        public long tipoArticuloID { get; set; }
        public string Descripcion { get; set; }

        public TipoArticulo(long tipoArticuloID, string descripcion)
        {
            this.tipoArticuloID = tipoArticuloID;
            Descripcion = descripcion;
        }
    }
}

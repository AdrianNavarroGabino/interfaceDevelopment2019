using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class TipoArticulo
    {
        public string tipoArticuloID { get; set; }
        public string Descripcion { get; set; }

        public TipoArticulo(string tipoArticuloID, string descripcion)
        {
            this.tipoArticuloID = tipoArticuloID;
            Descripcion = descripcion;
        }
    }
}

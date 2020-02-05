using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ArticuloAux
    {
        public string articuloIDAux { get; set; }
        public string nombreAux { get; set; }
        public string pvpAux { get; set; }
        public string marcaIDAux { get; set; }
        public string imagenAux { get; set; }
        public string urlimagenAux { get; set; }
        public string especificacionesAux { get; set; }
        public string tipoArticuloIDAux { get; set; }
        public TipoArticulo tipoArticulo { get; set; }
        public string tipoNombre { get; set; }

        public ArticuloAux(Articulo articulo, List<TipoArticulo> tipos)
        {
            articuloIDAux = articulo.articuloID;
            nombreAux = articulo.nombre;
            pvpAux = articulo.pvp;
            marcaIDAux = articulo.marcaID;
            imagenAux = articulo.imagen;
            urlimagenAux = articulo.urlimagen;
            especificacionesAux = articulo.especificaciones;
            tipoArticuloIDAux = articulo.tipoArticuloID;

            foreach(TipoArticulo t in tipos)
            {
                if(t.tipoArticuloID == tipoArticuloIDAux)
                {
                    tipoArticulo = t;
                    tipoNombre = t.Descripcion;
                    break;
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Articulo
    {
        public string articuloID { get; set; }
        public string nombre { get; set; }
        public double pvp { get; set; }
        public string marcaID { get; set; }
        public string imagen { get; set; }
        public string urlimagen { get; set; }
        public string especificaciones { get; set; }
        public long tipoArticulo { get; set; }

        public Articulo(string articuloID, string nombre, double pvp,
            string marcaID, string imagen, string urlimagen,
            string especificaciones, long tipoArticulo)
        {
            this.articuloID = articuloID;
            this.nombre = nombre;
            this.pvp = pvp;
            this.marcaID = marcaID;
            this.imagen = imagen;
            this.urlimagen = urlimagen;
            this.especificaciones = especificaciones;
            this.tipoArticulo = tipoArticulo;
        }
    }
}

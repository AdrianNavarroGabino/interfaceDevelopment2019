// Adrián Navarro Gabino

namespace EntityLayer
{
    public class Articulo
    {
        public string articuloID { get; set; }
        public string nombre { get; set; }
        public string pvp { get; set; }
        public string marcaID { get; set; }
        public string imagen { get; set; }
        public string urlimagen { get; set; }
        public string especificaciones { get; set; }
        public string tipoArticuloID { get; set; }
        public string cantidad { get; set; }

        public Articulo(string articuloID, string nombre, string pvp,
            string marcaID, string imagen, string urlimagen,
            string especificaciones, string tipoArticuloID)
        {
            this.articuloID = articuloID;
            this.nombre = nombre;
            this.pvp = pvp;
            this.marcaID = marcaID;
            this.imagen = imagen;
            this.urlimagen = urlimagen;
            this.especificaciones = especificaciones;
            this.tipoArticuloID = tipoArticuloID;
        }
    }
}

// Adrián Navarro Gabino

namespace EntityLayer
{
    public class Cesta
    {
        public string articuloID { get; set; }
        public string usuarioID { get; set; }
        public string fecha { get; set; }

        public Cesta(string articuloID, string usuarioID, string fecha)
        {
            this.articuloID = articuloID;
            this.usuarioID = usuarioID;
            this.fecha = fecha;
        }
    }
}

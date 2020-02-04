// Adrián Navarro Gabino

namespace EntityLayer
{
    public class Localidad
    {
        public string localidadID { get; set; }
        public string nombre { get; set; }
        public string provinciaID { get; set; }

        public Localidad(string localidadID, string nombre, string provinciaID)
        {
            this.localidadID = localidadID;
            this.nombre = nombre;
            this.provinciaID = provinciaID;
        }
    }
}

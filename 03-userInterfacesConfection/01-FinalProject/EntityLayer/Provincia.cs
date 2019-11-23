// Adrián Navarro Gabino

namespace EntityLayer
{
    public class Provincia
    {
        public string provinciaID { get; set; }
        public string nombre { get; set; }

        public Provincia(string provinciaID, string nombre)
        {
            this.provinciaID = provinciaID;
            this.nombre = nombre;
        }
    }
}

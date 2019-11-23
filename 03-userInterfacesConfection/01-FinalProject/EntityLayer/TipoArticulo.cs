// Adrián Navarro Gabino

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

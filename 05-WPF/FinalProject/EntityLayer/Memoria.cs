// Adrián Navarro Gabino

namespace EntityLayer
{
    public class Memoria
    {
        public string MemoriaID { get; set; }
        public string tipo { get; set; }

        public Memoria(string memoriaID, string tipo)
        {
            MemoriaID = memoriaID;
            this.tipo = tipo;
        }
    }
}

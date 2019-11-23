// Adrián Navarro Gabino

namespace EntityLayer
{
    public class Ptienea
    {
        public string pack { get; set; }
        public string articulo { get; set; }

        public Ptienea(string pack, string articulo)
        {
            this.pack = pack;
            this.articulo = articulo;
        }
    }
}

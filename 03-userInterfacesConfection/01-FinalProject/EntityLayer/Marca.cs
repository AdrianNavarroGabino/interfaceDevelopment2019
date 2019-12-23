// Adrián Navarro Gabino

namespace EntityLayer
{
    public class Marca
    {
        public string marcaID { get; set; }
        public string empresa { get; set; }
        public string logo { get; set; }

        public Marca(string marcaID, string empresa, string logo)
        {
            this.marcaID = marcaID;
            this.empresa = empresa;
            this.logo = logo;
        }
    }
}

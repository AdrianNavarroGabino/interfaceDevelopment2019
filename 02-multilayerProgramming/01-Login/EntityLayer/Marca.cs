using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Marca
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

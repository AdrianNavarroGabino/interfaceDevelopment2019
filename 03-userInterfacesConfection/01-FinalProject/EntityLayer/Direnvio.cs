using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Direnvio
    {
        public long usuarioID { get; set; }
        public string calle { get; set; }
        public string calle2 { get; set; }
        public string codpos { get; set; }
        public string localidadID { get; set; }
        public string provinciaID { get; set; }

        public Direnvio(long usuarioID, string calle, string calle2,
            string codpos, string localidadID, string provinciaID)
        {
            this.usuarioID = usuarioID;
            this.calle = calle;
            this.calle2 = calle2;
            this.codpos = codpos;
            this.localidadID = localidadID;
            this.provinciaID = provinciaID;
        }
    }
}

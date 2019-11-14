using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Tv
    {
        public string TvID { get; set; }
        public string panel { get; set; }
        public string pantalla { get; set; }
        public string resolucion { get; set; }
        public string hdreadyfullhd { get; set; }
        public string tdt { get; set; }

        public Tv(string tvID, string panel, string pantalla, string resolucion,
            string hdreadyfullhd, string tdt)
        {
            TvID = tvID;
            this.panel = panel;
            this.pantalla = pantalla;
            this.resolucion = resolucion;
            this.hdreadyfullhd = hdreadyfullhd;
            this.tdt = tdt;
        }
    }
}

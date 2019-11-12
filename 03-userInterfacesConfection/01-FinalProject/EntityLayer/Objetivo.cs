using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Objetivo
    {
        public string ObjetivoID { get; set; }
        public string tipo { get; set; }
        public string montura { get; set; }
        public string focal { get; set; }
        public string apertura { get; set; }
        public string especiales { get; set; }

        public Objetivo(string objetivoID, string tipo, string montura,
            string focal, string apertura, string especiales)
        {
            ObjetivoID = objetivoID;
            this.tipo = tipo;
            this.montura = montura;
            this.focal = focal;
            this.apertura = apertura;
            this.especiales = especiales;
        }
    }
}

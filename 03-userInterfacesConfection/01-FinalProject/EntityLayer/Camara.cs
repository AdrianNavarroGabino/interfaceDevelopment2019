using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class Camara
    {
        public string CamaraID { get; set; }
        public string resolucion { get; set; }
        public string sensor { get; set; }
        public string tipo { get; set; }
        public string factor { get; set; }
        public string objetivo { get; set; }
        public string pantalla { get; set; }
        public string zoom { get; set; }

        public Camara(string camaraID, string resolucion, string sensor,
            string tipo, string factor, string objetivo, string pantalla,
            string zoom)
        {
            CamaraID = camaraID;
            this.resolucion = resolucion;
            this.sensor = sensor;
            this.tipo = tipo;
            this.factor = factor;
            this.objetivo = objetivo;
            this.pantalla = pantalla;
            this.zoom = zoom;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Usuario
    {
        public int usuarioID { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public string telefono { get; set; }
        public string calle { get; set; }
        public string calle2 { get; set; }
        public string codpos { get; set; }
        public string puebloID { get; set; }
        public string provinciaID { get; set; }
        public string nacido { get; set; }

        public Usuario(int usuarioID, string email, string password, string nombre,
            string apellidos, string dni, string telefono, string calle,
            string calle2, string codpos, string puebloID, string provinciaID,
            string nacido)
        {
            this.usuarioID = usuarioID;
            this.email = email;
            this.nombre = nombre;
            this.password = password;
            this.apellidos = apellidos;
            this.dni = dni;
            this.telefono = telefono;
            this.calle = calle;
            this.calle2 = calle2;
            this.codpos = codpos;
            this.puebloID = puebloID;
            this.provinciaID = provinciaID;
            this.nacido = nacido;
        }
    }
}

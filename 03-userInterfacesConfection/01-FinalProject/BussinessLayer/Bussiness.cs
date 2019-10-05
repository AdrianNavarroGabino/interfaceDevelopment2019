using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using EntityLayer;

namespace BussinessLayer
{
    public class Bussiness
    {
        private Data dat;

        public Bussiness()
        {
            dat = new Data();
        }

        // Valido el login de un usuario
        public bool Validate(string usu, string pas)
        {
            List<Usuario> usersList = dat.ReadUsers();

            if (usersList != null)
            {
                for (int i = 0; i < usersList.Count; i++)
                {
                    if ((usersList[i].nombre == usu) &&
                        (usersList[i].password == pas))
                        return (true);
                }
            }

            return (false);
        }

        // Creo un nuevo usuario
        /*public bool NewUser(string usu, string pas)
        {
            return dat.NewUser(usu, pas);
        }*/
    }
}

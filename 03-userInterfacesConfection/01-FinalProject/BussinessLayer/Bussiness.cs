using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using EntityLayer;
using System.Security.Cryptography;

namespace BussinessLayer
{
    public class Bussiness
    {
        private Data dat;

        public Bussiness()
        {
            dat = new Data();
        }

        public string codifica_MD5(string pas)
        {
            int i;
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(pas));

            pas = "";
            for (i = 0; i < data.Length; i++)
            {
                pas = pas + data[i];
            }

            return pas;
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
                        (usersList[i].password == codifica_MD5(pas)))
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

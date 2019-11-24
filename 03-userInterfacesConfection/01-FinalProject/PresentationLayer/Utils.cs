// Adrián Navarro Gabino

using EntityLayer;
using System;
using System.Collections.Generic;

namespace PresentationLayer
{
    class Utils
    {
        public static Usuario SearchUserByIdCard(List<Usuario> users,
            String idCard)
        {
            foreach(Usuario u in users)
            {
                if(u.dni == idCard)
                {
                    return u;
                }
            }
            return null;
        }
    }
}

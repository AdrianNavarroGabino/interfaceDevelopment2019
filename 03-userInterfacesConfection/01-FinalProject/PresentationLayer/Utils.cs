using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    class Utils
    {
        public static Usuario SearchUserByIdCard(List<Usuario> users, String idCard)
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

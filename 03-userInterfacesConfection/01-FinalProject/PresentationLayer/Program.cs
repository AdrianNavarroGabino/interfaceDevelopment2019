using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    static class Program
    {
        static bool autologin = true;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (autologin)
            {
                Application.Run(new Main("admin", new BussinessLayer.Bussiness()));
            }
            else
            {
                Application.Run(new Login());
            }
        }
    }
}

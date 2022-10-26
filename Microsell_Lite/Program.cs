using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsell_Lite.Productos;
using Microsell_Lite.Utilitarios;
using Microsell_Lite.Proveedor;

namespace Microsell_Lite
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Frm_marca());
            //Application.Run(new Frm_categoria());
            //Application.Run(new Frm_distrito());
            //Application.Run(new Frm_AddProveedor());
            Application.Run(new Frm_Add_Producto());
        }
    }
}
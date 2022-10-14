using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Entidad;
using Prj_Capa_Datos;//Se referencia a la capa datos
namespace Prj_Capa_Negocio
{
    public class RN_Proveedor
    {
        //Se hacen instancias de la clase BD_Proveedor que mediante esta capa poder acceder a esos metodos 
        //y hacer la conexion con la capa negocio y capa datos
        public void RN_Registrar_Proveedor(EN_Proveedor pro)
        {
            BD_Proveedor obj = new BD_Proveedor();
            obj.BD_Registrar_Proveedor(pro);
        }
        public void RN_Editar_Marca(EN_Proveedor pro)
        {
            BD_Proveedor obj = new BD_Proveedor();
            obj.BD_Registrar_Proveedor(pro);
        }
        public DataTable RN_Mostrar_Todas_Proveedores()
        {
            BD_Proveedor obj = new BD_Proveedor();
            return obj.BD_Mostrar_Todos_Proveedores();
        }
    }
}

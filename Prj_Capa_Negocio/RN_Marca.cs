using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Datos;//Se referencia a la capa datos

namespace Prj_Capa_Negocio
{
    public class RN_Marca
    {//Se hacen instancias de la clase BD_Marca para que mediante esta capa poder acceder a esos metodos 
     //y hacer la conexion con la capa negocio y capa datos
        public void RN_Registrar_Marca(string nomMarca)
        {
            BD_Marca obj = new BD_Marca();//instancia
            obj.BD_Registrar_Marca(nomMarca);
        }
        public void RN_Editar_Marca(int idMarca, string nomMarca)
        {
            BD_Marca obj = new BD_Marca();
            obj.BD_Editar_Marca(idMarca, nomMarca);
        }
        public DataTable RN_Mostrar_Todas_Marcas()
        {
            BD_Marca obj = new BD_Marca();
            return obj.BD_Mostrar_Todas_Marcas();
        }
        public void RN_Eliminar_Marca(int idMarca)
        {
            BD_Marca obj = new BD_Marca();
            obj.BD_Eliminar_Marca(idMarca);
        }
    }
}

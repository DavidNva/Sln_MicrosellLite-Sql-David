using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Datos;//Se referencia a la capa datos
namespace Prj_Capa_Negocio
{
    public class RN_Distrito
    {//Se hacen instancias de la clase BD_Distrito para que mediante esta capa poder acceder a esos metodos 
     //y hacer la conexion con la capa negocio y capa datos
        public void RN_Registrar_Distrito(string nomDistrito)
        {
            BD_Distrito obj = new BD_Distrito();//instancia
            obj.BD_Registrar_Distrito(nomDistrito);
        }
        public void RN_Editar_Distrito(int idDistrito, string nomDistrito)
        {
            BD_Distrito obj = new BD_Distrito();
            obj.BD_Editar_Distrito(idDistrito, nomDistrito);
        }
        public DataTable RN_Mostrar_Todos_Distritos()
        {
            BD_Distrito obj = new BD_Distrito();
            return obj.BD_Mostrar_Todos_Distrito();
        }
        public void RN_Eliminar_Distrito(int idDistrito)
        {
            BD_Distrito obj = new BD_Distrito();
            obj.BD_Eliminar_Distrito(idDistrito);
        }
    }
}

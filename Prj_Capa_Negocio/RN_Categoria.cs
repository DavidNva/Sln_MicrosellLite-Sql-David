using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Capa_Datos;
using System.Data;

namespace Prj_Capa_Negocio
{//Se hacen instancias de la clase BD_Categoria para que mediante esta capa poder acceder a esos metodos 
    //y hacer la conexion con la capa negocio y capa datos
    public class RN_Categoria
    {
        public void RN_Registrar_Categoria(string nomCateg)
        {
            BD_Categoria obj = new BD_Categoria();//instancia
            obj.BD_Registrar_Categoria(nomCateg);
        }
        public void RN_Editar_Categoria(int idcateg, string nomCateg)
        {
            BD_Categoria obj = new BD_Categoria();
            obj.BD_Editar_Categoria(idcateg, nomCateg);
        }
        public DataTable RN_Mostrar_Todas_Categorias()
        {
            BD_Categoria obj = new BD_Categoria();
            return obj.BD_Mostrar_Todas_Categorias();
        }
    }
}

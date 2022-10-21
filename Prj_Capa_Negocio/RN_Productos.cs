using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using System.Data;

namespace Prj_Capa_Negocio
{
    //Se hacen instancias de la clase BD_Categoria para que mediante esta capa poder acceder a esos metodos 
    //y hacer la conexion con la capa negocio y capa datos
    public class RN_Productos
    {
        public void RN_Registrar_Productos(EN_Producto pro)
        {//DE BD_Producto
            BD_Productos obj = new BD_Productos();
            obj.BD_Registrar_Producto(pro);
        }
        public void RN_Editar_Productos(EN_Producto pro)
        {
            BD_Productos obj = new BD_Productos();
            obj.BD_Editar_Producto(pro);
        }
        public DataTable RN_Mostrar_Todas_Productos()
        {
            BD_Productos obj = new BD_Productos();
            return obj.BD_Mostrar_Todos_Productos();
        }
        public DataTable RN_Buscar_Productos(string valor)
        {
            BD_Productos obj = new BD_Productos();
            return obj.BD_Buscar_Productos(valor);
        }
        public void RN_darBaja_Productos(string idprod)
        {
            BD_Productos obj = new BD_Productos();
            obj.BD_Darbaja_Producto(idprod);
        }
        public void RN_Eliminar_Productos(string idprod)
        {
            BD_Productos obj = new BD_Productos();
            obj.BD_Eliminar_Producto(idprod);
        }
        public void RN_Sumar_Stock_Producto(string idProd, double stock)
        {
            BD_Productos obj = new BD_Productos();
            obj.BD_Sumar_Stock_Producto(idProd, stock);
        }
        public void RN_Restar_Stock_Producto(int idProd, double stock)
        {
            BD_Productos obj = new BD_Productos();
            obj.BD_Restar_Stock_Producto(idProd, stock);
        }
        public void RN_Actualizar_PrecioCompra_Producto(string idProd, double preCompraP, double preVentaMenor, double utilidad, double valorAlmacen)
        {
            BD_Productos obj = new BD_Productos();
            obj.BD_Actualizar_PrecioCompa_Producto(idProd, preCompraP, preVentaMenor, utilidad, valorAlmacen);
        }
    }
}

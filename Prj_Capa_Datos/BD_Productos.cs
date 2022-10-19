using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Prj_Capa_Entidad;
namespace Prj_Capa_Datos
{
    public class BD_Productos: BDConexion  //Heredamos de esta clase para tener el metodo Conectar(); 
    {
        public static bool seguardo = false;
        public void BD_Registrar_Proveedor(EN_Producto pro)
        {
            SqlConnection cn = new SqlConnection();//Instanciamos de una clase tipo SqlConnection
            try
            {//usamos la instancia
                cn.ConnectionString = Conectar();//Para indicar que vamos a hacer una conexion declarada anteriormente (Con el metodo de la clase heradada)
                SqlCommand cmd = new SqlCommand("Sp_registrar_Producto", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
                cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                cmd.Parameters.AddWithValue("@idpro", pro.IdProd);//Como parametro indicamos el nombre de la categoria (es la variable ya hecha con el procedimiento almacenado)
                                                                             //el parametro @idprove y demas deben ser igual al declarado en el sp,  //Tambien indicamos de donde proviene dicha informacion, en este caso del parametro del propio metodo, que trae el dato que ingrese el usuario
                cmd.Parameters.AddWithValue("@idprove", pro.IdProve);//Estos son los nombres identificares declarados en el scrip de sql y el segundo en la clase EN_Proveedor
                cmd.Parameters.AddWithValue("@descripcion", pro.Descripcion);
                cmd.Parameters.AddWithValue("@frank", pro.Frank);
                cmd.Parameters.AddWithValue("@Pre_compraSol", pro.Pre_CompraSol);
                cmd.Parameters.AddWithValue("@pre_CompraDolar", pro.Pre_CompraDolar);
                cmd.Parameters.AddWithValue("@StockActual", pro.StockActual);
                cmd.Parameters.AddWithValue("@idCat", pro.IdCat);
                cmd.Parameters.AddWithValue("@idMar", pro.IdMar);
                cmd.Parameters.AddWithValue("@Foto", pro.Foto);
                cmd.Parameters.AddWithValue("@Pre_Venta_Menor", pro.Pre_Venta_Menor);
                cmd.Parameters.AddWithValue("@Pre_Venta_Mayor", pro.Pre_Venta_Mayor);
                cmd.Parameters.AddWithValue("@Pre_Venta_Dolar", pro.Pre_Venta_Dolar);
                cmd.Parameters.AddWithValue("@UndMdida", pro.UndMdida);
                cmd.Parameters.AddWithValue("@PesoUnit", pro.PesoUnit);
                cmd.Parameters.AddWithValue("@Utilidad", pro.Utilidad);
                cmd.Parameters.AddWithValue("@TipoProd", pro.TipoProd);
                cmd.Parameters.AddWithValue("@ValorporProd", pro.ValorPorProd);
                cn.Open();//Abrimos la conexion
                cmd.ExecuteNonQuery();//Ejecutamos la consulta
                cn.Close();//Cerramos la conexión
                seguardo = true;    
                MessageBox.Show("El producto se ha registrado exitosamente");//Para verificar que ha ejecutado estas lineas, mostramos este mensaje

            }
            catch (Exception ex)//En caso de algun error
            {
                if (cn.State == ConnectionState.Open)//Si la conexion esta abierta
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Producto", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos.
            }
        }
        public void BD_Editar_Producto(EN_Producto pro)
        {
            SqlConnection cn = new SqlConnection();//Instanciamos de una clase tipo SqlConnection
            try
            {//usamos la instancia
                cn.ConnectionString = Conectar();//Para indicar que vamos a hacer una conexion declarada anteriormente (Con el metodo de la clase heradada)
                SqlCommand cmd = new SqlCommand("Sp_Editar_Producto", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
                cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                cmd.Parameters.AddWithValue("@idpro", pro.IdProd);//Como parametro indicamos el nombre de la categoria (es la variable ya hecha con el procedimiento almacenado)
                                                                  //el parametro @idprove y demas deben ser igual al declarado en el sp,  //Tambien indicamos de donde proviene dicha informacion, en este caso del parametro del propio metodo, que trae el dato que ingrese el usuario
                cmd.Parameters.AddWithValue("@idprove", pro.IdProve);//Estos son los nombres identificares declarados en el scrip de sql y el segundo en la clase EN_Proveedor
                cmd.Parameters.AddWithValue("@descripcion", pro.Descripcion);
                cmd.Parameters.AddWithValue("@frank", pro.Frank);
                cmd.Parameters.AddWithValue("@Pre_compraSol", pro.Pre_CompraSol);
                cmd.Parameters.AddWithValue("@pre_CompraDolar", pro.Pre_CompraDolar);
                cmd.Parameters.AddWithValue("@StockActual", pro.StockActual);
                cmd.Parameters.AddWithValue("@idCat", pro.IdCat);
                cmd.Parameters.AddWithValue("@idMar", pro.IdMar);
                cmd.Parameters.AddWithValue("@Foto", pro.Foto);
                cmd.Parameters.AddWithValue("@Pre_Venta_Menor", pro.Pre_Venta_Menor);
                cmd.Parameters.AddWithValue("@Pre_Venta_Mayor", pro.Pre_Venta_Mayor);
                cmd.Parameters.AddWithValue("@Pre_Venta_Dolar", pro.Pre_Venta_Dolar);
                cmd.Parameters.AddWithValue("@UndMdida", pro.UndMdida);
                cmd.Parameters.AddWithValue("@PesoUnit", pro.PesoUnit);
                cmd.Parameters.AddWithValue("@Utilidad", pro.Utilidad);
                cmd.Parameters.AddWithValue("@TipoProd", pro.TipoProd);
                cmd.Parameters.AddWithValue("@ValorporProd", pro.ValorPorProd);
                cn.Open();//Abrimos la conexion
                cmd.ExecuteNonQuery();//Ejecutamos la consulta
                cn.Close();//Cerramos la conexión
                seguardo = true;
                MessageBox.Show("El producto se ha editado exitosamente");//Para verificar que ha ejecutado estas lineas, mostramos este mensaje

            }
            catch (Exception ex)//En caso de algun error
            {
                if (cn.State == ConnectionState.Open)//Si la conexion esta abierta
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Producto", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos.
            }
        }

        public DataTable BD_Mostrar_Todos_Productos()
        {
            SqlConnection cn = new SqlConnection();//instancia
            try
            {
                cn.ConnectionString = Conectar();//Para indicar que vamos a hacer una conexion declarada anteriormente (Con el metodo de la clase heradada)
                SqlDataAdapter da = new SqlDataAdapter("sp_cargar_Todos_Productos", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion a la BD
                da.SelectCommand.CommandType = CommandType.StoredProcedure;//Indicamos que va a ser de tipo procedimiento almacenado
                DataTable data = new DataTable();//Con esta instruccion tenemos toda la tabla que genera la consulta (el procedimiento almacenado)    

                da.Fill(data);//Con esto ya tenemos una tabla virtual en memoria cargada con la informacion de la tabla
                da = null;
                return data;//Retorna el valor  de la informacion de la tabla

            }
            catch (Exception ex)//En caso de algun error
            {
                if (cn.State == ConnectionState.Open)//Si la conexion esta abierta
                {
                    cn.Close();//Cierra la conexion
                }
                MessageBox.Show("Error al consultar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Producto", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos. 
                return null;
            }
        }
        
        public DataTable BD_Buscar_Productos(string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_buscador_Productos", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion a la BD
                da.SelectCommand.CommandType = CommandType.StoredProcedure;//Sp_buscador_Productos////Indicamos que va a ser de tipo procedimiento almacenado
                da.SelectCommand.Parameters.AddWithValue("@valor", valor);
                DataTable data = new DataTable();//Con esta instruccion tenemos toda la tabla que genera la consulta (el procedimiento almacenado)

                da.Fill(data);//Con esto ya tenemos una tabla virtual en memoria cargada con la informacion de la tabla
                da = null;
                return data;//Retorna el valor  de la informacion de la tabla
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)//Si la conexion esta abierta
                {
                    cn.Close();//Cierra la conexion
                }
                MessageBox.Show("Error al consultar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Producto", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos. 
                return null;
               
            }
        }
    }
    
}

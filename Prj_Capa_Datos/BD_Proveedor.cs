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
    public class BD_Proveedor : BDConexion
    {
        //Parametro para indicar el nombre del distrito (en teoria podria provenir de una caja
        //de texto, dependiendo de lo que ingrese el usuario)
        public void BD_Registrar_Proveedor(EN_Proveedor pro)
        {
            SqlConnection cn = new SqlConnection();//Instanciamos de una clase tipo SqlConnection
            try
            {//usamos la instancia
                cn.ConnectionString = Conectar();//Para indicar que vamos a hacer una conexion declarada anteriormente (Con el metodo de la clase heradada)
                SqlCommand cmd = new SqlCommand("sp_registrar_Proveedor", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
                cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                cmd.Parameters.AddWithValue("@idproveedor",pro.IdProveedor);//Como parametro indicamos el nombre de la categoria (es la variable ya hecha con el procedimiento almacenado)
                                                                          //el parametro @distrito nombre debe seri igual al declarado en el sp,  //Tambien indicamos de donde proviene dicha informacion, en este caso del parametro del propio metodo, que trae el dato que ingrese el usuario
                cmd.Parameters.AddWithValue("@nombre",pro.NombreProveedor);//Estos son los nombres identificares declarados en el scrip de sql y el segundo en la clase EN_Proveedor
                cmd.Parameters.AddWithValue("@direccion", pro.Direccion);
                cmd.Parameters.AddWithValue("@telefono", pro.Telefono);
                cmd.Parameters.AddWithValue("@rubro", pro.Rubro);
                cmd.Parameters.AddWithValue("@ruc", pro.Ruc);
                cmd.Parameters.AddWithValue("@correo", pro.Correo);
                cmd.Parameters.AddWithValue("@contacto", pro.Contacto);
                cmd.Parameters.AddWithValue("@fotologo", pro.FotoLogo);
                cn.Open();//Abrimos la conexion
                cmd.ExecuteNonQuery();//Ejecutamos la consulta
                cn.Close();//Cerramos la conexión
                MessageBox.Show("El proveedor se ha registrado exitosamente");//Para verificar que ha ejecutado estas lineas, mostramos este mensaje

            }
            catch (Exception ex)//En caso de algun error
            {
                if (cn.State == ConnectionState.Open)//Si la conexion esta abierta
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Proveedor", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos.
            }
        }

        public void BD_Editar_Proveedor(EN_Proveedor pro)
        {
            SqlConnection cn = new SqlConnection();//Instanciamos de una clase tipo SqlConnection
            try
            {//usamos la instancia
                cn.ConnectionString = Conectar();//Para indicar que vamos a hacer una conexion declarada anteriormente (Con el metodo de la clase heradada)
                SqlCommand cmd = new SqlCommand("sp_Modificar_Proveedor", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
                cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                cmd.Parameters.AddWithValue("@idproveedor", pro.IdProveedor);//Como parametro indicamos el nombre de la categoria (es la variable ya hecha con el procedimiento almacenado)
                                                                             //el parametro @distrito nombre debe seri igual al declarado en el sp,  //Tambien indicamos de donde proviene dicha informacion, en este caso del parametro del propio metodo, que trae el dato que ingrese el usuario
                cmd.Parameters.AddWithValue("@nombre", pro.NombreProveedor);//Estos son los nombres identificares declarados en el scrip de sql y el segundo en la clase EN_Proveedor
                cmd.Parameters.AddWithValue("@direccion", pro.Direccion);
                cmd.Parameters.AddWithValue("@telefono", pro.Telefono);
                cmd.Parameters.AddWithValue("@rubro", pro.Rubro);
                cmd.Parameters.AddWithValue("@ruc", pro.Ruc);
                cmd.Parameters.AddWithValue("@correo", pro.Correo);
                cmd.Parameters.AddWithValue("@contacto", pro.Contacto);
                cmd.Parameters.AddWithValue("@fotologo", pro.FotoLogo);
                cn.Open();//Abrimos la conexion
                cmd.ExecuteNonQuery();//Ejecutamos la consulta
                cn.Close();//Cerramos la conexión
                MessageBox.Show("El proveedor se ha editado exitosamente");//Para verificar que ha ejecutado estas lineas, mostramos este mensaje

            }
            catch (Exception ex)//En caso de algun error
            {
                if (cn.State == ConnectionState.Open)//Si la conexion esta abierta
                {
                    cn.Close();
                }
                MessageBox.Show("Error al actualizar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Proveedor", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos.
            }
        }
        public DataTable BD_Mostrar_Todos_Proveedores()
        {
            SqlConnection cn = new SqlConnection();//instancia
            try
            {
                cn.ConnectionString = Conectar();//Para indicar que vamos a hacer una conexion declarada anteriormente (Con el metodo de la clase heradada)
                SqlDataAdapter da = new SqlDataAdapter("sp_Listar_Todos_Proveedores", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion a la BD
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
                    cn.Close();//Cieera la conexion
                }
                MessageBox.Show("Error al consultar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Proveedor", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos. 
                return null;
            }
        }
    }
}

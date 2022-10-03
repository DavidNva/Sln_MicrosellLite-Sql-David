using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prj_Capa_Datos
{
    public class BD_Marca : BDConexion//Heredamos de esta clase para tener el metodo Conectar(); 
    {
        public void BD_Registrar_Marca(string nomMarca)//Parametro para indicar el nombre de la marca (en teoria podria provenir de una caja
                                                       //de texto, dependiendo de lo que ingrese el usuario)
        {
            SqlConnection cn = new SqlConnection();//Instanciamos de una clase tipo SqlConnection
            try
            {//usamos la instancia
                cn.ConnectionString = Conectar();//Para indicar que vamos a hacer una conexion declarada anteriormente (Con el metodo de la clase heradada)
                SqlCommand cmd = new SqlCommand("sp_addMarca", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
                cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                cmd.Parameters.AddWithValue("@marca", nomMarca);//Como parametro indicamos el nombre de la categoria (es la variable ya hecha con el procedimiento almacenado)
                //el parametro @marca nombre debe seri igual al declarado en el sp,  //Tambien indicamos de donde proviene dicha informacion, en este caso del parametro del propio metodo, que trae el dato que ingrese el usuario
                
                cn.Open();//Abrimos la conexion
                cmd.ExecuteNonQuery();//Ejecutamos la consulta
                cn.Close();//Cerramos la conexión
                MessageBox.Show("La marca se ha registrado exitosamente");//Para verificar que ha ejecutado estas lineas, mostramos este mensaje

            }
            catch (Exception ex)//En caso de algun error
            {
                if (cn.State == ConnectionState.Open)//Si la conexion esta abierta
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Marca", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos.
            }
        }

        public void BD_Editar_Marca(int idMarca, string nomMarca)//Parametro para indicar el nombre de la marca (en teoria podria provenir de una caja
                                                                 //de texto, dependiendo de lo que ingrese el usuario)
        {
            SqlConnection cn = new SqlConnection();//Instanciamos de una clase tipo SqlConnection
            try
            {//usamos la instancia
                cn.ConnectionString = Conectar();//Para indicar que vamos a hacer una conexion declarada anteriormente (Con el metodo de la clase heradada)
                SqlCommand cmd = new SqlCommand("sp_Editar_Marca", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion
                cmd.CommandTimeout = 20;//Espera a ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                cmd.Parameters.AddWithValue("@idmar", idMarca);//Para la seleccion where
                cmd.Parameters.AddWithValue("@nom_marca", nomMarca);//Como parametro indicamos el nombre de la categoria (es la variable ya hecha con el procedimiento almacenado)
                //los parametros @idmar y @nom_marca nombre debe seri igual al declarado en el sp,  //Tambien indicamos de donde proviene dicha informacion, en este caso del parametro del propio metodo, que trae el dato que ingrese el usuario
                cn.Open();//Abrimos la conexion
                cmd.ExecuteNonQuery();//Ejecutamos la consulta
                cn.Close();//Cerramos la conexión
                MessageBox.Show("La marca se ha editado exitosamente");//Para verificar que ha ejecutado estas lineas, mostramos este mensaje

            }
            catch (Exception ex)//En caso de algun error
            {
                if (cn.State == ConnectionState.Open)//Si la conexion esta abierta
                {
                    cn.Close();
                }
                MessageBox.Show("Error al editar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Marca", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos. 
            }
        }

        public DataTable BD_Mostrar_Todas_Marcas()
        {
            SqlConnection cn = new SqlConnection();//instancia
            try
            {
                cn.ConnectionString = Conectar();//Para indicar que vamos a hacer una conexion declarada anteriormente (Con el metodo de la clase heradada)
                SqlDataAdapter da = new SqlDataAdapter("sp_Listar_Todos_Marcas", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion a la BD
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
                    cn.Close();
                }
                MessageBox.Show("Error al consultar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Marca", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos. 
                return null;
            }
        }

        public void BD_Eliminar_Marca(int idMarca)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();//se usa el metodo heredado
                SqlCommand cmd = new SqlCommand("sp_eliminar_Marca", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion a la BD
                cmd.CommandTimeout = 20;//Espero ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                cmd.CommandType = CommandType.StoredProcedure;//Indicamos que va a ser de tipo procedimiento almacenado
                cmd.Parameters.AddWithValue("@idmar", idMarca);//Como parametro indicamos el nombre de la categoria (es la variable ya hecha con el procedimiento almacenado)
                //el parametro @idmar debe ser igual al declarado en el sp,  //Tambien indicamos de donde proviene dicha informacion, en este caso del parametro del propio metodo, que trae el dato que ingrese el usuario

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("La marca se ha eliminado exitosamente");

            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al eliminar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Marca", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

    }
}

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
    public class BD_Categoria: BDConexion  //Heredamos de esta clase para tener el metodo Conectar(); 
    {
        public void BD_Registrar_Categoria(string nomCateg)//Parametro para indicar el nombre de la categoria (en teoria podria provenir de una caja
                                                           //de texto, dependiendo de lo que ingrese el usuario)
        {
            SqlConnection cn = new SqlConnection();//Instanciamos de una clase tipo SqlConnection
            try
            {//usamos la instancia
                cn.ConnectionString = Conectar();//Para indicar que vamos a hacer una conexion declarada anteriormente (Con el metodo de la clase heradada)
                SqlCommand cmd = new SqlCommand("sp_registrar_categoria",cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion a la BD
                cmd.CommandTimeout = 20;//Espero ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                cmd.Parameters.AddWithValue("@nombre", nomCateg);//Como parametro indicamos el nombre de la categoria (es la variable ya hecha con el procedimiento almacenado)
                //el parametro @nombre debe ser igual al declarado en el sp,  //Tambien indicamos de donde proviene dicha informacion, en este caso del parametro del propio metodo, que trae el dato que ingrese el usuario
                cn.Open();//Abrimos la conexion
                cmd.ExecuteNonQuery();//Ejecutamos la consulta
                cn.Close();//Cerramos la conexión
                MessageBox.Show("La categoria se ha registrado exitosamente");
                
            }
            catch (Exception ex)//En caso de algun error
            {
                if (cn.State==ConnectionState.Open)//Si la conexion esta abierta
                {
                    cn.Close();
                }
                MessageBox.Show("Error al guardar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Categoria", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos. 
            }
        }

        public void BD_Editar_Categoria(int idcateg, string nomCateg)//Parametro para indicar el nombre de la categoria (en teoria podria provenir de una caja
                                                                     //de texto, dependiendo de lo que ingrese el usuario)
        {
            SqlConnection cn = new SqlConnection();//Instanciamos de una clase tipo SqlConnection
            try
            {
                cn.ConnectionString = Conectar();//Para indicar que vamos a hacer una conexion declarada anteriormente (Con el metodo de la clase heradada)
                SqlCommand cmd = new SqlCommand("sp_modificar_categoria", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion a la BD
                cmd.CommandTimeout = 20;//Espero ejecutar esto en 20 segundo, si demora mas tiempo pasa al catch
                cmd.CommandType = CommandType.StoredProcedure;//Indicamos que el comando va a ser de tipo Procedimiento Almacenado
                cmd.Parameters.AddWithValue("@idcat", idcateg);//Para la seleccion where
                cmd.Parameters.AddWithValue("@nombre", nomCateg);//Como parametro indicamos el nombre de la categoria (es la variable ya hecha con el procedimiento almacenado)
                //el parametro @nombre debe ser igual al declarado en el sp,  //Tambien indicamos de donde proviene dicha informacion, en este caso del parametro del propio metodo, que trae el dato que ingrese el usuario
                cn.Open();//Abrimos la conexion
                cmd.ExecuteNonQuery();//Ejecutamos la consulta
                cn.Close();//Cerramos la conexión
                MessageBox.Show("La categoria se ha editado exitosamente");

            }
            catch (Exception ex)//En caso de algun error
            {
                if (cn.State == ConnectionState.Open)//Si la conexion esta abierta
                {
                    cn.Close();
                }
                MessageBox.Show("Error al editar: " + ex.Message + ex.StackTrace,
                    "Capa Datos Categoria", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos.
            }
        }

        public DataTable BD_Mostrar_Todas_Categorias()
        {
            SqlConnection cn = new SqlConnection();//instancia
            try
            {
                cn.ConnectionString = Conectar();//Para indicar que vamos a hacer una conexion declarada anteriormente (Con el metodo de la clase heradada)
                SqlDataAdapter da = new SqlDataAdapter("sp_listar_todas_Categorias", cn);//Indicamos el sp a ejecutar (debe ser con el nombre dado en sql y la conexion a la BD
                da.SelectCommand.CommandType = CommandType.StoredProcedure;//Indicamos que va a ser de tipo procedimiento almacenado
                DataTable data = new DataTable();//Con esta instruccion tenemos toda la tabla que genera la consulta (el procedimiento almacenado)    

                da.Fill(data); //Con esto ya tenemos una tabla virtual en memoria cargada con la informacion de la tabla
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
                    "Capa Datos Categoria", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);//Se notifica el mensaje de error, el tipo, el nombre de la capa en la que estamos. 
                return null;
            }
        }

    }
}

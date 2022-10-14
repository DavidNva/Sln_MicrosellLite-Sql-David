using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;
using Microsell_Lite.Utilitarios;


namespace Microsell_Lite.Proveedor
{
    public partial class Frm_AddProveedor : Form
    {
        public Frm_AddProveedor()
        {
            InitializeComponent();
        }

        string xFotoruta;
        private void lblFotoPerfil_Click(object sender, EventArgs e)
        {
            var filepath = string.Empty;//variable para la ruta de archivo, en inicio esta vacia

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)//Al dar ok para elegir un archivo (imagen)
                {
                    xFotoruta = openFileDialog1.FileName;//
                    picLOG.Load(xFotoruta);//Carga la imagen en el picture con la ruta del archivo de imagen
                }
            }
            catch (Exception ex)
            {

                picLOG.Load(Application.StartupPath + @"\user.png");
                xFotoruta = Application.StartupPath + @"user.png";
                MessageBox.Show("Error al guardar el personal" + ex.Message + ex.StackTrace);
            }
        }
        
        private bool Validar_TextBox()
        {
            Frm_Filtro Fil = new Frm_Filtro();
            Frm_Advertencia Ver = new Frm_Advertencia();//Mensaje cuando ocurre algun eror de validacion
            if (txt_IDProveedor.Text.Trim().Length < 2)//Si hay un espacio 
            {
                Fil.Show();
                //Ver. = "Ingresa o gener el ID del proveedor";
                Ver.ShowDialog();//Muestra el formulario de advertencia 
                Fil.Hide();//Oculta
                return false;
                
            }

            if (txtNombreProveedor.Text.Trim().Length < 2)
            {
                Fil.Show();//muestra
                Ver.Text = "Ingresa o genera un nombre para el proveedor";
                Ver.ShowDialog();
                Fil.Hide();//oculta
                return false;
            }

            if (txtRuc.Text.Trim().Length < 2)
            {
                Fil.Show();
                //Ver.lbl_msjl.Text = "Ingresa o genera un nombre para el proveedor";
                Ver.ShowDialog();
                Fil.Hide();
                return false;
            }
            return true;
        }//Este método valida los 3 campos mas importantes de la tabla proveedor que si o si, deben estar colocados, 
        //en este caso, el campo IDProveedor, el Nombre del Proveedor y su RUC
        //Para ello son las validaciones
        private void Registrar_Proveedor()
        {
            RN_Proveedor obj = new RN_Proveedor();
            EN_Proveedor pro = new EN_Proveedor();//Instancia la clase creada en la capa Entidad, para poder acceder a las
            //propiedades creadas para el proveedor y de esta forma usar un mismo objeto 

            try
            {
                pro.IdProveedor = txt_IDProveedor.Text;
                pro.NombreProveedor = txtNombreProveedor.Text;
                pro.Direccion = txtDireccion.Text;
                pro.Rubro = txtRubro.Text;
                pro.Ruc = txtRuc.Text;
                pro.Correo = txtCorreo.Text;
                pro.Telefono =txtTelefono.Text;
                pro.Contacto = txtContacto.Text;
                pro.FotoLogo = xFotoruta;

                obj.RN_Registrar_Proveedor(pro);
                limpiarForm();//Despues de registrar, limpiamos las cajas de texto
                this.Tag = "A";
                //this.Close();
            }
            catch (Exception ex)//Si ocurre alguna exception
            {
                MessageBox.Show("Error al guardar" + ex.Message + ex.StackTrace, "Form Add Proveedor",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }   
        }

        private void limpiarForm()
        {
            txt_IDProveedor.Text = "";
            txtNombreProveedor.Text = "";
            txtDireccion.Text = "";
            txtRubro.Text = "";
            txtRuc.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtContacto.Text = "";
            xFotoruta = "";
        }//Este metodo limpia los TextBox del formulario
        //Lo podemos llamar, por ejemplo, despues de registrar alguna proveedor

        private void btn_listo_Click(object sender, EventArgs e)
        {
            if (Validar_TextBox() == true){//Al dar clic en listo, si ya ha pasado todas las validaciones de forma correcta
                Registrar_Proveedor();//entonces procede a registrar un proveedor
            }
            else{
                MessageBox.Show("Faltan datos por llenar");//De no ser asi, envia el mensaje de error
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();//Cierra este formulario de AddProveedor
        }
    }
}

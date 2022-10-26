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

namespace Microsell_Lite.Productos
{
    public partial class Frm_Add_Producto : Form
    {
        public Frm_Add_Producto()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Validar_TextBox()
        {
            Frm_Filtro Fil = new Frm_Filtro();
            Frm_Advertencia Ver = new Frm_Advertencia();//Mensaje cuando ocurre algun eror de validacion
            if (txt_IDProducto.Text.Trim().Length < 2)//Si hay un espacio 
            {
                Fil.Show();
                //Ver. = "Ingresa o gener el ID del proveedor";
                Ver.ShowDialog();//Muestra el formulario de advertencia 
                Fil.Hide();//Oculta
                return false;

            }

            if (txt_DescripcionProd.Text.Trim().Length < 2)
            {
                Fil.Show();//muestra
                Ver.Text = "Ingresa o genera un nombre para el proveedor";
                Ver.ShowDialog();
                txt_DescripcionProd.Focus();
                Fil.Hide();//oculta
                return false;
            }

            if (txt_PrecioUnitario.Text.Trim().Length < 8)
            {
                Fil.Show();
                //Ver.lbl_msjl.Text = "Ingresa o genera un nombre para el proveedor";
                Ver.ShowDialog();
                txt_PrecioUnitario.Focus();
                Fil.Hide();
                return false;
            }//
            if (txt_PrecioUnitario.Text.Trim().Length < 8)
            {
                Fil.Show();
                //Ver.lbl_msjl.Text = "Ingresa o genera un nombre para el proveedor";
                Ver.ShowDialog();
                txt_PrecioUnitario.Focus();
                Fil.Hide();
                return false;
            }//
            
            return true;
        }//Este método valida los 3 campos mas importantes de la tabla proveedor que si o si, deben estar colocados, 
        //en este caso, el campo IDProveedor, el Nombre del Proveedor y su RUC
        //Para ello son las validaciones
    }
}

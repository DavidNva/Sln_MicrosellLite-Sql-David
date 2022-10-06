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
            var filepath = string.Empty;

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    xFotoruta = openFileDialog1.FileName;
                    picLOG.Load(xFotoruta);
                }
            }
            catch (Exception ex)
            {

                picLOG.Load(Application.StartupPath + @"\user.png");
                xFotoruta = Application.StartupPath + @"user.png";
                MessageBox.Show("Error al guardar el personal" + ex.Message + ex.StackTrace);
            }
        }
        /*
        private bool Validar_TextBox()
        {
            if (txt_IDProveedor.Text.Trim().Length < 2)
            {
                Fil.show();
                Ver.lbl_msjl.Text = "Ingresa o gener el ID del proveedor";
                Ver.ShowDialog();
                Fil.Hide();
                return false;
            }

            if (txtNombreProveedor.Text.Trim().Length < 2)
            {
                Fil.show();
                Ver.lbl_msjl.Text = "Ingresa o genera un nombre para el proveedor";
                Ver.ShowDialog();
                Fil.Hide();
                return false;
            }

            if (txtRuc.Text.Trim().Length < 2)
            {
                Fil.show();
                Ver.lbl_msjl.Text = "Ingresa o genera un nombre para el proveedor";
                Ver.ShowDialog();
                Fil.Hide();
                return false;
            }
            return true;
        }
        private void Registrar_Proveedor()
        {
            RN_Proveedor p = new RN_Proveedor();
            EN_Proveedor pro = new EN_Proveedor();

            try
            {
                pro.IdProveedor = txt_IDProveedor.Text;
                pro.NombreProveedor = txtNombreProveedor.Text;
                pro.Direccion = txtDireccion.Text;
                pro.Rubro = txtRubro.Text;
                pro.Ruc = txtRuc.Text;
                pro.Correo = txtCorreo.Text;
                pro.Contacto = txtContacto.Text;
                pro.FotoLogo = xFotoruta;
            }
            catch (Exception)
            {

                throw;
            }
        }*/
    }
}

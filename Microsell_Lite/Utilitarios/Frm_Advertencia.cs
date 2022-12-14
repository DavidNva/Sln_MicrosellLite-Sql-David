using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Negocio;

namespace Microsell_Lite.Utilitarios
{
    public partial class Frm_Advertencia : Form
    {
        public Frm_Advertencia()
        {
            InitializeComponent();
        }

        private void Frm_Advertencia_Load(object sender, EventArgs e)
        {

        }//En lugar de usar un MessageBox, usamos este formulario para mostrar alguna advertencia (Por ejemplo, 
        //se usa esta advertencia en una validacion de textBox del form proveedor

        private void Frm_Advertencia_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitario obj = new Utilitario();
                obj.Mover_formulario(this);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();//Cierra esta ventana de advertencia
        }

        private void Frm_Advertencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(sender, e);//Acepta dar enter para pulsar el boton aceptar
            }
        }
    }
}

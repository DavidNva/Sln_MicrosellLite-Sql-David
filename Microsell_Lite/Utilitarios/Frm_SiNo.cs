using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsell_Lite.Utilitarios
{
    public partial class Frm_SiNo : Form
    {
        public Frm_SiNo()
        {
            InitializeComponent();
        }
        //En lugar de usar un MessageBox usa este formulario para verificar la eliminacion de alguna elemento
        //por ejemplo, se usa en el formulario de marca, al intentar eliminar alguna
        private void btn_Si_Click(object sender, EventArgs e)
        {
            this.Tag = "Si";//Es una forma de confirmacion
            this.Close();

        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void lbl_Nomaalgo_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Utilitario u = new Utilitario();
                u.Mover_formulario(this);
            }
        }
    }
}

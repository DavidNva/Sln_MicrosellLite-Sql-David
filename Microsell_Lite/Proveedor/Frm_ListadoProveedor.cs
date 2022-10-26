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

namespace Microsell_Lite.Proveedor
{
    public partial class Frm_ListadoProveedor : Form
    {
        public Frm_ListadoProveedor()
        {
            InitializeComponent();
            Configurar_ListView();
            Cargar_Todos_Proveedores();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }
        private void Configurar_ListView()
        {
            var lis = lsv_ListaProveedores;
            lsv_ListaProveedores.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            //Configuramos columnas que queremos mostrar
            lis.Columns.Add("ID", 80, HorizontalAlignment.Left);
            lis.Columns.Add("Nombre Proveedor", 220, HorizontalAlignment.Left);
        }
        private void Llenar_ListView(DataTable data)
        {
            lsv_ListaProveedores.Items.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["IDPROVEE"].ToString());
                list.SubItems.Add(dr["NOMBRE"].ToString());//Los datos dentro del corchete deben ser igual al nombre de la columna en la tabla de sql
                lsv_ListaProveedores.Items.Add(list);
            }
        }
        private void Cargar_Todos_Proveedores()
        {
            RN_Proveedor obj = new RN_Proveedor();
            DataTable dato = new DataTable();
            dato = obj.RN_Mostrar_Todas_Proveedores();
            if(dato.Rows.Count > 0)
            {
                Llenar_ListView(dato);
            }
            else
            {
                lsv_ListaProveedores.Items.Clear();
            }
        }
    }
}


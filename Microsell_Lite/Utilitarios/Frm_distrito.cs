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
    public partial class Frm_distrito : Form
    {
        public Frm_distrito()
        {
            InitializeComponent();
        }

        private void Frm_distrito_Load(object sender, EventArgs e)
        {
            Configurar_listView();
            Cargar_Todos_Distrito();
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            //si se mueve en la barra superior
            Utilitario obj = new Utilitario();
            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Configurar_listView()
        {
            var lis = lsv_Distrito;

            lsv_Distrito.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            //Configuramos las columnas de la tabla del formulario
            lis.Columns.Add("ID", 40, HorizontalAlignment.Left);//0
            lis.Columns.Add("Distrito", 150, HorizontalAlignment.Left);//1
            lis.Columns.Add("Estado", 210, HorizontalAlignment.Left);//2
        }

        private void Llenar_ListView(DataTable data)
        {
            lsv_Distrito.Items.Clear();//Primero limpia los items
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Dis"].ToString());
                //el identificador Id_Dis debe ser igual al nombre de la columna de la tabla creada en sql
                list.SubItems.Add(dr["Distrito"].ToString());//lo mismo sucede con distrito
                list.SubItems.Add(dr["Estado_Dis"].ToString());//lo mismo sucede con estado distrito
                lsv_Distrito.Items.Add(list);
            }
        }
        private void Cargar_Todos_Distrito()
        {
            RN_Distrito obj = new RN_Distrito();//instancia para obtener los metodos RN
            DataTable dato = new DataTable();
            //carga virtualmente los datos (con la siguiente instruccion)
            //igualando la variable dato tipo DataTable con el metodo mostrar todas los Distritos
            dato = obj.RN_Mostrar_Todos_Distritos();//Muestra los Distritos de la tabla actual
            if (dato.Rows.Count > 0)//si dato tiene mas de una fila
            {
                Llenar_ListView(dato);//se llena la tabla
            }
            else
            {
                lsv_Distrito.Items.Clear();//sino, se limpia
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            panel_Add.Visible = true;//vuelve visible el panel de agregar
            txt_Nombre.Focus();
            editar = false;
        }
        public bool editar = false;

        private void btn_Listo_Click(object sender, EventArgs e)//este boton pertenece al panel 
        {
            RN_Distrito obj = new RN_Distrito();
            if (txt_Nombre.Text.Trim().Length < 0)
            {
                MessageBox.Show("Ingresa el nombre del Distritoa",
                    "Registrar Distrito", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (editar == false)
            {
                //Nuevo
                obj.RN_Registrar_Distrito(txt_Nombre.Text);//registra un nuevo Distrito
                panel_Add.Visible = false;//vuelve invisible el panel de agregar, mostrandose en primera plana la tabla principal
                Cargar_Todos_Distrito();//actualiza los valores
                txt_Nombre.Text = "";//limpia la caja de texto para una futura insercion
            }
            else
            {
                //Editar
                obj.RN_Editar_Distrito(Convert.ToInt32(txt_Id.Text), txt_Nombre.Text);
                panel_Add.Visible = false;
                Cargar_Todos_Distrito();
                txt_Nombre.Text = "";
                editar = false;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (lsv_Distrito.SelectedIndices.Count == 0)//si no se ha seleccionado ningun item, indice o Distrito como tal
            {
                MessageBox.Show("Selecciona el Item para Editar sus datos",
                    "Advertencia de Seguridad", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else//si existe una seleccion, entonces:
            {
                var lsv = lsv_Distrito.SelectedItems[0];
                txt_Id.Text = lsv.SubItems[0].Text;//se trae o carga los datos para que al mostrar de nuevo el panel de add
                txt_Nombre.Text = lsv.SubItems[1].Text;//solo se haga la edicion si volver a escribir todo

                panel_Add.Visible = true;//volvemos a mostrar el panel de agregar para editar
                txt_Nombre.Focus();
                editar = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lsv_Distrito.SelectedItems.Count == 0)//si no se ha seleccionado ningun item, indice o Distrito como tal
            {
                MessageBox.Show("Selecciona el elemento a eliminar",
                "Advertencia de Seguridad", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                var lsv = lsv_Distrito.SelectedItems[0];//si existe una seleccion, entonces:
                txt_Id.Text = lsv.SubItems[0].Text;

                Frm_SiNo sino = new Frm_SiNo();//instancia el formulario de SiNo
                sino.lbl_Nomaalgo.Text = "¿Estas seguro de eliminar el Distrito?";//Cambia el texto de "" a el mensaje, del label creado en el form SiNo
                sino.ShowDialog();
                if (sino.Tag.ToString() == "Si")//En dado caso de dar clic en si
                {
                    RN_Distrito obj = new RN_Distrito();
                    obj.RN_Eliminar_Distrito(Convert.ToInt32(txt_Id.Text));//lo elimina
                }//sino, como tal no hace nada
                Cargar_Todos_Distrito();//al cerrar el show dialog, se ejecuta o carga de nuevo todas las Distrito
                //es decir, actualiza toda la tabla
            }
        }
    }
}

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
    public partial class Frm_marca : Form
    {
        public Frm_marca()
        {
            InitializeComponent();
        }

        private void Frm_marca_Load(object sender, EventArgs e)
        {
            Configurar_listView();
            Cargar_Todos_Marca();//Cada que se abre este formulario, carga todos los datos o filas de Marca
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {//si se mueve en la barra superior
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
            var lis = lsv_Marca;

            lsv_Marca.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            //Configuramos las columnas
            lis.Columns.Add("ID", 40, HorizontalAlignment.Left);//0
            lis.Columns.Add("Marca", 350, HorizontalAlignment.Left);//1
        }

        private void Llenar_ListView(DataTable data)
        {
            lsv_Marca.Items.Clear();//Primero limpia los items
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Marca"].ToString());
                //el identificador Id_Marca debe ser igual al nombre de la columna de la tabla creada en sql
                list.SubItems.Add(dr["Marca"].ToString());//lo mismo sucede con Marca
                lsv_Marca.Items.Add(list);
            }
        }
        private void Cargar_Todos_Marca()
        {
            RN_Marca obj = new RN_Marca();//instancia para obtener los metodos RN
            DataTable dato = new DataTable();
            //carga virtualmente los datos (con la siguiente instruccion)
            //igualando la variable dato tipo DataTable con el metodo mostrar todas las marcas
            dato = obj.RN_Mostrar_Todas_Marcas();//Muestra las marcas de la tabla actual
            if (dato.Rows.Count > 0)//si dato tiene mas de una fila
            {
                Llenar_ListView(dato);//se llena la tabla
            }
            else
            {
                lsv_Marca.Items.Clear();//sino, se limpia
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
            RN_Marca obj = new RN_Marca();
            if (txt_Nombre.Text.Trim().Length < 0)
            {
                MessageBox.Show("Ingresa el nombre de la Marca",
                    "Registrar Marca", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (editar == false)
            {
                //Nuevo
                obj.RN_Registrar_Marca(txt_Nombre.Text);//registra una nueva categoriia
                panel_Add.Visible = false;//vuelve invisible el panel de agregar, mostrandose en primera plana la tabla principal
                Cargar_Todos_Marca();//actualiza los valores
                txt_Nombre.Text = "";//limpia la caja de texto para una futura insercion
            }
            else
            {
                //Editar
                obj.RN_Editar_Marca(Convert.ToInt32(txt_Id.Text), txt_Nombre.Text);
                panel_Add.Visible = false;
                Cargar_Todos_Marca();
                txt_Nombre.Text = "";
                editar = false;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (lsv_Marca.SelectedIndices.Count == 0)//si no se ha seleccionado ningun item, indice o marca como tal
            {
                MessageBox.Show("Selecciona el Item para Editar sus datos",
                    "Advertencia de Seguridad", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else//si existe una seleccion, entonces:
            {
                var lsv = lsv_Marca.SelectedItems[0];
                txt_Id.Text = lsv.SubItems[0].Text;//se trae o carga los datos para que al mostrar de nuevo el panel de add
                txt_Nombre.Text = lsv.SubItems[1].Text;//solo se haga la edicion si volver a escribir todo

                panel_Add.Visible = true;//volvemos a mostrar el panel de agregar para editar
                txt_Nombre.Focus();
                editar = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lsv_Marca.SelectedItems.Count == 0)//si no se ha seleccionado ningun item, indice o marca como tal
            {
                MessageBox.Show("Selecciona el elemento a eliminar",
                "Advertencia de Seguridad", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                var lsv = lsv_Marca.SelectedItems[0];//si existe una seleccion, entonces:
                txt_Id.Text = lsv.SubItems[0].Text;

                Frm_SiNo sino = new Frm_SiNo();//instancia el formulario de SiNo
                sino.lbl_Nomaalgo.Text = "¿Estas seguro de eliminar la Marca?";//Cambia el texto de "" a el mensaje, del label creado en el form SiNo
                sino.ShowDialog();
                if (sino.Tag.ToString() == "Si")//En dado caso de dar clic en si
                {
                    RN_Marca obj = new RN_Marca();
                    obj.RN_Eliminar_Marca(Convert.ToInt32(txt_Id.Text));//lo elimina
                }//sino, como tal no hace nada
                Cargar_Todos_Marca();//al cerrar el show dialog, se ejecuta o carga de nuevo todas las marcas
                //es decir, actualiza toda la tabla
            }
        }
    }
}

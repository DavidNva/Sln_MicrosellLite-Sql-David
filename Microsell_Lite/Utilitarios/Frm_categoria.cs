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
    public partial class Frm_categoria : Form
    {
        public Frm_categoria()
        {
            InitializeComponent();
        }

        private void Frm_categoria_Load(object sender, EventArgs e)
        {
            Configurar_listView();
            Cargar_Todos_carteg();
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {//si se mueve en la barra superior
            Utilitario obj = new Utilitario();
            if (e.Button==MouseButtons.Left)
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
            var lis = lsv_Categ;

            lsv_Categ.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            //Configuramos las columnas
            lis.Columns.Add("ID", 40, HorizontalAlignment.Left);//0
            lis.Columns.Add("Categoria", 350, HorizontalAlignment.Left);//1
        }

        private void Llenar_ListView(DataTable data)
        {
            lsv_Categ.Items.Clear();//Primero limpia los items
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Cat"].ToString());
                //el identificador Id_Cat debe ser igual al nombre de la columna de la tabla creada en sql
                list.SubItems.Add(dr["Categoria"]. ToString());//lo mismo sucede con categoria
                lsv_Categ.Items.Add(list);
            }
        }
        private void Cargar_Todos_carteg()
        {
            RN_Categoria obj = new RN_Categoria();//instancia para obtener los metodos RN
            DataTable dato = new DataTable();
            //carga virtualmente los datos 
            //igualando la variable dato tipo DataTable con el metodo mostrar todas categorias
            dato = obj.RN_Mostrar_Todas_Categorias();//Muestra las categorias de la tabla actual
            if (dato.Rows.Count>0)//si dato tiene mas de una fila
            {
                Llenar_ListView(dato);//llenas la tabla 
            }
            else
            {
                lsv_Categ.Items.Clear();//sino, la limpias
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            panel_Add.Visible = true;//vuelve visible el panel de agregar
            txt_Nombre.Focus();
            editar = false;
        }
        public bool editar = false;

        private void btn_Listo_Click(object sender, EventArgs e)//este boton pertenece al panel Add anterior 
        {
            RN_Categoria obj = new RN_Categoria();
            if (txt_Nombre.Text.Trim().Length<0)
            {
                MessageBox.Show("Ingresa el nombre de la categoria",
                    "Registrar Categoria", MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (editar==false)
            {
                //Nuevo
                obj.RN_Registrar_Categoria(txt_Nombre.Text);//registra una nueva categoria
                panel_Add.Visible = false;//vuelve invisible el panel de agregar, mostrandose en primera plana la tabla principal
                Cargar_Todos_carteg();//actualiza los valores
                txt_Nombre.Text = "";//limpia la caja de texto para una futura insercion
            }
            else
            {
                
                obj.RN_Editar_Categoria(Convert.ToInt32(txt_Id.Text), txt_Nombre.Text);
                panel_Add.Visible = false;
                Cargar_Todos_carteg();
                txt_Nombre.Text = "";
                editar = false;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (lsv_Categ.SelectedIndices.Count==0)//si no se ha seleccionado ningun item, indice o categoria como tal
            {
                MessageBox.Show("Selecciona el Item para Editar sus datos",
                    "Advertencia de Seguridad", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else//si existe una seleccion, entonces:
            {
                var lsv = lsv_Categ.SelectedItems[0];
                txt_Id.Text = lsv.SubItems[0].Text;//se trae o carga los datos para que al mostrar de nuevo el panel de add
                txt_Nombre.Text = lsv.SubItems[1].Text;//solo se haga la edicion si volver a escribir todo

                panel_Add.Visible = true;//volvemos a mostrar el panel de agregar para editar
                txt_Nombre.Focus();
                editar = true;
            }
        }
    }
}

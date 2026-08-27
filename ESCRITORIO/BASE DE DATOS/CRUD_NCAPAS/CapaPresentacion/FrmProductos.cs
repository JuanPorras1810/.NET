using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProductos : Form
    {
        //Variables globales 
        private string idProducto = null;
        private bool editar = false;

        CN_Productos OCn_Productos = new CN_Productos();
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarDgvProductos();
            DgvProductos.ClearSelection();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                OCn_Productos.Insertar(TxtNombre.Text, TxtDescripcion.Text, TxtMarca.Text, TxtPrecio.Text, TxtStock.Text);
                CargarDgvProductos();
                Limpiar();
            }
            else
            {
                OCn_Productos.Actualizar(idProducto, TxtNombre.Text, TxtDescripcion.Text, TxtMarca.Text, TxtPrecio.Text, TxtStock.Text);
                CargarDgvProductos();
                Limpiar();
                editar = false;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvProductos.SelectedRows.Count > 0)
            {
                editar = true;
                TxtNombre.Text = DgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                TxtMarca.Text = DgvProductos.CurrentRow.Cells["Marca"].Value.ToString();
                TxtDescripcion.Text = DgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                TxtPrecio.Text = DgvProductos.CurrentRow.Cells["Precio"].Value.ToString();
                TxtStock.Text = DgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = DgvProductos.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Seleccione", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvProductos.SelectedRows.Count > 0)
            {
                DialogResult rta = MessageBox.Show("Seguro que deseas eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (rta == DialogResult.Yes)
                {
                    idProducto = DgvProductos.CurrentRow.Cells["Id"].Value.ToString();
                    OCn_Productos.Eliminar(idProducto);
                    CargarDgvProductos();
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Seleccione", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        //Mis metodos 
        private void CargarDgvProductos() 
        {
            DgvProductos.DataSource = OCn_Productos.Mostrar();
        }

        private void Limpiar() 
        {
            TxtNombre.Clear();
            TxtDescripcion.Clear();
            TxtMarca.Clear();
            TxtPrecio.Clear();
            TxtStock.Clear();
            TxtNombre.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            editar = false;
            Limpiar();
        }
    }
}

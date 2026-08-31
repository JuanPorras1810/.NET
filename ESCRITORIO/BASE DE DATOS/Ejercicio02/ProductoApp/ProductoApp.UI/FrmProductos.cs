using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductoApp.BLL.Logic;
using ProductoApp.Entities.Models;


namespace ProductoApp.UI
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
            _bll = new ProductoBLL();
            ConfigurarDataGridView();
            Shown += FrmProductos_Shown;

        }
        private bool _cargandoProductos;
        private readonly ProductoBLL _bll;

        private void FrmProductos_Load(object sender, EventArgs e)
        {
                CargarProductos();
        }

        private void DgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (_cargandoProductos)
                return;

            if (DgvProductos.SelectedRows.Count == 0)
            {
                TxtNombre.Clear();
                TxtPrecio.Clear();
                BtnEliminar.Enabled = false;
                BtnGuardar.Text = "Guardar";
                return;
            }

            DataGridViewRow fila = DgvProductos.SelectedRows[0];

            TxtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
            TxtPrecio.Text = fila.Cells["Precio"].Value?.ToString();

            BtnEliminar.Enabled = true;
            BtnGuardar.Text = "Actualizar";

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string resultado;

            if (BtnGuardar.Text == "Actualizar" && DgvProductos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(DgvProductos.SelectedRows[0].Cells["IdProducto"].Value);

                Producto prod = new Producto
                {
                    IdProducto = id,
                    Nombre = TxtNombre.Text.Trim(),
                    Precio = decimal.Parse(TxtPrecio.Text)
                };

                resultado = _bll.Actualizar(prod);
            }
            else
            {
                Producto prod = new Producto
                {
                    Nombre = TxtNombre.Text.Trim(),
                    Precio = decimal.Parse(TxtPrecio.Text),
                    Stock = 0
                };

                resultado = _bll.Insertar(prod);
            }
            MessageBox.Show(resultado, "Resultado",resultado.StartsWith("✅") ? MessageBoxButtons.OK : MessageBoxButtons.OK,resultado.StartsWith("✅") ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            CargarProductos();
            LimpiarCampos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                int id = Convert.ToInt32(DgvProductos.SelectedRows[0].Cells["IdProducto"].Value);
                string res = _bll.Eliminar(id);
                MessageBox.Show(res, "Eliminar");
                CargarProductos();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarProductos()
        {
             try
    {
        _cargandoProductos = true;

        List<Producto> lista = _bll.Listar();

        DgvProductos.DataSource = null;
        DgvProductos.DataSource = lista;

        DgvProductos.ClearSelection();
        DgvProductos.CurrentCell = null;
    }
    catch (Exception ex)
    {
        MessageBox.Show(
            "Error al cargar datos:\n" + ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
    finally
    {
        _cargandoProductos = false;
        TxtNombre.Clear();
        TxtPrecio.Clear();
        BtnEliminar.Enabled = false;
        BtnGuardar.Text = "Guardar";
    }

    DgvProductos.Columns["Descripcion"].Visible = false;

        }

        private void LimpiarCampos()
        {
            TxtNombre.Text = string.Empty;
            TxtPrecio.Text = string.Empty;
            BtnGuardar.Text = "Guardar";
            BtnEliminar.Enabled = false;
            DgvProductos.ClearSelection();
            TxtNombre.Focus();
        }

        private void ConfigurarDataGridView()
        {
            DgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProductos.MultiSelect = false;
            DgvProductos.ReadOnly = true;
            DgvProductos.AllowUserToAddRows = false;
            DgvProductos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 40, 80);
            DgvProductos.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void FrmProductos_Shown(object sender, EventArgs e)
        {
            DgvProductos.ClearSelection();
            DgvProductos.CurrentCell = null;
            TxtNombre.Clear();
            TxtPrecio.Clear();
            BtnGuardar.Text = "Guardar";
            BtnEliminar.Enabled = false;
            TxtNombre.Focus();
        }
    }
}

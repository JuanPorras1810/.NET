using NaturVida.App.Data;
using NaturVida.App.Logic;
using NaturVida.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NaturVida.App.UI
{
    public partial class FrmProductos : Form
    {
        private readonly CategoriaBLL catBll = new();
        private readonly ProductoBLL prodBll = new();

        public FrmProductos()
        {
            InitializeComponent();
            BtnEliminar.Enabled = false;
            DgvProductos.CellClick += DgvProductos_CellClick;
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarGrilla();
        }

        public void CargarCategorias()
        {
            var categorias = catBll.Listar();
            categorias.Insert(0, new Categoria
            {
                Id = 0,
                Nombre = "-- Seleccione --"
            });
            CboCategoria.DataSource = categorias;
            CboCategoria.DisplayMember = "Nombre";   // Lo que ve el usuario
            CboCategoria.ValueMember = "Id";         // El valor oculto (ID)
        }

        private void CargarGrilla()
        {
            DgvProductos.DataSource = prodBll.Listar();

            if (DgvProductos.Columns["Id"] != null) 
                DgvProductos.Columns["Id"]!.Visible = false;

            if (DgvProductos.Columns["CategoriaId"] != null) 
                DgvProductos.Columns["CategoriaId"]!.Visible = false;

            if (DgvProductos.Columns["Categoria"] != null) 
                DgvProductos.Columns["Categoria"]!.Visible = false;

            Limpiar();
        }

        private void DgvProductos_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (DgvProductos.CurrentRow == null) return;

            if (DgvProductos.CurrentRow.DataBoundItem is Producto prod)
            {
                LblId.Text = prod.Id.ToString();
                TxtNombre.Text = prod.Nombre;
                TxtPrecio.Text = prod.Precio.ToString();
                NumStock.Value = prod.Stock;
                CboCategoria.SelectedValue = prod.CategoriaId;

                BtnEliminar.Enabled = true;
                BtnGuardar.Text = "Actualizar";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int idCatSeleccionada = CboCategoria.SelectedValue != null ? (int)CboCategoria.SelectedValue : 0;

            if (idCatSeleccionada == 0)
            {
                MessageBox.Show("No has seleccionado una categoría.", "Resultado");
                return;
            }

            if (!decimal.TryParse(TxtPrecio.Text.Trim(), out decimal precioValidado))
            {
                MessageBox.Show("El precio debe ser un numero", "resultado");
                TxtPrecio.Focus();
                return;
            }

            var prod = new Producto
            {
                Id = int.TryParse(LblId.Text, out int id) ? id : 0,
                Nombre = TxtNombre.Text,
                Precio = TxtPrecio.Text != "" ? decimal.Parse(TxtPrecio.Text) : 0,
                Stock = (int)NumStock.Value,
                CategoriaId = idCatSeleccionada
            };

            string msg = prodBll.Guardar(prod);
            MessageBox.Show(msg, "Resultado");
            CargarGrilla();

            BtnGuardar.Text = "Guardar";
            BtnEliminar.Enabled = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (LblId.Text == "" || LblId.Text == "0") return;

            var res = MessageBox.Show("¿Eliminar producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                prodBll.Eliminar(int.Parse(LblId.Text));
                CargarGrilla();

                BtnGuardar.Text = "Guardar";
                BtnEliminar.Enabled = false;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            BtnGuardar.Text = "Guardar";
            Limpiar();
        }

        private void Limpiar()
        {
            LblId.Text = "";
            TxtNombre.Clear();
            TxtPrecio.Clear();
            NumStock.Text = "";

            if (CboCategoria.Items.Count > 0) CboCategoria.SelectedIndex = 0;
            DgvProductos.ClearSelection();
        }
    }
}

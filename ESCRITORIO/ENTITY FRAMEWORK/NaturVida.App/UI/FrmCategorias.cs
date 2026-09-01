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
    public partial class FrmCategorias : Form
    {

        private readonly CategoriaBLL bll = new();
        public FrmCategorias()
        {

            InitializeComponent();
            BtnEliminar.Enabled = false;
            BtnGuardar.Click += BtnGuardar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            BtnNuevo.Click += BtnNuevo_Click;
            DgvCategorias.CellClick += DgvCategorias_CellClick;

        }
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            DgvCategorias.DataSource = bll.Listar();
            if (DgvCategorias.Columns["Id"] != null)
            {
                DgvCategorias.Columns["Id"]!.Visible = false;
            }
            Limpiar();
        }

        private void DgvCategorias_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (DgvCategorias.CurrentRow == null) return;

            if (DgvCategorias.CurrentRow.DataBoundItem is Categoria cat)
            {
                LblId.Text = cat.Id.ToString();
                TxtNombre.Text = cat.Nombre;
                ChkActivo.Checked = cat.Activo;
                BtnEliminar.Enabled = true;
                BtnGuardar.Text = "Actualizar";
            }
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var cat = new Categoria
            {
                Id = int.TryParse(LblId.Text, out int id) ? id : 0,
                Nombre = TxtNombre.Text.Trim(),
                Activo = ChkActivo.Checked
            };

            string msg = bll.Guardar(cat);
            MessageBox.Show(msg, "Resultado");
            Cargar();
            BtnGuardar.Text = "Guardar";
            BtnEliminar.Enabled = false;
        }

        private void BtnEliminar_Click(object? sender, EventArgs e)
        {
            if (LblId.Text == "") return;
            var res = MessageBox.Show("¿Eliminar categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string msg = bll.Eliminar(int.Parse(LblId.Text));
                MessageBox.Show(msg);
                Cargar();
                BtnGuardar.Text = "Guardar";
                BtnEliminar.Enabled = false;
            }

        }

        private void BtnNuevo_Click(object? sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            BtnGuardar.Text = "Guardar";
            Limpiar();
        }

        private void Limpiar()
        {
            TxtNombre.Clear();
            ChkActivo.Checked = true;
            LblId.Text = string.Empty;
            TxtNombre.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NaturVida.App.UI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            BtnCategorias.Click += (s, e) => AbrirFormulario(new FrmCategorias());
            BtnProductos.Click += (s, e) => AbrirFormulario(new FrmProductos());
        }

        private void AbrirFormulario(Form hijo)
        {
            PanelContenido.Controls.Clear();

            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;

            PanelContenido.Controls.Add(hijo);
            hijo.Show();
        }
    }
}

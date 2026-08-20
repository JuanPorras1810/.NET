using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CboLibro.SelectedIndex = 0;
            CboFormaPago.SelectedIndex = 0;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            //Validar que no este vacio
            if (CboLibro.SelectedIndex == 0)
            {
                EpError.SetError(CboLibro, "Debe seleccionar un libro");
                CboLibro.Focus();
                return;
            }
            else if (TxtCantidad.Text.Trim() == "")
            {
                EpError.SetError(TxtCantidad, "Debe ingresar la cantidad");
                TxtCantidad.Focus();
                return;
            }
            else if (CboFormaPago.SelectedIndex == 0)
            {
                EpError.SetError(CboFormaPago, "Debe seleccionar una forma de pago");
                CboFormaPago.Focus();
                return;
            }
            else
            {
                EpError.Clear();
            }

            //Captura de datos
            string libro = CboLibro.Text;
            int cantidad = int.Parse(TxtCantidad.Text);
            string formaPago = CboFormaPago.Text;

            //Calcular precio libros
            int precio = 0;
            switch (libro)
            {
                case "Cien años de soledad":
                    precio = 50000;
                    break;

                case "Don Quijote de la Mancha":
                    precio = 40000;
                    break;

                case "El principito":
                    precio = 30000;
                    break;

                default:
                    break;
            }

            double subtotal = cantidad * precio;

            //Calcular el descuento
            double descuento = (formaPago == "Contado") ? subtotal * 0.05 : 0;
            double recargo = (formaPago == "Tarjeta") ? subtotal * 0.10 : 0;

            //Calcular el total 
            double total = subtotal - descuento + recargo;

            //Imprimir resultado
            ListViewItem fila = new ListViewItem(libro);
            fila.SubItems.Add(precio.ToString("C"));
            fila.SubItems.Add(cantidad.ToString());
            fila.SubItems.Add(formaPago);
            fila.SubItems.Add(descuento.ToString("C"));
            fila.SubItems.Add(recargo.ToString("C"));
            fila.SubItems.Add(total.ToString("C"));

            LvTabla.Items.Add(fila);

            BtnNuevo_Click(sender, e);
        }

        private void CboLibro_Validated(object sender, EventArgs e)
        {
            if (CboLibro.SelectedIndex == 0)
            {
                EpError.SetError(CboLibro, "Debe seleccionar una opcion");
                CboLibro.Focus();
            }
            else
            {
                EpError.Clear();
            }

        }

        private void CboFormaPago_Validated(object sender, EventArgs e)
        {
            if (CboFormaPago.SelectedIndex == 0)
            {
                EpError.SetError(CboFormaPago, "Debe seleccionar una opcion");
                CboFormaPago.Focus();
            }
            else
            {
                EpError.Clear();
            }
        }

        private void TxtCantidad_Validated(object sender, EventArgs e)
        {
            if ((!double.TryParse(TxtCantidad.Text, out double cantidad)))
            {
                EpError.SetError(TxtCantidad, "Debe ser un numero");
                TxtCantidad.Focus();
            }
            else if (double.Parse(TxtCantidad.Text) <= 0)
            {
                EpError.SetError(TxtCantidad, "Debe ser un numero positivo mayor a 0");
                TxtCantidad.Focus();
            }
            else
            {
                EpError.Clear();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CboLibro.SelectedIndex = 0;
            TxtCantidad.Clear();
            CboFormaPago.SelectedIndex = 0;
            CboLibro.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Seguro desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {
                this.Close();
            }
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio06
{
    public partial class FrmAlquiler : Form
    {
        public FrmAlquiler()
        {
            InitializeComponent();
            THora.Enabled = true;
        }

        private void FrmAlquiler_Load(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToShortDateString();
            CboTipo.SelectedIndex = 0;
        }

        private void THora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            //Validar que no este vacio
            if (CboTipo.SelectedIndex == 0)
            {
                EpError.SetError(CboTipo, "Debe seleccionar un tipo de habitacion");
                CboTipo.Focus();
                return;
            }
            else if (TxtDias.Text.Trim() == "")
            {
                EpError.SetError(TxtDias, "Debe ingresar los dias");
                TxtDias.Focus(); 
                return;
            }
            else
            {
                EpError.Clear();
            }


            //Capturar datos
            string habitacion = CboTipo.Text;
            int dias = int.Parse(TxtDias.Text);

            //Costos por habitacion
            double costo = 0;
            switch (habitacion)
            {
                case "Simple":
                    costo = 30;
                    break;

                case "Doble":
                    costo = 50;
                    break;

                case "Matrimonial":
                    costo = 120;
                    break;

                case "Presidencial":
                    costo = 300;
                    break;

                default:
                    costo = 0;
                    break;
            }

            //Realizar calculos
            double subtotal = costo * dias;
            double descuento = 0;

            if (dias <= 5)
            {
                descuento = 0;
            }
            else if (dias > 5 && dias <= 10)
            {
                descuento = subtotal * 0.05;
            }
            else if (dias > 10 && dias <= 30)
            {
                descuento = subtotal * 0.1;
            }
            else if (dias > 30)
            {
                descuento = subtotal * 0.2;
            }

            double neto = subtotal - descuento;

            //Emprimir datos tabla registro de alquiler
            ListViewItem fila = new ListViewItem(habitacion);
            fila.SubItems.Add(costo.ToString("C"));
            fila.SubItems.Add(dias.ToString());
            fila.SubItems.Add(subtotal.ToString("C"));
            fila.SubItems.Add(descuento.ToString("C"));
            fila.SubItems.Add(neto.ToString("C"));
            LvAlquiler.Items.Add(fila);

            //Determinar las estadisticas
            int i = 0;
            int cSimple = 0, cDoble = 0, cMatrimonial = 0, cPresidencial = 0;
            double tSimple = 0, tDoble = 0, tMatrimonial = 0, tPresidencial = 0;

            do
            {
                string tipo = LvAlquiler.Items[i].SubItems[0].Text;

                switch (tipo)
                {
                    case "Simple":
                        cSimple += int.Parse(LvAlquiler.Items[i].SubItems[2].Text);
                        tSimple += double.Parse(LvAlquiler.Items[i].SubItems[5].Text, NumberStyles.Currency);
                        break;

                    case "Doble":
                        cDoble += int.Parse(LvAlquiler.Items[i].SubItems[2].Text);
                        tDoble += double.Parse(LvAlquiler.Items[i].SubItems[5].Text, NumberStyles.Currency);
                        break;

                    case "Matrimonial":
                        cMatrimonial += int.Parse(LvAlquiler.Items[i].SubItems[2].Text);
                        tMatrimonial += double.Parse(LvAlquiler.Items[i].SubItems[5].Text, NumberStyles.Currency);
                        break;

                    case "Presidencial":
                        cPresidencial += int.Parse(LvAlquiler.Items[i].SubItems[2].Text);
                        tPresidencial += double.Parse(LvAlquiler.Items[i].SubItems[5].Text, NumberStyles.Currency);
                        break;
                }
                i++;

            } while (i < LvAlquiler.Items.Count);

            //Emprimir datos tabla estadisticas
            LvEstadisticas.Items.Clear();
            string[] elementosFila = new string[3];
            ListViewItem row;

            elementosFila[0] = "Habitacion Simple";
            elementosFila[1] = cSimple.ToString();
            elementosFila[2] = tSimple.ToString("C");
            row = new ListViewItem(elementosFila);
            LvEstadisticas.Items.Add(row);

            elementosFila[0] = "Habitacion Doble";
            elementosFila[1] = cDoble.ToString();
            elementosFila[2] = tDoble.ToString("C");
            row = new ListViewItem(elementosFila);
            LvEstadisticas.Items.Add(row);

            elementosFila[0] = "Habitacion Matrimonial";
            elementosFila[1] = cMatrimonial.ToString();
            elementosFila[2] = tMatrimonial.ToString("C");
            row = new ListViewItem(elementosFila);
            LvEstadisticas.Items.Add(row);

            elementosFila[0] = "Habitacion Presidencial";
            elementosFila[1] = cPresidencial.ToString();
            elementosFila[2] = tPresidencial.ToString("C");
            row = new ListViewItem(elementosFila);
            LvEstadisticas.Items.Add(row);

            BtnLimpiar_Click(sender, e);

        }

        private void CboTipo_Validated(object sender, EventArgs e)
        {
            if (CboTipo.SelectedIndex == 0)
            {
                EpError.SetError(CboTipo, "Debe seleccionar una opcion");
                CboTipo.Focus();
            }
            else
            {
                EpError.Clear();
            }
        }

        private void TxtDias_Validated(object sender, EventArgs e)
        {
            if ((!int.TryParse(TxtDias.Text, out int dias )))
            {
                EpError.SetError(TxtDias, "Debe ser un numero");
                TxtDias.Focus();
            }
            else if (int.Parse(TxtDias.Text) <= 0)
            {
                EpError.SetError(TxtDias, "Debe ser un numero positivo mayor a 0");
                TxtDias.Focus();
            }
            else
            {
                EpError.Clear();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            CboTipo.SelectedIndex = 0;
            TxtDias.Clear();
            CboTipo.Focus();
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

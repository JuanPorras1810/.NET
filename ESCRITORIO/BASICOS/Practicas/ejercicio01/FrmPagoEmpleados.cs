using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio01
{
    public partial class FrmPagoEmpleados : Form
    {
        public FrmPagoEmpleados()
        {
            InitializeComponent();
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            //Recuperar toda la informacion
            int horas = Convert.ToInt32(TxtHoras.Text);
            double costoHoras = Convert.ToInt32(TxtCostoHora.Text);
            //Realizar calculos
            double sueldoBasico = horas * costoHoras;
            double bonificacion = sueldoBasico * 0.20;
            double bruto = sueldoBasico + bonificacion;
            double descuento = bruto * 0.12;
            double neto = bruto - descuento;
            //Imprime el resultado
            LblMontoBruto.Text = bruto.ToString("C");
            LblMontoDescuento.Text = descuento.ToString("C");
            LblMontoNeto.Text = neto.ToString("C");
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtEmpleado.Clear();
            TxtCostoHora.Clear();
            TxtHoras.Clear();
            LblMontoBruto.Text = 0.ToString("C");
            LblMontoDescuento.Text = 0.ToString("C");
            LblMontoNeto.Text = 0.ToString("C");
            TxtEmpleado.Focus();


        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult rta =  MessageBox.Show("Seguro desea salir?" , "Salida" , MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (rta == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void FrmPagoEmpleados_Load(object sender, EventArgs e)
        {
            LblMontoBruto.Text = 0.ToString("C");
            LblMontoDescuento.Text = 0.ToString("C");
            LblMontoNeto.Text = 0.ToString("C");
        }
    }
}

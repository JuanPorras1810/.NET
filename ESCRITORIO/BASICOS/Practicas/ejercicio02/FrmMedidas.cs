using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio02
{
    public partial class FrmMedidas : Form
    {
        public FrmMedidas()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //Captura de datos por teclado (metros)
            double metros = double.Parse(TxtMetros.Text);

            //Conversiones
            double centimetros = metros * 100;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12;
            double yardas = pies / 3;

            //Resultado
            LstR.Items.Add("** RESUMEN DE CONVERSIONES **");
            LstR.Items.Add($"MEDIDA EN METROS: {metros:F2}");
            LstR.Items.Add("-----------------------------------------------------------------------");
            LstR.Items.Add($"MEDIDA EN CENTIMETROS: {centimetros:F2}");
            LstR.Items.Add($"MEDIDA EN PULGADAS: {pulgadas:F2}");
            LstR.Items.Add($"MEDIDA EN PIES: {pies:F2}");
            LstR.Items.Add($"MEDIDA EN YARDAS: {yardas:F2}");
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtMetros.Clear();
            LstR.Items.Clear();
            TxtMetros.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Estas seguro de salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           
            if (rta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

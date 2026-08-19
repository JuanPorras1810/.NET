using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //Captura de datos
            double altura = double.Parse(TxtAltura.Text);
            double diametro = double.Parse(TxtDiametro.Text);

            //Calculo
            double radio = diametro / 2;
            double area = (2 * Math.PI * radio) * (radio + altura);
            double volumen = Math.PI * (radio * radio) * altura;

            //Imprime el resultado 
            TxtR.Text = "** RESUMEN DE VOLUMEN Y AREAS **";
            TxtR.Text += $"\r\nVALOR ALTURA: {altura:F2}";
            TxtR.Text += $"\r\nVALOR DIAMETRO: {diametro:F2}";
            TxtR.Text += $"\r\n-----------------------------------------------------";
            TxtR.Text += $"\r\nRADIO: {radio:F2}";
            TxtR.Text += $"\r\nAREA: {area:F2}";
            TxtR.Text += $"\r\nVOLUMEN: {volumen:F2}";

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtAltura.Clear();
            TxtDiametro.Clear();
            TxtR.Clear();
            TxtAltura.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

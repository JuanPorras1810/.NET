using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validar(TextBox TxtNota) {
            if (TxtNota.Text.Trim().Length < 1)
            {
                EpError.SetError(TxtNota, "Debe tener al menos 1 caracrer");
                TxtNota.Focus();
            }
            else if (int.Parse(TxtNota.Text) < 0)
            {
                EpError.SetError(TxtNota, "Debe ser un numero positivo");
                TxtNota.Focus();
            }
            else if (int.Parse(TxtNota.Text) > 100)
            {
                EpError.SetError(TxtNota, "Debe ser un numero entre 0 - 100");
                TxtNota.Focus();
            }
            else
            {
                EpError.Clear();
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturando los valores
            String alumno = TxtAlumno.Text;
            int e1 = int.Parse(TxtE1.Text);
            int e2 = int.Parse(TxtE2.Text);
            int e3 = int.Parse(TxtE3.Text);
            int e4 = int.Parse(TxtE4.Text);

            //Determinar la menor nota 
            int menor = 0;
            if (e1 < e2) menor = e1;
            else menor = e2;
            if(e3 < menor) menor = e3;
            if(e4 < menor) menor = e4;

            //Calcular el promedio
            double promedio = (e1 + e2 + e3 + e4 - menor) / 3;

            //Condicion si aprobo o no
            string condicion = promedio >= 70? "Aprobado" : condicion = "Desaprobado";

            //Imprimiendo los resultados
            ListViewItem fila = new ListViewItem(alumno);
            fila.SubItems.Add(e1.ToString());
            fila.SubItems.Add(e2.ToString());
            fila.SubItems.Add(e3.ToString());
            fila.SubItems.Add(e4.ToString());
            fila.SubItems.Add(menor.ToString());
            fila.SubItems.Add(promedio.ToString());
            fila.SubItems.Add(condicion);
            LvRegistro.Items.Add(fila);
            BtnCancelar_Click(sender, e);
           
        }

        private void LvRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtAlumno.Clear();
            TxtE1.Clear();
            TxtE2.Clear();
            TxtE3.Clear();
            TxtE4.Clear();
            TxtAlumno.Focus();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Seguro desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            { 
                this.Close();
            }
        }

        private void TxtAlumno_Validated(object sender, EventArgs e)
        {
            if (TxtAlumno.Text.Trim().Length < 5)
            {
                EpError.SetError(TxtAlumno, "Debe tener al menos 5 caracteres");
                TxtAlumno.Focus();
            }
            else
            {
                EpError.Clear();
            }
        }

        private void TxtE1_Validated(object sender, EventArgs e)
        {
            validar(TxtE1);
        }

        private void TxtE2_Validated(object sender, EventArgs e)
        {
            validar(TxtE2);
        }

        private void TxtE3_Validated(object sender, EventArgs e)
        {
            validar(TxtE3);
        }

        private void TxtE4_Validated(object sender, EventArgs e)
        {
            validar(TxtE4);
        }
    }
}

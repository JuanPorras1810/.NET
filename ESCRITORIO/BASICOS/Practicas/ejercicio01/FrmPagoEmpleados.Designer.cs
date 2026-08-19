namespace ejercicio01
{
    partial class FrmPagoEmpleados
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmpleado = new System.Windows.Forms.TextBox();
            this.TxtHoras = new System.Windows.Forms.TextBox();
            this.TxtCostoHora = new System.Windows.Forms.TextBox();
            this.BtnProcesar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblMontoNeto = new System.Windows.Forms.Label();
            this.LblMontoDescuento = new System.Windows.Forms.Label();
            this.LblMontoBruto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE PAGO DE EMPLEADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMPLEADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "HORAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "COSTO HORA";
            // 
            // TxtEmpleado
            // 
            this.TxtEmpleado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpleado.Location = new System.Drawing.Point(117, 68);
            this.TxtEmpleado.Name = "TxtEmpleado";
            this.TxtEmpleado.Size = new System.Drawing.Size(377, 26);
            this.TxtEmpleado.TabIndex = 4;
            // 
            // TxtHoras
            // 
            this.TxtHoras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHoras.Location = new System.Drawing.Point(86, 122);
            this.TxtHoras.Name = "TxtHoras";
            this.TxtHoras.Size = new System.Drawing.Size(100, 26);
            this.TxtHoras.TabIndex = 5;
            // 
            // TxtCostoHora
            // 
            this.TxtCostoHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCostoHora.Location = new System.Drawing.Point(333, 122);
            this.TxtCostoHora.Name = "TxtCostoHora";
            this.TxtCostoHora.Size = new System.Drawing.Size(161, 26);
            this.TxtCostoHora.TabIndex = 6;
            // 
            // BtnProcesar
            // 
            this.BtnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnProcesar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcesar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnProcesar.Location = new System.Drawing.Point(15, 177);
            this.BtnProcesar.Name = "BtnProcesar";
            this.BtnProcesar.Size = new System.Drawing.Size(110, 48);
            this.BtnProcesar.TabIndex = 7;
            this.BtnProcesar.Text = "PROCESAR";
            this.BtnProcesar.UseVisualStyleBackColor = false;
            this.BtnProcesar.Click += new System.EventHandler(this.BtnProcesar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnLimpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnLimpiar.Location = new System.Drawing.Point(410, 177);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(84, 48);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnSalir.Location = new System.Drawing.Point(12, 428);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(87, 48);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblMontoNeto);
            this.groupBox1.Controls.Add(this.LblMontoDescuento);
            this.groupBox1.Controls.Add(this.LblMontoBruto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 148);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUADRO DE RESUMEN";
            // 
            // LblMontoNeto
            // 
            this.LblMontoNeto.AutoSize = true;
            this.LblMontoNeto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontoNeto.Location = new System.Drawing.Point(374, 74);
            this.LblMontoNeto.Name = "LblMontoNeto";
            this.LblMontoNeto.Size = new System.Drawing.Size(17, 18);
            this.LblMontoNeto.TabIndex = 16;
            this.LblMontoNeto.Text = "0";
            // 
            // LblMontoDescuento
            // 
            this.LblMontoDescuento.AutoSize = true;
            this.LblMontoDescuento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontoDescuento.Location = new System.Drawing.Point(192, 74);
            this.LblMontoDescuento.Name = "LblMontoDescuento";
            this.LblMontoDescuento.Size = new System.Drawing.Size(17, 18);
            this.LblMontoDescuento.TabIndex = 15;
            this.LblMontoDescuento.Text = "0";
            // 
            // LblMontoBruto
            // 
            this.LblMontoBruto.AutoSize = true;
            this.LblMontoBruto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontoBruto.Location = new System.Drawing.Point(43, 74);
            this.LblMontoBruto.Name = "LblMontoBruto";
            this.LblMontoBruto.Size = new System.Drawing.Size(17, 18);
            this.LblMontoBruto.TabIndex = 14;
            this.LblMontoBruto.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "NETO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "DESCUENTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "BRUTO";
            // 
            // FrmPagoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnProcesar);
            this.Controls.Add(this.TxtCostoHora);
            this.Controls.Add(this.TxtHoras);
            this.Controls.Add(this.TxtEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPagoEmpleados";
            this.Text = "form1";
            this.Load += new System.EventHandler(this.FrmPagoEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmpleado;
        private System.Windows.Forms.TextBox TxtHoras;
        private System.Windows.Forms.TextBox TxtCostoHora;
        private System.Windows.Forms.Button BtnProcesar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblMontoNeto;
        private System.Windows.Forms.Label LblMontoDescuento;
        private System.Windows.Forms.Label LblMontoBruto;
    }
}


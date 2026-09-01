namespace NaturVida.App.UI
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DgvProductos = new DataGridView();
            CboCategoria = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            TxtNombre = new TextBox();
            TxtPrecio = new TextBox();
            label3 = new Label();
            label4 = new Label();
            NumStock = new NumericUpDown();
            LblId = new Label();
            BtnGuardar = new Button();
            BtnNuevo = new Button();
            BtnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumStock).BeginInit();
            SuspendLayout();
            // 
            // DgvProductos
            // 
            DgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProductos.Location = new Point(24, 22);
            DgvProductos.Name = "DgvProductos";
            DgvProductos.ReadOnly = true;
            DgvProductos.Size = new Size(345, 253);
            DgvProductos.TabIndex = 0;
            DgvProductos.CellClick += DgvProductos_CellClick;
            // 
            // CboCategoria
            // 
            CboCategoria.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CboCategoria.FormattingEnabled = true;
            CboCategoria.Items.AddRange(new object[] { "Seleccione..." });
            CboCategoria.Location = new Point(396, 43);
            CboCategoria.Name = "CboCategoria";
            CboCategoria.Size = new Size(193, 26);
            CboCategoria.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 22);
            label1.Name = "label1";
            label1.Size = new Size(87, 18);
            label1.TabIndex = 2;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(621, 22);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre.Location = new Point(621, 43);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(193, 26);
            TxtNombre.TabIndex = 4;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPrecio.Location = new Point(396, 114);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(193, 26);
            TxtPrecio.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(396, 93);
            label3.Name = "label3";
            label3.Size = new Size(60, 18);
            label3.TabIndex = 5;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(621, 93);
            label4.Name = "label4";
            label4.Size = new Size(54, 18);
            label4.TabIndex = 7;
            label4.Text = "Stock";
            // 
            // NumStock
            // 
            NumStock.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumStock.Location = new Point(621, 114);
            NumStock.Name = "NumStock";
            NumStock.Size = new Size(87, 26);
            NumStock.TabIndex = 9;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(776, 125);
            LblId.Name = "LblId";
            LblId.Size = new Size(38, 15);
            LblId.TabIndex = 10;
            LblId.Text = "label5";
            LblId.Visible = false;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.White;
            BtnGuardar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = SystemColors.ControlText;
            BtnGuardar.Location = new Point(396, 173);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(97, 35);
            BtnGuardar.TabIndex = 11;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.White;
            BtnNuevo.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNuevo.Location = new Point(509, 173);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(97, 35);
            BtnNuevo.TabIndex = 12;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.White;
            BtnEliminar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEliminar.Location = new Point(621, 173);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(97, 35);
            BtnEliminar.TabIndex = 13;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 295);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnGuardar);
            Controls.Add(LblId);
            Controls.Add(NumStock);
            Controls.Add(label4);
            Controls.Add(TxtPrecio);
            Controls.Add(label3);
            Controls.Add(TxtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CboCategoria);
            Controls.Add(DgvProductos);
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)DgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvProductos;
        private ComboBox CboCategoria;
        private Label label1;
        private Label label2;
        private TextBox TxtNombre;
        private TextBox TxtPrecio;
        private Label label3;
        private Label label4;
        private NumericUpDown NumStock;
        private Label LblId;
        private Button BtnGuardar;
        private Button BtnNuevo;
        private Button BtnEliminar;
    }
}
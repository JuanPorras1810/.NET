namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView2 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtNombre = new TextBox();
            TxtDescripcion = new TextBox();
            TxtMarca = new TextBox();
            TxtPrecio = new TextBox();
            TxtStock = new TextBox();
            BtnGuardar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Marca, Precio, Stock, Descripcion });
            dataGridView2.Location = new Point(41, 27);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(643, 311);
            dataGridView2.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Marca
            // 
            Marca.HeaderText = "Descripcion";
            Marca.Name = "Marca";
            // 
            // Precio
            // 
            Precio.HeaderText = "Marca";
            Precio.Name = "Precio";
            // 
            // Stock
            // 
            Stock.HeaderText = "Precio";
            Stock.Name = "Stock";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Stock";
            Descripcion.Name = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(789, 27);
            label1.Name = "label1";
            label1.Size = new Size(228, 24);
            label1.TabIndex = 2;
            label1.Text = "Gestion de productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(711, 82);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(711, 141);
            label3.Name = "label3";
            label3.Size = new Size(104, 18);
            label3.TabIndex = 4;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(711, 200);
            label4.Name = "label4";
            label4.Size = new Size(58, 18);
            label4.TabIndex = 5;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(711, 259);
            label5.Name = "label5";
            label5.Size = new Size(60, 18);
            label5.TabIndex = 6;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(711, 318);
            label6.Name = "label6";
            label6.Size = new Size(54, 18);
            label6.TabIndex = 7;
            label6.Text = "Stock";
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre.Location = new Point(821, 79);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(278, 26);
            TxtNombre.TabIndex = 8;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDescripcion.Location = new Point(821, 138);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(278, 26);
            TxtDescripcion.TabIndex = 9;
            // 
            // TxtMarca
            // 
            TxtMarca.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMarca.Location = new Point(821, 197);
            TxtMarca.Name = "TxtMarca";
            TxtMarca.Size = new Size(278, 26);
            TxtMarca.TabIndex = 10;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPrecio.Location = new Point(821, 259);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(278, 26);
            TxtPrecio.TabIndex = 11;
            // 
            // TxtStock
            // 
            TxtStock.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtStock.Location = new Point(821, 312);
            TxtStock.Name = "TxtStock";
            TxtStock.Size = new Size(278, 26);
            TxtStock.TabIndex = 12;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = Color.DodgerBlue;
            BtnGuardar.Location = new Point(885, 369);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(162, 49);
            BtnGuardar.TabIndex = 13;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEditar.ForeColor = Color.DodgerBlue;
            BtnEditar.Location = new Point(44, 369);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(162, 49);
            BtnEditar.TabIndex = 14;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEliminar.ForeColor = Color.DodgerBlue;
            BtnEliminar.Location = new Point(227, 369);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(162, 49);
            BtnEliminar.TabIndex = 15;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 450);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(TxtStock);
            Controls.Add(TxtPrecio);
            Controls.Add(TxtMarca);
            Controls.Add(TxtDescripcion);
            Controls.Add(TxtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtNombre;
        private TextBox TxtDescripcion;
        private TextBox TxtMarca;
        private TextBox TxtPrecio;
        private TextBox TxtStock;
        private Button BtnGuardar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Descripcion;
    }
}

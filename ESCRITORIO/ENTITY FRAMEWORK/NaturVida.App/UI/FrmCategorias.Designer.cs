namespace NaturVida.App.UI
{
    partial class FrmCategorias
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
            DgvCategorias = new DataGridView();
            label1 = new Label();
            TxtNombre = new TextBox();
            ChkActivo = new CheckBox();
            BtnGuardar = new Button();
            BtnEliminar = new Button();
            BtnNuevo = new Button();
            LblId = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // DgvCategorias
            // 
            DgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCategorias.Location = new Point(23, 26);
            DgvCategorias.Name = "DgvCategorias";
            DgvCategorias.ReadOnly = true;
            DgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCategorias.Size = new Size(242, 236);
            DgvCategorias.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 26);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre.Location = new Point(302, 47);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(227, 26);
            TxtNombre.TabIndex = 2;
            // 
            // ChkActivo
            // 
            ChkActivo.AutoSize = true;
            ChkActivo.Checked = true;
            ChkActivo.CheckState = CheckState.Checked;
            ChkActivo.Location = new Point(535, 52);
            ChkActivo.Name = "ChkActivo";
            ChkActivo.Size = new Size(60, 19);
            ChkActivo.TabIndex = 3;
            ChkActivo.Text = "Activo";
            ChkActivo.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.White;
            BtnGuardar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = SystemColors.ControlText;
            BtnGuardar.Location = new Point(302, 109);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(105, 34);
            BtnGuardar.TabIndex = 4;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.White;
            BtnEliminar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEliminar.ForeColor = SystemColors.ControlText;
            BtnEliminar.Location = new Point(548, 109);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(105, 34);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.White;
            BtnNuevo.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNuevo.ForeColor = SystemColors.ControlText;
            BtnNuevo.Location = new Point(424, 109);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(105, 34);
            BtnNuevo.TabIndex = 6;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(624, 263);
            LblId.Name = "LblId";
            LblId.Size = new Size(38, 15);
            LblId.TabIndex = 7;
            LblId.Text = "label2";
            LblId.Visible = false;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 287);
            Controls.Add(LblId);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnGuardar);
            Controls.Add(ChkActivo);
            Controls.Add(TxtNombre);
            Controls.Add(label1);
            Controls.Add(DgvCategorias);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)DgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvCategorias;
        private Label label1;
        private TextBox TxtNombre;
        private CheckBox ChkActivo;
        private Button BtnGuardar;
        private Button BtnNuevo;
        private Label LblId;
        private Button BtnEliminar;
    }
}
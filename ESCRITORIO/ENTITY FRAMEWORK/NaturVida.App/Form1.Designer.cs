namespace NaturVida.App
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
            DgvCategorias = new DataGridView();
            Txtnombre = new TextBox();
            label1 = new Label();
            LblID = new Label();
            checkBox1 = new CheckBox();
            BtnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // DgvCategorias
            // 
            DgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCategorias.Location = new Point(12, 12);
            DgvCategorias.Name = "DgvCategorias";
            DgvCategorias.Size = new Size(240, 322);
            DgvCategorias.TabIndex = 0;
            // 
            // Txtnombre
            // 
            Txtnombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtnombre.Location = new Point(316, 33);
            Txtnombre.Name = "Txtnombre";
            Txtnombre.Size = new Size(191, 26);
            Txtnombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 12);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // LblID
            // 
            LblID.AutoSize = true;
            LblID.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblID.Location = new Point(652, 117);
            LblID.Name = "LblID";
            LblID.Size = new Size(71, 18);
            LblID.TabIndex = 3;
            LblID.Text = "Nombre";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(520, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnGuardar.Location = new Point(312, 224);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(88, 38);
            BtnGuardar.TabIndex = 5;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGuardar);
            Controls.Add(checkBox1);
            Controls.Add(LblID);
            Controls.Add(label1);
            Controls.Add(Txtnombre);
            Controls.Add(DgvCategorias);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvCategorias;
        private TextBox Txtnombre;
        private Label label1;
        private Label LblID;
        private CheckBox checkBox1;
        private Button BtnGuardar;
    }
}

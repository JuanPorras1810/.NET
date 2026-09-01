namespace NaturVida.App.UI
{
    partial class FrmMenu
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
            PanelMenu = new Panel();
            BtnProductos = new Button();
            BtnCategorias = new Button();
            label2 = new Label();
            PanelContenido = new Panel();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(15, 23, 42);
            PanelMenu.Controls.Add(BtnProductos);
            PanelMenu.Controls.Add(BtnCategorias);
            PanelMenu.Controls.Add(label2);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Padding = new Padding(10);
            PanelMenu.Size = new Size(200, 314);
            PanelMenu.TabIndex = 0;
            // 
            // BtnProductos
            // 
            BtnProductos.FlatStyle = FlatStyle.Flat;
            BtnProductos.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnProductos.ForeColor = Color.FromArgb(59, 130, 246);
            BtnProductos.Location = new Point(0, 135);
            BtnProductos.Margin = new Padding(3, 5, 3, 3);
            BtnProductos.Name = "BtnProductos";
            BtnProductos.Size = new Size(200, 50);
            BtnProductos.TabIndex = 5;
            BtnProductos.Text = "Productos";
            BtnProductos.UseVisualStyleBackColor = true;
            // 
            // BtnCategorias
            // 
            BtnCategorias.FlatStyle = FlatStyle.Flat;
            BtnCategorias.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCategorias.ForeColor = Color.FromArgb(59, 130, 246);
            BtnCategorias.Location = new Point(0, 87);
            BtnCategorias.Margin = new Padding(3, 5, 3, 3);
            BtnCategorias.Name = "BtnCategorias";
            BtnCategorias.Size = new Size(200, 50);
            BtnCategorias.TabIndex = 3;
            BtnCategorias.Text = "Categorías";
            BtnCategorias.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(180, 60);
            label2.TabIndex = 2;
            label2.Text = "NaturVida";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelContenido
            // 
            PanelContenido.BackColor = Color.FromArgb(243, 244, 246);
            PanelContenido.Dock = DockStyle.Fill;
            PanelContenido.Location = new Point(200, 0);
            PanelContenido.Name = "PanelContenido";
            PanelContenido.Size = new Size(856, 314);
            PanelContenido.TabIndex = 1;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 314);
            Controls.Add(PanelContenido);
            Controls.Add(PanelMenu);
            Name = "FrmMenu";
            Text = "FrmMenu";
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelContenido;
        private Label label2;
        private Button BtnCategorias;
        private Button BtnProductos;
    }
}
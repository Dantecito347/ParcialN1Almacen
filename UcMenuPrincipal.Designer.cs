namespace Parcial_Nº1___Almacen
{
    partial class UcMenuPrincipal
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuProductos = new System.Windows.Forms.Button();
            this.MenuCarrito = new System.Windows.Forms.Button();
            this.MenuEnvios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parcial_Nº1___Almacen.Properties.Resources.WhatsApp_Image_2025_05_02_at_11_30_58;
            this.pictureBox1.Location = new System.Drawing.Point(264, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MenuProductos
            // 
            this.MenuProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.MenuProductos.Location = new System.Drawing.Point(16, 217);
            this.MenuProductos.Name = "MenuProductos";
            this.MenuProductos.Size = new System.Drawing.Size(141, 64);
            this.MenuProductos.TabIndex = 2;
            this.MenuProductos.Text = "PRODUCTOS";
            this.MenuProductos.UseVisualStyleBackColor = true;
            this.MenuProductos.Click += new System.EventHandler(this.MenuProductos_Click);
            // 
            // MenuCarrito
            // 
            this.MenuCarrito.Location = new System.Drawing.Point(314, 309);
            this.MenuCarrito.Name = "MenuCarrito";
            this.MenuCarrito.Size = new System.Drawing.Size(114, 50);
            this.MenuCarrito.TabIndex = 5;
            this.MenuCarrito.Text = "CARRITO";
            this.MenuCarrito.UseVisualStyleBackColor = true;
            this.MenuCarrito.Click += new System.EventHandler(this.MenuCarrito_Click);
            // 
            // MenuEnvios
            // 
            this.MenuEnvios.Cursor = System.Windows.Forms.Cursors.Default;
            this.MenuEnvios.Location = new System.Drawing.Point(564, 217);
            this.MenuEnvios.Name = "MenuEnvios";
            this.MenuEnvios.Size = new System.Drawing.Size(141, 64);
            this.MenuEnvios.TabIndex = 7;
            this.MenuEnvios.Text = "ENVIOS";
            this.MenuEnvios.UseVisualStyleBackColor = true;
            this.MenuEnvios.Click += new System.EventHandler(this.MenuEnvios_Click);
            // 
            // UcMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.MenuEnvios);
            this.Controls.Add(this.MenuCarrito);
            this.Controls.Add(this.MenuProductos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UcMenuPrincipal";
            this.Size = new System.Drawing.Size(730, 362);
            this.Load += new System.EventHandler(this.UcMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MenuProductos;
        private System.Windows.Forms.Button MenuCarrito;
        private System.Windows.Forms.Button MenuEnvios;
    }
}

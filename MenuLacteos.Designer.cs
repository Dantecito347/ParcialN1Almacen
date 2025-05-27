namespace Parcial_Nº1___Almacen
{
    partial class MenuLacteos
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
            this.label7 = new System.Windows.Forms.Label();
            this.BotonRetroceder = new System.Windows.Forms.Button();
            this.listviewLacteos = new System.Windows.Forms.ListView();
            this.VerCarrito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(139, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(473, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Elija los productos que desea comprar";
            // 
            // BotonRetroceder
            // 
            this.BotonRetroceder.Location = new System.Drawing.Point(12, 45);
            this.BotonRetroceder.Name = "BotonRetroceder";
            this.BotonRetroceder.Size = new System.Drawing.Size(101, 37);
            this.BotonRetroceder.TabIndex = 13;
            this.BotonRetroceder.Text = "ATRAS";
            this.BotonRetroceder.UseVisualStyleBackColor = true;
            this.BotonRetroceder.Click += new System.EventHandler(this.BotonRetroceder_Click);
            // 
            // listviewLacteos
            // 
            this.listviewLacteos.HideSelection = false;
            this.listviewLacteos.Location = new System.Drawing.Point(115, 141);
            this.listviewLacteos.Name = "listviewLacteos";
            this.listviewLacteos.Size = new System.Drawing.Size(515, 181);
            this.listviewLacteos.TabIndex = 14;
            this.listviewLacteos.UseCompatibleStateImageBehavior = false;
            this.listviewLacteos.SelectedIndexChanged += new System.EventHandler(this.listviewLacteos_SelectedIndexChanged);
            // 
            // VerCarrito
            // 
            this.VerCarrito.Location = new System.Drawing.Point(11, 321);
            this.VerCarrito.Name = "VerCarrito";
            this.VerCarrito.Size = new System.Drawing.Size(102, 50);
            this.VerCarrito.TabIndex = 18;
            this.VerCarrito.Text = "VER CARRITO";
            this.VerCarrito.UseVisualStyleBackColor = true;
            this.VerCarrito.Click += new System.EventHandler(this.VerCarrito_Click);
            // 
            // MenuLacteos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.VerCarrito);
            this.Controls.Add(this.listviewLacteos);
            this.Controls.Add(this.BotonRetroceder);
            this.Controls.Add(this.label7);
            this.Name = "MenuLacteos";
            this.Size = new System.Drawing.Size(750, 406);
            this.Load += new System.EventHandler(this.MenuLacteos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BotonRetroceder;
        private System.Windows.Forms.ListView listviewLacteos;
        private System.Windows.Forms.Button VerCarrito;
    }
}

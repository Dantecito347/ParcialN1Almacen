namespace Parcial_Nº1___Almacen
{
    partial class UcMenuAlimentos
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
            this.listviewAlimentos = new System.Windows.Forms.ListView();
            this.VerCarrito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(204, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(473, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Elija los productos que desea comprar";
            // 
            // BotonRetroceder
            // 
            this.BotonRetroceder.Location = new System.Drawing.Point(16, 39);
            this.BotonRetroceder.Name = "BotonRetroceder";
            this.BotonRetroceder.Size = new System.Drawing.Size(101, 37);
            this.BotonRetroceder.TabIndex = 11;
            this.BotonRetroceder.Text = "ATRAS";
            this.BotonRetroceder.UseVisualStyleBackColor = true;
            this.BotonRetroceder.Click += new System.EventHandler(this.BotonRetroceder_Click);
            // 
            // listviewAlimentos
            // 
            this.listviewAlimentos.HideSelection = false;
            this.listviewAlimentos.Location = new System.Drawing.Point(114, 112);
            this.listviewAlimentos.Name = "listviewAlimentos";
            this.listviewAlimentos.Size = new System.Drawing.Size(614, 251);
            this.listviewAlimentos.TabIndex = 12;
            this.listviewAlimentos.UseCompatibleStateImageBehavior = false;
            this.listviewAlimentos.SelectedIndexChanged += new System.EventHandler(this.listviewAlimentos_SelectedIndexChanged);
            // 
            // VerCarrito
            // 
            this.VerCarrito.Location = new System.Drawing.Point(6, 337);
            this.VerCarrito.Name = "VerCarrito";
            this.VerCarrito.Size = new System.Drawing.Size(102, 50);
            this.VerCarrito.TabIndex = 13;
            this.VerCarrito.Text = "VER CARRITO";
            this.VerCarrito.UseVisualStyleBackColor = true;
            this.VerCarrito.Click += new System.EventHandler(this.VerCarrito_Click);
            // 
            // UcMenuAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.VerCarrito);
            this.Controls.Add(this.listviewAlimentos);
            this.Controls.Add(this.BotonRetroceder);
            this.Controls.Add(this.label7);
            this.Name = "UcMenuAlimentos";
            this.Size = new System.Drawing.Size(881, 413);
            this.Load += new System.EventHandler(this.UcMenuAlimentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BotonRetroceder;
        private System.Windows.Forms.ListView listviewAlimentos;
        private System.Windows.Forms.Button VerCarrito;
    }
}

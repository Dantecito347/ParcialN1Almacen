namespace Parcial_Nº1___Almacen
{
    partial class MenuEnvios
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
            this.listViewRepartidores = new System.Windows.Forms.ListView();
            this.VerCarrito = new System.Windows.Forms.Button();
            this.btnAgregarRepartidor = new System.Windows.Forms.Button();
            this.btnBorrarRepartidor = new System.Windows.Forms.Button();
            this.btnModificarRepartidor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(134, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(517, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Seleccione el repartidor que desea entregar sus productos";
            // 
            // BotonRetroceder
            // 
            this.BotonRetroceder.Location = new System.Drawing.Point(13, 80);
            this.BotonRetroceder.Name = "BotonRetroceder";
            this.BotonRetroceder.Size = new System.Drawing.Size(85, 45);
            this.BotonRetroceder.TabIndex = 14;
            this.BotonRetroceder.Text = "ATRAS";
            this.BotonRetroceder.UseVisualStyleBackColor = true;
            this.BotonRetroceder.Click += new System.EventHandler(this.BotonRetroceder_Click);
            // 
            // listViewRepartidores
            // 
            this.listViewRepartidores.HideSelection = false;
            this.listViewRepartidores.Location = new System.Drawing.Point(107, 154);
            this.listViewRepartidores.Name = "listViewRepartidores";
            this.listViewRepartidores.Size = new System.Drawing.Size(491, 153);
            this.listViewRepartidores.TabIndex = 15;
            this.listViewRepartidores.UseCompatibleStateImageBehavior = false;
            this.listViewRepartidores.SelectedIndexChanged += new System.EventHandler(this.listViewRepartidores_SelectedIndexChanged);
            // 
            // VerCarrito
            // 
            this.VerCarrito.Location = new System.Drawing.Point(13, 335);
            this.VerCarrito.Name = "VerCarrito";
            this.VerCarrito.Size = new System.Drawing.Size(85, 45);
            this.VerCarrito.TabIndex = 16;
            this.VerCarrito.Text = "VER CARRITO";
            this.VerCarrito.UseVisualStyleBackColor = true;
            this.VerCarrito.Click += new System.EventHandler(this.VerCarrito_Click);
            // 
            // btnAgregarRepartidor
            // 
            this.btnAgregarRepartidor.Location = new System.Drawing.Point(604, 154);
            this.btnAgregarRepartidor.Name = "btnAgregarRepartidor";
            this.btnAgregarRepartidor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarRepartidor.TabIndex = 17;
            this.btnAgregarRepartidor.Text = "AGREGAR";
            this.btnAgregarRepartidor.UseVisualStyleBackColor = true;
            this.btnAgregarRepartidor.Click += new System.EventHandler(this.btnAgregarRepartidor_Click);
            // 
            // btnBorrarRepartidor
            // 
            this.btnBorrarRepartidor.Location = new System.Drawing.Point(604, 218);
            this.btnBorrarRepartidor.Name = "btnBorrarRepartidor";
            this.btnBorrarRepartidor.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarRepartidor.TabIndex = 18;
            this.btnBorrarRepartidor.Text = "BORRAR";
            this.btnBorrarRepartidor.UseVisualStyleBackColor = true;
            this.btnBorrarRepartidor.Click += new System.EventHandler(this.btnBorrarRepartidor_Click);
            // 
            // btnModificarRepartidor
            // 
            this.btnModificarRepartidor.Location = new System.Drawing.Point(604, 284);
            this.btnModificarRepartidor.Name = "btnModificarRepartidor";
            this.btnModificarRepartidor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarRepartidor.TabIndex = 19;
            this.btnModificarRepartidor.Text = "MODIFICAR";
            this.btnModificarRepartidor.UseVisualStyleBackColor = true;
            this.btnModificarRepartidor.Click += new System.EventHandler(this.btnModificarRepartidor_Click);
            // 
            // MenuEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnModificarRepartidor);
            this.Controls.Add(this.btnBorrarRepartidor);
            this.Controls.Add(this.btnAgregarRepartidor);
            this.Controls.Add(this.VerCarrito);
            this.Controls.Add(this.listViewRepartidores);
            this.Controls.Add(this.BotonRetroceder);
            this.Controls.Add(this.label7);
            this.Name = "MenuEnvios";
            this.Size = new System.Drawing.Size(786, 404);
            this.Load += new System.EventHandler(this.MenuEnvios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BotonRetroceder;
        private System.Windows.Forms.ListView listViewRepartidores;
        private System.Windows.Forms.Button VerCarrito;
        private System.Windows.Forms.Button btnAgregarRepartidor;
        private System.Windows.Forms.Button btnBorrarRepartidor;
        private System.Windows.Forms.Button btnModificarRepartidor;
    }
}

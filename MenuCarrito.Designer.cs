namespace Parcial_Nº1___Almacen
{
    partial class MenuCarrito
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.lblRepartidor = new System.Windows.Forms.Label();
            this.FinalizarCompra = new System.Windows.Forms.Button();
            this.Retroceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(311, 186);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(337, 31);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 46);
            this.Agregar.TabIndex = 3;
            this.Agregar.Text = "AGREGAR";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(337, 83);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 46);
            this.Modificar.TabIndex = 4;
            this.Modificar.Text = "MODIFICAR";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(337, 135);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 46);
            this.Borrar.TabIndex = 5;
            this.Borrar.Text = "BORRAR";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // lblRepartidor
            // 
            this.lblRepartidor.AutoSize = true;
            this.lblRepartidor.Location = new System.Drawing.Point(29, 241);
            this.lblRepartidor.Name = "lblRepartidor";
            this.lblRepartidor.Size = new System.Drawing.Size(35, 13);
            this.lblRepartidor.TabIndex = 10;
            this.lblRepartidor.Text = "label1";
            // 
            // FinalizarCompra
            // 
            this.FinalizarCompra.Location = new System.Drawing.Point(228, 223);
            this.FinalizarCompra.Name = "FinalizarCompra";
            this.FinalizarCompra.Size = new System.Drawing.Size(103, 42);
            this.FinalizarCompra.TabIndex = 11;
            this.FinalizarCompra.Text = "FINALIZAR COMPRA";
            this.FinalizarCompra.UseVisualStyleBackColor = true;
            this.FinalizarCompra.Click += new System.EventHandler(this.FinalizarCompra_Click);
            // 
            // Retroceder
            // 
            this.Retroceder.Location = new System.Drawing.Point(20, 282);
            this.Retroceder.Name = "Retroceder";
            this.Retroceder.Size = new System.Drawing.Size(75, 23);
            this.Retroceder.TabIndex = 12;
            this.Retroceder.Text = "ATRAS";
            this.Retroceder.UseVisualStyleBackColor = true;
            this.Retroceder.Click += new System.EventHandler(this.Retroceder_Click);
            // 
            // MenuCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.Retroceder);
            this.Controls.Add(this.FinalizarCompra);
            this.Controls.Add(this.lblRepartidor);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.listBox1);
            this.Name = "MenuCarrito";
            this.Size = new System.Drawing.Size(572, 380);
            this.Load += new System.EventHandler(this.MenuCarrito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Label lblRepartidor;
        private System.Windows.Forms.Button FinalizarCompra;
        private System.Windows.Forms.Button Retroceder;
    }
}

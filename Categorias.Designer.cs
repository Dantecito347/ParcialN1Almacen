namespace Parcial_Nº1___Almacen
{
    partial class UcPRODUCTOS
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
            this.label1 = new System.Windows.Forms.Label();
            this.MenuAlimentos = new System.Windows.Forms.Button();
            this.MenuBebidas = new System.Windows.Forms.Button();
            this.MenuLacteos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonRetroceder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(350, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una categoria";
            // 
            // MenuAlimentos
            // 
            this.MenuAlimentos.Cursor = System.Windows.Forms.Cursors.Default;
            this.MenuAlimentos.Location = new System.Drawing.Point(211, 165);
            this.MenuAlimentos.Name = "MenuAlimentos";
            this.MenuAlimentos.Size = new System.Drawing.Size(132, 63);
            this.MenuAlimentos.TabIndex = 1;
            this.MenuAlimentos.Text = "ALIMENTOS";
            this.MenuAlimentos.UseVisualStyleBackColor = true;
            this.MenuAlimentos.Click += new System.EventHandler(this.MenuAlimentos_Click);
            // 
            // MenuBebidas
            // 
            this.MenuBebidas.Cursor = System.Windows.Forms.Cursors.Default;
            this.MenuBebidas.Location = new System.Drawing.Point(441, 165);
            this.MenuBebidas.Name = "MenuBebidas";
            this.MenuBebidas.Size = new System.Drawing.Size(132, 63);
            this.MenuBebidas.TabIndex = 2;
            this.MenuBebidas.Text = "BEBIDAS";
            this.MenuBebidas.UseVisualStyleBackColor = true;
            this.MenuBebidas.Click += new System.EventHandler(this.MenuBebidas_Click);
            // 
            // MenuLacteos
            // 
            this.MenuLacteos.Cursor = System.Windows.Forms.Cursors.Default;
            this.MenuLacteos.Location = new System.Drawing.Point(667, 165);
            this.MenuLacteos.Name = "MenuLacteos";
            this.MenuLacteos.Size = new System.Drawing.Size(132, 63);
            this.MenuLacteos.TabIndex = 3;
            this.MenuLacteos.Text = "LACTEOS";
            this.MenuLacteos.UseVisualStyleBackColor = true;
            this.MenuLacteos.Click += new System.EventHandler(this.MenuLacteos_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.BotonRetroceder);
            this.panel1.Controls.Add(this.MenuLacteos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MenuAlimentos);
            this.panel1.Controls.Add(this.MenuBebidas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 293);
            this.panel1.TabIndex = 4;
            // 
            // BotonRetroceder
            // 
            this.BotonRetroceder.Location = new System.Drawing.Point(102, 49);
            this.BotonRetroceder.Name = "BotonRetroceder";
            this.BotonRetroceder.Size = new System.Drawing.Size(107, 40);
            this.BotonRetroceder.TabIndex = 12;
            this.BotonRetroceder.Text = "ATRAS";
            this.BotonRetroceder.UseVisualStyleBackColor = true;
            this.BotonRetroceder.Click += new System.EventHandler(this.BotonRetroceder_Click);
            // 
            // UcPRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "UcPRODUCTOS";
            this.Size = new System.Drawing.Size(886, 293);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MenuAlimentos;
        private System.Windows.Forms.Button MenuBebidas;
        private System.Windows.Forms.Button MenuLacteos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonRetroceder;
    }
}

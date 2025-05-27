namespace Parcial_Nº1___Almacen
{
    partial class UcMenuBebidas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listviewBebidas = new System.Windows.Forms.ListView();
            this.VerCarrito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(154, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(473, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Elija los productos que desea comprar";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(266, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(234, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(148, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 31);
            this.label6.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "ATRAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listviewBebidas
            // 
            this.listviewBebidas.HideSelection = false;
            this.listviewBebidas.Location = new System.Drawing.Point(121, 103);
            this.listviewBebidas.Name = "listviewBebidas";
            this.listviewBebidas.Size = new System.Drawing.Size(553, 201);
            this.listviewBebidas.TabIndex = 16;
            this.listviewBebidas.UseCompatibleStateImageBehavior = false;
            this.listviewBebidas.SelectedIndexChanged += new System.EventHandler(this.listviewBebidas_SelectedIndexChanged);
            // 
            // VerCarrito
            // 
            this.VerCarrito.Location = new System.Drawing.Point(3, 298);
            this.VerCarrito.Name = "VerCarrito";
            this.VerCarrito.Size = new System.Drawing.Size(102, 50);
            this.VerCarrito.TabIndex = 17;
            this.VerCarrito.Text = "VER CARRITO";
            this.VerCarrito.UseVisualStyleBackColor = true;
            this.VerCarrito.Click += new System.EventHandler(this.VerCarrito_Click);
            // 
            // UcMenuBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.VerCarrito);
            this.Controls.Add(this.listviewBebidas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "UcMenuBebidas";
            this.Size = new System.Drawing.Size(803, 534);
            this.Load += new System.EventHandler(this.MenuBebidas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listviewBebidas;
        private System.Windows.Forms.Button VerCarrito;
    }
}

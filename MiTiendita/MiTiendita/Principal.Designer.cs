namespace MiTiendita
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ventas = new System.Windows.Forms.Button();
            this.Compras = new System.Windows.Forms.Button();
            this.Proveedor = new System.Windows.Forms.Button();
            this.clientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Ventas
            // 
            this.Ventas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Ventas.Location = new System.Drawing.Point(186, 325);
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(87, 35);
            this.Ventas.TabIndex = 6;
            this.Ventas.Text = "Ventas";
            this.Ventas.UseVisualStyleBackColor = false;
            this.Ventas.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // Compras
            // 
            this.Compras.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Compras.Location = new System.Drawing.Point(322, 325);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(84, 35);
            this.Compras.TabIndex = 7;
            this.Compras.Text = "Compras";
            this.Compras.UseVisualStyleBackColor = false;
            this.Compras.Click += new System.EventHandler(this.Compras_Click);
            // 
            // Proveedor
            // 
            this.Proveedor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Proveedor.Location = new System.Drawing.Point(442, 325);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(79, 35);
            this.Proveedor.TabIndex = 8;
            this.Proveedor.Text = "Proveedores";
            this.Proveedor.UseVisualStyleBackColor = false;
            this.Proveedor.Click += new System.EventHandler(this.Proveedor_Click);
            // 
            // clientes
            // 
            this.clientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clientes.Location = new System.Drawing.Point(56, 325);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(94, 35);
            this.clientes.TabIndex = 9;
            this.clientes.Text = "Clientes";
            this.clientes.UseVisualStyleBackColor = false;
            this.clientes.Click += new System.EventHandler(this.clientes_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(655, 401);
            this.Controls.Add(this.clientes);
            this.Controls.Add(this.Proveedor);
            this.Controls.Add(this.Compras);
            this.Controls.Add(this.Ventas);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Principal";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Ventas;
        private System.Windows.Forms.Button Compras;
        private System.Windows.Forms.Button Proveedor;
        private System.Windows.Forms.Button clientes;
    }
}


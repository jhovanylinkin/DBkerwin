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
            this.Agregar = new System.Windows.Forms.Button();
            this.Clietes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Desconectar = new System.Windows.Forms.Button();
            this.Ventas = new System.Windows.Forms.Button();
            this.Compras = new System.Windows.Forms.Button();
            this.Proveedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(23, 325);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(85, 35);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Productos";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clietes
            // 
            this.Clietes.Location = new System.Drawing.Point(125, 325);
            this.Clietes.Name = "Clietes";
            this.Clietes.Size = new System.Drawing.Size(91, 35);
            this.Clietes.TabIndex = 2;
            this.Clietes.Text = "Clientes";
            this.Clietes.UseVisualStyleBackColor = true;
            this.Clietes.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Desconectar
            // 
            this.Desconectar.Location = new System.Drawing.Point(552, 339);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(91, 35);
            this.Desconectar.TabIndex = 5;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // Ventas
            // 
            this.Ventas.Location = new System.Drawing.Point(233, 325);
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(87, 35);
            this.Ventas.TabIndex = 6;
            this.Ventas.Text = "Ventas";
            this.Ventas.UseVisualStyleBackColor = true;
            // 
            // Compras
            // 
            this.Compras.Location = new System.Drawing.Point(340, 325);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(84, 35);
            this.Compras.TabIndex = 7;
            this.Compras.Text = "Compras";
            this.Compras.UseVisualStyleBackColor = true;
            // 
            // Proveedor
            // 
            this.Proveedor.Location = new System.Drawing.Point(442, 325);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(79, 35);
            this.Proveedor.TabIndex = 8;
            this.Proveedor.Text = "Proveedores";
            this.Proveedor.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 401);
            this.Controls.Add(this.Proveedor);
            this.Controls.Add(this.Compras);
            this.Controls.Add(this.Ventas);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Clietes);
            this.Controls.Add(this.Agregar);
            this.Name = "Principal";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Clietes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.Button Ventas;
        private System.Windows.Forms.Button Compras;
        private System.Windows.Forms.Button Proveedor;
    }
}


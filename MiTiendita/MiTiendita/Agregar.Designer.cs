namespace MiTiendita
{
    partial class Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreAgregar = new System.Windows.Forms.TextBox();
            this.UnidadAgregar = new System.Windows.Forms.TextBox();
            this.PrecioAgregar = new System.Windows.Forms.TextBox();
            this.CantidadCantidad = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IDAgregar = new System.Windows.Forms.TextBox();
            this.ActualizartoProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // NombreAgregar
            // 
            this.NombreAgregar.Location = new System.Drawing.Point(93, 76);
            this.NombreAgregar.Name = "NombreAgregar";
            this.NombreAgregar.Size = new System.Drawing.Size(144, 20);
            this.NombreAgregar.TabIndex = 5;
            this.NombreAgregar.TextChanged += new System.EventHandler(this.NombreAgregar_TextChanged);
            // 
            // UnidadAgregar
            // 
            this.UnidadAgregar.Location = new System.Drawing.Point(93, 122);
            this.UnidadAgregar.Name = "UnidadAgregar";
            this.UnidadAgregar.Size = new System.Drawing.Size(144, 20);
            this.UnidadAgregar.TabIndex = 6;
            this.UnidadAgregar.TextChanged += new System.EventHandler(this.UnidadAgregar_TextChanged);
            // 
            // PrecioAgregar
            // 
            this.PrecioAgregar.Location = new System.Drawing.Point(93, 170);
            this.PrecioAgregar.Name = "PrecioAgregar";
            this.PrecioAgregar.Size = new System.Drawing.Size(100, 20);
            this.PrecioAgregar.TabIndex = 7;
            this.PrecioAgregar.TextChanged += new System.EventHandler(this.PrecioAgregar_TextChanged);
            // 
            // CantidadCantidad
            // 
            this.CantidadCantidad.Location = new System.Drawing.Point(93, 217);
            this.CantidadCantidad.Name = "CantidadCantidad";
            this.CantidadCantidad.Size = new System.Drawing.Size(57, 20);
            this.CantidadCantidad.TabIndex = 8;
            this.CantidadCantidad.TextChanged += new System.EventHandler(this.CantidadCantidad_TextChanged);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Guardar.Location = new System.Drawing.Point(46, 323);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 9;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // IDAgregar
            // 
            this.IDAgregar.Location = new System.Drawing.Point(93, 32);
            this.IDAgregar.Name = "IDAgregar";
            this.IDAgregar.Size = new System.Drawing.Size(75, 20);
            this.IDAgregar.TabIndex = 13;
            this.IDAgregar.TextChanged += new System.EventHandler(this.IDAgregar_TextChanged);
            // 
            // ActualizartoProductos
            // 
            this.ActualizartoProductos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ActualizartoProductos.Location = new System.Drawing.Point(148, 323);
            this.ActualizartoProductos.Name = "ActualizartoProductos";
            this.ActualizartoProductos.Size = new System.Drawing.Size(115, 23);
            this.ActualizartoProductos.TabIndex = 15;
            this.ActualizartoProductos.Text = "Actualizar";
            this.ActualizartoProductos.UseVisualStyleBackColor = false;
            this.ActualizartoProductos.Click += new System.EventHandler(this.ActualizartoProductos_Click);
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 375);
            this.Controls.Add(this.ActualizartoProductos);
            this.Controls.Add(this.IDAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.CantidadCantidad);
            this.Controls.Add(this.PrecioAgregar);
            this.Controls.Add(this.UnidadAgregar);
            this.Controls.Add(this.NombreAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreAgregar;
        private System.Windows.Forms.TextBox UnidadAgregar;
        private System.Windows.Forms.TextBox PrecioAgregar;
        private System.Windows.Forms.TextBox CantidadCantidad;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDAgregar;
        private System.Windows.Forms.Button ActualizartoProductos;
    }
}
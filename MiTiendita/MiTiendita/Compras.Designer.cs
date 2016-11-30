namespace MiTiendita
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.AgregarCompra = new System.Windows.Forms.Button();
            this.BuscarCompra = new System.Windows.Forms.Button();
            this.BorrarCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreCompra = new System.Windows.Forms.TextBox();
            this.TotalCompra = new System.Windows.Forms.TextBox();
            this.FechaCompra = new System.Windows.Forms.TextBox();
            this.CantidadCompra = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.Label();
            this.PrecioCompra = new System.Windows.Forms.TextBox();
            this.ListaCompra = new System.Windows.Forms.DataGridView();
            this.ActualizarCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarCompra
            // 
            this.AgregarCompra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AgregarCompra.Location = new System.Drawing.Point(15, 334);
            this.AgregarCompra.Name = "AgregarCompra";
            this.AgregarCompra.Size = new System.Drawing.Size(75, 23);
            this.AgregarCompra.TabIndex = 0;
            this.AgregarCompra.Text = "Agregar";
            this.AgregarCompra.UseVisualStyleBackColor = false;
            // 
            // BuscarCompra
            // 
            this.BuscarCompra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BuscarCompra.Location = new System.Drawing.Point(96, 334);
            this.BuscarCompra.Name = "BuscarCompra";
            this.BuscarCompra.Size = new System.Drawing.Size(75, 23);
            this.BuscarCompra.TabIndex = 1;
            this.BuscarCompra.Text = "Buscar";
            this.BuscarCompra.UseVisualStyleBackColor = false;
            // 
            // BorrarCompra
            // 
            this.BorrarCompra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BorrarCompra.Location = new System.Drawing.Point(177, 334);
            this.BorrarCompra.Name = "BorrarCompra";
            this.BorrarCompra.Size = new System.Drawing.Size(75, 23);
            this.BorrarCompra.TabIndex = 2;
            this.BorrarCompra.Text = "Borrar";
            this.BorrarCompra.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(498, 51);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 5;
            this.Total.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad";
            // 
            // NombreCompra
            // 
            this.NombreCompra.Location = new System.Drawing.Point(96, 16);
            this.NombreCompra.Name = "NombreCompra";
            this.NombreCompra.Size = new System.Drawing.Size(100, 20);
            this.NombreCompra.TabIndex = 8;
            // 
            // TotalCompra
            // 
            this.TotalCompra.Location = new System.Drawing.Point(535, 48);
            this.TotalCompra.Name = "TotalCompra";
            this.TotalCompra.Size = new System.Drawing.Size(100, 20);
            this.TotalCompra.TabIndex = 9;
            // 
            // FechaCompra
            // 
            this.FechaCompra.Location = new System.Drawing.Point(282, 16);
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.Size = new System.Drawing.Size(110, 20);
            this.FechaCompra.TabIndex = 10;
            // 
            // CantidadCompra
            // 
            this.CantidadCompra.Location = new System.Drawing.Point(96, 51);
            this.CantidadCompra.Name = "CantidadCompra";
            this.CantidadCompra.Size = new System.Drawing.Size(100, 20);
            this.CantidadCompra.TabIndex = 11;
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(241, 51);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(37, 13);
            this.Precio.TabIndex = 12;
            this.Precio.Text = "Precio";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.Location = new System.Drawing.Point(282, 48);
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Size = new System.Drawing.Size(110, 20);
            this.PrecioCompra.TabIndex = 13;
            // 
            // ListaCompra
            // 
            this.ListaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaCompra.Location = new System.Drawing.Point(40, 75);
            this.ListaCompra.Name = "ListaCompra";
            this.ListaCompra.Size = new System.Drawing.Size(586, 225);
            this.ListaCompra.TabIndex = 14;
            // 
            // ActualizarCompra
            // 
            this.ActualizarCompra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ActualizarCompra.Location = new System.Drawing.Point(258, 334);
            this.ActualizarCompra.Name = "ActualizarCompra";
            this.ActualizarCompra.Size = new System.Drawing.Size(75, 23);
            this.ActualizarCompra.TabIndex = 15;
            this.ActualizarCompra.Text = "Actualizar";
            this.ActualizarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActualizarCompra.UseVisualStyleBackColor = false;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(665, 377);
            this.Controls.Add(this.ActualizarCompra);
            this.Controls.Add(this.ListaCompra);
            this.Controls.Add(this.PrecioCompra);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.CantidadCompra);
            this.Controls.Add(this.FechaCompra);
            this.Controls.Add(this.TotalCompra);
            this.Controls.Add(this.NombreCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BorrarCompra);
            this.Controls.Add(this.BuscarCompra);
            this.Controls.Add(this.AgregarCompra);
            this.Name = "Compras";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.ListaCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarCompra;
        private System.Windows.Forms.Button BuscarCompra;
        private System.Windows.Forms.Button BorrarCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreCompra;
        private System.Windows.Forms.TextBox TotalCompra;
        private System.Windows.Forms.TextBox FechaCompra;
        private System.Windows.Forms.TextBox CantidadCompra;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.TextBox PrecioCompra;
        private System.Windows.Forms.DataGridView ListaCompra;
        private System.Windows.Forms.Button ActualizarCompra;
    }
}
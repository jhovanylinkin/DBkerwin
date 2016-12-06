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
            this.CantidadCompra = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.Label();
            this.PrecioCompra = new System.Windows.Forms.TextBox();
            this.ListaCompra = new System.Windows.Forms.DataGridView();
            this.ColumnIDCompraa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualizarCompra = new System.Windows.Forms.Button();
            this.fechaCompras = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnidadCompras = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalDelPedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GuardarInDB = new System.Windows.Forms.Button();
            this.idProductoCompras = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxIDCompra = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarCompra
            // 
            this.AgregarCompra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AgregarCompra.Location = new System.Drawing.Point(96, 334);
            this.AgregarCompra.Name = "AgregarCompra";
            this.AgregarCompra.Size = new System.Drawing.Size(75, 23);
            this.AgregarCompra.TabIndex = 0;
            this.AgregarCompra.Text = "Agregar";
            this.AgregarCompra.UseVisualStyleBackColor = false;
            this.AgregarCompra.Click += new System.EventHandler(this.AgregarCompra_Click);
            // 
            // BuscarCompra
            // 
            this.BuscarCompra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BuscarCompra.Location = new System.Drawing.Point(15, 334);
            this.BuscarCompra.Name = "BuscarCompra";
            this.BuscarCompra.Size = new System.Drawing.Size(75, 23);
            this.BuscarCompra.TabIndex = 1;
            this.BuscarCompra.Text = "Buscar";
            this.BuscarCompra.UseVisualStyleBackColor = false;
            this.BuscarCompra.Click += new System.EventHandler(this.BuscarCompra_Click);
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
            this.BorrarCompra.Click += new System.EventHandler(this.BorrarCompra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(440, 339);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(107, 13);
            this.Total.TabIndex = 5;
            this.Total.Text = "Total del las compras";
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad";
            // 
            // NombreCompra
            // 
            this.NombreCompra.Location = new System.Drawing.Point(62, 13);
            this.NombreCompra.Name = "NombreCompra";
            this.NombreCompra.Size = new System.Drawing.Size(100, 20);
            this.NombreCompra.TabIndex = 8;
            this.NombreCompra.TextChanged += new System.EventHandler(this.NombreCompra_TextChanged);
            // 
            // TotalCompra
            // 
            this.TotalCompra.Location = new System.Drawing.Point(715, 45);
            this.TotalCompra.Name = "TotalCompra";
            this.TotalCompra.ReadOnly = true;
            this.TotalCompra.Size = new System.Drawing.Size(100, 20);
            this.TotalCompra.TabIndex = 9;
            this.TotalCompra.TextChanged += new System.EventHandler(this.TotalCompra_TextChanged);
            // 
            // CantidadCompra
            // 
            this.CantidadCompra.Location = new System.Drawing.Point(62, 50);
            this.CantidadCompra.Name = "CantidadCompra";
            this.CantidadCompra.Size = new System.Drawing.Size(100, 20);
            this.CantidadCompra.TabIndex = 11;
            this.CantidadCompra.TextChanged += new System.EventHandler(this.CantidadCompra_TextChanged);
            this.CantidadCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadCompra_KeyDown);
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(174, 18);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(37, 13);
            this.Precio.TabIndex = 12;
            this.Precio.Text = "Precio";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.Location = new System.Drawing.Point(217, 13);
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Size = new System.Drawing.Size(110, 20);
            this.PrecioCompra.TabIndex = 13;
            this.PrecioCompra.TextChanged += new System.EventHandler(this.PrecioCompra_TextChanged);
            // 
            // ListaCompra
            // 
            this.ListaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDCompraa,
            this.ColumnIDProducto,
            this.ColumnNombre,
            this.ColumnUnidades,
            this.ColumnPrecio,
            this.ColumnCantidad,
            this.ColumnIDProveedor,
            this.ColumnProveedor,
            this.ColumnTotal,
            this.ColumnFecha});
            this.ListaCompra.Location = new System.Drawing.Point(3, 76);
            this.ListaCompra.Name = "ListaCompra";
            this.ListaCompra.Size = new System.Drawing.Size(1039, 220);
            this.ListaCompra.TabIndex = 14;
            this.ListaCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaCompra_CellContentClick);
            // 
            // ColumnIDCompraa
            // 
            this.ColumnIDCompraa.HeaderText = "ID Compra";
            this.ColumnIDCompraa.Name = "ColumnIDCompraa";
            // 
            // ColumnIDProducto
            // 
            this.ColumnIDProducto.HeaderText = "ID Producto";
            this.ColumnIDProducto.Name = "ColumnIDProducto";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnUnidades
            // 
            this.ColumnUnidades.HeaderText = "Unidad";
            this.ColumnUnidades.Name = "ColumnUnidades";
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.Name = "ColumnCantidad";
            // 
            // ColumnIDProveedor
            // 
            this.ColumnIDProveedor.HeaderText = "ID Proveedor";
            this.ColumnIDProveedor.Name = "ColumnIDProveedor";
            // 
            // ColumnProveedor
            // 
            this.ColumnProveedor.HeaderText = "Proveedor";
            this.ColumnProveedor.Name = "ColumnProveedor";
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.Name = "ColumnTotal";
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
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
            // fechaCompras
            // 
            this.fechaCompras.Location = new System.Drawing.Point(571, 7);
            this.fechaCompras.Name = "fechaCompras";
            this.fechaCompras.Size = new System.Drawing.Size(200, 20);
            this.fechaCompras.TabIndex = 17;
            // 
            // comboBoxProveedor
            // 
            this.comboBoxProveedor.FormattingEnabled = true;
            this.comboBoxProveedor.Location = new System.Drawing.Point(400, 45);
            this.comboBoxProveedor.Name = "comboBoxProveedor";
            this.comboBoxProveedor.Size = new System.Drawing.Size(110, 21);
            this.comboBoxProveedor.TabIndex = 18;
            this.comboBoxProveedor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Proveedor";
            // 
            // UnidadCompras
            // 
            this.UnidadCompras.Location = new System.Drawing.Point(217, 46);
            this.UnidadCompras.Name = "UnidadCompras";
            this.UnidadCompras.Size = new System.Drawing.Size(110, 20);
            this.UnidadCompras.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Unidad";
            // 
            // TotalDelPedido
            // 
            this.TotalDelPedido.Location = new System.Drawing.Point(553, 336);
            this.TotalDelPedido.Name = "TotalDelPedido";
            this.TotalDelPedido.ReadOnly = true;
            this.TotalDelPedido.Size = new System.Drawing.Size(100, 20);
            this.TotalDelPedido.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(678, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total";
            // 
            // GuardarInDB
            // 
            this.GuardarInDB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GuardarInDB.Location = new System.Drawing.Point(675, 334);
            this.GuardarInDB.Name = "GuardarInDB";
            this.GuardarInDB.Size = new System.Drawing.Size(75, 23);
            this.GuardarInDB.TabIndex = 24;
            this.GuardarInDB.Text = "Guardar";
            this.GuardarInDB.UseVisualStyleBackColor = false;
            this.GuardarInDB.Click += new System.EventHandler(this.GuardarInDB_Click);
            // 
            // idProductoCompras
            // 
            this.idProductoCompras.Location = new System.Drawing.Point(400, 13);
            this.idProductoCompras.Name = "idProductoCompras";
            this.idProductoCompras.Size = new System.Drawing.Size(110, 20);
            this.idProductoCompras.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "IDProducto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "IDCompra";
            // 
            // comboBoxIDCompra
            // 
            this.comboBoxIDCompra.FormattingEnabled = true;
            this.comboBoxIDCompra.Location = new System.Drawing.Point(580, 46);
            this.comboBoxIDCompra.Name = "comboBoxIDCompra";
            this.comboBoxIDCompra.Size = new System.Drawing.Size(91, 21);
            this.comboBoxIDCompra.TabIndex = 29;
            this.comboBoxIDCompra.SelectedIndexChanged += new System.EventHandler(this.comboBoxIDCompra_SelectedIndexChanged);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1043, 366);
            this.Controls.Add(this.comboBoxIDCompra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idProductoCompras);
            this.Controls.Add(this.GuardarInDB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalDelPedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UnidadCompras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxProveedor);
            this.Controls.Add(this.fechaCompras);
            this.Controls.Add(this.ActualizarCompra);
            this.Controls.Add(this.ListaCompra);
            this.Controls.Add(this.PrecioCompra);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.CantidadCompra);
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
            this.Load += new System.EventHandler(this.Compras_Load);
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
        private System.Windows.Forms.TextBox CantidadCompra;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.TextBox PrecioCompra;
        private System.Windows.Forms.DataGridView ListaCompra;
        private System.Windows.Forms.Button ActualizarCompra;
        private System.Windows.Forms.DateTimePicker fechaCompras;
        private System.Windows.Forms.ComboBox comboBoxProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UnidadCompras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalDelPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GuardarInDB;
        private System.Windows.Forms.TextBox idProductoCompras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxIDCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDCompraa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
    }
}
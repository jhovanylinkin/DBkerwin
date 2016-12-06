namespace MiTiendita
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.AgregarVenta = new System.Windows.Forms.Button();
            this.BuscarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListaVenta = new System.Windows.Forms.DataGridView();
            this.TotalVenta = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNombreVentas = new System.Windows.Forms.ComboBox();
            this.comboBoxClienteventas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonVender = new System.Windows.Forms.Button();
            this.CBUltimaVenta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ColumnIDVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnidCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDProduco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarVenta
            // 
            this.AgregarVenta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AgregarVenta.Location = new System.Drawing.Point(61, 341);
            this.AgregarVenta.Name = "AgregarVenta";
            this.AgregarVenta.Size = new System.Drawing.Size(75, 23);
            this.AgregarVenta.TabIndex = 0;
            this.AgregarVenta.Text = "Agregar";
            this.AgregarVenta.UseVisualStyleBackColor = false;
            this.AgregarVenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuscarVenta
            // 
            this.BuscarVenta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BuscarVenta.Location = new System.Drawing.Point(154, 341);
            this.BuscarVenta.Name = "BuscarVenta";
            this.BuscarVenta.Size = new System.Drawing.Size(75, 23);
            this.BuscarVenta.TabIndex = 1;
            this.BuscarVenta.Text = "Buscar";
            this.BuscarVenta.UseVisualStyleBackColor = false;
            this.BuscarVenta.Click += new System.EventHandler(this.BuscarVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            // 
            // ListaVenta
            // 
            this.ListaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDVentas,
            this.ColumnTTV,
            this.ColumnFecha,
            this.ColumnidCliente,
            this.ColumnIDProduco,
            this.Columnproducto,
            this.ColumnCantidad});
            this.ListaVenta.Location = new System.Drawing.Point(55, 90);
            this.ListaVenta.Name = "ListaVenta";
            this.ListaVenta.Size = new System.Drawing.Size(741, 214);
            this.ListaVenta.TabIndex = 7;
            // 
            // TotalVenta
            // 
            this.TotalVenta.Location = new System.Drawing.Point(94, 64);
            this.TotalVenta.Name = "TotalVenta";
            this.TotalVenta.Size = new System.Drawing.Size(100, 20);
            this.TotalVenta.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(546, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "cantidad";
            // 
            // comboBoxNombreVentas
            // 
            this.comboBoxNombreVentas.FormattingEnabled = true;
            this.comboBoxNombreVentas.Location = new System.Drawing.Point(94, 18);
            this.comboBoxNombreVentas.Name = "comboBoxNombreVentas";
            this.comboBoxNombreVentas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNombreVentas.TabIndex = 13;
            this.comboBoxNombreVentas.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreVentas_SelectedIndexChanged);
            // 
            // comboBoxClienteventas
            // 
            this.comboBoxClienteventas.FormattingEnabled = true;
            this.comboBoxClienteventas.Location = new System.Drawing.Point(280, 60);
            this.comboBoxClienteventas.Name = "comboBoxClienteventas";
            this.comboBoxClienteventas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClienteventas.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cliente";
            // 
            // ButtonVender
            // 
            this.ButtonVender.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonVender.Location = new System.Drawing.Point(633, 340);
            this.ButtonVender.Name = "ButtonVender";
            this.ButtonVender.Size = new System.Drawing.Size(75, 23);
            this.ButtonVender.TabIndex = 16;
            this.ButtonVender.Text = "Vender";
            this.ButtonVender.UseVisualStyleBackColor = false;
            this.ButtonVender.Click += new System.EventHandler(this.ButtonVender_Click);
            // 
            // CBUltimaVenta
            // 
            this.CBUltimaVenta.FormattingEnabled = true;
            this.CBUltimaVenta.Location = new System.Drawing.Point(625, 38);
            this.CBUltimaVenta.Name = "CBUltimaVenta";
            this.CBUltimaVenta.Size = new System.Drawing.Size(121, 21);
            this.CBUltimaVenta.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ultima venta";
            // 
            // ColumnIDVentas
            // 
            this.ColumnIDVentas.HeaderText = "IDVentas";
            this.ColumnIDVentas.Name = "ColumnIDVentas";
            // 
            // ColumnTTV
            // 
            this.ColumnTTV.HeaderText = "TotalVenta";
            this.ColumnTTV.Name = "ColumnTTV";
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            // 
            // ColumnidCliente
            // 
            this.ColumnidCliente.HeaderText = "ID Cliente";
            this.ColumnidCliente.Name = "ColumnidCliente";
            // 
            // ColumnIDProduco
            // 
            this.ColumnIDProduco.HeaderText = "ID Producto";
            this.ColumnIDProduco.Name = "ColumnIDProduco";
            // 
            // Columnproducto
            // 
            this.Columnproducto.HeaderText = "Producto";
            this.Columnproducto.Name = "Columnproducto";
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.Name = "ColumnCantidad";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(837, 375);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBUltimaVenta);
            this.Controls.Add(this.ButtonVender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxClienteventas);
            this.Controls.Add(this.comboBoxNombreVentas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TotalVenta);
            this.Controls.Add(this.ListaVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscarVenta);
            this.Controls.Add(this.AgregarVenta);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarVenta;
        private System.Windows.Forms.Button BuscarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ListaVenta;
        private System.Windows.Forms.TextBox TotalVenta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNombreVentas;
        private System.Windows.Forms.ComboBox comboBoxClienteventas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonVender;
        private System.Windows.Forms.ComboBox CBUltimaVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnidCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDProduco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
    }
}
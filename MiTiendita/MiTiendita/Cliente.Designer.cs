namespace MiTiendita
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.AgregarCliente = new System.Windows.Forms.Button();
            this.BuscarCliente = new System.Windows.Forms.Button();
            this.BorrarCliente = new System.Windows.Forms.Button();
            this.NombreLb = new System.Windows.Forms.Label();
            this.TelefonoLb = new System.Windows.Forms.Label();
            this.DireccionLb = new System.Windows.Forms.Label();
            this.NombreCliente = new System.Windows.Forms.TextBox();
            this.TelefonoCliente = new System.Windows.Forms.TextBox();
            this.DireccionCliente = new System.Windows.Forms.TextBox();
            this.ListaCliente = new System.Windows.Forms.DataGridView();
            this.ActualizarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarCliente
            // 
            this.AgregarCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AgregarCliente.Location = new System.Drawing.Point(24, 160);
            this.AgregarCliente.Name = "AgregarCliente";
            this.AgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.AgregarCliente.TabIndex = 0;
            this.AgregarCliente.Text = "Agregar";
            this.AgregarCliente.UseVisualStyleBackColor = false;
            this.AgregarCliente.Click += new System.EventHandler(this.AgregarCliente_Click);
            // 
            // BuscarCliente
            // 
            this.BuscarCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BuscarCliente.Location = new System.Drawing.Point(24, 199);
            this.BuscarCliente.Name = "BuscarCliente";
            this.BuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.BuscarCliente.TabIndex = 1;
            this.BuscarCliente.Text = "Buscar";
            this.BuscarCliente.UseVisualStyleBackColor = false;
            this.BuscarCliente.Click += new System.EventHandler(this.BuscarCliente_Click);
            // 
            // BorrarCliente
            // 
            this.BorrarCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BorrarCliente.Location = new System.Drawing.Point(24, 240);
            this.BorrarCliente.Name = "BorrarCliente";
            this.BorrarCliente.Size = new System.Drawing.Size(75, 23);
            this.BorrarCliente.TabIndex = 2;
            this.BorrarCliente.Text = "Borrar";
            this.BorrarCliente.UseVisualStyleBackColor = false;
            this.BorrarCliente.Click += new System.EventHandler(this.BorrarCliente_Click);
            // 
            // NombreLb
            // 
            this.NombreLb.AutoSize = true;
            this.NombreLb.Location = new System.Drawing.Point(36, 9);
            this.NombreLb.Name = "NombreLb";
            this.NombreLb.Size = new System.Drawing.Size(44, 13);
            this.NombreLb.TabIndex = 3;
            this.NombreLb.Text = "Nombre";
            // 
            // TelefonoLb
            // 
            this.TelefonoLb.AutoSize = true;
            this.TelefonoLb.Location = new System.Drawing.Point(36, 73);
            this.TelefonoLb.Name = "TelefonoLb";
            this.TelefonoLb.Size = new System.Drawing.Size(49, 13);
            this.TelefonoLb.TabIndex = 4;
            this.TelefonoLb.Text = "Telefono";
            // 
            // DireccionLb
            // 
            this.DireccionLb.AutoSize = true;
            this.DireccionLb.Location = new System.Drawing.Point(36, 39);
            this.DireccionLb.Name = "DireccionLb";
            this.DireccionLb.Size = new System.Drawing.Size(52, 13);
            this.DireccionLb.TabIndex = 5;
            this.DireccionLb.Text = "Direccion";
            // 
            // NombreCliente
            // 
            this.NombreCliente.Location = new System.Drawing.Point(94, 6);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(412, 20);
            this.NombreCliente.TabIndex = 6;
            // 
            // TelefonoCliente
            // 
            this.TelefonoCliente.Location = new System.Drawing.Point(94, 66);
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.Size = new System.Drawing.Size(109, 20);
            this.TelefonoCliente.TabIndex = 7;
            // 
            // DireccionCliente
            // 
            this.DireccionCliente.Location = new System.Drawing.Point(94, 36);
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.Size = new System.Drawing.Size(412, 20);
            this.DireccionCliente.TabIndex = 8;
            // 
            // ListaCliente
            // 
            this.ListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaCliente.Location = new System.Drawing.Point(128, 93);
            this.ListaCliente.Name = "ListaCliente";
            this.ListaCliente.Size = new System.Drawing.Size(541, 200);
            this.ListaCliente.TabIndex = 10;
            // 
            // ActualizarCliente
            // 
            this.ActualizarCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ActualizarCliente.Location = new System.Drawing.Point(24, 281);
            this.ActualizarCliente.Name = "ActualizarCliente";
            this.ActualizarCliente.Size = new System.Drawing.Size(75, 23);
            this.ActualizarCliente.TabIndex = 11;
            this.ActualizarCliente.Text = "Actualizar";
            this.ActualizarCliente.UseVisualStyleBackColor = false;
            this.ActualizarCliente.Click += new System.EventHandler(this.ActualizarCliente_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 359);
            this.Controls.Add(this.ActualizarCliente);
            this.Controls.Add(this.ListaCliente);
            this.Controls.Add(this.DireccionCliente);
            this.Controls.Add(this.TelefonoCliente);
            this.Controls.Add(this.NombreCliente);
            this.Controls.Add(this.DireccionLb);
            this.Controls.Add(this.TelefonoLb);
            this.Controls.Add(this.NombreLb);
            this.Controls.Add(this.BorrarCliente);
            this.Controls.Add(this.BuscarCliente);
            this.Controls.Add(this.AgregarCliente);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.ListaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarCliente;
        private System.Windows.Forms.Button BuscarCliente;
        private System.Windows.Forms.Button BorrarCliente;
        private System.Windows.Forms.Label NombreLb;
        private System.Windows.Forms.Label TelefonoLb;
        private System.Windows.Forms.Label DireccionLb;
        private System.Windows.Forms.TextBox NombreCliente;
        private System.Windows.Forms.TextBox TelefonoCliente;
        private System.Windows.Forms.TextBox DireccionCliente;
        private System.Windows.Forms.DataGridView ListaCliente;
        private System.Windows.Forms.Button ActualizarCliente;
    }
}
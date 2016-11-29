namespace MiTiendita
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            this.ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.Lista = new System.Windows.Forms.ListBox();
            this.Inicio = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Busca = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ActualizarProducto = new System.Windows.Forms.Button();
=======
            this.Borrar = new System.Windows.Forms.Button();
            this.Busca = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewBuscarProductos = new System.Windows.Forms.DataGridView();
            this.actualizarBuscar = new System.Windows.Forms.Button();
>>>>>>> dev
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(69, 30);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(75, 20);
            this.ID.TabIndex = 17;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(69, 74);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(144, 20);
            this.Nombre.TabIndex = 15;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
<<<<<<< HEAD
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(69, 168);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(575, 147);
            this.Lista.TabIndex = 18;
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(584, 369);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(75, 23);
            this.Inicio.TabIndex = 19;
            this.Inicio.Text = "Inicio";
            this.Inicio.UseVisualStyleBackColor = true;
            // 
=======
>>>>>>> dev
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(413, 345);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 20;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Busca
            // 
            this.Busca.Location = new System.Drawing.Point(251, 345);
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(75, 23);
            this.Busca.TabIndex = 21;
            this.Busca.Text = "Buscar";
            this.Busca.UseVisualStyleBackColor = true;
            this.Busca.Click += new System.EventHandler(this.Busca_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(494, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
<<<<<<< HEAD
            // ActualizarProducto
            // 
            this.ActualizarProducto.Location = new System.Drawing.Point(289, 345);
            this.ActualizarProducto.Name = "ActualizarProducto";
            this.ActualizarProducto.Size = new System.Drawing.Size(62, 23);
            this.ActualizarProducto.TabIndex = 23;
            this.ActualizarProducto.Text = "button1";
            this.ActualizarProducto.UseVisualStyleBackColor = true;
=======
            // dataGridViewBuscarProductos
            // 
            this.dataGridViewBuscarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscarProductos.Location = new System.Drawing.Point(35, 130);
            this.dataGridViewBuscarProductos.Name = "dataGridViewBuscarProductos";
            this.dataGridViewBuscarProductos.Size = new System.Drawing.Size(453, 201);
            this.dataGridViewBuscarProductos.TabIndex = 23;
            this.dataGridViewBuscarProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuscarProductos_CellContentClick);
            // 
            // actualizarBuscar
            // 
            this.actualizarBuscar.Location = new System.Drawing.Point(332, 345);
            this.actualizarBuscar.Name = "actualizarBuscar";
            this.actualizarBuscar.Size = new System.Drawing.Size(75, 23);
            this.actualizarBuscar.TabIndex = 24;
            this.actualizarBuscar.Text = "Actualizar";
            this.actualizarBuscar.UseVisualStyleBackColor = true;
            this.actualizarBuscar.Click += new System.EventHandler(this.actualizarBuscar_Click);
>>>>>>> dev
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 418);
<<<<<<< HEAD
            this.Controls.Add(this.ActualizarProducto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Busca);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.Lista);
=======
            this.Controls.Add(this.actualizarBuscar);
            this.Controls.Add(this.dataGridViewBuscarProductos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Busca);
            this.Controls.Add(this.Borrar);
>>>>>>> dev
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Name = "Buscar";
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label1;
<<<<<<< HEAD
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Busca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ActualizarProducto;
=======
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Busca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewBuscarProductos;
        private System.Windows.Forms.Button actualizarBuscar;
>>>>>>> dev
    }
}
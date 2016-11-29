using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiTiendita
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void dataGridViewBuscarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ////////////////////////////////////////////////////////////////////////////////////////
        private void Busca_Click(object sender, EventArgs e)
        {
           
                int integrarID;//conversion de string  int
                integrarID = Convert.ToInt32(ID.Text);
                integrarID = int.Parse(ID.Text);
                dataGridViewBuscarProductos.DataSource = ProductosIME.BuscarProductos(integrarID, Nombre.Text);//Metodo parainiciar la usqueda
           
            
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////////////////////////////////////////////////
        public Productos productoSeleccionado { get; set; }
        private void Borrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewBuscarProductos.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridViewBuscarProductos.CurrentRow.Cells[0].Value);
                productoSeleccionado = ProductosIME.ObtenerProductos(id);
                //this.Close();
                if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ProductosIME.EliminarProductos(productoSeleccionado.idProducto) > 0)
                    {
                        MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("debe de seleccionar una fila");
            }

           

            }
        /////////////////////////////////////////////////////////////////////
        private void actualizarBuscar_Click(object sender, EventArgs e)
        {
            if (dataGridViewBuscarProductos.SelectedRows.Count == 1)
            {
                Productos pProductos = new Productos();
                int id = Convert.ToInt32(dataGridViewBuscarProductos.CurrentRow.Cells[0].Value);
                string nombre = Convert.ToString(dataGridViewBuscarProductos.CurrentRow.Cells[1].Value);
                string unidades = Convert.ToString(dataGridViewBuscarProductos.CurrentRow.Cells[2].Value);
                double precio = Convert.ToDouble(dataGridViewBuscarProductos.CurrentRow.Cells[3].Value);
                int pieza = Convert.ToInt32(dataGridViewBuscarProductos.CurrentRow.Cells[4].Value);
                pProductos.idProducto = id;
                pProductos.nombre = nombre;
                pProductos.unidanes = unidades;
                pProductos.precio = precio;
                pProductos.pieza = pieza;


                if (ProductosIME.ActualizarProducto(pProductos) > 0)
                {
                    MessageBox.Show("Los datos del Producto se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }
    }
}

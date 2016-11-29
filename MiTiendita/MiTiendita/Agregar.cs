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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }
        //public Productos productoActual { get; set; }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDAgregar.Text) || string.IsNullOrWhiteSpace(NombreAgregar.Text) ||
                            string.IsNullOrWhiteSpace(UnidadAgregar.Text)||string.IsNullOrWhiteSpace(PrecioAgregar.Text)|| string.IsNullOrWhiteSpace(CantidadCantidad.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {

                Productos pProductos = new Productos();
                int integrarID,integrarPieza;//conversion de string  int
                double integrarPrecio;
                integrarID = Convert.ToInt32(IDAgregar.Text);
                integrarID = int.Parse(IDAgregar.Text);
                integrarPieza = Convert.ToInt32(CantidadCantidad.Text);
                integrarPieza = int.Parse(CantidadCantidad.Text);
                integrarPrecio = Convert.ToDouble(PrecioAgregar.Text);
                integrarPrecio = double.Parse(PrecioAgregar.Text); 

                pProductos.idProducto = integrarID;
                pProductos.nombre = NombreAgregar.Text.Trim();
                pProductos.unidanes = UnidadAgregar.Text.Trim();
                pProductos.precio = integrarPrecio;
               //pProductos.Fecha_Nacimiento = dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day;
                pProductos.pieza = integrarPieza;
             

                int resultado = ProductosIME.AgregarProductos(pProductos);
                if (resultado > 0)
                {
                    MessageBox.Show("Productos registrados con exito ", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpiar();
                    //Deshabilitar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el producto, verifique su ID de producto", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }

        private void IDAgregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreAgregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnidadAgregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioAgregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void CantidadCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Load(object sender, EventArgs e)
        {

        }

        private void ActualizartoProductos_Click(object sender, EventArgs e)
        {
            Buscar i = new Buscar();
            i.Show();
        }
    }
}

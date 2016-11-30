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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            Principal i = new Principal();
            i.Show();
            this.Close();
        }

        private void AgregarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreProveedor.Text) || string.IsNullOrWhiteSpace(DireccionProveedor.Text) ||
                            string.IsNullOrWhiteSpace(RFCProveedor.Text) || string.IsNullOrWhiteSpace(TelefonoProveedor.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                Proveedoress provProveedores = new Proveedoress();
              
                provProveedores.nombreProveedor = NombreProveedor.Text.Trim();
                provProveedores.rfcProveedor = RFCProveedor.Text.Trim();
                provProveedores.direccionProveedor = DireccionProveedor.Text.Trim();
                //pProductos.Fecha_Nacimiento = dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day;
                provProveedores.telefonoProveedor = TelefonoProveedor.Text.Trim();


                int resultado = ProveedoresIME.AgregarProveedores(provProveedores);
                if (resultado > 0)
                {
                    MessageBox.Show("Provedor registrados con exito ", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpiar();
                    //Deshabilitar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el producto", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }

        private void BuscarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreProveedor.Text))
            {

                MessageBox.Show("El campo Nombre es obligatorio!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                dataGridViewProveedores.DataSource = ProveedoresIME.BuscarProveedores( NombreProveedor.Text);//Metodo parainiciar la usqueda
            }
        }

        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarProveedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count == 1)
            {
                Proveedoress provProvedores = new Proveedoress();
                int idProveedores = Convert.ToInt32(dataGridViewProveedores.CurrentRow.Cells[0].Value);
                string nombreProveedores = Convert.ToString(dataGridViewProveedores.CurrentRow.Cells[1].Value);
                string rfcProveedores = Convert.ToString(dataGridViewProveedores.CurrentRow.Cells[2].Value);
                string direccionProveedores = Convert.ToString(dataGridViewProveedores.CurrentRow.Cells[3].Value);
                string telefonoProveedores = Convert.ToString(dataGridViewProveedores.CurrentRow.Cells[4].Value);
                
                provProvedores.idProveedor =idProveedores;
                provProvedores.nombreProveedor = nombreProveedores;
                provProvedores.rfcProveedor = rfcProveedores;
                provProvedores.direccionProveedor = direccionProveedores;
                provProvedores.telefonoProveedor = telefonoProveedores;


                if (ProveedoresIME.ActualizarProveedor(provProvedores) > 0)
                {
                    MessageBox.Show("Los datos del Proveedor se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila!", "Seleccione  una fila!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public Proveedoress proveedoresSeleccionado { get; set; }
        private void BorrarProveedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridViewProveedores.CurrentRow.Cells[0].Value);
                proveedoresSeleccionado = ProveedoresIME.ObtenerProveedores(id);
                if (MessageBox.Show("Esta Seguro que desea eliminar el Proveedor Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ProveedoresIME.EliminarProveedores(proveedoresSeleccionado.idProveedor) > 0)
                    {
                        MessageBox.Show("Proveeddor Eliminado Correctamente!", "Proveedor Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Proveedor", "Proveedor No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}



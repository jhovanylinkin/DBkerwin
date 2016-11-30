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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            Principal i = new Principal();
            i.Show();
            this.Close();
        }

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreCliente.Text) || string.IsNullOrWhiteSpace(DireccionCliente.Text) ||
                            string.IsNullOrWhiteSpace(TelefonoCliente.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        
            else
            {
                Clientes clClientes = new Clientes();

                clClientes.nombreCliente = NombreCliente.Text.Trim();
                clClientes.telefonoCliente = TelefonoCliente.Text.Trim();
                clClientes.direccionCliente = DireccionCliente.Text.Trim();
                //pProductos.Fecha_Nacimiento = dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day;
          
                int resultado = ClientesIME.AgregarClientes(clClientes);
                if (resultado > 0)
                {
                    MessageBox.Show("Clientes registrados con exito ", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpiar();
                    //Deshabilitar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }

        private void BuscarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreCliente.Text))
            {

                MessageBox.Show("El campo Nombre es obligatorio!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                ListaCliente.DataSource = ClientesIME.BuscarClientes(NombreCliente.Text);//Metodo parainiciar la usqueda
            }
        }
        public Clientes clienteSeleccionado { get; set; }
        private void BorrarCliente_Click(object sender, EventArgs e)
        {
            if (ListaCliente.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(ListaCliente.CurrentRow.Cells[0].Value);
                clienteSeleccionado = ClientesIME.ObtenerClientes(id);
                if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ClientesIME.EliminarClientes(clienteSeleccionado.idCliente) > 0)
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

        private void ActualizarCliente_Click(object sender, EventArgs e)
        {
            if (ListaCliente.SelectedRows.Count == 1)
            {
                Clientes clClientes = new Clientes();
                int idCliente = Convert.ToInt32(ListaCliente.CurrentRow.Cells[0].Value);
                string nombreCliente = Convert.ToString(ListaCliente.CurrentRow.Cells[1].Value);
                string telefonoCliente = Convert.ToString(ListaCliente.CurrentRow.Cells[2].Value);
                string direccionCliente = Convert.ToString(ListaCliente.CurrentRow.Cells[3].Value);
                
                clClientes.idCliente = idCliente;
                clClientes.nombreCliente = nombreCliente;
                clClientes.telefonoCliente = telefonoCliente;
                clClientes.direccionCliente =direccionCliente;
               


                if (ClientesIME.ActualizarCliente(clClientes) > 0)
                {
                    MessageBox.Show("Los datos del Cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

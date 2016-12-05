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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            comboBoxNombreVentas.DataSource = ProductosIME.obtenerProductosName();
            comboBoxNombreVentas.DisplayMember = "nombre";
            comboBoxNombreVentas.ValueMember = "idProducto";


            comboBoxClienteventas.DataSource = ClientesIME.obtenerclientesName();
            comboBoxClienteventas.DisplayMember= "nombreCliente";
            comboBoxClienteventas.ValueMember = "idCliente";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idventas;
            idventas = " ";
            string totalVenta;
            totalVenta = TotalVenta.Text;
            string fecha;
            fecha = dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day;
            string idCliente;
            idCliente = Convert.ToString(comboBoxClienteventas.SelectedValue);
            string idProducto;
            idProducto = Convert.ToString(comboBoxNombreVentas.SelectedValue);
            string producto;
            producto = comboBoxNombreVentas.Text;
            ListaVenta.Rows.Add( idventas,totalVenta, fecha, idCliente, idProducto, producto);
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            Principal i = new Principal();
            i.Show();
            this.Close();
        }

        private void comboBoxNombreVentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonVender_Click(object sender, EventArgs e)
        {
            if (ListaVenta.SelectedRows.Count == 1)
            {
                
                Productos pProductos = new Productos();
                ComprasC compCompras = new ComprasC();
                Proveedoress provProveedores = new Proveedoress();
                Clientes cClientes = new Clientes();
                ventass vVentas = new ventass();

                
                int totalVenta = Convert.ToInt32(ListaVenta.CurrentRow.Cells[1].Value);
                string fecha = Convert.ToString(ListaVenta.CurrentRow.Cells[2].Value);
                int idCliente = Convert.ToInt32(ListaVenta.CurrentRow.Cells[3].Value);
                int idProducto = Convert.ToInt32(ListaVenta.CurrentRow.Cells[4].Value);

                
                vVentas.totalVentas = totalVenta;
                vVentas.fechaVentas = fecha;
                cClientes.idCliente = idCliente;
                pProductos.idProducto = idProducto;
                

               

                int resultado = VentasIME.AgregarProductos(vVentas,cClientes, pProductos);
                int resultado2 = ProductosIME.AgregarCompras(pProductos, compCompras, provProveedores);
                if (resultado > 0 )
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

            else
            {
                MessageBox.Show("Seleccione una lista a guardar!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}

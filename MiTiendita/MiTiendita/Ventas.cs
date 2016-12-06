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

            CBUltimaVenta.DataSource = VentasIME.obtenerComprasUltimoID();
            CBUltimaVenta.DisplayMember = "idVentas";
            CBUltimaVenta.ValueMember = "idVentas";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int op = int.Parse(CBUltimaVenta.Text);
            int opP = op + 1;
            string preOptenerIDVentas;
            preOptenerIDVentas = Convert.ToString(opP);


            
            string totalVenta;
            totalVenta = TotalVenta.Text;
            string fecha;
            fecha = dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day;
            string idCliente;
            idCliente = Convert.ToString(comboBoxClienteventas.SelectedValue);
            string idProducto;
            idProducto = Convert.ToString(comboBoxNombreVentas.SelectedValue);
            string producto;
            string cantidad = textBox1.Text;
            producto = comboBoxNombreVentas.Text;
            ListaVenta.Rows.Add(preOptenerIDVentas,totalVenta, fecha, idCliente, idProducto, producto,cantidad);
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

                int idVentas1 = Convert.ToInt32(ListaVenta.CurrentRow.Cells[0].Value);
                int totalVenta = Convert.ToInt32(ListaVenta.CurrentRow.Cells[1].Value);
                string fecha = Convert.ToString(ListaVenta.CurrentRow.Cells[2].Value);
                int idCliente = Convert.ToInt32(ListaVenta.CurrentRow.Cells[3].Value);
                int idProducto = Convert.ToInt32(ListaVenta.CurrentRow.Cells[4].Value);
                int cantidadVenta = Convert.ToInt32(ListaVenta.CurrentRow.Cells[6].Value);

                vVentas.idVentas= idVentas1;
                vVentas.totalVentas = totalVenta;
                vVentas.fechaVentas = fecha;
                vVentas.cantidad = cantidadVenta;
                cClientes.idCliente = idCliente;
                pProductos.idProducto = idProducto;

                

               

                int resultado = VentasIME.AgregarVentas(vVentas,cClientes, pProductos);
                int resultado2 =VentasIME.AgregarVentas_has_producto(vVentas,pProductos);
                if (resultado > 0 && resultado2> 0 )
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

        private void BuscarVenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CBUltimaVenta.Text))
            {

                MessageBox.Show("El campo ID de la ultima venta es obligatorio!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ListaVenta.Columns.Clear();
                ListaVenta.Refresh();
                
                ListaVenta.DataSource = VentasIME.BuscarVentas(CBUltimaVenta.Text);//Metodo parainiciar la usqueda
                /*string precio = Convert.ToString(ListaCompra.CurrentRow.Cells[7].Value);
                TotalCompra.Text = precio;
                PrecioCompra.Text = precio;*/
            }
        }
    }
}

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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }
        
        
        private void Inicio_Click(object sender, EventArgs e)
        {
            Principal i = new Principal();
            i.Show();
            this.Close();
        }

        private void BuscarCompra_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(idProductoCompras.Text))
            {

                MessageBox.Show("El campo ID produto es obligatorio!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ListaCompra.Columns.Clear();
                ListaCompra.Refresh();

                ListaCompra.DataSource = ComprasIME.BuscarProductosPARACOMPRAS(idProductoCompras.Text);//Metodo parainiciar la usqueda
                string precio = Convert.ToString(ListaCompra.CurrentRow.Cells[7].Value);
                TotalCompra.Text = precio;
                PrecioCompra.Text = precio;
            }
        }

        private void NombreCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void Compras_Load(object sender, EventArgs e)
        {
            comboBoxProveedor.DataSource = ProveedoresIME.obtenerProveedoresName();
            comboBoxProveedor.DisplayMember ="nombreProveedor";
            comboBoxProveedor.ValueMember = "idProveedor";
            comboBoxIDCompra.DataSource = ComprasIME.obtenerComprasUltimoID();
            comboBoxIDCompra.DisplayMember = "idcompras";
            comboBoxIDCompra.ValueMember = "idcompras";
            
        }

        private void ListaCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string idCompra;
        public string idProducto;
        public string nombre;
        public string unidades;
        public double precio;
        public int cantidad;
        public string idproveedor;
        public string proveedor;
        public double total;
        public string fecha;


        private void AgregarCompra_Click(object sender, EventArgs e)
        {
            idCompra = comboBoxIDCompra.Text;
            idProducto = idProductoCompras.Text;
            nombre = NombreCompra.Text;
            unidades = UnidadCompras.Text;
            precio = double.Parse(PrecioCompra.Text);
            cantidad = int.Parse(CantidadCompra.Text);
            idproveedor = Convert.ToString(comboBoxProveedor.SelectedValue);
            proveedor = comboBoxProveedor.Text;
            total = double.Parse(TotalCompra.Text);
            fecha= fechaCompras.Value.Year + "/" + fechaCompras.Value.Month + "/" + fechaCompras.Value.Day;


            double totalOB;
            double totalMultiPedido;
            ListaCompra.Rows.Add(idCompra,idProducto,nombre,unidades,precio,cantidad,idproveedor,proveedor,total,fecha);
            if (string.IsNullOrWhiteSpace(TotalDelPedido.Text))
            {
                totalOB=0;
                totalMultiPedido = total;
                TotalDelPedido.Text =Convert.ToString(totalMultiPedido);
            }
            else {
                totalOB = double.Parse(TotalDelPedido.Text);
                totalMultiPedido =total + totalOB;
                TotalDelPedido.Text = Convert.ToString(totalMultiPedido);
            }
        }

        private void PrecioCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CantidadCompra_TextChanged(object sender, EventArgs e)
        {
            double integrarPrecioU, integrarCantidadProd, multiprecio;//conversion de string  int
            integrarPrecioU = Convert.ToDouble(PrecioCompra.Text);
            integrarCantidadProd = Convert.ToDouble(CantidadCompra.Text);
            multiprecio = integrarCantidadProd * integrarPrecioU;
            TotalCompra.Text = Convert.ToString(multiprecio);
        }

        public void CantidadCompra_KeyDown(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                double integrarPrecioU,integrarCantidadProd,multiprecio;//conversion de string  int
                integrarPrecioU = Convert.ToDouble(PrecioCompra.Text);
                integrarCantidadProd =Convert.ToDouble(CantidadCompra.Text);
                multiprecio = integrarCantidadProd * integrarPrecioU;
                TotalCompra.Text = Convert.ToString(multiprecio);
            }

        }

        private void Total_Click(object sender, EventArgs e)
        {

        }
        public Productos productoSeleccionado { get; set; }
        private void BorrarCompra_Click(object sender, EventArgs e)
        {
            if (ListaCompra.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(ListaCompra.CurrentRow.Cells[0].Value);
                productoSeleccionado = ProductosIME.ObtenerProductos(id);
                //this.Close();
                if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ProductosIME.EliminarProductos(productoSeleccionado.idProducto) > 0)
                    {
                        MessageBox.Show("Producto Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Producto", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void GuardarInDB_Click(object sender, EventArgs e)
        {

            if (ListaCompra.SelectedRows.Count == 1)
            {
               
                Productos pProductos = new Productos();
                ComprasC compCompras = new ComprasC();
                Proveedoress provProveedores = new Proveedoress();

                int idCompra = Convert.ToInt32(ListaCompra.CurrentRow.Cells[0].Value);
                int idProducto = Convert.ToInt32(ListaCompra.CurrentRow.Cells[1].Value);
                string nombre = Convert.ToString(ListaCompra.CurrentRow.Cells[2].Value);
                string unidades = Convert.ToString(ListaCompra.CurrentRow.Cells[3].Value);
                double precio = Convert.ToDouble(ListaCompra.CurrentRow.Cells[4].Value);
                int cantidad = Convert.ToInt32(ListaCompra.CurrentRow.Cells[5].Value);
                int idProveedor = Convert.ToInt32(ListaCompra.CurrentRow.Cells[6].Value);
                string proveedor = Convert.ToString(ListaCompra.CurrentRow.Cells[7].Value);
                int total = Convert.ToInt32(ListaCompra.CurrentRow.Cells[8].Value);
                string fecha = Convert.ToString(ListaCompra.CurrentRow.Cells[9].Value);

                compCompras.idcompras = idCompra;
                pProductos.idProducto = idProducto;
                pProductos.nombre = nombre;
                pProductos.unidanes = unidades;
                pProductos.precio = precio;
                compCompras.cantidad = cantidad;
                provProveedores.idProveedor = idProveedor;
                compCompras.totalCompras = total;
                compCompras.fechaCompras = fecha;




                int resultado = ProductosIME.AgregarCompras(compCompras, provProveedores);
                int resultado2 = ProductosIME.AgregarProductos(pProductos);
                int resultado3 = ProductosIME.AgregarProductos_has_Compras(pProductos,compCompras); ;
                
                if (resultado > 0 && resultado2 >0 && resultado3 >0)
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

        private void TotalCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxIDCompra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------
        public Productos compraSeleccionada { get; set; }
        private void ActualizarCompra_Click(object sender, EventArgs e)
        {
            if (ListaCompra.SelectedRows.Count == 1)
            {
                Productos pProductos = new Productos();
                ComprasC compCompras = new ComprasC();
                Proveedoress provProveedores = new Proveedoress();

                int idCompra = Convert.ToInt32(ListaCompra.CurrentRow.Cells[0].Value);
                int idProducto = Convert.ToInt32(ListaCompra.CurrentRow.Cells[1].Value);
                string nombre = Convert.ToString(ListaCompra.CurrentRow.Cells[2].Value);
                string unidades = Convert.ToString(ListaCompra.CurrentRow.Cells[3].Value);
                double precio = Convert.ToDouble(ListaCompra.CurrentRow.Cells[4].Value);
                int cantidad = Convert.ToInt32(ListaCompra.CurrentRow.Cells[5].Value);
                int idProveedor = Convert.ToInt32(ListaCompra.CurrentRow.Cells[6].Value);
                double total = Convert.ToDouble(ListaCompra.CurrentRow.Cells[7].Value);
                string fecha = Convert.ToString(ListaCompra.CurrentRow.Cells[8].Value);

                double op = cantidad * precio;

                compCompras.idcompras = idCompra;
                pProductos.idProducto = idProducto;
                pProductos.nombre = nombre;
                pProductos.unidanes = unidades;
                pProductos.precio = precio;
                compCompras.cantidad = cantidad;
                provProveedores.idProveedor = idProveedor;
                compCompras.totalCompras = op;
                compCompras.fechaCompras = fecha;



                if (ComprasIME.ActualizarCompra(compCompras,pProductos,provProveedores) > 0)
                {
                    MessageBox.Show("Los datos del Producto se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //---------------------------------------------------------------------------------------------------------------------------------------------------
        private void idProductoCompras_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MiTiendita
{
    public partial class Principal : Form
    {
        
        MySqlConnection conexion = new MySqlConnection();

        public Principal()
        {

            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Agregar i = new Agregar();
            i.Show();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            
        }
        public void abrircconeccion()
        {

            string cadenaconeccion = "Server=localhost;Database=mydb; user id=root; password=fundamentos";
            conexion.ConnectionString = cadenaconeccion;
            try
            {
                conexion.Open();
                MessageBox.Show("Conectado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("no conectado" + ex);
            }
        }

        public void cerrarconeccion()
        {
            try
            {
                conexion.Close();
                MessageBox.Show("desconectado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("no desconectado" + ex);
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            abrircconeccion();
        }

        private void Desconectar_Click(object sender, EventArgs e)
        {
            cerrarconeccion();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void clientes_Click(object sender, EventArgs e)
        {
            Cliente i = new Cliente();
            i.Show();
        }
    }
}

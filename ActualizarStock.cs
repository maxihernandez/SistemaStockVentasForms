using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaStockVentas
{
    public partial class ActualizarStock : Form
    {
   

        public ActualizarStock()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connMax = Conexion.conectarBase();
            String buscado = textBox1.Text;
            DataTable tabla = new DataTable();
            SqlCommand consultarTEMP = new SqlCommand("select * from Producto where DescProducto like '%"+buscado+"%'", connMax);

            consultarTEMP.CommandTimeout = 10000;
            if (connMax != null)
            {
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = consultarTEMP;
                adp.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            else
            {
                MessageBox.Show("Error,no se pudo cargar");
            }
            connMax.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Actualizacion de Stock*/
            String valorSumar = textBox3.Text;
            String idProd = textBox2.Text;

            SqlConnection connMax = Conexion.conectarBase();
            SqlCommand obtenerCantidad = new SqlCommand("select Cantidad from Producto  where idProducto = '" + idProd + "'", connMax);
            var cantidadActual = obtenerCantidad.ExecuteScalar();
            connMax.Close();
            int sumando1 = Convert.ToInt32(cantidadActual);
            int sumando2 = Int32.Parse(valorSumar);
            int cantidadActulizada = sumando1 + sumando2;

            connMax.Open();
            SqlCommand updateCantidad = new SqlCommand("UPDATE Producto SET Cantidad = '"+ cantidadActulizada + "'" +"WHERE idProducto = '"+ idProd + "'", connMax);
            updateCantidad.ExecuteNonQuery();
            connMax.Close();
            MessageBox.Show("Articulo Actualizado");




        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

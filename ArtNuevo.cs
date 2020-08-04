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
    public partial class ArtNuevo : Form
    {
        public ArtNuevo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String descripcion = textBox1.Text;
            String proveedor = textBox2.Text;
            String categoria = textBox3.Text;
            String costo = textBox4.Text;
            String cantidad = textBox5.Text;
            int costoaux = 0;
            costoaux = int.Parse(costo);
            int cantidadaux = 0;
            cantidadaux = int.Parse(cantidad);

            SqlCommand ultimoID = null;

            SqlConnection conn = Conexion.conectarBase();

            /*Obetengo el ultimo Id generado y preparo el siguiente*/

            ultimoID = new SqlCommand("SELECT MAX(idProducto)  FROM Producto",conn);
            var result = ultimoID.ExecuteScalar();
            int sigId = Convert.ToInt32(result);
            sigId++;

            /********************************/

            try { 
            SqlCommand insetadoArt = new SqlCommand(" insert into Producto(idProducto,DescProducto, Proveedor, Categoria, Costo, Cantidad) Values (@maxId,@descripcion,@proveedor,@categoria,@costoaux,@cantidadaux)", conn);
            insetadoArt.Parameters.AddWithValue("@maxId", sigId);
            insetadoArt.Parameters.AddWithValue("@descripcion", textBox1.Text);
            insetadoArt.Parameters.AddWithValue("@proveedor", textBox3.Text);
            insetadoArt.Parameters.AddWithValue("@categoria", textBox2.Text);
            insetadoArt.Parameters.AddWithValue("@costoaux", costoaux);
            insetadoArt.Parameters.AddWithValue("@cantidadaux", cantidadaux);

            insetadoArt.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Articulo Cargado");
            }
            catch
            {
                MessageBox.Show("Articulo No Pudo ser Cargado");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArtNuevo_Load(object sender, EventArgs e)
        {

        }
    }
}

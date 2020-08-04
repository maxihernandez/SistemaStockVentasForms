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
    public partial class StockConsulta : Form
    {
        public StockConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connMax = Conexion.conectarBase();

            DataTable tabla = new DataTable();
            SqlCommand consultarTEMP = new SqlCommand("select DescProducto,Proveedor,Categoria,Costo,Cantidad from Producto  ", connMax);

            consultarTEMP.CommandTimeout = 10000;
            if (connMax != null) {
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = consultarTEMP;
            adp.Fill(tabla);
            dataGridView1.DataSource = tabla;
            }
            else
            {
                MessageBox.Show("Error");
            }
            connMax.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaStockVentas
{
    class Conexion
    {
        public static SqlConnection conectarBase()
        {
            SqlConnection conn = null;
            try
            {

                conn = new SqlConnection("Data source=MAXI-PC\\SQLEXPRESS ;initial catalog = dbZendaTe;Integrated Security=true;");

                conn.Open();

            }
            catch
            {
                MessageBox.Show("No se pudo realizar la conexion a la Base de Datos");
                conn = null;
            }

            return conn;

        }


    }
}

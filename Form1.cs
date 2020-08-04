using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaStockVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockConsulta st = new StockConsulta();
            st.MdiParent = this;
            st.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void articuloNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArtNuevo artNew = new ArtNuevo();
            artNew.MdiParent = this;
            artNew.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarStock atStock = new ActualizarStock();
            atStock.MdiParent = this;
            atStock.Show();

        }
    }
}

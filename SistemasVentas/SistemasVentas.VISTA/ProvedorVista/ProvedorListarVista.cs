using SistemasVentas.BSS;
using SistemasVentas.VISTA.SistemaVentaVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProvedorVista
{
    public partial class ProvedorListarVista : Form
    {
        public ProvedorListarVista()
        {
            InitializeComponent();
        }

        private void ProvedorListarVista_Load(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            dataGridView1.DataSource = bss.ProductoDatosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            dataGridView1.DataSource = bss.ProductoDatosBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProveeBss bss = new ProveeBss();
            dataGridView1.DataSource = bss.ProveeDatosBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IngresoBss bss = new IngresoBss();
            dataGridView1.DataSource = bss.IngresoDatosBss();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro de que desea cerrar sesion", "Cerrar Sesion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SistemaVentaInicioVista inicioVista = new SistemaVentaInicioVista();
                inicioVista.Show();

                this.Close();
            }
        }
    }
}

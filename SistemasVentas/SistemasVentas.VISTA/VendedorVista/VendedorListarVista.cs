using SistemasVentas.BSS;
using SistemasVentas.VISTA.GerenteVista;
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

namespace SistemasVentas.VISTA.VendedorVista
{
    public partial class VendedorListarVista : Form
    {
        public VendedorListarVista()
        {
            InitializeComponent();
        }

        private void VendedorListarVista_Load(object sender, EventArgs e)
        {
            ClienteBss bss = new ClienteBss();
            dataGridView1.DataSource = bss.ClienteDatosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteBss bss = new ClienteBss();
            dataGridView1.DataSource = bss.ClienteDatosBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            dataGridView1.DataSource = bss.ProductoDatosBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentaBss bss = new VentaBss();
            dataGridView1.DataSource = bss.VentaDatosBss();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetalleVentaBss bss = new DetalleVentaBss();
            dataGridView1.DataSource = bss.DetalleVentaDatosBss();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            VendedorInsertarVista vender = new VendedorInsertarVista();
            vender.Show();
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

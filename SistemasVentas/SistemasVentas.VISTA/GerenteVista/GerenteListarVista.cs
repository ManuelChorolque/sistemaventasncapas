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

namespace SistemasVentas.VISTA.GerenteVista
{
    public partial class GerenteListarVista : Form
    {
        public GerenteListarVista()
        {
            InitializeComponent();
        }
        private void GerenteListarVista_Load(object sender, EventArgs e)
        {
            PersonaBss bss = new PersonaBss();
            dataGridView1.DataSource = bss.ListarPersonasBss();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            PersonaBss bss = new PersonaBss();
            dataGridView1.DataSource = bss.ListarPersonasBss();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RolBss bss = new RolBss();
            dataGridView1.DataSource = bss.ListarRolBss();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TipoProdBss bss = new TipoProdBss();
            dataGridView1.DataSource = bss.ListarTipoProdBss();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MarcaBss bss = new MarcaBss();
            dataGridView1.DataSource = bss.ListarMarcaBss();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            ProveedorBss bss = new ProveedorBss();
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            UsuarioBss bss = new UsuarioBss();
            dataGridView1.DataSource = bss.UsuarioDatosBss();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            UsuarioRolBss bss = new UsuarioRolBss();
            dataGridView1.DataSource = bss.UsuarioRolDatosBss();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            ClienteBss bss = new ClienteBss();
            dataGridView1.DataSource = bss.ClienteDatosBss();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            IngresoBss bss = new IngresoBss();
            dataGridView1.DataSource = bss.IngresoDatosBss();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            VentaBss bss = new VentaBss();
            dataGridView1.DataSource = bss.VentaDatosBss();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            dataGridView1.DataSource = bss.ProductoDatosBss();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            ProveeBss bss = new ProveeBss();
            dataGridView1.DataSource = bss.ProveeDatosBss();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            DetalleVentaBss bss = new DetalleVentaBss();
            dataGridView1.DataSource = bss.DetalleVentaDatosBss();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            DetalleIngBss bss = new DetalleIngBss();
            dataGridView1.DataSource = bss.DetalleIngDatosBss();
        }
        private void button15_Click_1(object sender, EventArgs e)
        {
            GerenteModificarTablasLista listarVista = new GerenteModificarTablasLista();
            listarVista.Show();
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

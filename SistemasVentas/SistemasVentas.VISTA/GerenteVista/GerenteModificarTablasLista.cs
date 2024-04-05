using SistemasVentas.BSS;
using SistemasVentas.VISTA.ClienteVista;
using SistemasVentas.VISTA.DetalleIngVista;
using SistemasVentas.VISTA.DetalleVentaVista;
using SistemasVentas.VISTA.IngresoVista;
using SistemasVentas.VISTA.MarcaVista;
using SistemasVentas.VISTA.PersonaVista;
using SistemasVentas.VISTA.ProductoVista;
using SistemasVentas.VISTA.ProveedorVista;
using SistemasVentas.VISTA.ProveeVista;
using SistemasVentas.VISTA.RolVista;
using SistemasVentas.VISTA.TipoProdVista;
using SistemasVentas.VISTA.UsuarioRolVista;
using SistemasVentas.VISTA.UsuarioVista;
using SistemasVentas.VISTA.VentaVista;
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
    public partial class GerenteModificarTablasLista : Form
    {
        public GerenteModificarTablasLista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista listarVista = new PersonaListarVista();
            listarVista.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RolListarVista listarVista = new RolListarVista();
            listarVista.Show();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TipoProdListarVista listarVista = new TipoProdListarVista();
            listarVista.Show();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MarcaListarVista listarVista = new MarcaListarVista();
            listarVista.Show();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ProveedorListarVista listarVista = new ProveedorListarVista();
            listarVista.Show();
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            UsuarioListarVista listarVista = new UsuarioListarVista();
            listarVista.Show();
            this.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            UsuarioRolListarVista listarVista = new UsuarioRolListarVista();
            listarVista.Show();
            this.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            ClienteListarVista listarVista = new ClienteListarVista();
            listarVista.Show();
            this.Close();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            IngresoListarVista listarVista = new IngresoListarVista();
            listarVista.Show();
            this.Close();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            VentaListarVista listarVista = new VentaListarVista();
            listarVista.Show();
            this.Close();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            ProductoListarVista listarVista = new ProductoListarVista();
            listarVista.Show();
            this.Close();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            ProveeListarVista listarVista = new ProveeListarVista();
            listarVista.Show();
            this.Close();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            DetalleVentaListarVista listarVista = new DetalleVentaListarVista();
            listarVista.Show();
            this.Close();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            DetalleIngListarVista listarVista = new DetalleIngListarVista();
            listarVista.Show();
            this.Close();
        }
    }
}

using SistemasVentas.BSS;
using SistemasVentas.VISTA.VentaVista;
using SistemasVentas.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.VISTA.DetalleVentaVista;
using SistemasVentas.VISTA.DetalleIngVista;
using SistemasVentas.VISTA.ProveeVista;
using SistemasVentas.VISTA.RolVista;
using SistemasVentas.VISTA.UsuarioVista;

namespace SistemasVentas.VISTA.ProductoVista
{
    public partial class ProductoListarVista : Form
    {
        public ProductoListarVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void ProductoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProductoDatosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProveeInsertarVista.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeEditarVista.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaInsertarVista.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaEditarVista.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleIngInsertarVista.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleIngEditarVista.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductoInsertarVista fr = new ProductoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ProductoDatosBss();
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdProductoSelecionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProductoEditarVista fr = new ProductoEditarVista(IdProductoSelecionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ProductoDatosBss();
            }
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdProductoSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar este producto", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProductoBss(IdProductoSelecionado);
                dataGridView1.DataSource = bss.ProductoDatosBss();
            }
            this.Close();
        }
    }
}

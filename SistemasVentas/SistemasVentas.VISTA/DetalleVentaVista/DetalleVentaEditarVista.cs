using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVista;
using SistemasVentas.VISTA.VentaVista;
using SistemasVentas.VISTA.DetalleVentaVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleVentaVista
{
    public partial class DetalleVentaEditarVista : Form
    {
        int idx = 0;
        DetalleVenta d = new DetalleVenta();
        DetalleVentaBss bss = new DetalleVentaBss();
        public DetalleVentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdVentaSeleccionado = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            VentaBss bss = new VentaBss();
            VentaListarVista fr = new VentaListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bss.ObtenerIdBss(IdVentaSeleccionado);
                textBox1.Text = venta.Fecha.ToString();
            }
        }
        public static int IdProductoSeleccionado = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            ProductoListarVista fr = new ProductoListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bss.ObtenerIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.Nombre;
            }
        }

        private void DetalleVentaEditarVista_Load(object sender, EventArgs e)
        {
            d = bss.ObtenerIdBss(idx);
            textBox1.Text = d.IdVenta.ToString();
            textBox2.Text = d.IdProducto.ToString();
            textBox3.Text = d.Cantidad.ToString();
            textBox4.Text = d.PrecioVenta.ToString();
            textBox5.Text = d.Subtotal.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.IdVenta = IdVentaSeleccionado;
            d.IdProducto = IdProductoSeleccionado;
            d.Cantidad = Convert.ToInt32(textBox3.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            d.Subtotal = Convert.ToDecimal(textBox5.Text);

            bss.EditarDetalleVentaBss(d);
            MessageBox.Show("Datos actualizados");
        }
    }
}

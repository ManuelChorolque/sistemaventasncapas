using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.TipoProdVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.VendedorVista
{
    public partial class VendedorInsertarVista : Form
    {
        private int n = 0;
        public VendedorInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdClienteSeleccionado = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            PersonaBss bss = new PersonaBss();
            VendedorClienteListarVista fr = new VendedorClienteListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdClienteSeleccionado);
                textBox1.Text = persona.Nombre + ' ' + persona.Apellido;
            }

        }
        public static int IdProductoSeleccionado = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            VendedorProductoListarVista fr = new VendedorProductoListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bss.ObtenerIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.Nombre;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            Producto p = bss.ObtenerIdBss(IdProductoSeleccionado);

            DetalleVentaBss bss1 = new DetalleVentaBss();
            DetalleVenta d = bss1.ObtenerIdBss(IdProductoSeleccionado);

            int cantidad = Convert.ToInt32(domainUpDown1.Text);

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = d.IdDetalleVenta;
            dataGridView1.Rows[n].Cells[1].Value = p.Nombre;
            dataGridView1.Rows[n].Cells[2].Value = cantidad;
            dataGridView1.Rows[n].Cells[3].Value = d.PrecioVenta;
            dataGridView1.Rows[n].Cells[4].Value = d.PrecioVenta * cantidad; //subtotal

            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[4].Value);
                }
            }
            label7.Text = total.ToString(); //suma de todos los subtotales(total)

            textBox2.Text = "";
            domainUpDown1.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentaBss bss3 = new VentaBss();
            Venta v = bss3.ObtenerIdBss(IdProductoSeleccionado);

            DetalleVentaBss bss1 = new DetalleVentaBss();
            DetalleVenta d = bss1.ObtenerIdBss(IdProductoSeleccionado);

            ProductoBss bss2 = new ProductoBss();
            Producto p = bss2.ObtenerIdBss(IdProductoSeleccionado);
            d.IdDetalleVenta= Convert.ToInt32(dataGridView1.Rows[n].Cells[0].Value);
            p.Nombre = IdProductoSeleccionado.ToString();
            d.Cantidad = Convert.ToInt32(domainUpDown1.Text);
            d.Subtotal = Convert.ToDecimal(dataGridView1.Rows[n].Cells[4].Value);
            v.Total = Convert.ToInt32(label7.Text);

            bss2.InsertarProductoBss(p);
            bss3.InsertarVentaBss(v);
            bss1.InsertarDetalleVentaBss(d);
            MessageBox.Show("se guardo correctamente producto");
        }
    }
}

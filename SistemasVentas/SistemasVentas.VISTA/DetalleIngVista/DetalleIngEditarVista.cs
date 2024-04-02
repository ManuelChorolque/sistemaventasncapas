using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.IngresoVista;
using SistemasVentas.VISTA.ProductoVista;
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

namespace SistemasVentas.VISTA.DetalleIngVista
{
    public partial class DetalleIngEditarVista : Form
    {
        int idx = 0;
        DetalleIng d = new DetalleIng();
        DetalleIngBss bss = new DetalleIngBss();
        public DetalleIngEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        } 
        public static int IdProductoSeleccionado = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            ProductoListarVista fr = new ProductoListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bss.ObtenerIdBss(IdProductoSeleccionado);
                textBox1.Text = producto.Nombre;
            }
        }
        public static int IdIngresoSeleccionado = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            IngresoBss bss = new IngresoBss();
            IngresoListarVista fr = new IngresoListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bss.ObtenerIdBss(IdIngresoSeleccionado);
                textBox2.Text = ingreso.FechaIngreso.ToString();
            }
        }

        private void DetalleIngEditarVista_Load(object sender, EventArgs e)
        {
            d = bss.ObtenerIdBss(idx);          
            textBox1.Text = d.IdProducto.ToString();
            textBox2.Text = d.IdIngreso.ToString();
            dateTimePicker1.Value = d.FechaVenc;
            textBox4.Text = d.Cantidad.ToString();
            textBox5.Text = d.PrecioCosto.ToString();
            textBox6.Text = d.PrecioVenta.ToString();
            textBox7.Text = d.Subtotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            d.IdProducto = IdProductoSeleccionado;
            d.IdIngreso = IdIngresoSeleccionado;
            d.FechaVenc = dateTimePicker1.Value;
            d.Cantidad = Convert.ToInt32(textBox4.Text);
            d.PrecioCosto = Convert.ToDecimal(textBox5.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox6.Text);
            d.Subtotal = Convert.ToDecimal(textBox7.Text);        

            bss.EditarDetalleIngBss(d);
            MessageBox.Show("Datos actualizados");
        }
    }
}

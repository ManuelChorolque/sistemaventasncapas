using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.MarcaVista;
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

namespace SistemasVentas.VISTA.ProductoVista
{
    public partial class ProductoEditarVista : Form
    {

        int idx = 0;
        Producto p = new Producto();
        ProductoBss bss = new ProductoBss();
        public ProductoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdTipoProdSeleccionado = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            TipoProdBss bss = new TipoProdBss();
            TipoProdListarVista fr = new TipoProdListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProd tipoProd = bss.ObtenerIdBss(IdTipoProdSeleccionado);
                textBox1.Text = tipoProd.Nombre;
            }
        }
        public static int IdMarcaSeleccionado = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            MarcaBss bss = new MarcaBss();
            MarcaListarVista fr = new MarcaListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca marca = bss.ObtenerIdBss(IdMarcaSeleccionado);
                textBox2.Text = marca.Nombre;
            }
        }

        private void ProductoEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIdBss(idx);
            textBox1.Text = p.IdTipoProd.ToString();
            textBox2.Text = p.IdMarca.ToString();
            textBox3.Text = p.Nombre;
            textBox4.Text = p.CodigoBarra;
            textBox5.Text = p.Unidad.ToString();
            textBox6.Text = p.Descripcion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdTipoProd = IdTipoProdSeleccionado;
            p.IdMarca = IdMarcaSeleccionado;
            p.Nombre = textBox3.Text;
            p.CodigoBarra = textBox4.Text;
            p.Unidad = Convert.ToInt32(textBox5.Text);
            p.Descripcion = textBox6.Text;


            bss.EditarProductoBss(p);
            MessageBox.Show("Datos actualizados");
        }
    }
}

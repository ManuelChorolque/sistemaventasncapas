using SistemasVentas.BSS;
using SistemasVentas.VISTA.UsuarioVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleIngVista
{
    public partial class DetalleIngListarVista : Form
    {
        public DetalleIngListarVista()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void DetalleIngListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.DetalleIngDatosBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleIngInsertarVista fr = new DetalleIngInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.DetalleIngDatosBss();
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdDetalleIngSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleIngEditarVista fr = new DetalleIngEditarVista(IdDetalleIngSelecionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.DetalleIngDatosBss();
            }
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdDetalleIngSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar este detalle ingreso", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleIngBss(IdDetalleIngSelecionado);
                dataGridView1.DataSource = bss.DetalleIngDatosBss();
            }
            this.Close();
        }
    }
}

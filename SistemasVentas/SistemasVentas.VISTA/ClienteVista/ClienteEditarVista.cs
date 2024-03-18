using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ClienteVista
{
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        Cliente c = new Cliente();
        ClienteBss bss = new ClienteBss();
        public ClienteEditarVista(int id)
        {
            idx= id;
            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            c = bss.ObtenerIdBss(idx);
            textBox1.Text = c.IdCliente;
           


        }
    }
}

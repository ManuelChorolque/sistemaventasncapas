using SistemasVentas.DAL;
using SistemasVentas.VISTA.GerenteVista;
using SistemasVentas.VISTA.VendedorVista;
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

namespace SistemasVentas.VISTA.ProvedorVista
{
    public partial class ProvedorInicioSesionVista : Form
    {
        public ProvedorInicioSesionVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (conexion.VerificadorCredenciales(usuario, contraseña))
            {
                MessageBox.Show("Iniciando sesion");
                ProvedorListarVista formulario = new ProvedorListarVista();

                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
            this.Close();
        }
    }
}

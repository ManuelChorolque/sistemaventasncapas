﻿using SistemasVentas.VISTA.GerenteVista;
using SistemasVentas.VISTA.ProvedorVista;
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

namespace SistemasVentas.VISTA.SistemaVentaVista
{
    public partial class SistemaVentaInicioVista : Form
    {
        public SistemaVentaInicioVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerenteInicioSesionVista listarvista = new GerenteInicioSesionVista();
            listarvista.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VendedorInicioSesionVista listarvista = new VendedorInicioSesionVista();
            listarvista.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProvedorInicioSesionVista listarvista = new ProvedorInicioSesionVista();
            listarvista.Show();
        }
    }
}

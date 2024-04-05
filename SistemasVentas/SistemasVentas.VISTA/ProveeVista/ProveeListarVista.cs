﻿using SistemasVentas.BSS;
using SistemasVentas.VISTA.PersonaVista;
using SistemasVentas.VISTA.UsuarioRolVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.VISTA.ProveeVista;

namespace SistemasVentas.VISTA.ProveeVista
{
    public partial class ProveeListarVista : Form
    {
        public ProveeListarVista()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void ProveeListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProveeDatosBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProveeInsertarVista fr = new ProveeInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ProveeDatosBss();
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdProveeSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeEditarVista fr = new ProveeEditarVista(IdProveeSelecionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ProveeDatosBss();
            }
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdProveeSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar este provee", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProveeBss(IdProveeSelecionado);
                dataGridView1.DataSource = bss.ProveeDatosBss();
            }
            this.Close();
        }
    }
}

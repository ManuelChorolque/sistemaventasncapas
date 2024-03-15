﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVista;

namespace SistemasVentas.VISTA.UsuariosInserVistasVer
{
    public partial class UsuariosInsertarVistaVer : Form
    {
        public UsuariosInsertarVistaVer()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss=new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog()==DialogResult.OK) 
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);

                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}

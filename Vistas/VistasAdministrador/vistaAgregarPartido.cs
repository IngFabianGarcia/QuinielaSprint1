﻿using QuinielaSprint1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuinielaSprint1.Vistas.VistasAdicionales
{
    public partial class vistaAgregarPartido : Form
    {
        public vistaAgregarPartido()
        {
            InitializeComponent();
        }

        private void vistaAgregarPartido_Load(object sender, EventArgs e)
        {
            obtenerTablas datos = new obtenerTablas();
            DataTable dataTable = datos.TablaEquipos();
            dtEquipos.DataSource = dataTable;

            obtenerTablas datos1 = new obtenerTablas();
            DataTable dataTable1 = datos1.TablaPartidosConId();
            dtPartidos.DataSource = dataTable1;
        }

        private void btnAgregarPartido_Click(object sender, EventArgs e)
        {
            ProcedimientosSql.AgregarPartido(fechaUsuario.Value, txtIdLocal.Text, txtIdVisitante.Text);
            obtenerTablas datos1 = new obtenerTablas();
            DataTable dataTable1 = datos1.TablaPartidosConId();
            dtPartidos.DataSource = dataTable1;
        }
    }
}

using JuanApp.Formularios.Herramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuanApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            statusLabel.Text = "Bienvenido estimado Juan,¿qué hacemos hoy?";
        }

        private void menuItemSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Hide();
            ConsultaEntrada Estadisticas = new();
            Estadisticas.ShowDialog();
        }

        private void btnEntradaFormulario_Click(object sender, EventArgs e)
        {
            Hide();
            FormularioEntrada formularioEntrada = new();
            formularioEntrada.ShowDialog();
        }
    }
}

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
            Estadisticas Estadisticas = new();
            Estadisticas.ShowDialog();
        }

        private void btnEntradaFormulario_Click(object sender, EventArgs e)
        {
            Hide();
            Formularios.Entrada.FormularioProducto formularioEntrada = new();
            formularioEntrada.ShowDialog();
        }

        private void btnEntradaConsulta_Click(object sender, EventArgs e)
        {
            Hide();
            Formularios.Entrada.ConsultaEntrada ConsultaEntrada = new();
            ConsultaEntrada.ShowDialog();
        }

        private void btnEntradaCargarExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnSalidaFormulario_Click(object sender, EventArgs e)
        {
            Hide();
            Formularios.Salida.FormularioSalida FormularioSalida = new();
            FormularioSalida.ShowDialog();
        }

        private void btnSalidaConsulta_Click(object sender, EventArgs e)
        {
            Hide();
            Formularios.Salida.ConsultaSalida ConsultaSalida = new();
            ConsultaSalida.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Hide();
            Stock Stock = new();
            Stock.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Hide();
            Formularios.Herramientas.Producto.ConsultaProducto ConsultaProducto = new();
            ConsultaProducto.ShowDialog();
        }
    }
}

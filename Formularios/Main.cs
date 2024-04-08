using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Formularios.Herramientas;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp
{
    public partial class Main : Form
    {
        private readonly ServiceProvider _serviceProvider;
        private readonly IProductoRepository _productoRepository;

        public Main(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _productoRepository = serviceProvider.GetRequiredService<IProductoRepository>();

            InitializeComponent();

            statusLabel.Text = "Bienvenido estimado Juan,¿qué hacemos hoy?";
        }

        private void menuItemSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Estadisticas Estadisticas = new();
            Estadisticas.ShowDialog();
        }

        private void btnEntradaFormulario_Click(object sender, EventArgs e)
        {
            Formularios.Entrada.FormularioEntrada FormularioEntrada = new();
            FormularioEntrada.ShowDialog();
        }

        private void btnEntradaConsulta_Click(object sender, EventArgs e)
        {
            Formularios.Entrada.ConsultaEntrada ConsultaEntrada = new();
            ConsultaEntrada.ShowDialog();
        }

        private void btnEntradaCargarExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnSalidaFormulario_Click(object sender, EventArgs e)
        {
            Formularios.Salida.FormularioSalida FormularioSalida = new();
            FormularioSalida.ShowDialog();
        }

        private void btnSalidaConsulta_Click(object sender, EventArgs e)
        {
            Formularios.Salida.ConsultaSalida ConsultaSalida = new();
            ConsultaSalida.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock Stock = new();
            Stock.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Formularios.Herramientas.Producto.ConsultaProducto ConsultaProducto = new(_serviceProvider);
            ConsultaProducto.ShowDialog();
        }
    }
}

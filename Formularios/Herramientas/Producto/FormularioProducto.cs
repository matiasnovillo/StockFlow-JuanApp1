using JuanApp.Areas.JuanApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.Entrada
{
    public partial class FormularioProducto : Form
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IProductoService _productoService;

        public FormularioProducto(ServiceProvider serviceProvider)
        {
            _productoRepository = serviceProvider.GetRequiredService<IProductoRepository>();
            _productoService = serviceProvider.GetRequiredService<IProductoService>();

            InitializeComponent();
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

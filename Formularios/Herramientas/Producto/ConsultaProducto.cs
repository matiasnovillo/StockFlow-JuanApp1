using JuanApp.Areas.JuanApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace JuanApp.Formularios.Herramientas.Producto
{
    public partial class ConsultaProducto : Form
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IProductoService _productoService;

        public ConsultaProducto(ServiceProvider serviceProvider)
        {
            _productoRepository = serviceProvider.GetRequiredService<IProductoRepository>();
            _productoService = serviceProvider.GetRequiredService<IProductoService>();

            InitializeComponent();
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Areas.JuanApp.Entities.Producto> lstProducto = [];

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                lstProducto = _productoRepository
                .AsQueryable()
                .ToList();
            }
            else
            {
                lstProducto = _productoRepository
                .AsQueryable()
                .Where(x => x.Nombre == txtBuscar.Text)
                .ToList();
            }
            
            DataGridViewProducto.AutoGenerateColumns = true;
            DataGridViewProducto.DataSource = lstProducto;
        }
    }
}

using JuanApp.Areas.JuanApp.Interfaces;
using System.Windows.Forms;

namespace JuanApp.Formularios.Herramientas.Producto
{
    public partial class ConsultaProducto : Form
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IProductoService _productoService;

        public ConsultaProducto(IProductoService productoService,
            IProductoRepository productoRepository)
        {
            _productoService = productoService;
            _productoRepository = productoRepository;

            InitializeComponent();
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
            Main Main = new();
            Main.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Areas.JuanApp.Entities.Producto> lstProducto = [];
            lstProducto = _productoRepository
                .AsQueryable()
                .Where(x => x.Nombre == txtBuscar.Text)
            .ToList();

            DataGridViewProducto.AutoGenerateColumns = true;
            DataGridViewProducto.DataSource = lstProducto;
        }
    }
}

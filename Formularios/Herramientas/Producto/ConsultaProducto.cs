using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Formularios.Entrada;
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

            DataGridViewButtonColumn colActualizar = new();
            colActualizar.HeaderText = "Actualizar";
            colActualizar.Text = "Actualizar";
            colActualizar.UseColumnTextForButtonValue = true;
            DataGridViewProducto.Columns.Add(colActualizar);

            DataGridViewButtonColumn colBorrar = new();
            colBorrar.HeaderText = "Borrar";
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;
            DataGridViewProducto.Columns.Add(colBorrar);

            DataGridViewProducto.AutoGenerateColumns = true;
            DataGridViewProducto.DataSource = lstProducto;

            statusLabel.Text = $@"Información: Cantidad de productos listados: {lstProducto.Count}";
        }

        private void DataGridViewProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Actualizar
                int ProductoId = Convert.ToInt32(DataGridViewProducto.Rows[e.RowIndex].Cells["ProductoId"].Value.ToString());

                FormularioProducto FormularioProducto = new(_productoRepository,
                _productoService,
                ProductoId);

                FormularioProducto.ShowDialog();
            }
            else if (e.ColumnIndex == 1)
            {
                //Borrar
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioProducto FormularioProducto = new(_productoRepository,
                _productoService,
                0);

            FormularioProducto.ShowDialog();
        }
    }
}

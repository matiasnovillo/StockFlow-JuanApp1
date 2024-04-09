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

            DataGridViewTextBoxColumn col0 = new();
            col0.DataPropertyName = "ProductoId";
            col0.HeaderText = "ProductoId";
            DataGridViewProducto.Columns.Add(col0);

            DataGridViewTextBoxColumn col1 = new();
            col1.DataPropertyName = "CodigoProducto";
            col1.HeaderText = "CodigoProducto";
            DataGridViewProducto.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new();
            col2.DataPropertyName = "Nombre";
            col2.HeaderText = "Nombre";
            DataGridViewProducto.Columns.Add(col2);

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

            DataGridViewProducto.AutoGenerateColumns = false;
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetTabla();
        }

        private void DataGridViewProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                //Actualizar
                int ProductoId = Convert.ToInt32(DataGridViewProducto.Rows[e.RowIndex].Cells[0].Value.ToString());

                FormularioProducto FormularioProducto = new(_productoRepository,
                _productoService,
                ProductoId);

                FormularioProducto.ShowDialog();

                GetTabla();
            }
            else if (e.ColumnIndex == 4)
            {
                //Borrar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int ProductoId = Convert.ToInt32(DataGridViewProducto.Rows[e.RowIndex].Cells[0].Value.ToString());

                    _productoRepository.DeleteByProductoId(ProductoId);

                    GetTabla();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioProducto FormularioProducto = new(_productoRepository,
                _productoService,
                0);

            FormularioProducto.ShowDialog();
        }

        private void GetTabla()
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

            DataGridViewProducto.DataSource = lstProducto;

            statusLabel.Text = $@"Información: Cantidad de productos listados: {lstProducto.Count}";
        }
    }
}

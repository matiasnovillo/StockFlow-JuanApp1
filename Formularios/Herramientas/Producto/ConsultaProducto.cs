using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Formularios.Entrada;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.Herramientas.Producto
{
    public partial class ConsultaProducto : Form
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IProductoService _productoService;

        public ConsultaProducto(ServiceProvider serviceProvider)
        {
            try
            {
                _productoRepository = serviceProvider.GetRequiredService<IProductoRepository>();
                _productoService = serviceProvider.GetRequiredService<IProductoService>();

                InitializeComponent();

                DataGridViewTextBoxColumn col0 = new();
                col0.DataPropertyName = "ProductoId";
                col0.HeaderText = "ID del sistema";
                DataGridViewProducto.Columns.Add(col0);

                DataGridViewTextBoxColumn col1 = new();
                col1.DataPropertyName = "CodigoProducto";
                col1.HeaderText = "Código de producto";
                DataGridViewProducto.Columns.Add(col1);

                DataGridViewTextBoxColumn col2 = new();
                col2.DataPropertyName = "Nombre";
                col2.HeaderText = "Nombre";
                DataGridViewProducto.Columns.Add(col2);

                DataGridViewTextBoxColumn col3 = new();
                col3.DataPropertyName = "Precio";
                col3.HeaderText = "Precio X KG.";
                DataGridViewProducto.Columns.Add(col3);

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

                WindowState = FormWindowState.Maximized;

                GetTabla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                GetTabla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DataGridViewProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    //Actualizar
                    int ProductoId = Convert.ToInt32(DataGridViewProducto.Rows[e.RowIndex].Cells[0].Value.ToString());

                    FormularioProducto FormularioProducto = new(_productoRepository,
                    _productoService,
                    ProductoId);

                    FormularioProducto.ShowDialog();

                    GetTabla();
                }
                else if (e.ColumnIndex == 5)
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
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioProducto FormularioProducto = new(_productoRepository,
                        _productoService,
                        0);

                FormularioProducto.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GetTabla()
        {
            try
            {
                List<Areas.JuanApp.Entities.Producto> lstProducto = [];

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstProducto = _productoRepository
                    .AsQueryable()
                    .OrderBy(x => x.ProductoId)
                    .ToList();
                }
                else
                {
                    lstProducto = _productoRepository
                    .AsQueryable()
                    .Where(x => x.Nombre == txtBuscar.Text)
                    .OrderBy(x => x.ProductoId)
                    .ToList();
                }

                DataGridViewProducto.Rows.Clear();

                foreach (Areas.JuanApp.Entities.Producto producto in lstProducto)
                {
                    int rowIndex = DataGridViewProducto.Rows.Add(
                        producto.ProductoId,
                        producto.CodigoProducto,
                        producto.Nombre,
                        producto.Precio,
                        "",
                        "");

                    // Intercalar colores
                    if (rowIndex % 2 == 0)
                    {
                        DataGridViewProducto.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGray;  // Color para filas pares
                    }
                    else
                    {
                        DataGridViewProducto.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;  // Color para filas impares
                    }
                }

                statusLabel.Text = $@"Cantidad de Productos Listados: {lstProducto.Count}";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DataGridViewProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegurarse de que se haga clic en una fila válida y no en el encabezado
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in DataGridViewProducto.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        // Colorear la fila seleccionada
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        // Restaurar el color intercalado
                        if (row.Index % 2 == 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    GetTabla();
                }
            }
            catch (Exception) { throw; }
        }
    }
}

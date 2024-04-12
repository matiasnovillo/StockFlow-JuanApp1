using JuanApp.Areas.JuanApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace JuanApp.Formularios.Salida
{
    public partial class ConsultaSalida : Form
    {
        private readonly ISalidaRepository _salidaRepository;
        private readonly ISalidaService _salidaService;
        private readonly ServiceProvider _serviceProvider;

        public ConsultaSalida(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _salidaRepository = serviceProvider.GetRequiredService<ISalidaRepository>();
            _salidaService = serviceProvider.GetRequiredService<ISalidaService>();

            InitializeComponent();

            DataGridViewTextBoxColumn col0 = new();
            col0.DataPropertyName = "SalidaId";
            col0.HeaderText = "SalidaId";
            DataGridViewSalida.Columns.Add(col0);

            DataGridViewTextBoxColumn col1 = new();
            col1.DataPropertyName = "CodigoDeCliente";
            col1.HeaderText = "CodigoDeCliente";
            DataGridViewSalida.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new();
            col2.DataPropertyName = "NombreDeCliente";
            col2.HeaderText = "NombreDeCliente";
            DataGridViewSalida.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new();
            col3.DataPropertyName = "CodigoDeProducto";
            col3.HeaderText = "CodigoDeProducto";
            DataGridViewSalida.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new();
            col4.DataPropertyName = "NombreDeProducto";
            col4.HeaderText = "NombreDeProducto";
            DataGridViewSalida.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new();
            col5.DataPropertyName = "KilosReales";
            col5.HeaderText = "KilosReales";
            DataGridViewSalida.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new();
            col6.DataPropertyName = "Precio";
            col6.HeaderText = "Precio";
            DataGridViewSalida.Columns.Add(col6);

            DataGridViewTextBoxColumn col7 = new();
            col7.DataPropertyName = "Subtotal";
            col7.HeaderText = "Subtotal";
            DataGridViewSalida.Columns.Add(col7);

            DataGridViewButtonColumn colActualizar = new();
            colActualizar.HeaderText = "Actualizar";
            colActualizar.Text = "Actualizar";
            colActualizar.UseColumnTextForButtonValue = true;
            DataGridViewSalida.Columns.Add(colActualizar);

            DataGridViewButtonColumn colBorrar = new();
            colBorrar.HeaderText = "Borrar";
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;
            DataGridViewSalida.Columns.Add(colBorrar);

            DataGridViewSalida.AutoGenerateColumns = false;

            dateTimePickerFechaInicio.Value = DateTime.Now.AddDays(-30);
            dateTimePickerFechaFin.Value = DateTime.Now.AddDays(1);

            GetTabla();
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetTabla();
        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewSalida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                //Actualizar
                int EntradaId = Convert.ToInt32(DataGridViewSalida.Rows[e.RowIndex].Cells[0].Value.ToString());

                FormularioSalida FormularioSalida = new(_serviceProvider,
                EntradaId);

                FormularioSalida.ShowDialog();

                GetTabla();
            }
            else if (e.ColumnIndex == 9)
            {
                //Borrar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int EntradaId = Convert.ToInt32(DataGridViewSalida.Rows[e.RowIndex].Cells[0].Value.ToString());

                    _salidaRepository.DeleteBySalidaId(EntradaId);

                    GetTabla();
                }
            }
        }

        private void GetTabla()
        {
            List<Areas.JuanApp.Entities.Salida> lstSalida = [];

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                lstSalida = _salidaRepository
                .AsQueryable()
                .Where(x => x.DateTimeLastModification >= dateTimePickerFechaInicio.Value &&
                x.DateTimeLastModification <= dateTimePickerFechaFin.Value)
                .OrderBy(x => x.CodigoDeCliente)
                .Take(500)
                .ToList();
            }
            else
            {
                string[] words = Regex
                    .Replace(txtBuscar.Text
                    .Trim(), @"\s+", " ")
                    .Split(" ");

                lstSalida = _salidaRepository
                .AsQueryable()
                .Where(x => words.Any(word => x.CodigoDeCliente.Contains(word)) ||
                words.Any(word => x.NombreDeCliente.ToString().Contains(word)) ||
                words.Any(word => x.NombreDeProducto.ToString().Contains(word)) ||
                words.Any(word => x.CodigoDeProducto.ToString().Contains(word)))
                .Where(x => x.DateTimeLastModification >= dateTimePickerFechaInicio.Value &&
                x.DateTimeLastModification <= dateTimePickerFechaFin.Value)
                .OrderBy(x => x.CodigoDeCliente)
                .Take(500)
                .ToList();
            }

            DataGridViewSalida.DataSource = lstSalida;

            statusLabel.Text = $@"Información: Cantidad de entradas listadas: {lstSalida.Count}. Se muestran solo los últimos 500 registros";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioSalida FormularioSalida = new(_serviceProvider,
                0);

            FormularioSalida.ShowDialog();
        }
    }
}

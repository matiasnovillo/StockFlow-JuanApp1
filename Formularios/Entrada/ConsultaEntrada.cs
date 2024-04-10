using DocumentFormat.OpenXml.ExtendedProperties;
using JuanApp.Areas.JuanApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace JuanApp.Formularios.Entrada
{
    public partial class ConsultaEntrada : Form
    {
        private readonly IEntradaRepository _entradaRepository;
        private readonly IEntradaService _entradaService;
        private readonly ServiceProvider _serviceProvider;

        public ConsultaEntrada(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _entradaRepository = serviceProvider.GetRequiredService<IEntradaRepository>();
            _entradaService = serviceProvider.GetRequiredService<IEntradaService>();

            InitializeComponent();

            DataGridViewTextBoxColumn col0 = new();
            col0.DataPropertyName = "EntradaId";
            col0.HeaderText = "EntradaId";
            DataGridViewEntrada.Columns.Add(col0);

            DataGridViewTextBoxColumn col1 = new();
            col1.DataPropertyName = "CodigoDeBarra";
            col1.HeaderText = "CodigoDeBarra";
            DataGridViewEntrada.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new();
            col2.DataPropertyName = "NroDePesaje";
            col2.HeaderText = "NroDePesaje";
            DataGridViewEntrada.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new();
            col3.DataPropertyName = "CodigoDeProducto";
            col3.HeaderText = "CodigoDeProducto";
            DataGridViewEntrada.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new();
            col4.DataPropertyName = "NombreDeProducto";
            col4.HeaderText = "NombreDeProducto";
            DataGridViewEntrada.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new();
            col5.DataPropertyName = "TexContenido";
            col5.HeaderText = "TexContenido";
            DataGridViewEntrada.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new();
            col6.DataPropertyName = "Neto";
            col6.HeaderText = "Neto";
            DataGridViewEntrada.Columns.Add(col6);

            DataGridViewButtonColumn colActualizar = new();
            colActualizar.HeaderText = "Actualizar";
            colActualizar.Text = "Actualizar";
            colActualizar.UseColumnTextForButtonValue = true;
            DataGridViewEntrada.Columns.Add(colActualizar);

            DataGridViewButtonColumn colBorrar = new();
            colBorrar.HeaderText = "Borrar";
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;
            DataGridViewEntrada.Columns.Add(colBorrar);

            DataGridViewEntrada.AutoGenerateColumns = false;

            dateTimePickerFechaInicio.Value = DateTime.Now.AddDays(-30);
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetTabla();
        }

        private void DataGridViewEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                //Actualizar
                int EntradaId = Convert.ToInt32(DataGridViewEntrada.Rows[e.RowIndex].Cells[0].Value.ToString());

                FormularioEntrada FormularioEntrada = new(_serviceProvider,
                EntradaId);

                FormularioEntrada.ShowDialog();

                GetTabla();
            }
            else if (e.ColumnIndex == 8)
            {
                //Borrar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int EntradaId = Convert.ToInt32(DataGridViewEntrada.Rows[e.RowIndex].Cells[0].Value.ToString());

                    _entradaRepository.DeleteByEntradaId(EntradaId);

                    GetTabla();
                }
            }
        }

        private void GetTabla()
        {
            List<Areas.JuanApp.Entities.Entrada> lstEntrada = [];

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                lstEntrada = _entradaRepository
                .AsQueryable()
                .Where(x => x.DateTimeLastModification >= dateTimePickerFechaInicio.Value &&
                x.DateTimeLastModification <= dateTimePickerFechaFin.Value)
                .OrderBy(x => x.NroDePesaje)
                .Take(500)
                .ToList();
            }
            else
            {
                string[] words = Regex
                    .Replace(txtBuscar.Text
                    .Trim(), @"\s+", " ")
                    .Split(" ");

                lstEntrada = _entradaRepository
                .AsQueryable()
                .Where(x => words.Any(word => x.NombreDeProducto.Contains(word)) ||
                words.Any(word => x.NroDePesaje.ToString().Contains(word)) ||
                words.Any(word => x.CodigoDeProducto.ToString().Contains(word)))
                .Where(x => x.DateTimeLastModification >= dateTimePickerFechaInicio.Value &&
                x.DateTimeLastModification <= dateTimePickerFechaFin.Value)
                .OrderBy(x => x.NroDePesaje)
                .Take(500)
                .ToList();
            }

            DataGridViewEntrada.DataSource = lstEntrada;

            statusLabel.Text = $@"Información: Cantidad de entradas listadas: {lstEntrada.Count}. Se muestran solo los últimos 500 registros";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioEntrada FormularioEntrada = new(_serviceProvider,
                0);

            FormularioEntrada.ShowDialog();
        }
    }
}

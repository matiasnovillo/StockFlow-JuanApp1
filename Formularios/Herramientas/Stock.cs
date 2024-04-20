using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Areas.JuanApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace JuanApp.Formularios.Herramientas
{
    public partial class Stock : Form
    {
        private readonly ISalidaRepository _salidaRepository;
        private readonly IEntradaRepository _entradaRepository;
        private readonly ServiceProvider _serviceProvider;

        public Stock(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _salidaRepository = serviceProvider.GetRequiredService<ISalidaRepository>();
            _entradaRepository = serviceProvider.GetRequiredService<IEntradaRepository>();

            InitializeComponent();

            DataGridViewTextBoxColumn col0 = new();
            col0.DataPropertyName = "EntradaId";
            col0.HeaderText = "EntradaId";
            DataGridViewStock.Columns.Add(col0);

            DataGridViewTextBoxColumn col2 = new();
            col2.DataPropertyName = "NroDePesaje";
            col2.HeaderText = "NroDePesaje";
            DataGridViewStock.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new();
            col3.DataPropertyName = "CodigoDeProducto";
            col3.HeaderText = "CodigoDeProducto";
            DataGridViewStock.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new();
            col4.DataPropertyName = "NombreDeProducto";
            col4.HeaderText = "NombreDeProducto";
            DataGridViewStock.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new();
            col5.DataPropertyName = "TexContenido";
            col5.HeaderText = "TexContenido";
            DataGridViewStock.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new();
            col6.DataPropertyName = "Neto";
            col6.HeaderText = "Neto";
            DataGridViewStock.Columns.Add(col6);

            DataGridViewTextBoxColumn col7 = new();
            col7.DataPropertyName = "DateTimeLastModification";
            col7.HeaderText = "Fecha de creacion";
            DataGridViewStock.Columns.Add(col7);

            DataGridViewButtonColumn colBorrar = new();
            colBorrar.HeaderText = "-";
            colBorrar.Text = "-";
            colBorrar.UseColumnTextForButtonValue = true;
            DataGridViewStock.Columns.Add(colBorrar);

            numericUpDownRegistrosPorPagina.Value = 500;

            GetTabla();
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

        private void GetTabla()
        {
            try
            {
                List<Areas.JuanApp.Entities.Entrada> lstStock = [];

                List<Areas.JuanApp.Entities.Entrada> lstEntrada = _entradaRepository.GetAll();

                List<Areas.JuanApp.Entities.Salida> lstSalida = _salidaRepository.GetAll();

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstStock = lstEntrada.Where(entrada =>
                            !lstSalida.Any(salida => salida.NroDePesaje == entrada.NroDePesaje))
                            .OrderBy(x => x.NombreDeProducto)
                            .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                            .ToList();
                }
                else
                {
                    string[] words = Regex
                        .Replace(txtBuscar.Text
                        .Trim(), @"\s+", " ")
                        .Split(" ");

                    lstStock = lstEntrada.Where(entrada =>
                            !lstSalida.Any(salida => salida.NroDePesaje == entrada.NroDePesaje))
                            .Where(x => words.Any(word => x.NombreDeProducto.Contains(word)) ||
                            words.Any(word => x.NroDePesaje.ToString().Contains(word)) ||
                            words.Any(word => x.CodigoDeProducto.ToString().Contains(word)))
                            .OrderBy(x => x.NombreDeProducto)
                            .Take(Convert.ToInt32(numericUpDownRegistrosPorPagina.Value))
                            .ToList();
                }

                DataGridViewStock.DataSource = lstStock;

                statusLabel.Text = $@"Información: Cantidad de entradas listadas: {lstStock.Count}";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

using ClosedXML.Excel;
using JuanApp.Areas.BasicCore.Entities;
using JuanApp.Areas.BasicCore.Interfaces;
using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Formularios.Herramientas;
using JuanApp.Formularios.Herramientas.Remito;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp
{
    public partial class Main : Form
    {
        private readonly ServiceProvider _serviceProvider;

        private readonly IFailureRepository _failureRepository;

        private readonly IEntradaRepository _entradaRepository;
        private readonly IEntradaService _entradaService;

        public Main(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _failureRepository = serviceProvider.GetRequiredService<IFailureRepository>();

            _entradaRepository = serviceProvider.GetRequiredService<IEntradaRepository>();
            _entradaService = serviceProvider.GetRequiredService<IEntradaService>();



            InitializeComponent();

            statusLabel.Text = "Bienvenido estimado Juan,¿qué hacemos hoy?";
        }

        private void menuItemSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            try
            {
                Estadisticas Estadisticas = new();
                Estadisticas.ShowDialog();
            }
            catch (Exception ex)
            {
                Failure Failure = new Failure()
                {
                    FailureId = 0,
                    Active = true,
                    UserCreationId = 1,
                    UserLastModificationId = 1,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    Message = ex.Message,
                    EmergencyLevel = 1,
                    StackTrace = ex.StackTrace,
                    Source = ex.Source,
                    Comment = ""
                };
                _failureRepository.Add(Failure);

                MessageBox.Show($@"Error: {ex.Message}", "Error");
            }
        }

        private void btnEntradaConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                Formularios.Entrada.ConsultaEntrada ConsultaEntrada = new(_serviceProvider);
                ConsultaEntrada.ShowDialog();
            }
            catch (Exception ex)
            {
                Failure Failure = new Failure()
                {
                    FailureId = 0,
                    Active = true,
                    UserCreationId = 1,
                    UserLastModificationId = 1,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    Message = ex.Message,
                    EmergencyLevel = 1,
                    StackTrace = ex.StackTrace,
                    Source = ex.Source,
                    Comment = ""
                };
                _failureRepository.Add(Failure);

                MessageBox.Show($@"Error: {ex.Message}", "Error");
            }
        }

        private void btnEntradaCargarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string FilePath = openFileDialog.FileName;

                    var WorkBook = new XLWorkbook(FilePath);
                    var Rows = WorkBook.Worksheet(1).RangeUsed().RowsUsed();

                    foreach (var row in Rows)
                    {
                        string ExitWords = row.Cell(1).GetString();
                        if (ExitWords == "Total KG")
                        {
                            break;
                        }

                        var rowNumber = row.RowNumber();

                        if (rowNumber > 6)
                        {
                            int NroDePesaje = Convert.ToInt32(row.Cell(1).GetString());
                            string CodigoDeProducto = row.Cell(2).GetString();
                            string NombreDeProducto = row.Cell(3).GetString();
                            int TexContenido = Convert.ToInt32(row.Cell(4).GetString());
                            decimal Neto = Convert.ToDecimal(row.Cell(5).GetString()); ;

                            //TODO Agregar el codigo de barra
                            Areas.JuanApp.Entities.Entrada Entrada = new()
                            {
                                EntradaId = 0,
                                Active = true,
                                DateTimeCreation = DateTime.Now,
                                DateTimeLastModification = DateTime.Now,
                                UserCreationId = 1,
                                UserLastModificationId = 1,
                                CodigoDeBarra = "",
                                NroDePesaje = NroDePesaje,
                                CodigoDeProducto = CodigoDeProducto,
                                NombreDeProducto = NombreDeProducto,
                                TexContenido = TexContenido,
                                Neto = Neto
                            };

                            Areas.JuanApp.Entities.Entrada EntradaDePrueba = _entradaRepository
                                .AsQueryable()
                                .Where(x => x.NroDePesaje == Entrada.NroDePesaje)
                                .FirstOrDefault();

                            if (EntradaDePrueba == null)
                            {
                                _entradaRepository.Add(Entrada);
                            }
                            else
                            {
                                MessageBox.Show($@"El registro con Nº de pesada {NroDePesaje} 
ya existe en la base de datos", "Atención");

                                // Mostrar la ventana de confirmación
                                if (MessageBox.Show("¿Desea cancelar el proceso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    break;
                                }
                            }
                        }
                    }

                    MessageBox.Show($@"Carga de datos realizada correctamente", "Información");
                }
            }
            catch (Exception ex)
            {
                Failure Failure = new Failure()
                {
                    FailureId = 0,
                    Active = true,
                    UserCreationId = 1,
                    UserLastModificationId = 1,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    Message = ex.Message,
                    EmergencyLevel = 1,
                    StackTrace = ex.StackTrace,
                    Source = ex.Source,
                    Comment = ""
                };
                _failureRepository.Add(Failure);

                MessageBox.Show($@"Error: {ex.Message}", "Error");
            }
        }

        private void btnSalidaConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                Formularios.Salida.ConsultaSalida ConsultaSalida = new(_serviceProvider);
                ConsultaSalida.ShowDialog();
            }
            catch (Exception ex)
            {
                Failure Failure = new Failure()
                {
                    FailureId = 0,
                    Active = true,
                    UserCreationId = 1,
                    UserLastModificationId = 1,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    Message = ex.Message,
                    EmergencyLevel = 1,
                    StackTrace = ex.StackTrace,
                    Source = ex.Source,
                    Comment = ""
                };
                _failureRepository.Add(Failure);

                MessageBox.Show($@"Error: {ex.Message}", "Error");
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            try
            {
                Stock Stock = new();
                Stock.ShowDialog();
            }
            catch (Exception ex)
            {
                Failure Failure = new Failure()
                {
                    FailureId = 0,
                    Active = true,
                    UserCreationId = 1,
                    UserLastModificationId = 1,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    Message = ex.Message,
                    EmergencyLevel = 1,
                    StackTrace = ex.StackTrace,
                    Source = ex.Source,
                    Comment = ""
                };
                _failureRepository.Add(Failure);

                MessageBox.Show($@"Error: {ex.Message}", "Error");
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Formularios.Herramientas.Producto.ConsultaProducto ConsultaProducto = new(_serviceProvider);
                ConsultaProducto.ShowDialog();
            }
            catch (Exception ex)
            {
                Failure Failure = new Failure()
                {
                    FailureId = 0,
                    Active = true,
                    UserCreationId = 1,
                    UserLastModificationId = 1,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    Message = ex.Message,
                    EmergencyLevel = 1,
                    StackTrace = ex.StackTrace,
                    Source = ex.Source,
                    Comment = ""
                };
                _failureRepository.Add(Failure);

                MessageBox.Show($@"Error: {ex.Message}", "Error");
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Formularios.Herramientas.Cliente.ConsultaCliente ConsultaCliente = new(_serviceProvider);
                ConsultaCliente.ShowDialog();
            }
            catch (Exception ex)
            {
                Failure Failure = new Failure()
                {
                    FailureId = 0,
                    Active = true,
                    UserCreationId = 1,
                    UserLastModificationId = 1,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    Message = ex.Message,
                    EmergencyLevel = 1,
                    StackTrace = ex.StackTrace,
                    Source = ex.Source,
                    Comment = ""
                };
                _failureRepository.Add(Failure);

                MessageBox.Show($@"Error: {ex.Message}", "Error");
            }
        }

        private void btnRemito_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaRemito ConsultaRemito = new(_serviceProvider);
                ConsultaRemito.ShowDialog();
            }
            catch (Exception ex)
            {
                Failure Failure = new Failure()
                {
                    FailureId = 0,
                    Active = true,
                    UserCreationId = 1,
                    UserLastModificationId = 1,
                    DateTimeCreation = DateTime.Now,
                    DateTimeLastModification = DateTime.Now,
                    Message = ex.Message,
                    EmergencyLevel = 1,
                    StackTrace = ex.StackTrace,
                    Source = ex.Source,
                    Comment = ""
                };
                _failureRepository.Add(Failure);

                MessageBox.Show($@"Error: {ex.Message}", "Error");
            }
        }
    }
}

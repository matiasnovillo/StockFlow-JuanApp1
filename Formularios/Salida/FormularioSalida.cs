using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Areas.JuanApp.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.Salida
{
    public partial class FormularioSalida : Form
    {
        private readonly ISalidaRepository _salidaRepository;
        private readonly ISalidaService _salidaService;
        private readonly IProductoRepository _productoRepository;
        private readonly int _salidaId;
        public FormularioSalida(IServiceProvider serviceProvider,
            int salidaId)
        {
            _salidaRepository = serviceProvider.GetRequiredService<ISalidaRepository>();
            _salidaService = serviceProvider.GetRequiredService<ISalidaService>();
            _productoRepository = serviceProvider.GetRequiredService<IProductoRepository>();

            _salidaId = salidaId;

            InitializeComponent();

            if (salidaId > 0)
            {
                Areas.JuanApp.Entities.Salida Salida = _salidaRepository
                                                                    .GetBySalidaId(salidaId);

                txtCodigoDeCliente.Text = Salida.CodigoDeCliente;
                txtNombreDeCliente.Text = Salida.NombreDeCliente;
                txtCodigoDeBarra.Text = Salida.CodigoDeBarra;
                txtCodigoDeProducto.Text = Salida.CodigoDeProducto.ToString();
                txtNombreProducto.Text = Salida.NombreDeProducto;
                numericUpDownKilosTotales.Value = Salida.KilosReales;
                numericUpDownPrecio.Value = Salida.Precio;
                numericUpDownSubtotal.Value = Salida.Subtotal;
            }

            statusLabel.Text = "";
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoDeCliente.Text) ||
               string.IsNullOrEmpty(txtNombreDeCliente.Text) ||
               string.IsNullOrEmpty(txtCodigoDeBarra.Text) ||
               string.IsNullOrEmpty(txtCodigoDeProducto.Text) ||
               string.IsNullOrEmpty(txtNombreProducto.Text) ||
               numericUpDownKilosTotales.Value == 0 ||
               numericUpDownPrecio.Value == 0 ||
               numericUpDownSubtotal.Value == 0)
            {
                statusLabel.Text = "Faltan datos a completar";
            }
            else
            {
                if (_salidaId == 0)
                {
                    //Agregar
                    Areas.JuanApp.Entities.Salida Salida = new()
                    {
                        SalidaId = _salidaId,
                        Active = true,
                        UserCreationId = 1,
                        UserLastModificationId = 1,
                        DateTimeCreation = DateTime.Now,
                        DateTimeLastModification = DateTime.Now,
                        CodigoDeCliente = txtCodigoDeCliente.Text,
                        NombreDeCliente = txtNombreDeCliente.Text,
                        CodigoDeBarra = txtCodigoDeBarra.Text,
                        CodigoDeProducto = Convert.ToInt32(txtCodigoDeProducto.Text),
                        NombreDeProducto = txtNombreProducto.Text,
                        KilosReales = numericUpDownKilosTotales.Value,
                        Precio = numericUpDownPrecio.Value,
                        Subtotal = numericUpDownSubtotal.Value
                    };
                    _salidaRepository.Add(Salida);
                }
                else
                {
                    //Actualizar
                    Areas.JuanApp.Entities.Salida Salida = _salidaRepository.GetBySalidaId(_salidaId);

                    Salida.CodigoDeCliente = txtCodigoDeCliente.Text;
                    Salida.NombreDeCliente = txtNombreDeCliente.Text;
                    Salida.CodigoDeBarra = txtCodigoDeBarra.Text;
                    Salida.CodigoDeProducto = Convert.ToInt32(txtCodigoDeProducto.Text);
                    Salida.NombreDeProducto = txtNombreProducto.Text;
                    Salida.KilosReales = numericUpDownKilosTotales.Value;
                    Salida.Precio = numericUpDownPrecio.Value;
                    Salida.Subtotal = numericUpDownSubtotal.Value;
                    Salida.UserLastModificationId = 1;
                    Salida.DateTimeLastModification = DateTime.Now;

                    _salidaRepository.Update(Salida);
                }

                Hide();
            }
        }
    }
}

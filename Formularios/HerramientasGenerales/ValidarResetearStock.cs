using JuanApp.Areas.JuanApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.HerramientasGenerales
{
    public partial class ValidarResetearStock : Form
    {
        private readonly ServiceProvider _serviceProvider;

        private readonly IEntradaRepository _entradaRepository;
        private readonly ISalidaRepository _salidaRepository;

        public ValidarResetearStock(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _entradaRepository = serviceProvider.GetRequiredService<IEntradaRepository>();
            _salidaRepository = serviceProvider.GetRequiredService<ISalidaRepository>();

            InitializeComponent();
        }

        private void btnResetearStock_Click(object sender, EventArgs e)
        {

            if (txtAValidar.Text == "PAMPA Y BRASA")
            {
                //TODO BORRAR TODO. ESPERAR QUE DICE JUAN DE ESTO

                //Delete all from Entrada and Salida
                _entradaRepository.DeleteAll();
                _salidaRepository.DeleteAll();

                MessageBox.Show("Datos de stock borrados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El texto ingresado es incorrecto. Proceso cancelado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtAValidar.Text = "";
            Close();
        }
    }
}

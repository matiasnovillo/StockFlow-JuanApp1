using JuanApp.Areas.JuanApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.HerramientasGenerales
{
    public partial class Herramientas : Form
    {
        private readonly ServiceProvider _serviceProvider;

        public Herramientas(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
        }

        private void btnResetearStock_Click(object sender, EventArgs e)
        {
            ValidarResetearStock ValidarResetearStock = new ValidarResetearStock(_serviceProvider);

            ValidarResetearStock.ShowDialog();
        }
    }
}

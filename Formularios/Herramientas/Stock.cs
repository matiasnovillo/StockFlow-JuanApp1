using JuanApp.Areas.JuanApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

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
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

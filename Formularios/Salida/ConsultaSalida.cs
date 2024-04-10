using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.Salida
{
    public partial class ConsultaSalida : Form
    {
        public ConsultaSalida(ServiceProvider serviceProvider)
        {
            InitializeComponent();
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

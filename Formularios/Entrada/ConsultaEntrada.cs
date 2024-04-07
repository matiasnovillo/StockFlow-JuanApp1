namespace JuanApp.Formularios.Entrada
{
    public partial class ConsultaEntrada : Form
    {
        public ConsultaEntrada()
        {
            InitializeComponent();
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
            Main Main = new();
            Main.Show();
        }
    }
}

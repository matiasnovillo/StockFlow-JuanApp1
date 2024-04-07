namespace JuanApp.Formularios.Entrada
{
    public partial class FormularioProducto : Form
    {
        public FormularioProducto()
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

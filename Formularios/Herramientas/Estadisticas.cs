namespace JuanApp.Formularios.Herramientas
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
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

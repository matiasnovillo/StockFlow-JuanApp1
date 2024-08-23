namespace JuanApp.Formularios.HerramientasGenerales
{
    public partial class Herramientas : Form
    {
        public Herramientas()
        {
            InitializeComponent();
        }

        private void btnResetearStock_Click(object sender, EventArgs e)
        {
            ValidarResetearStock ValidarResetearStock = new ValidarResetearStock();

            ValidarResetearStock.ShowDialog();
        }
    }
}

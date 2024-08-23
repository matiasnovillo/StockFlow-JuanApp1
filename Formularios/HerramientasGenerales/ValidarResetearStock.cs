namespace JuanApp.Formularios.HerramientasGenerales
{
    public partial class ValidarResetearStock : Form
    {
        public ValidarResetearStock()
        {
            InitializeComponent();
        }

        private void btnResetearStock_Click(object sender, EventArgs e)
        {

            if (txtAValidar.Text == "PAMPA Y BRASA")
            {
                //TODO BORRAR TODO. ESPERAR QUE DICE JUAN DE ESTO

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

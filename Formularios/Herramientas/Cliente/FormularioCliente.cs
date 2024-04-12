using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Areas.JuanApp.Entities;

namespace JuanApp.Formularios.Entrada
{
    public partial class FormularioCliente : Form
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IClienteService _clienteService;
        private readonly int _clienteId;

        public FormularioCliente(IClienteRepository clienteRepository,
            IClienteService clienteService,
            int ClienteId)
        {
            try
            {
                _clienteRepository = clienteRepository;
                _clienteService = clienteService;
                _clienteId = ClienteId;

                InitializeComponent();

                if (ClienteId > 0)
                {
                    Cliente Cliente = _clienteRepository.GetByClienteId(ClienteId);
                    txtCodigoDeCliente.Text = Cliente.CodigoDeCliente;
                    txtNombreDeCliente.Text = Cliente.NombreDeCliente;
                }

                statusLabel.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoDeCliente.Text) ||
                        string.IsNullOrEmpty(txtNombreDeCliente.Text))
                {
                    statusLabel.Text = "Faltan datos a completar";
                }
                else
                {
                    if (_clienteId == 0)
                    {
                        //Agregar
                        Cliente Cliente = new()
                        {
                            ClienteId = _clienteId,
                            Active = true,
                            UserCreationId = 1,
                            UserLastModificationId = 1,
                            DateTimeCreation = DateTime.Now,
                            DateTimeLastModification = DateTime.Now,
                            NombreDeCliente = txtNombreDeCliente.Text,
                            CodigoDeCliente = txtCodigoDeCliente.Text,
                        };
                        _clienteRepository.Add(Cliente);
                    }
                    else
                    {
                        //Actualizar
                        Cliente Cliente = _clienteRepository.GetByClienteId(_clienteId);

                        Cliente.CodigoDeCliente = txtCodigoDeCliente.Text;
                        Cliente.NombreDeCliente = txtNombreDeCliente.Text;
                        Cliente.UserLastModificationId = 1;
                        Cliente.DateTimeLastModification = DateTime.Now;

                        _clienteRepository.Update(Cliente);
                    }

                    Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

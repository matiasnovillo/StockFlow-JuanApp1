using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Formularios.Entrada;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.Herramientas.Cliente
{
    public partial class ConsultaCliente : Form
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IClienteService _clienteService;

        public ConsultaCliente(ServiceProvider serviceProvider)
        {
            try
            {
                _clienteRepository = serviceProvider.GetRequiredService<IClienteRepository>();
                _clienteService = serviceProvider.GetRequiredService<IClienteService>();

                InitializeComponent();

                DataGridViewTextBoxColumn col0 = new();
                col0.DataPropertyName = "ClienteId";
                col0.HeaderText = "ClienteId";
                DataGridViewCliente.Columns.Add(col0);

                DataGridViewTextBoxColumn col1 = new();
                col1.DataPropertyName = "CodigoDeCliente";
                col1.HeaderText = "CodigoDeCliente";
                DataGridViewCliente.Columns.Add(col1);

                DataGridViewTextBoxColumn col2 = new();
                col2.DataPropertyName = "NombreDeCliente";
                col2.HeaderText = "NombreDeCliente";
                DataGridViewCliente.Columns.Add(col2);

                DataGridViewTextBoxColumn col3 = new();
                col3.DataPropertyName = "Domicilio";
                col3.HeaderText = "Domicilio";
                DataGridViewCliente.Columns.Add(col3);

                DataGridViewTextBoxColumn col4 = new();
                col4.DataPropertyName = "Telefono";
                col4.HeaderText = "Telefono";
                DataGridViewCliente.Columns.Add(col4);

                DataGridViewButtonColumn colActualizar = new();
                colActualizar.HeaderText = "Actualizar";
                colActualizar.Text = "Actualizar";
                colActualizar.UseColumnTextForButtonValue = true;
                DataGridViewCliente.Columns.Add(colActualizar);

                DataGridViewButtonColumn colBorrar = new();
                colBorrar.HeaderText = "Borrar";
                colBorrar.Text = "Borrar";
                colBorrar.UseColumnTextForButtonValue = true;
                DataGridViewCliente.Columns.Add(colBorrar);

                DataGridViewCliente.AutoGenerateColumns = false;

                GetTabla();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                GetTabla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    //Actualizar
                    int ClienteId = Convert.ToInt32(DataGridViewCliente.Rows[e.RowIndex].Cells[0].Value.ToString());

                    FormularioCliente FormularioCliente = new(_clienteRepository,
                    _clienteService,
                    ClienteId);

                    FormularioCliente.ShowDialog();

                    GetTabla();
                }
                else if (e.ColumnIndex == 4)
                {
                    //Borrar
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int ClienteId = Convert.ToInt32(DataGridViewCliente.Rows[e.RowIndex].Cells[0].Value.ToString());

                        _clienteRepository.DeleteByClienteId(ClienteId);

                        GetTabla();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioCliente FormularioCliente = new(_clienteRepository,
                        _clienteService,
                        0);

                FormularioCliente.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GetTabla()
        {
            try
            {
                List<Areas.JuanApp.Entities.Cliente> lstCliente = [];

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstCliente = _clienteRepository
                    .AsQueryable()
                    .OrderBy(x => x.ClienteId)
                    .ToList();
                }
                else
                {
                    lstCliente = _clienteRepository
                    .AsQueryable()
                    .Where(x => x.NombreDeCliente == txtBuscar.Text)
                    .OrderBy(x => x.ClienteId)
                    .ToList();
                }

                DataGridViewCliente.DataSource = lstCliente;

                statusLabel.Text = $@"Información: Cantidad de clientes listados: {lstCliente.Count}";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

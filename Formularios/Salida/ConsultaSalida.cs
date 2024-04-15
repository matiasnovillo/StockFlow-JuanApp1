using DocumentFormat.OpenXml.Spreadsheet;
using JuanApp.Areas.JuanApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using PdfSharp;
using PdfSharp.Pdf;
using System.Text.RegularExpressions;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace JuanApp.Formularios.Salida
{
    public partial class ConsultaSalida : Form
    {
        private readonly ISalidaRepository _salidaRepository;
        private readonly ISalidaService _salidaService;
        private readonly ServiceProvider _serviceProvider;

        public ConsultaSalida(ServiceProvider serviceProvider)
        {
            try
            {
                _serviceProvider = serviceProvider;
                _salidaRepository = serviceProvider.GetRequiredService<ISalidaRepository>();
                _salidaService = serviceProvider.GetRequiredService<ISalidaService>();

                InitializeComponent();

                DataGridViewTextBoxColumn col0 = new();
                col0.DataPropertyName = "SalidaId";
                col0.HeaderText = "SalidaId";
                DataGridViewSalida.Columns.Add(col0);

                DataGridViewTextBoxColumn col1 = new();
                col1.DataPropertyName = "CodigoDeCliente";
                col1.HeaderText = "CodigoDeCliente";
                DataGridViewSalida.Columns.Add(col1);

                DataGridViewTextBoxColumn col2 = new();
                col2.DataPropertyName = "NombreDeCliente";
                col2.HeaderText = "NombreDeCliente";
                DataGridViewSalida.Columns.Add(col2);

                DataGridViewTextBoxColumn col3 = new();
                col3.DataPropertyName = "CodigoDeProducto";
                col3.HeaderText = "CodigoDeProducto";
                DataGridViewSalida.Columns.Add(col3);

                DataGridViewTextBoxColumn col4 = new();
                col4.DataPropertyName = "NombreDeProducto";
                col4.HeaderText = "NombreDeProducto";
                DataGridViewSalida.Columns.Add(col4);

                DataGridViewTextBoxColumn col5 = new();
                col5.DataPropertyName = "KilosReales";
                col5.HeaderText = "KilosReales";
                DataGridViewSalida.Columns.Add(col5);

                DataGridViewTextBoxColumn col6 = new();
                col6.DataPropertyName = "Precio";
                col6.HeaderText = "Precio";
                DataGridViewSalida.Columns.Add(col6);

                DataGridViewTextBoxColumn col7 = new();
                col7.DataPropertyName = "Subtotal";
                col7.HeaderText = "Subtotal";
                DataGridViewSalida.Columns.Add(col7);

                DataGridViewButtonColumn colActualizar = new();
                colActualizar.HeaderText = "Actualizar";
                colActualizar.Text = "Actualizar";
                colActualizar.UseColumnTextForButtonValue = true;
                DataGridViewSalida.Columns.Add(colActualizar);

                DataGridViewButtonColumn colBorrar = new();
                colBorrar.HeaderText = "Borrar";
                colBorrar.Text = "Borrar";
                colBorrar.UseColumnTextForButtonValue = true;
                DataGridViewSalida.Columns.Add(colBorrar);

                DataGridViewSalida.AutoGenerateColumns = false;

                dateTimePickerFechaInicio.Value = DateTime.Now.AddDays(-30);
                dateTimePickerFechaFin.Value = DateTime.Now.AddDays(1);

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

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string SelectedPath = FolderBrowserDialog.SelectedPath;

                List<Areas.JuanApp.Entities.Salida> lstSalida = GetTabla();

                string AjaxForString = "";

                foreach (Areas.JuanApp.Entities.Salida salida in lstSalida)
                {
                    AjaxForString += $@"{salida.SalidaId},";
                }

                AjaxForString = AjaxForString.TrimEnd(',');

                _salidaService.ExportAsExcel(lstSalida, 
                    new() { AjaxForString = AjaxForString }, 
                    "NotAll", 
                    SelectedPath);

                MessageBox.Show($@"Generación de Excel realizada correctamente", "Información");
            }    
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string SelectedPath = FolderBrowserDialog.SelectedPath;

                string HTML = $@"
<html>
    <head>
    </head>
    <body>
        <p>&nbsp;</p>
        <table style=""border-collapse: collapse; width: 100%;"" border=""1"">
        <tbody>
        <tr>
        <td style=""width: 25%;"">[Logo]</td>
        <td style=""width: 25%;"">
        <p>Raz&oacute;n social</p>
        <p>CUIT</p>
        <p>Direcci&oacute;n</p>
        <p>Localidad</p>
        <p>Tel&eacute;fono</p>
        </td>
        <td style=""width: 25%;"">
        <p>Pampa y Brasa SRL</p>
        <p>30-71819155-2</p>
        <p>Lima 1333</p>
        <p>Martinez</p>
        <p>1164943915</p>
        </td>
        <td style=""width: 25%;"">
        <p>Remito</p>
        <p>N&ordm; [NroDeRemito]</p>
        <p>Fecha</p>
        <p>[FechaDeRemito]</p>
        </td>
        </tr>
        </tbody>
        </table>
        <table style=""border-collapse: collapse; width: 100%; height: 142px;"" border=""1"">
        <tbody>
        <tr style=""height: 142px;"">
        <td style=""width: 25%; height: 142px;"">
        <p>Nombre</p>
        <p>Domicilio</p>
        <p>Localidad</p>
        <p>CUIT</p>
        </td>
        <td style=""width: 25%; height: 142px;"">
        <p>[NombreCliente]</p>
        <p>[DireccionCliente]</p>
        <p>[LocalidadCliente]</p>
        <p>[CUITCliente]</p>
        </td>
        <td style=""width: 25%; height: 142px;"">
        <p>Tel&eacute;fono</p>
        <p>CP</p>
        <p>Provincia</p>
        </td>
        <td style=""width: 25%; height: 142px;"">
        <p>[TelefonoCliente]</p>
        <p>[CodigoPostalCliente]</p>
        <p>[ProvinciaCliente]</p>
        </td>
        </tr>
        </tbody>
        </table>
        <table style=""border-collapse: collapse; width: 100%;"" border=""1"">
        <tbody>
        <tr>
        <td style=""width: 20%;"">Art&iacute;culo</td>
        <td style=""width: 20%;"">Descripci&oacute;n</td>
        <td style=""width: 20%;"">Cantidad (KG)</td>
        <td style=""width: 20%;"">Precio ($)</td>
        <td style=""width: 20%;"">Subtotal ($)</td>
        </tr>
        <tr>
        <td style=""width: 20%;"">&nbsp;</td>
        <td style=""width: 20%;"">&nbsp;</td>
        <td style=""width: 20%;"">&nbsp;</td>
        <td style=""width: 20%;"">&nbsp;</td>
        <td style=""width: 20%;"">&nbsp;</td>
        </tr>
        </tbody>
        </table>
        <table style=""border-collapse: collapse; width: 100%;"" border=""1"">
        <tbody>
        <tr>
        <td style=""width: 33.3333%;"">&nbsp;</td>
        <td style=""width: 33.3333%;"">&nbsp;</td>
        <td style=""width: 33.3333%;"">
        <p>Cantidad total: [CantidadTotal]</p>
        <p>Precio total: [PrecioTotal]</p>
        <p>TOTAL: [Total]</p>
        </td>
        </tr>
        </tbody>
        </table>
        <table style=""border-collapse: collapse; width: 100%;"" border=""1"">
        <tbody>
        <tr>
        <td style=""width: 50%;"">
        <p>Recibi conforme:</p>
        <p>&nbsp;</p>
        </td>
        <td style=""width: 50%;"">
        <p>Firma y sello:</p>
        <p>&nbsp;</p>
        </td>
        </tr>
        </tbody>
        </table>
    </body>
</html>";

                PdfSharp.Pdf.PdfDocument documento = PdfGenerator.GeneratePdf(HTML, PageSize.A4);
                documento.Save($@"{SelectedPath}\Salida_{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.pdf");

                MessageBox.Show($@"Generación de PDF realizada correctamente", "Información");
            }
        }

        private void DataGridViewSalida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 8)
                {
                    //Actualizar
                    int EntradaId = Convert.ToInt32(DataGridViewSalida.Rows[e.RowIndex].Cells[0].Value.ToString());

                    FormularioSalida FormularioSalida = new(_serviceProvider,
                    EntradaId);

                    FormularioSalida.ShowDialog();

                    GetTabla();
                }
                else if (e.ColumnIndex == 9)
                {
                    //Borrar
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int EntradaId = Convert.ToInt32(DataGridViewSalida.Rows[e.RowIndex].Cells[0].Value.ToString());

                        _salidaRepository.DeleteBySalidaId(EntradaId);

                        GetTabla();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<Areas.JuanApp.Entities.Salida> GetTabla()
        {
            try
            {
                List<Areas.JuanApp.Entities.Salida> lstSalida = [];

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    lstSalida = _salidaRepository
                    .AsQueryable()
                    .Where(x => x.DateTimeLastModification >= dateTimePickerFechaInicio.Value &&
                    x.DateTimeLastModification <= dateTimePickerFechaFin.Value)
                    .OrderBy(x => x.NombreDeProducto)
                    .Take(500)
                    .ToList();
                }
                else
                {
                    string[] words = Regex
                        .Replace(txtBuscar.Text
                        .Trim(), @"\s+", " ")
                        .Split(" ");

                    lstSalida = _salidaRepository
                    .AsQueryable()
                    .Where(x => words.Any(word => x.CodigoDeCliente.Contains(word)) ||
                    words.Any(word => x.NombreDeCliente.ToString().Contains(word)) ||
                    words.Any(word => x.NombreDeProducto.ToString().Contains(word)) ||
                    words.Any(word => x.CodigoDeProducto.ToString().Contains(word)))
                    .Where(x => x.DateTimeLastModification >= dateTimePickerFechaInicio.Value &&
                    x.DateTimeLastModification <= dateTimePickerFechaFin.Value)
                    .OrderBy(x => x.NombreDeProducto)
                    .Take(500)
                    .ToList();
                }

                decimal KilosRealesTotal = 0;
                decimal PrecioTotal = 0;
                decimal SubtotalTotal = 0;
                foreach (Areas.JuanApp.Entities.Salida salida in lstSalida)
                {
                    KilosRealesTotal += salida.KilosReales;
                    PrecioTotal += salida.Precio;
                    SubtotalTotal += salida.Subtotal;
                }
                txtKilosRealesTotal.Text = KilosRealesTotal.ToString();
                txtPrecioTotal.Text = PrecioTotal.ToString();
                txtSubtotalTotal.Text = SubtotalTotal.ToString();

                DataGridViewSalida.DataSource = lstSalida;

                statusLabel.Text = $@"Información: Cantidad de entradas listadas: {lstSalida.Count}. Se muestran solo los últimos 500 registros";

                return lstSalida;
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
                FormularioSalida FormularioSalida = new(_serviceProvider,
                        0);

                FormularioSalida.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

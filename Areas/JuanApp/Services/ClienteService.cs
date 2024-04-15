using System.Data;
using System.Globalization;
using ClosedXML.Excel;
using CsvHelper;
using JuanApp.Areas.BasicCore;
using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Library;

/*
 * GUID:e6c09dfe-3a3e-461b-b3f9-734aee05fc7b
 * 
 * Coded by fiyistack.com
 * Copyright © 2024
 * 
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 * 
 */

namespace JuanApp.Areas.JuanApp.Services
{
    public class ClienteService : IClienteService
    {
        protected readonly JuanAppContext _context;

        public ClienteService(JuanAppContext context)
        {
            _context = context;
        }

        #region Exportations
        public DateTime ExportAsPDF(Ajax Ajax, string ExportationType)
        {
            var Renderer = new HtmlToPdf();
            DateTime Now = DateTime.Now;
            string RowsAsHTML = "";
            List<Cliente> lstCliente = [];

            if (ExportationType == "All")
            {
                lstCliente = _context.Cliente.ToList();
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                foreach (string RowChecked in RowsChecked)
                {
                    Cliente Cliente = _context.Cliente
                                                .Where(x => x.ClienteId == Convert.ToInt32(RowChecked))
                                                .FirstOrDefault();
                    lstCliente.Add(Cliente);
                }
            }

            foreach (Cliente row in lstCliente)
            {
                RowsAsHTML += $@"{row.ToStringOnlyValuesForHTML()}";
            }

            Renderer.RenderHtmlAsPdf($@"<table cellpadding=""0"" cellspacing=""0"" border=""0"" width=""88%"" style=""width: 88% !important; min-width: 88%; max-width: 88%;"">
    <tr>
    <td align=""left"" valign=""top"">
        <font face=""'Source Sans Pro', sans-serif"" color=""#1a1a1a"" style=""font-size: 52px; line-height: 55px; font-weight: 300; letter-spacing: -1.5px;"">
            <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #1a1a1a; font-size: 52px; line-height: 55px; font-weight: 300; letter-spacing: -1.5px;"">Mikromatica</span>
        </font>
        <div style=""height: 25px; line-height: 25px; font-size: 23px;"">&nbsp;</div>
        <font face=""'Source Sans Pro', sans-serif"" color=""#4c4c4c"" style=""font-size: 36px; line-height: 45px; font-weight: 300; letter-spacing: -1px;"">
            <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #4c4c4c; font-size: 36px; line-height: 45px; font-weight: 300; letter-spacing: -1px;"">Registers of Cliente</span>
        </font>
        <div style=""height: 35px; line-height: 35px; font-size: 33px;"">&nbsp;</div>
    </td>
    </tr>
</table>
<br>
<table cellpadding=""0"" cellspacing=""0"" border=""0"" width=""100%"" style=""width: 100% !important; min-width: 100%; max-width: 100%;"">
    <tr>
        <th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">ClienteId&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Active&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">DateTimeCreation&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">DateTimeLastModification&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">UserCreationId&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">UserLastModificationId&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">NombreDeCliente&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">CodigoDeCliente&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Domicilio&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Localidad&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">CUIT&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Telefono&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">CodigoPostal&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Provincia&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th>
    </tr>
    {RowsAsHTML}
</table>
<br>
<font face=""'Source Sans Pro', sans-serif"" color=""#868686"" style=""font-size: 17px; line-height: 20px;"">
    <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #868686; font-size: 17px; line-height: 20px;"">Printed on: {Now}</span>
</font>
").SaveAs($@"wwwroot/PDFFiles/JuanApp/Cliente/Cliente_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.pdf");

            return Now;
        }

        public DateTime ExportAsExcel(Ajax Ajax, string ExportationType)
        {
            DateTime Now = DateTime.Now;

            using var Book = new XLWorkbook();

            if (ExportationType == "All")
            {
                DataTable dtCliente = new();

                //We define another DataTable dtClienteCopy to avoid issue related to DateTime conversion
                DataTable dtClienteCopy = new();
                dtClienteCopy.TableName = "Cliente";

                #region Define columns for dtClienteCopy
                DataColumn dtColumnClienteIdFordtClienteCopy = new DataColumn();
                    dtColumnClienteIdFordtClienteCopy.DataType = typeof(string);
                    dtColumnClienteIdFordtClienteCopy.ColumnName = "ClienteId";
                    dtClienteCopy.Columns.Add(dtColumnClienteIdFordtClienteCopy);

                    DataColumn dtColumnActiveFordtClienteCopy = new DataColumn();
                    dtColumnActiveFordtClienteCopy.DataType = typeof(string);
                    dtColumnActiveFordtClienteCopy.ColumnName = "Active";
                    dtClienteCopy.Columns.Add(dtColumnActiveFordtClienteCopy);

                    DataColumn dtColumnDateTimeCreationFordtClienteCopy = new DataColumn();
                    dtColumnDateTimeCreationFordtClienteCopy.DataType = typeof(string);
                    dtColumnDateTimeCreationFordtClienteCopy.ColumnName = "DateTimeCreation";
                    dtClienteCopy.Columns.Add(dtColumnDateTimeCreationFordtClienteCopy);

                    DataColumn dtColumnDateTimeLastModificationFordtClienteCopy = new DataColumn();
                    dtColumnDateTimeLastModificationFordtClienteCopy.DataType = typeof(string);
                    dtColumnDateTimeLastModificationFordtClienteCopy.ColumnName = "DateTimeLastModification";
                    dtClienteCopy.Columns.Add(dtColumnDateTimeLastModificationFordtClienteCopy);

                    DataColumn dtColumnUserCreationIdFordtClienteCopy = new DataColumn();
                    dtColumnUserCreationIdFordtClienteCopy.DataType = typeof(string);
                    dtColumnUserCreationIdFordtClienteCopy.ColumnName = "UserCreationId";
                    dtClienteCopy.Columns.Add(dtColumnUserCreationIdFordtClienteCopy);

                    DataColumn dtColumnUserLastModificationIdFordtClienteCopy = new DataColumn();
                    dtColumnUserLastModificationIdFordtClienteCopy.DataType = typeof(string);
                    dtColumnUserLastModificationIdFordtClienteCopy.ColumnName = "UserLastModificationId";
                    dtClienteCopy.Columns.Add(dtColumnUserLastModificationIdFordtClienteCopy);

                    DataColumn dtColumnNombreDeClienteFordtClienteCopy = new DataColumn();
                    dtColumnNombreDeClienteFordtClienteCopy.DataType = typeof(string);
                    dtColumnNombreDeClienteFordtClienteCopy.ColumnName = "NombreDeCliente";
                    dtClienteCopy.Columns.Add(dtColumnNombreDeClienteFordtClienteCopy);

                    DataColumn dtColumnCodigoDeClienteFordtClienteCopy = new DataColumn();
                    dtColumnCodigoDeClienteFordtClienteCopy.DataType = typeof(string);
                    dtColumnCodigoDeClienteFordtClienteCopy.ColumnName = "CodigoDeCliente";
                    dtClienteCopy.Columns.Add(dtColumnCodigoDeClienteFordtClienteCopy);

                    DataColumn dtColumnDomicilioFordtClienteCopy = new DataColumn();
                    dtColumnDomicilioFordtClienteCopy.DataType = typeof(string);
                    dtColumnDomicilioFordtClienteCopy.ColumnName = "Domicilio";
                    dtClienteCopy.Columns.Add(dtColumnDomicilioFordtClienteCopy);

                    DataColumn dtColumnLocalidadFordtClienteCopy = new DataColumn();
                    dtColumnLocalidadFordtClienteCopy.DataType = typeof(string);
                    dtColumnLocalidadFordtClienteCopy.ColumnName = "Localidad";
                    dtClienteCopy.Columns.Add(dtColumnLocalidadFordtClienteCopy);

                    DataColumn dtColumnCUITFordtClienteCopy = new DataColumn();
                    dtColumnCUITFordtClienteCopy.DataType = typeof(string);
                    dtColumnCUITFordtClienteCopy.ColumnName = "CUIT";
                    dtClienteCopy.Columns.Add(dtColumnCUITFordtClienteCopy);

                    DataColumn dtColumnTelefonoFordtClienteCopy = new DataColumn();
                    dtColumnTelefonoFordtClienteCopy.DataType = typeof(string);
                    dtColumnTelefonoFordtClienteCopy.ColumnName = "Telefono";
                    dtClienteCopy.Columns.Add(dtColumnTelefonoFordtClienteCopy);

                    DataColumn dtColumnCodigoPostalFordtClienteCopy = new DataColumn();
                    dtColumnCodigoPostalFordtClienteCopy.DataType = typeof(string);
                    dtColumnCodigoPostalFordtClienteCopy.ColumnName = "CodigoPostal";
                    dtClienteCopy.Columns.Add(dtColumnCodigoPostalFordtClienteCopy);

                    DataColumn dtColumnProvinciaFordtClienteCopy = new DataColumn();
                    dtColumnProvinciaFordtClienteCopy.DataType = typeof(string);
                    dtColumnProvinciaFordtClienteCopy.ColumnName = "Provincia";
                    dtClienteCopy.Columns.Add(dtColumnProvinciaFordtClienteCopy);

                    
                #endregion

                #region Create another DataTable to copy
                List<Cliente> lstCliente = _context.Cliente.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("ClienteId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("NombreDeCliente", typeof(string));
                DataTable.Columns.Add("CodigoDeCliente", typeof(string));
                DataTable.Columns.Add("Domicilio", typeof(string));
                DataTable.Columns.Add("Localidad", typeof(string));
                DataTable.Columns.Add("CUIT", typeof(string));
                DataTable.Columns.Add("Telefono", typeof(string));
                DataTable.Columns.Add("CodigoPostal", typeof(string));
                DataTable.Columns.Add("Provincia", typeof(string));
                

                foreach (Cliente cliente in lstCliente)
                        {
                            DataTable.Rows.Add(
                                cliente.ClienteId,
                        cliente.Active,
                        cliente.DateTimeCreation,
                        cliente.DateTimeLastModification,
                        cliente.UserCreationId,
                        cliente.UserLastModificationId,
                        cliente.NombreDeCliente,
                        cliente.CodigoDeCliente,
                        cliente.Domicilio,
                        cliente.Localidad,
                        cliente.CUIT,
                        cliente.Telefono,
                        cliente.CodigoPostal,
                        cliente.Provincia);
                        }
                #endregion

                dtCliente = DataTable;

                foreach (DataRow DataRow in dtCliente.Rows)
                {
                    dtClienteCopy.Rows.Add(DataRow.ItemArray);
                }

                var Sheet = Book.Worksheets.Add(dtClienteCopy);

                Sheet.ColumnsUsed().AdjustToContents();

                Book.SaveAs($@"wwwroot/ExcelFiles/JuanApp/Cliente/Cliente_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.xlsx");
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                DataSet dsCliente = new();

                foreach (string RowChecked in RowsChecked)
                {
                    //We define another DataTable dtClienteCopy to avoid issue related to DateTime conversion
                    DataTable dtClienteCopy = new();

                    #region Define columns for dtClienteCopy
                    DataColumn dtColumnClienteIdFordtClienteCopy = new DataColumn();
                    dtColumnClienteIdFordtClienteCopy.DataType = typeof(string);
                    dtColumnClienteIdFordtClienteCopy.ColumnName = "ClienteId";
                    dtClienteCopy.Columns.Add(dtColumnClienteIdFordtClienteCopy);

                    DataColumn dtColumnActiveFordtClienteCopy = new DataColumn();
                    dtColumnActiveFordtClienteCopy.DataType = typeof(string);
                    dtColumnActiveFordtClienteCopy.ColumnName = "Active";
                    dtClienteCopy.Columns.Add(dtColumnActiveFordtClienteCopy);

                    DataColumn dtColumnDateTimeCreationFordtClienteCopy = new DataColumn();
                    dtColumnDateTimeCreationFordtClienteCopy.DataType = typeof(string);
                    dtColumnDateTimeCreationFordtClienteCopy.ColumnName = "DateTimeCreation";
                    dtClienteCopy.Columns.Add(dtColumnDateTimeCreationFordtClienteCopy);

                    DataColumn dtColumnDateTimeLastModificationFordtClienteCopy = new DataColumn();
                    dtColumnDateTimeLastModificationFordtClienteCopy.DataType = typeof(string);
                    dtColumnDateTimeLastModificationFordtClienteCopy.ColumnName = "DateTimeLastModification";
                    dtClienteCopy.Columns.Add(dtColumnDateTimeLastModificationFordtClienteCopy);

                    DataColumn dtColumnUserCreationIdFordtClienteCopy = new DataColumn();
                    dtColumnUserCreationIdFordtClienteCopy.DataType = typeof(string);
                    dtColumnUserCreationIdFordtClienteCopy.ColumnName = "UserCreationId";
                    dtClienteCopy.Columns.Add(dtColumnUserCreationIdFordtClienteCopy);

                    DataColumn dtColumnUserLastModificationIdFordtClienteCopy = new DataColumn();
                    dtColumnUserLastModificationIdFordtClienteCopy.DataType = typeof(string);
                    dtColumnUserLastModificationIdFordtClienteCopy.ColumnName = "UserLastModificationId";
                    dtClienteCopy.Columns.Add(dtColumnUserLastModificationIdFordtClienteCopy);

                    DataColumn dtColumnNombreDeClienteFordtClienteCopy = new DataColumn();
                    dtColumnNombreDeClienteFordtClienteCopy.DataType = typeof(string);
                    dtColumnNombreDeClienteFordtClienteCopy.ColumnName = "NombreDeCliente";
                    dtClienteCopy.Columns.Add(dtColumnNombreDeClienteFordtClienteCopy);

                    DataColumn dtColumnCodigoDeClienteFordtClienteCopy = new DataColumn();
                    dtColumnCodigoDeClienteFordtClienteCopy.DataType = typeof(string);
                    dtColumnCodigoDeClienteFordtClienteCopy.ColumnName = "CodigoDeCliente";
                    dtClienteCopy.Columns.Add(dtColumnCodigoDeClienteFordtClienteCopy);

                    DataColumn dtColumnDomicilioFordtClienteCopy = new DataColumn();
                    dtColumnDomicilioFordtClienteCopy.DataType = typeof(string);
                    dtColumnDomicilioFordtClienteCopy.ColumnName = "Domicilio";
                    dtClienteCopy.Columns.Add(dtColumnDomicilioFordtClienteCopy);

                    DataColumn dtColumnLocalidadFordtClienteCopy = new DataColumn();
                    dtColumnLocalidadFordtClienteCopy.DataType = typeof(string);
                    dtColumnLocalidadFordtClienteCopy.ColumnName = "Localidad";
                    dtClienteCopy.Columns.Add(dtColumnLocalidadFordtClienteCopy);

                    DataColumn dtColumnCUITFordtClienteCopy = new DataColumn();
                    dtColumnCUITFordtClienteCopy.DataType = typeof(string);
                    dtColumnCUITFordtClienteCopy.ColumnName = "CUIT";
                    dtClienteCopy.Columns.Add(dtColumnCUITFordtClienteCopy);

                    DataColumn dtColumnTelefonoFordtClienteCopy = new DataColumn();
                    dtColumnTelefonoFordtClienteCopy.DataType = typeof(string);
                    dtColumnTelefonoFordtClienteCopy.ColumnName = "Telefono";
                    dtClienteCopy.Columns.Add(dtColumnTelefonoFordtClienteCopy);

                    DataColumn dtColumnCodigoPostalFordtClienteCopy = new DataColumn();
                    dtColumnCodigoPostalFordtClienteCopy.DataType = typeof(string);
                    dtColumnCodigoPostalFordtClienteCopy.ColumnName = "CodigoPostal";
                    dtClienteCopy.Columns.Add(dtColumnCodigoPostalFordtClienteCopy);

                    DataColumn dtColumnProvinciaFordtClienteCopy = new DataColumn();
                    dtColumnProvinciaFordtClienteCopy.DataType = typeof(string);
                    dtColumnProvinciaFordtClienteCopy.ColumnName = "Provincia";
                    dtClienteCopy.Columns.Add(dtColumnProvinciaFordtClienteCopy);

                    
                    #endregion

                    dsCliente.Tables.Add(dtClienteCopy);

                    #region Create DataTable with data from DB
                        Cliente cliente = _context.Cliente
                                                    .Where(x => x.ClienteId == Convert.ToInt32(RowChecked))
                                                    .FirstOrDefault();

                        DataTable DataTable = new();
                        DataTable.Columns.Add("ClienteId", typeof(string));
                        DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("NombreDeCliente", typeof(string));
                DataTable.Columns.Add("CodigoDeCliente", typeof(string));
                DataTable.Columns.Add("Domicilio", typeof(string));
                DataTable.Columns.Add("Localidad", typeof(string));
                DataTable.Columns.Add("CUIT", typeof(string));
                DataTable.Columns.Add("Telefono", typeof(string));
                DataTable.Columns.Add("CodigoPostal", typeof(string));
                DataTable.Columns.Add("Provincia", typeof(string));
                
                        
                        DataTable.Rows.Add(
                                cliente.ClienteId,
                        cliente.Active,
                        cliente.DateTimeCreation,
                        cliente.DateTimeLastModification,
                        cliente.UserCreationId,
                        cliente.UserLastModificationId,
                        cliente.NombreDeCliente,
                        cliente.CodigoDeCliente,
                        cliente.Domicilio,
                        cliente.Localidad,
                        cliente.CUIT,
                        cliente.Telefono,
                        cliente.CodigoPostal,
                        cliente.Provincia);
                        #endregion

                        dtClienteCopy = DataTable;

                        foreach (DataRow DataRow in dtClienteCopy.Rows)
                        {
                            dsCliente.Tables[0].Rows.Add(DataRow.ItemArray);
                        }
                }

                for (int i = 0; i < dsCliente.Tables.Count; i++)
                {
                    var Sheet = Book.Worksheets.Add(dsCliente.Tables[i]);
                    Sheet.ColumnsUsed().AdjustToContents();
                }
                Book.SaveAs($@"wwwroot/ExcelFiles/JuanApp/Cliente/Cliente_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.xlsx");
            }
            return Now;
        }

        public DateTime ExportAsCSV(Ajax Ajax, string ExportationType)
        {
            DateTime Now = DateTime.Now;
            List<Cliente> lstCliente = new List<Cliente> { };

            if (ExportationType == "All")
            {
                lstCliente = _context.Cliente.ToList();
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                foreach (string RowChecked in RowsChecked)
                {
                    Cliente Cliente = _context.Cliente
                                            .Where(x => x.ClienteId == Convert.ToInt32(RowChecked))
                                            .FirstOrDefault();      
                    lstCliente.Add(Cliente);
                }
            }

            using (var Writer = new StreamWriter($@"wwwroot/CSVFiles/JuanApp/Cliente/Cliente_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.csv"))
            using (var CsvWriter = new CsvWriter(Writer, CultureInfo.InvariantCulture))
            {
                CsvWriter.WriteRecords(lstCliente);
            }

            return Now;
        }
        #endregion
    }
}
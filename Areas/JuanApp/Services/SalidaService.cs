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
    public class SalidaService : ISalidaService
    {
        protected readonly JuanAppContext _context;

        public SalidaService(JuanAppContext context)
        {
            _context = context;
        }

        #region Exportations
        public DateTime ExportAsPDF(Ajax Ajax, string ExportationType)
        {
            var Renderer = new HtmlToPdf();
            DateTime Now = DateTime.Now;
            string RowsAsHTML = "";
            List<Salida> lstSalida = [];

            if (ExportationType == "All")
            {
                lstSalida = _context.Salida.ToList();
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                foreach (string RowChecked in RowsChecked)
                {
                    Salida Salida = _context.Salida
                                                .Where(x => x.SalidaId == Convert.ToInt32(RowChecked))
                                                .FirstOrDefault();
                    lstSalida.Add(Salida);
                }
            }

            foreach (Salida row in lstSalida)
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
            <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #4c4c4c; font-size: 36px; line-height: 45px; font-weight: 300; letter-spacing: -1px;"">Registers of Salida</span>
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
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">SalidaId&nbsp;&nbsp;&nbsp;</span>
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
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">CodigoDeCliente&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">NombreDeCliente&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">CodigoDeProducto&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">NombreDeProducto&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">KilosReales&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Precio&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Subtotal&nbsp;&nbsp;&nbsp;</span>
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
").SaveAs($@"wwwroot/PDFFiles/JuanApp/Salida/Salida_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.pdf");

            return Now;
        }

        public DateTime ExportAsExcel(Ajax Ajax, string ExportationType)
        {
            DateTime Now = DateTime.Now;

            using var Book = new XLWorkbook();

            if (ExportationType == "All")
            {
                DataTable dtSalida = new();

                //We define another DataTable dtSalidaCopy to avoid issue related to DateTime conversion
                DataTable dtSalidaCopy = new();

                #region Define columns for dtSalidaCopy
                DataColumn dtColumnSalidaIdFordtSalidaCopy = new DataColumn();
                    dtColumnSalidaIdFordtSalidaCopy.DataType = typeof(string);
                    dtColumnSalidaIdFordtSalidaCopy.ColumnName = "SalidaId";
                    dtSalidaCopy.Columns.Add(dtColumnSalidaIdFordtSalidaCopy);

                    DataColumn dtColumnActiveFordtSalidaCopy = new DataColumn();
                    dtColumnActiveFordtSalidaCopy.DataType = typeof(string);
                    dtColumnActiveFordtSalidaCopy.ColumnName = "Active";
                    dtSalidaCopy.Columns.Add(dtColumnActiveFordtSalidaCopy);

                    DataColumn dtColumnDateTimeCreationFordtSalidaCopy = new DataColumn();
                    dtColumnDateTimeCreationFordtSalidaCopy.DataType = typeof(string);
                    dtColumnDateTimeCreationFordtSalidaCopy.ColumnName = "DateTimeCreation";
                    dtSalidaCopy.Columns.Add(dtColumnDateTimeCreationFordtSalidaCopy);

                    DataColumn dtColumnDateTimeLastModificationFordtSalidaCopy = new DataColumn();
                    dtColumnDateTimeLastModificationFordtSalidaCopy.DataType = typeof(string);
                    dtColumnDateTimeLastModificationFordtSalidaCopy.ColumnName = "DateTimeLastModification";
                    dtSalidaCopy.Columns.Add(dtColumnDateTimeLastModificationFordtSalidaCopy);

                    DataColumn dtColumnUserCreationIdFordtSalidaCopy = new DataColumn();
                    dtColumnUserCreationIdFordtSalidaCopy.DataType = typeof(string);
                    dtColumnUserCreationIdFordtSalidaCopy.ColumnName = "UserCreationId";
                    dtSalidaCopy.Columns.Add(dtColumnUserCreationIdFordtSalidaCopy);

                    DataColumn dtColumnUserLastModificationIdFordtSalidaCopy = new DataColumn();
                    dtColumnUserLastModificationIdFordtSalidaCopy.DataType = typeof(string);
                    dtColumnUserLastModificationIdFordtSalidaCopy.ColumnName = "UserLastModificationId";
                    dtSalidaCopy.Columns.Add(dtColumnUserLastModificationIdFordtSalidaCopy);

                    DataColumn dtColumnCodigoDeClienteFordtSalidaCopy = new DataColumn();
                    dtColumnCodigoDeClienteFordtSalidaCopy.DataType = typeof(string);
                    dtColumnCodigoDeClienteFordtSalidaCopy.ColumnName = "CodigoDeCliente";
                    dtSalidaCopy.Columns.Add(dtColumnCodigoDeClienteFordtSalidaCopy);

                    DataColumn dtColumnNombreDeClienteFordtSalidaCopy = new DataColumn();
                    dtColumnNombreDeClienteFordtSalidaCopy.DataType = typeof(string);
                    dtColumnNombreDeClienteFordtSalidaCopy.ColumnName = "NombreDeCliente";
                    dtSalidaCopy.Columns.Add(dtColumnNombreDeClienteFordtSalidaCopy);

                    DataColumn dtColumnCodigoDeProductoFordtSalidaCopy = new DataColumn();
                    dtColumnCodigoDeProductoFordtSalidaCopy.DataType = typeof(string);
                    dtColumnCodigoDeProductoFordtSalidaCopy.ColumnName = "CodigoDeProducto";
                    dtSalidaCopy.Columns.Add(dtColumnCodigoDeProductoFordtSalidaCopy);

                    DataColumn dtColumnNombreDeProductoFordtSalidaCopy = new DataColumn();
                    dtColumnNombreDeProductoFordtSalidaCopy.DataType = typeof(string);
                    dtColumnNombreDeProductoFordtSalidaCopy.ColumnName = "NombreDeProducto";
                    dtSalidaCopy.Columns.Add(dtColumnNombreDeProductoFordtSalidaCopy);

                    DataColumn dtColumnKilosRealesFordtSalidaCopy = new DataColumn();
                    dtColumnKilosRealesFordtSalidaCopy.DataType = typeof(string);
                    dtColumnKilosRealesFordtSalidaCopy.ColumnName = "KilosReales";
                    dtSalidaCopy.Columns.Add(dtColumnKilosRealesFordtSalidaCopy);

                    DataColumn dtColumnPrecioFordtSalidaCopy = new DataColumn();
                    dtColumnPrecioFordtSalidaCopy.DataType = typeof(string);
                    dtColumnPrecioFordtSalidaCopy.ColumnName = "Precio";
                    dtSalidaCopy.Columns.Add(dtColumnPrecioFordtSalidaCopy);

                    DataColumn dtColumnSubtotalFordtSalidaCopy = new DataColumn();
                    dtColumnSubtotalFordtSalidaCopy.DataType = typeof(string);
                    dtColumnSubtotalFordtSalidaCopy.ColumnName = "Subtotal";
                    dtSalidaCopy.Columns.Add(dtColumnSubtotalFordtSalidaCopy);

                    
                #endregion

                #region Create another DataTable to copy
                List<Salida> lstSalida = _context.Salida.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("SalidaId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("CodigoDeCliente", typeof(string));
                DataTable.Columns.Add("NombreDeCliente", typeof(string));
                DataTable.Columns.Add("CodigoDeProducto", typeof(string));
                DataTable.Columns.Add("NombreDeProducto", typeof(string));
                DataTable.Columns.Add("KilosReales", typeof(string));
                DataTable.Columns.Add("Precio", typeof(string));
                DataTable.Columns.Add("Subtotal", typeof(string));
                

                foreach (Salida salida in lstSalida)
                        {
                            DataTable.Rows.Add(
                                salida.SalidaId,
                        salida.Active,
                        salida.DateTimeCreation,
                        salida.DateTimeLastModification,
                        salida.UserCreationId,
                        salida.UserLastModificationId,
                        salida.CodigoDeCliente,
                        salida.NombreDeCliente,
                        salida.CodigoDeProducto,
                        salida.NombreDeProducto,
                        salida.KilosReales,
                        salida.Precio,
                        salida.Subtotal
                        
                                );
                        }
                #endregion

                dtSalida = DataTable;

                foreach (DataRow DataRow in dtSalida.Rows)
                {
                    dtSalidaCopy.Rows.Add(DataRow.ItemArray);
                }

                var Sheet = Book.Worksheets.Add(dtSalidaCopy);

                Sheet.ColumnsUsed().AdjustToContents();

                Book.SaveAs($@"wwwroot/ExcelFiles/JuanApp/Salida/Salida_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.xlsx");
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                DataSet dsSalida = new();

                foreach (string RowChecked in RowsChecked)
                {
                    //We define another DataTable dtSalidaCopy to avoid issue related to DateTime conversion
                    DataTable dtSalidaCopy = new();

                    #region Define columns for dtSalidaCopy
                    DataColumn dtColumnSalidaIdFordtSalidaCopy = new DataColumn();
                    dtColumnSalidaIdFordtSalidaCopy.DataType = typeof(string);
                    dtColumnSalidaIdFordtSalidaCopy.ColumnName = "SalidaId";
                    dtSalidaCopy.Columns.Add(dtColumnSalidaIdFordtSalidaCopy);

                    DataColumn dtColumnActiveFordtSalidaCopy = new DataColumn();
                    dtColumnActiveFordtSalidaCopy.DataType = typeof(string);
                    dtColumnActiveFordtSalidaCopy.ColumnName = "Active";
                    dtSalidaCopy.Columns.Add(dtColumnActiveFordtSalidaCopy);

                    DataColumn dtColumnDateTimeCreationFordtSalidaCopy = new DataColumn();
                    dtColumnDateTimeCreationFordtSalidaCopy.DataType = typeof(string);
                    dtColumnDateTimeCreationFordtSalidaCopy.ColumnName = "DateTimeCreation";
                    dtSalidaCopy.Columns.Add(dtColumnDateTimeCreationFordtSalidaCopy);

                    DataColumn dtColumnDateTimeLastModificationFordtSalidaCopy = new DataColumn();
                    dtColumnDateTimeLastModificationFordtSalidaCopy.DataType = typeof(string);
                    dtColumnDateTimeLastModificationFordtSalidaCopy.ColumnName = "DateTimeLastModification";
                    dtSalidaCopy.Columns.Add(dtColumnDateTimeLastModificationFordtSalidaCopy);

                    DataColumn dtColumnUserCreationIdFordtSalidaCopy = new DataColumn();
                    dtColumnUserCreationIdFordtSalidaCopy.DataType = typeof(string);
                    dtColumnUserCreationIdFordtSalidaCopy.ColumnName = "UserCreationId";
                    dtSalidaCopy.Columns.Add(dtColumnUserCreationIdFordtSalidaCopy);

                    DataColumn dtColumnUserLastModificationIdFordtSalidaCopy = new DataColumn();
                    dtColumnUserLastModificationIdFordtSalidaCopy.DataType = typeof(string);
                    dtColumnUserLastModificationIdFordtSalidaCopy.ColumnName = "UserLastModificationId";
                    dtSalidaCopy.Columns.Add(dtColumnUserLastModificationIdFordtSalidaCopy);

                    DataColumn dtColumnCodigoDeClienteFordtSalidaCopy = new DataColumn();
                    dtColumnCodigoDeClienteFordtSalidaCopy.DataType = typeof(string);
                    dtColumnCodigoDeClienteFordtSalidaCopy.ColumnName = "CodigoDeCliente";
                    dtSalidaCopy.Columns.Add(dtColumnCodigoDeClienteFordtSalidaCopy);

                    DataColumn dtColumnNombreDeClienteFordtSalidaCopy = new DataColumn();
                    dtColumnNombreDeClienteFordtSalidaCopy.DataType = typeof(string);
                    dtColumnNombreDeClienteFordtSalidaCopy.ColumnName = "NombreDeCliente";
                    dtSalidaCopy.Columns.Add(dtColumnNombreDeClienteFordtSalidaCopy);

                    DataColumn dtColumnCodigoDeProductoFordtSalidaCopy = new DataColumn();
                    dtColumnCodigoDeProductoFordtSalidaCopy.DataType = typeof(string);
                    dtColumnCodigoDeProductoFordtSalidaCopy.ColumnName = "CodigoDeProducto";
                    dtSalidaCopy.Columns.Add(dtColumnCodigoDeProductoFordtSalidaCopy);

                    DataColumn dtColumnNombreDeProductoFordtSalidaCopy = new DataColumn();
                    dtColumnNombreDeProductoFordtSalidaCopy.DataType = typeof(string);
                    dtColumnNombreDeProductoFordtSalidaCopy.ColumnName = "NombreDeProducto";
                    dtSalidaCopy.Columns.Add(dtColumnNombreDeProductoFordtSalidaCopy);

                    DataColumn dtColumnKilosRealesFordtSalidaCopy = new DataColumn();
                    dtColumnKilosRealesFordtSalidaCopy.DataType = typeof(string);
                    dtColumnKilosRealesFordtSalidaCopy.ColumnName = "KilosReales";
                    dtSalidaCopy.Columns.Add(dtColumnKilosRealesFordtSalidaCopy);

                    DataColumn dtColumnPrecioFordtSalidaCopy = new DataColumn();
                    dtColumnPrecioFordtSalidaCopy.DataType = typeof(string);
                    dtColumnPrecioFordtSalidaCopy.ColumnName = "Precio";
                    dtSalidaCopy.Columns.Add(dtColumnPrecioFordtSalidaCopy);

                    DataColumn dtColumnSubtotalFordtSalidaCopy = new DataColumn();
                    dtColumnSubtotalFordtSalidaCopy.DataType = typeof(string);
                    dtColumnSubtotalFordtSalidaCopy.ColumnName = "Subtotal";
                    dtSalidaCopy.Columns.Add(dtColumnSubtotalFordtSalidaCopy);

                    
                    #endregion

                    dsSalida.Tables.Add(dtSalidaCopy);

                    #region Create DataTable with data from DB
                        Salida salida = _context.Salida
                                                    .Where(x => x.SalidaId == Convert.ToInt32(RowChecked))
                                                    .FirstOrDefault();

                        DataTable DataTable = new();
                        DataTable.Columns.Add("SalidaId", typeof(string));
                        DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("CodigoDeCliente", typeof(string));
                DataTable.Columns.Add("NombreDeCliente", typeof(string));
                DataTable.Columns.Add("CodigoDeProducto", typeof(string));
                DataTable.Columns.Add("NombreDeProducto", typeof(string));
                DataTable.Columns.Add("KilosReales", typeof(string));
                DataTable.Columns.Add("Precio", typeof(string));
                DataTable.Columns.Add("Subtotal", typeof(string));
                
                        
                        DataTable.Rows.Add(
                                salida.SalidaId,
                        salida.Active,
                        salida.DateTimeCreation,
                        salida.DateTimeLastModification,
                        salida.UserCreationId,
                        salida.UserLastModificationId,
                        salida.CodigoDeCliente,
                        salida.NombreDeCliente,
                        salida.CodigoDeProducto,
                        salida.NombreDeProducto,
                        salida.KilosReales,
                        salida.Precio,
                        salida.Subtotal
                        
                                );
                        #endregion

                        dtSalidaCopy = DataTable;

                        foreach (DataRow DataRow in dtSalidaCopy.Rows)
                        {
                            dsSalida.Tables[0].Rows.Add(DataRow.ItemArray);
                        }
                }

                for (int i = 0; i < dsSalida.Tables.Count; i++)
                {
                    var Sheet = Book.Worksheets.Add(dsSalida.Tables[i]);
                    Sheet.ColumnsUsed().AdjustToContents();
                }
                Book.SaveAs($@"wwwroot/ExcelFiles/JuanApp/Salida/Salida_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.xlsx");
            }
            return Now;
        }

        public DateTime ExportAsCSV(Ajax Ajax, string ExportationType)
        {
            DateTime Now = DateTime.Now;
            List<Salida> lstSalida = new List<Salida> { };

            if (ExportationType == "All")
            {
                lstSalida = _context.Salida.ToList();
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                foreach (string RowChecked in RowsChecked)
                {
                    Salida Salida = _context.Salida
                                            .Where(x => x.SalidaId == Convert.ToInt32(RowChecked))
                                            .FirstOrDefault();      
                    lstSalida.Add(Salida);
                }
            }

            using (var Writer = new StreamWriter($@"wwwroot/CSVFiles/JuanApp/Salida/Salida_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.csv"))
            using (var CsvWriter = new CsvWriter(Writer, CultureInfo.InvariantCulture))
            {
                CsvWriter.WriteRecords(lstSalida);
            }

            return Now;
        }
        #endregion
    }
}
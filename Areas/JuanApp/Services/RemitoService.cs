using System.Data;
using System.Globalization;
using ClosedXML.Excel;
using CsvHelper;
using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Library;
using JuanApp.DatabaseContexts;

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
    public class RemitoService : IRemitoService
    {
        protected readonly JuanAppContext _context;

        public RemitoService(JuanAppContext context)
        {
            _context = context;
        }

        #region Exportations
        public DateTime ExportAsPDF(Ajax Ajax, string ExportationType)
        {
            var Renderer = new HtmlToPdf();
            DateTime Now = DateTime.Now;
            string RowsAsHTML = "";
            List<Remito> lstRemito = [];

            if (ExportationType == "All")
            {
                lstRemito = _context.Remito.ToList();
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                foreach (string RowChecked in RowsChecked)
                {
                    Remito Remito = _context.Remito
                                                .Where(x => x.RemitoId == Convert.ToInt32(RowChecked))
                                                .FirstOrDefault();
                    lstRemito.Add(Remito);
                }
            }

            foreach (Remito row in lstRemito)
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
            <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #4c4c4c; font-size: 36px; line-height: 45px; font-weight: 300; letter-spacing: -1px;"">Registers of Remito</span>
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
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">RemitoId&nbsp;&nbsp;&nbsp;</span>
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
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Fecha&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">KilosTotales&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">PrecioTotal&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">SubtotalTotal&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">CodigoCliente&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">NombreCliente&nbsp;&nbsp;&nbsp;</span>
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
").SaveAs($@"wwwroot/PDFFiles/JuanApp/Remito/Remito_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.pdf");

            return Now;
        }

        public DateTime ExportAsExcel(Ajax Ajax, string ExportationType)
        {
            DateTime Now = DateTime.Now;

            using var Book = new XLWorkbook();

            if (ExportationType == "All")
            {
                DataTable dtRemito = new();

                //We define another DataTable dtRemitoCopy to avoid issue related to DateTime conversion
                DataTable dtRemitoCopy = new();
                dtRemitoCopy.TableName = "Remito";

                #region Define columns for dtRemitoCopy
                DataColumn dtColumnRemitoIdFordtRemitoCopy = new DataColumn();
                    dtColumnRemitoIdFordtRemitoCopy.DataType = typeof(string);
                    dtColumnRemitoIdFordtRemitoCopy.ColumnName = "RemitoId";
                    dtRemitoCopy.Columns.Add(dtColumnRemitoIdFordtRemitoCopy);

                    DataColumn dtColumnActiveFordtRemitoCopy = new DataColumn();
                    dtColumnActiveFordtRemitoCopy.DataType = typeof(string);
                    dtColumnActiveFordtRemitoCopy.ColumnName = "Active";
                    dtRemitoCopy.Columns.Add(dtColumnActiveFordtRemitoCopy);

                    DataColumn dtColumnDateTimeCreationFordtRemitoCopy = new DataColumn();
                    dtColumnDateTimeCreationFordtRemitoCopy.DataType = typeof(string);
                    dtColumnDateTimeCreationFordtRemitoCopy.ColumnName = "DateTimeCreation";
                    dtRemitoCopy.Columns.Add(dtColumnDateTimeCreationFordtRemitoCopy);

                    DataColumn dtColumnDateTimeLastModificationFordtRemitoCopy = new DataColumn();
                    dtColumnDateTimeLastModificationFordtRemitoCopy.DataType = typeof(string);
                    dtColumnDateTimeLastModificationFordtRemitoCopy.ColumnName = "DateTimeLastModification";
                    dtRemitoCopy.Columns.Add(dtColumnDateTimeLastModificationFordtRemitoCopy);

                    DataColumn dtColumnUserCreationIdFordtRemitoCopy = new DataColumn();
                    dtColumnUserCreationIdFordtRemitoCopy.DataType = typeof(string);
                    dtColumnUserCreationIdFordtRemitoCopy.ColumnName = "UserCreationId";
                    dtRemitoCopy.Columns.Add(dtColumnUserCreationIdFordtRemitoCopy);

                    DataColumn dtColumnUserLastModificationIdFordtRemitoCopy = new DataColumn();
                    dtColumnUserLastModificationIdFordtRemitoCopy.DataType = typeof(string);
                    dtColumnUserLastModificationIdFordtRemitoCopy.ColumnName = "UserLastModificationId";
                    dtRemitoCopy.Columns.Add(dtColumnUserLastModificationIdFordtRemitoCopy);

                    DataColumn dtColumnFechaFordtRemitoCopy = new DataColumn();
                    dtColumnFechaFordtRemitoCopy.DataType = typeof(string);
                    dtColumnFechaFordtRemitoCopy.ColumnName = "Fecha";
                    dtRemitoCopy.Columns.Add(dtColumnFechaFordtRemitoCopy);

                    DataColumn dtColumnKilosTotalesFordtRemitoCopy = new DataColumn();
                    dtColumnKilosTotalesFordtRemitoCopy.DataType = typeof(string);
                    dtColumnKilosTotalesFordtRemitoCopy.ColumnName = "KilosTotales";
                    dtRemitoCopy.Columns.Add(dtColumnKilosTotalesFordtRemitoCopy);

                    DataColumn dtColumnPrecioTotalFordtRemitoCopy = new DataColumn();
                    dtColumnPrecioTotalFordtRemitoCopy.DataType = typeof(string);
                    dtColumnPrecioTotalFordtRemitoCopy.ColumnName = "PrecioTotal";
                    dtRemitoCopy.Columns.Add(dtColumnPrecioTotalFordtRemitoCopy);

                    DataColumn dtColumnSubtotalTotalFordtRemitoCopy = new DataColumn();
                    dtColumnSubtotalTotalFordtRemitoCopy.DataType = typeof(string);
                    dtColumnSubtotalTotalFordtRemitoCopy.ColumnName = "SubtotalTotal";
                    dtRemitoCopy.Columns.Add(dtColumnSubtotalTotalFordtRemitoCopy);

                    DataColumn dtColumnCodigoClienteFordtRemitoCopy = new DataColumn();
                    dtColumnCodigoClienteFordtRemitoCopy.DataType = typeof(string);
                    dtColumnCodigoClienteFordtRemitoCopy.ColumnName = "CodigoCliente";
                    dtRemitoCopy.Columns.Add(dtColumnCodigoClienteFordtRemitoCopy);

                    DataColumn dtColumnNombreClienteFordtRemitoCopy = new DataColumn();
                    dtColumnNombreClienteFordtRemitoCopy.DataType = typeof(string);
                    dtColumnNombreClienteFordtRemitoCopy.ColumnName = "NombreCliente";
                    dtRemitoCopy.Columns.Add(dtColumnNombreClienteFordtRemitoCopy);

                    
                #endregion

                #region Create another DataTable to copy
                List<Remito> lstRemito = _context.Remito.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("RemitoId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("KilosTotales", typeof(string));
                DataTable.Columns.Add("PrecioTotal", typeof(string));
                DataTable.Columns.Add("SubtotalTotal", typeof(string));
                DataTable.Columns.Add("CodigoCliente", typeof(string));
                DataTable.Columns.Add("NombreCliente", typeof(string));
                

                foreach (Remito remito in lstRemito)
                        {
                            DataTable.Rows.Add(
                                remito.RemitoId,
                        remito.Active,
                        remito.DateTimeCreation,
                        remito.DateTimeLastModification,
                        remito.UserCreationId,
                        remito.UserLastModificationId,
                        remito.Fecha,
                        remito.KilosTotales,
                        remito.PrecioTotal,
                        remito.SubtotalTotal,
                        remito.CodigoCliente,
                        remito.NombreCliente);
                        }
                #endregion

                dtRemito = DataTable;

                foreach (DataRow DataRow in dtRemito.Rows)
                {
                    dtRemitoCopy.Rows.Add(DataRow.ItemArray);
                }

                var Sheet = Book.Worksheets.Add(dtRemitoCopy);

                Sheet.ColumnsUsed().AdjustToContents();

                Book.SaveAs($@"wwwroot/ExcelFiles/JuanApp/Remito/Remito_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.xlsx");
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                DataSet dsRemito = new();

                foreach (string RowChecked in RowsChecked)
                {
                    //We define another DataTable dtRemitoCopy to avoid issue related to DateTime conversion
                    DataTable dtRemitoCopy = new();

                    #region Define columns for dtRemitoCopy
                    DataColumn dtColumnRemitoIdFordtRemitoCopy = new DataColumn();
                    dtColumnRemitoIdFordtRemitoCopy.DataType = typeof(string);
                    dtColumnRemitoIdFordtRemitoCopy.ColumnName = "RemitoId";
                    dtRemitoCopy.Columns.Add(dtColumnRemitoIdFordtRemitoCopy);

                    DataColumn dtColumnActiveFordtRemitoCopy = new DataColumn();
                    dtColumnActiveFordtRemitoCopy.DataType = typeof(string);
                    dtColumnActiveFordtRemitoCopy.ColumnName = "Active";
                    dtRemitoCopy.Columns.Add(dtColumnActiveFordtRemitoCopy);

                    DataColumn dtColumnDateTimeCreationFordtRemitoCopy = new DataColumn();
                    dtColumnDateTimeCreationFordtRemitoCopy.DataType = typeof(string);
                    dtColumnDateTimeCreationFordtRemitoCopy.ColumnName = "DateTimeCreation";
                    dtRemitoCopy.Columns.Add(dtColumnDateTimeCreationFordtRemitoCopy);

                    DataColumn dtColumnDateTimeLastModificationFordtRemitoCopy = new DataColumn();
                    dtColumnDateTimeLastModificationFordtRemitoCopy.DataType = typeof(string);
                    dtColumnDateTimeLastModificationFordtRemitoCopy.ColumnName = "DateTimeLastModification";
                    dtRemitoCopy.Columns.Add(dtColumnDateTimeLastModificationFordtRemitoCopy);

                    DataColumn dtColumnUserCreationIdFordtRemitoCopy = new DataColumn();
                    dtColumnUserCreationIdFordtRemitoCopy.DataType = typeof(string);
                    dtColumnUserCreationIdFordtRemitoCopy.ColumnName = "UserCreationId";
                    dtRemitoCopy.Columns.Add(dtColumnUserCreationIdFordtRemitoCopy);

                    DataColumn dtColumnUserLastModificationIdFordtRemitoCopy = new DataColumn();
                    dtColumnUserLastModificationIdFordtRemitoCopy.DataType = typeof(string);
                    dtColumnUserLastModificationIdFordtRemitoCopy.ColumnName = "UserLastModificationId";
                    dtRemitoCopy.Columns.Add(dtColumnUserLastModificationIdFordtRemitoCopy);

                    DataColumn dtColumnFechaFordtRemitoCopy = new DataColumn();
                    dtColumnFechaFordtRemitoCopy.DataType = typeof(string);
                    dtColumnFechaFordtRemitoCopy.ColumnName = "Fecha";
                    dtRemitoCopy.Columns.Add(dtColumnFechaFordtRemitoCopy);

                    DataColumn dtColumnKilosTotalesFordtRemitoCopy = new DataColumn();
                    dtColumnKilosTotalesFordtRemitoCopy.DataType = typeof(string);
                    dtColumnKilosTotalesFordtRemitoCopy.ColumnName = "KilosTotales";
                    dtRemitoCopy.Columns.Add(dtColumnKilosTotalesFordtRemitoCopy);

                    DataColumn dtColumnPrecioTotalFordtRemitoCopy = new DataColumn();
                    dtColumnPrecioTotalFordtRemitoCopy.DataType = typeof(string);
                    dtColumnPrecioTotalFordtRemitoCopy.ColumnName = "PrecioTotal";
                    dtRemitoCopy.Columns.Add(dtColumnPrecioTotalFordtRemitoCopy);

                    DataColumn dtColumnSubtotalTotalFordtRemitoCopy = new DataColumn();
                    dtColumnSubtotalTotalFordtRemitoCopy.DataType = typeof(string);
                    dtColumnSubtotalTotalFordtRemitoCopy.ColumnName = "SubtotalTotal";
                    dtRemitoCopy.Columns.Add(dtColumnSubtotalTotalFordtRemitoCopy);

                    DataColumn dtColumnCodigoClienteFordtRemitoCopy = new DataColumn();
                    dtColumnCodigoClienteFordtRemitoCopy.DataType = typeof(string);
                    dtColumnCodigoClienteFordtRemitoCopy.ColumnName = "CodigoCliente";
                    dtRemitoCopy.Columns.Add(dtColumnCodigoClienteFordtRemitoCopy);

                    DataColumn dtColumnNombreClienteFordtRemitoCopy = new DataColumn();
                    dtColumnNombreClienteFordtRemitoCopy.DataType = typeof(string);
                    dtColumnNombreClienteFordtRemitoCopy.ColumnName = "NombreCliente";
                    dtRemitoCopy.Columns.Add(dtColumnNombreClienteFordtRemitoCopy);

                    
                    #endregion

                    dsRemito.Tables.Add(dtRemitoCopy);

                    #region Create DataTable with data from DB
                        Remito remito = _context.Remito
                                                    .Where(x => x.RemitoId == Convert.ToInt32(RowChecked))
                                                    .FirstOrDefault();

                        DataTable DataTable = new();
                        DataTable.Columns.Add("RemitoId", typeof(string));
                        DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Fecha", typeof(string));
                DataTable.Columns.Add("KilosTotales", typeof(string));
                DataTable.Columns.Add("PrecioTotal", typeof(string));
                DataTable.Columns.Add("SubtotalTotal", typeof(string));
                DataTable.Columns.Add("CodigoCliente", typeof(string));
                DataTable.Columns.Add("NombreCliente", typeof(string));
                
                        
                        DataTable.Rows.Add(
                                remito.RemitoId,
                        remito.Active,
                        remito.DateTimeCreation,
                        remito.DateTimeLastModification,
                        remito.UserCreationId,
                        remito.UserLastModificationId,
                        remito.Fecha,
                        remito.KilosTotales,
                        remito.PrecioTotal,
                        remito.SubtotalTotal,
                        remito.CodigoCliente,
                        remito.NombreCliente
                        
                                );
                        #endregion

                        dtRemitoCopy = DataTable;

                        foreach (DataRow DataRow in dtRemitoCopy.Rows)
                        {
                            dsRemito.Tables[0].Rows.Add(DataRow.ItemArray);
                        }
                }

                for (int i = 0; i < dsRemito.Tables.Count; i++)
                {
                    var Sheet = Book.Worksheets.Add(dsRemito.Tables[i]);
                    Sheet.ColumnsUsed().AdjustToContents();
                }
                Book.SaveAs($@"wwwroot/ExcelFiles/JuanApp/Remito/Remito_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.xlsx");
            }
            return Now;
        }

        public DateTime ExportAsCSV(Ajax Ajax, string ExportationType)
        {
            DateTime Now = DateTime.Now;
            List<Remito> lstRemito = new List<Remito> { };

            if (ExportationType == "All")
            {
                lstRemito = _context.Remito.ToList();
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                foreach (string RowChecked in RowsChecked)
                {
                    Remito Remito = _context.Remito
                                            .Where(x => x.RemitoId == Convert.ToInt32(RowChecked))
                                            .FirstOrDefault();      
                    lstRemito.Add(Remito);
                }
            }

            using (var Writer = new StreamWriter($@"wwwroot/CSVFiles/JuanApp/Remito/Remito_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.csv"))
            using (var CsvWriter = new CsvWriter(Writer, CultureInfo.InvariantCulture))
            {
                CsvWriter.WriteRecords(lstRemito);
            }

            return Now;
        }
        #endregion
    }
}
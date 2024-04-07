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
    public class ProductoService : IProductoService
    {
        protected readonly JuanAppContext _context;

        public ProductoService(JuanAppContext context)
        {
            _context = context;
        }

        #region Exportations
        public DateTime ExportAsPDF(Ajax Ajax, string ExportationType)
        {
            var Renderer = new HtmlToPdf();
            DateTime Now = DateTime.Now;
            string RowsAsHTML = "";
            List<Producto> lstProducto = [];

            if (ExportationType == "All")
            {
                lstProducto = _context.Producto.ToList();
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                foreach (string RowChecked in RowsChecked)
                {
                    Producto Producto = _context.Producto
                                                .Where(x => x.ProductoId == Convert.ToInt32(RowChecked))
                                                .FirstOrDefault();
                    lstProducto.Add(Producto);
                }
            }

            foreach (Producto row in lstProducto)
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
            <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #4c4c4c; font-size: 36px; line-height: 45px; font-weight: 300; letter-spacing: -1px;"">Registers of Producto</span>
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
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">ProductoId&nbsp;&nbsp;&nbsp;</span>
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
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">Nombre&nbsp;&nbsp;&nbsp;</span>
            </font>
            <div style=""height: 10px; line-height: 10px; font-size: 8px;"">&nbsp;</div>
        </th><th align=""left"" valign=""top"" style=""border-width: 1px; border-style: solid; border-color: #e8e8e8; border-top: none; border-left: none; border-right: none;"">
            <font face=""'Source Sans Pro', sans-serif"" color=""#000000"" style=""font-size: 20px; line-height: 28px; font-weight: 600;"">
                <span style=""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #000000; font-size: 20px; line-height: 28px; font-weight: 600;"">CodigoProducto&nbsp;&nbsp;&nbsp;</span>
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
").SaveAs($@"wwwroot/PDFFiles/JuanApp/Producto/Producto_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.pdf");

            return Now;
        }

        public DateTime ExportAsExcel(Ajax Ajax, string ExportationType)
        {
            DateTime Now = DateTime.Now;

            using var Book = new XLWorkbook();

            if (ExportationType == "All")
            {
                DataTable dtProducto = new();

                //We define another DataTable dtProductoCopy to avoid issue related to DateTime conversion
                DataTable dtProductoCopy = new();

                #region Define columns for dtProductoCopy
                DataColumn dtColumnProductoIdFordtProductoCopy = new DataColumn();
                    dtColumnProductoIdFordtProductoCopy.DataType = typeof(string);
                    dtColumnProductoIdFordtProductoCopy.ColumnName = "ProductoId";
                    dtProductoCopy.Columns.Add(dtColumnProductoIdFordtProductoCopy);

                    DataColumn dtColumnActiveFordtProductoCopy = new DataColumn();
                    dtColumnActiveFordtProductoCopy.DataType = typeof(string);
                    dtColumnActiveFordtProductoCopy.ColumnName = "Active";
                    dtProductoCopy.Columns.Add(dtColumnActiveFordtProductoCopy);

                    DataColumn dtColumnDateTimeCreationFordtProductoCopy = new DataColumn();
                    dtColumnDateTimeCreationFordtProductoCopy.DataType = typeof(string);
                    dtColumnDateTimeCreationFordtProductoCopy.ColumnName = "DateTimeCreation";
                    dtProductoCopy.Columns.Add(dtColumnDateTimeCreationFordtProductoCopy);

                    DataColumn dtColumnDateTimeLastModificationFordtProductoCopy = new DataColumn();
                    dtColumnDateTimeLastModificationFordtProductoCopy.DataType = typeof(string);
                    dtColumnDateTimeLastModificationFordtProductoCopy.ColumnName = "DateTimeLastModification";
                    dtProductoCopy.Columns.Add(dtColumnDateTimeLastModificationFordtProductoCopy);

                    DataColumn dtColumnUserCreationIdFordtProductoCopy = new DataColumn();
                    dtColumnUserCreationIdFordtProductoCopy.DataType = typeof(string);
                    dtColumnUserCreationIdFordtProductoCopy.ColumnName = "UserCreationId";
                    dtProductoCopy.Columns.Add(dtColumnUserCreationIdFordtProductoCopy);

                    DataColumn dtColumnUserLastModificationIdFordtProductoCopy = new DataColumn();
                    dtColumnUserLastModificationIdFordtProductoCopy.DataType = typeof(string);
                    dtColumnUserLastModificationIdFordtProductoCopy.ColumnName = "UserLastModificationId";
                    dtProductoCopy.Columns.Add(dtColumnUserLastModificationIdFordtProductoCopy);

                    DataColumn dtColumnNombreFordtProductoCopy = new DataColumn();
                    dtColumnNombreFordtProductoCopy.DataType = typeof(string);
                    dtColumnNombreFordtProductoCopy.ColumnName = "Nombre";
                    dtProductoCopy.Columns.Add(dtColumnNombreFordtProductoCopy);

                    DataColumn dtColumnCodigoProductoFordtProductoCopy = new DataColumn();
                    dtColumnCodigoProductoFordtProductoCopy.DataType = typeof(string);
                    dtColumnCodigoProductoFordtProductoCopy.ColumnName = "CodigoProducto";
                    dtProductoCopy.Columns.Add(dtColumnCodigoProductoFordtProductoCopy);

                    
                #endregion

                #region Create another DataTable to copy
                List<Producto> lstProducto = _context.Producto.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("ProductoId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Nombre", typeof(string));
                DataTable.Columns.Add("CodigoProducto", typeof(string));
                

                foreach (Producto producto in lstProducto)
                        {
                            DataTable.Rows.Add(
                                producto.ProductoId,
                        producto.Active,
                        producto.DateTimeCreation,
                        producto.DateTimeLastModification,
                        producto.UserCreationId,
                        producto.UserLastModificationId,
                        producto.Nombre,
                        producto.CodigoProducto
                        
                                );
                        }
                #endregion

                dtProducto = DataTable;

                foreach (DataRow DataRow in dtProducto.Rows)
                {
                    dtProductoCopy.Rows.Add(DataRow.ItemArray);
                }

                var Sheet = Book.Worksheets.Add(dtProductoCopy);

                Sheet.ColumnsUsed().AdjustToContents();

                Book.SaveAs($@"wwwroot/ExcelFiles/JuanApp/Producto/Producto_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.xlsx");
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                DataSet dsProducto = new();

                foreach (string RowChecked in RowsChecked)
                {
                    //We define another DataTable dtProductoCopy to avoid issue related to DateTime conversion
                    DataTable dtProductoCopy = new();

                    #region Define columns for dtProductoCopy
                    DataColumn dtColumnProductoIdFordtProductoCopy = new DataColumn();
                    dtColumnProductoIdFordtProductoCopy.DataType = typeof(string);
                    dtColumnProductoIdFordtProductoCopy.ColumnName = "ProductoId";
                    dtProductoCopy.Columns.Add(dtColumnProductoIdFordtProductoCopy);

                    DataColumn dtColumnActiveFordtProductoCopy = new DataColumn();
                    dtColumnActiveFordtProductoCopy.DataType = typeof(string);
                    dtColumnActiveFordtProductoCopy.ColumnName = "Active";
                    dtProductoCopy.Columns.Add(dtColumnActiveFordtProductoCopy);

                    DataColumn dtColumnDateTimeCreationFordtProductoCopy = new DataColumn();
                    dtColumnDateTimeCreationFordtProductoCopy.DataType = typeof(string);
                    dtColumnDateTimeCreationFordtProductoCopy.ColumnName = "DateTimeCreation";
                    dtProductoCopy.Columns.Add(dtColumnDateTimeCreationFordtProductoCopy);

                    DataColumn dtColumnDateTimeLastModificationFordtProductoCopy = new DataColumn();
                    dtColumnDateTimeLastModificationFordtProductoCopy.DataType = typeof(string);
                    dtColumnDateTimeLastModificationFordtProductoCopy.ColumnName = "DateTimeLastModification";
                    dtProductoCopy.Columns.Add(dtColumnDateTimeLastModificationFordtProductoCopy);

                    DataColumn dtColumnUserCreationIdFordtProductoCopy = new DataColumn();
                    dtColumnUserCreationIdFordtProductoCopy.DataType = typeof(string);
                    dtColumnUserCreationIdFordtProductoCopy.ColumnName = "UserCreationId";
                    dtProductoCopy.Columns.Add(dtColumnUserCreationIdFordtProductoCopy);

                    DataColumn dtColumnUserLastModificationIdFordtProductoCopy = new DataColumn();
                    dtColumnUserLastModificationIdFordtProductoCopy.DataType = typeof(string);
                    dtColumnUserLastModificationIdFordtProductoCopy.ColumnName = "UserLastModificationId";
                    dtProductoCopy.Columns.Add(dtColumnUserLastModificationIdFordtProductoCopy);

                    DataColumn dtColumnNombreFordtProductoCopy = new DataColumn();
                    dtColumnNombreFordtProductoCopy.DataType = typeof(string);
                    dtColumnNombreFordtProductoCopy.ColumnName = "Nombre";
                    dtProductoCopy.Columns.Add(dtColumnNombreFordtProductoCopy);

                    DataColumn dtColumnCodigoProductoFordtProductoCopy = new DataColumn();
                    dtColumnCodigoProductoFordtProductoCopy.DataType = typeof(string);
                    dtColumnCodigoProductoFordtProductoCopy.ColumnName = "CodigoProducto";
                    dtProductoCopy.Columns.Add(dtColumnCodigoProductoFordtProductoCopy);

                    
                    #endregion

                    dsProducto.Tables.Add(dtProductoCopy);

                    #region Create DataTable with data from DB
                        Producto producto = _context.Producto
                                                    .Where(x => x.ProductoId == Convert.ToInt32(RowChecked))
                                                    .FirstOrDefault();

                        DataTable DataTable = new();
                        DataTable.Columns.Add("ProductoId", typeof(string));
                        DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Nombre", typeof(string));
                DataTable.Columns.Add("CodigoProducto", typeof(string));
                
                        
                        DataTable.Rows.Add(
                                producto.ProductoId,
                        producto.Active,
                        producto.DateTimeCreation,
                        producto.DateTimeLastModification,
                        producto.UserCreationId,
                        producto.UserLastModificationId,
                        producto.Nombre,
                        producto.CodigoProducto
                        
                                );
                        #endregion

                        dtProductoCopy = DataTable;

                        foreach (DataRow DataRow in dtProductoCopy.Rows)
                        {
                            dsProducto.Tables[0].Rows.Add(DataRow.ItemArray);
                        }
                }

                for (int i = 0; i < dsProducto.Tables.Count; i++)
                {
                    var Sheet = Book.Worksheets.Add(dsProducto.Tables[i]);
                    Sheet.ColumnsUsed().AdjustToContents();
                }
                Book.SaveAs($@"wwwroot/ExcelFiles/JuanApp/Producto/Producto_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.xlsx");
            }
            return Now;
        }

        public DateTime ExportAsCSV(Ajax Ajax, string ExportationType)
        {
            DateTime Now = DateTime.Now;
            List<Producto> lstProducto = new List<Producto> { };

            if (ExportationType == "All")
            {
                lstProducto = _context.Producto.ToList();
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                foreach (string RowChecked in RowsChecked)
                {
                    Producto Producto = _context.Producto
                                            .Where(x => x.ProductoId == Convert.ToInt32(RowChecked))
                                            .FirstOrDefault();      
                    lstProducto.Add(Producto);
                }
            }

            using (var Writer = new StreamWriter($@"wwwroot/CSVFiles/JuanApp/Producto/Producto_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.csv"))
            using (var CsvWriter = new CsvWriter(Writer, CultureInfo.InvariantCulture))
            {
                CsvWriter.WriteRecords(lstProducto);
            }

            return Now;
        }
        #endregion
    }
}
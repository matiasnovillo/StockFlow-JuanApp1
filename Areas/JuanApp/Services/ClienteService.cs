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
            throw new NotImplementedException();
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
                        cliente.CodigoDeCliente
                        
                                );
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
                
                        
                        DataTable.Rows.Add(
                                cliente.ClienteId,
                        cliente.Active,
                        cliente.DateTimeCreation,
                        cliente.DateTimeLastModification,
                        cliente.UserCreationId,
                        cliente.UserLastModificationId,
                        cliente.NombreDeCliente,
                        cliente.CodigoDeCliente
                        
                                );
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
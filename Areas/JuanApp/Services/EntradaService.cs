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
    public class EntradaService : IEntradaService
    {
        protected readonly JuanAppContext _context;

        public EntradaService(JuanAppContext context)
        {
            _context = context;
        }

        public DateTime ExportAsPDF(Ajax Ajax, string ExportationType)
        {
            throw new NotImplementedException();
        }

        public DateTime ExportAsExcel(List<Entrada> lstEntrada, Ajax Ajax, string ExportationType, string pathToSave)
        {
            DateTime Now = DateTime.Now;

            using var Book = new XLWorkbook();

            if (ExportationType == "All")
            {
                DataTable dtEntrada = new();

                //We define another DataTable dtEntradaCopy to avoid issue related to DateTime conversion
                DataTable dtEntradaCopy = new();

                DataColumn dtColumnEntradaIdFordtEntradaCopy = new DataColumn();
                dtColumnEntradaIdFordtEntradaCopy.DataType = typeof(string);
                dtColumnEntradaIdFordtEntradaCopy.ColumnName = "EntradaId";
                dtEntradaCopy.Columns.Add(dtColumnEntradaIdFordtEntradaCopy);

                DataColumn dtColumnActiveFordtEntradaCopy = new DataColumn();
                dtColumnActiveFordtEntradaCopy.DataType = typeof(string);
                dtColumnActiveFordtEntradaCopy.ColumnName = "Active";
                dtEntradaCopy.Columns.Add(dtColumnActiveFordtEntradaCopy);

                DataColumn dtColumnDateTimeCreationFordtEntradaCopy = new DataColumn();
                dtColumnDateTimeCreationFordtEntradaCopy.DataType = typeof(string);
                dtColumnDateTimeCreationFordtEntradaCopy.ColumnName = "DateTimeCreation";
                dtEntradaCopy.Columns.Add(dtColumnDateTimeCreationFordtEntradaCopy);

                DataColumn dtColumnDateTimeLastModificationFordtEntradaCopy = new DataColumn();
                dtColumnDateTimeLastModificationFordtEntradaCopy.DataType = typeof(string);
                dtColumnDateTimeLastModificationFordtEntradaCopy.ColumnName = "DateTimeLastModification";
                dtEntradaCopy.Columns.Add(dtColumnDateTimeLastModificationFordtEntradaCopy);

                DataColumn dtColumnUserCreationIdFordtEntradaCopy = new DataColumn();
                dtColumnUserCreationIdFordtEntradaCopy.DataType = typeof(string);
                dtColumnUserCreationIdFordtEntradaCopy.ColumnName = "UserCreationId";
                dtEntradaCopy.Columns.Add(dtColumnUserCreationIdFordtEntradaCopy);

                DataColumn dtColumnUserLastModificationIdFordtEntradaCopy = new DataColumn();
                dtColumnUserLastModificationIdFordtEntradaCopy.DataType = typeof(string);
                dtColumnUserLastModificationIdFordtEntradaCopy.ColumnName = "UserLastModificationId";
                dtEntradaCopy.Columns.Add(dtColumnUserLastModificationIdFordtEntradaCopy);

                DataColumn dtColumnCodigoDeClienteFordtEntradaCopy = new DataColumn();
                dtColumnCodigoDeClienteFordtEntradaCopy.DataType = typeof(string);
                dtColumnCodigoDeClienteFordtEntradaCopy.ColumnName = "CodigoDeCliente";
                dtEntradaCopy.Columns.Add(dtColumnCodigoDeClienteFordtEntradaCopy);

                DataColumn dtColumnNombreDeClienteFordtEntradaCopy = new DataColumn();
                dtColumnNombreDeClienteFordtEntradaCopy.DataType = typeof(string);
                dtColumnNombreDeClienteFordtEntradaCopy.ColumnName = "NombreDeCliente";
                dtEntradaCopy.Columns.Add(dtColumnNombreDeClienteFordtEntradaCopy);

                DataColumn dtColumnCodigoDeProductoFordtEntradaCopy = new DataColumn();
                dtColumnCodigoDeProductoFordtEntradaCopy.DataType = typeof(string);
                dtColumnCodigoDeProductoFordtEntradaCopy.ColumnName = "CodigoDeProducto";
                dtEntradaCopy.Columns.Add(dtColumnCodigoDeProductoFordtEntradaCopy);

                DataColumn dtColumnNombreDeProductoFordtEntradaCopy = new DataColumn();
                dtColumnNombreDeProductoFordtEntradaCopy.DataType = typeof(string);
                dtColumnNombreDeProductoFordtEntradaCopy.ColumnName = "NombreDeProducto";
                dtEntradaCopy.Columns.Add(dtColumnNombreDeProductoFordtEntradaCopy);

                DataColumn dtColumnKilosRealesFordtEntradaCopy = new DataColumn();
                dtColumnKilosRealesFordtEntradaCopy.DataType = typeof(string);
                dtColumnKilosRealesFordtEntradaCopy.ColumnName = "KilosReales";
                dtEntradaCopy.Columns.Add(dtColumnKilosRealesFordtEntradaCopy);

                DataColumn dtColumnPrecioFordtEntradaCopy = new DataColumn();
                dtColumnPrecioFordtEntradaCopy.DataType = typeof(string);
                dtColumnPrecioFordtEntradaCopy.ColumnName = "Precio";
                dtEntradaCopy.Columns.Add(dtColumnPrecioFordtEntradaCopy);

                DataColumn dtColumnSubtotalFordtEntradaCopy = new DataColumn();
                dtColumnSubtotalFordtEntradaCopy.DataType = typeof(string);
                dtColumnSubtotalFordtEntradaCopy.ColumnName = "Subtotal";
                dtEntradaCopy.Columns.Add(dtColumnSubtotalFordtEntradaCopy);

                DataColumn dtColumnCodigoDeBarraFordtEntradaCopy = new DataColumn();
                dtColumnCodigoDeBarraFordtEntradaCopy.DataType = typeof(string);
                dtColumnCodigoDeBarraFordtEntradaCopy.ColumnName = "CodigoDeBarra";
                dtEntradaCopy.Columns.Add(dtColumnCodigoDeBarraFordtEntradaCopy);

                List<Entrada> lstEntradaAll = _context.Entrada.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("EntradaId", typeof(string));
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
                DataTable.Columns.Add("CodigoDeBarra", typeof(string));

                foreach (DataRow DataRow in dtEntrada.Rows)
                {
                    dtEntradaCopy.Rows.Add(DataRow.ItemArray);
                }

                var Sheet = Book.Worksheets.Add(dtEntradaCopy);

                Sheet.ColumnsUsed().AdjustToContents();

                Book.SaveAs($@"wwwroot/ExcelFiles/JuanApp/Entrada/Entrada_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.xlsx");
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                DataSet dsEntrada = new();

                //We define another DataTable dtEntradaCopy to avoid issue related to DateTime conversion
                DataTable dtEntradaCopy = new();

                DataColumn dtColumnEntradaIdFordtEntradaCopy = new DataColumn();
                dtColumnEntradaIdFordtEntradaCopy.DataType = typeof(string);
                dtColumnEntradaIdFordtEntradaCopy.ColumnName = "ID del sistema";
                dtEntradaCopy.Columns.Add(dtColumnEntradaIdFordtEntradaCopy);

                DataColumn dtColumnCodigoDeBarraFordtEntradaCopy = new DataColumn();
                dtColumnCodigoDeBarraFordtEntradaCopy.DataType = typeof(string);
                dtColumnCodigoDeBarraFordtEntradaCopy.ColumnName = "Nº de pesaje";
                dtEntradaCopy.Columns.Add(dtColumnCodigoDeBarraFordtEntradaCopy);

                DataColumn dtColumnCodigoDeClienteFordtEntradaCopy = new DataColumn();
                dtColumnCodigoDeClienteFordtEntradaCopy.DataType = typeof(string);
                dtColumnCodigoDeClienteFordtEntradaCopy.ColumnName = "Código de producto";
                dtEntradaCopy.Columns.Add(dtColumnCodigoDeClienteFordtEntradaCopy);

                DataColumn dtColumnNombreDeClienteFordtEntradaCopy = new DataColumn();
                dtColumnNombreDeClienteFordtEntradaCopy.DataType = typeof(string);
                dtColumnNombreDeClienteFordtEntradaCopy.ColumnName = "Nombre de producto";
                dtEntradaCopy.Columns.Add(dtColumnNombreDeClienteFordtEntradaCopy);

                DataColumn dtColumnCodigoDeProductoFordtEntradaCopy = new DataColumn();
                dtColumnCodigoDeProductoFordtEntradaCopy.DataType = typeof(string);
                dtColumnCodigoDeProductoFordtEntradaCopy.ColumnName = "Tex. Contenido";
                dtEntradaCopy.Columns.Add(dtColumnCodigoDeProductoFordtEntradaCopy);

                DataColumn dtColumnNombreDeProductoFordtEntradaCopy = new DataColumn();
                dtColumnNombreDeProductoFordtEntradaCopy.DataType = typeof(string);
                dtColumnNombreDeProductoFordtEntradaCopy.ColumnName = "Neto";
                dtEntradaCopy.Columns.Add(dtColumnNombreDeProductoFordtEntradaCopy);

                DataColumn dtColumnKilosRealesFordtEntradaCopy = new DataColumn();
                dtColumnKilosRealesFordtEntradaCopy.DataType = typeof(string);
                dtColumnKilosRealesFordtEntradaCopy.ColumnName = "Fecha de creación";
                dtEntradaCopy.Columns.Add(dtColumnKilosRealesFordtEntradaCopy);

                dsEntrada.Tables.Add(dtEntradaCopy);

                DataTable DataTable = new();
                DataTable.Columns.Add("EntradaId", typeof(string));
                DataTable.Columns.Add("NroDePesaje", typeof(string));
                DataTable.Columns.Add("CodigoDeProducto", typeof(string));
                DataTable.Columns.Add("NombreDeProducto", typeof(string));
                DataTable.Columns.Add("TexContenido", typeof(string));
                DataTable.Columns.Add("Neto", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));

                foreach (Entrada entrada in lstEntrada)
                {
                    DataTable.Rows.Add(
                        entrada.EntradaId,
                        entrada.NroDePesaje,
                        entrada.CodigoDeProducto,
                        entrada.NombreDeProducto,
                        entrada.TexContenido,
                        entrada.Neto,
                        entrada.DateTimeLastModification);
                }

                dtEntradaCopy = DataTable;

                foreach (DataRow DataRow in dtEntradaCopy.Rows)
                {
                    dsEntrada.Tables[0].Rows.Add(DataRow.ItemArray);
                }

                for (int i = 0; i < dsEntrada.Tables.Count; i++)
                {
                    var Sheet = Book.Worksheets.Add(dsEntrada.Tables[i]);
                    Sheet.ColumnsUsed().AdjustToContents();
                }
                Book.SaveAs($@"{pathToSave}/Stock_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.xlsx");
            }
            return Now;
        }

        public DateTime ExportAsCSV(Ajax Ajax, string ExportationType)
        {
            DateTime Now = DateTime.Now;
            List<Entrada> lstEntrada = new List<Entrada> { };

            if (ExportationType == "All")
            {
                lstEntrada = _context.Entrada.ToList();
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                foreach (string RowChecked in RowsChecked)
                {
                    Entrada Entrada = _context.Entrada
                                            .Where(x => x.EntradaId == Convert.ToInt32(RowChecked))
                                            .FirstOrDefault();      
                    lstEntrada.Add(Entrada);
                }
            }

            using (var Writer = new StreamWriter($@"wwwroot/CSVFiles/JuanApp/Entrada/Entrada_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.csv"))
            using (var CsvWriter = new CsvWriter(Writer, CultureInfo.InvariantCulture))
            {
                CsvWriter.WriteRecords(lstEntrada);
            }

            return Now;
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.DatabaseContexts;
using System.Text.RegularExpressions;
using System.Data;
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

namespace JuanApp.Areas.JuanApp.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        protected readonly JuanAppContext _context;

        public ProductoRepository(JuanAppContext context)
        {
            _context = context;
        }

        public IQueryable<Producto> AsQueryable()
        {
            try
            {
                return _context.Producto.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Producto.Count();
            }
            catch (Exception) { throw; }
        }

        public Producto? GetByProductoId(int productoId)
        {
            try
            {
                return _context.Producto
                            .FirstOrDefault(x => x.ProductoId == productoId);
            }
            catch (Exception) { throw; }
        }

        public Producto? GetByCodigoDeProducto(int codigoDeProducto)
        {
            try
            {
                return _context.Producto
                            .FirstOrDefault(x => x.ProductoId == codigoDeProducto);
            }
            catch (Exception) { throw; }
        }

        public List<Producto?> GetAll()
        {
            try
            {
                return _context.Producto.ToList();
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public int Add(Producto producto)
        {
            try
            {
                _context.Producto.Add(producto);
                _context.SaveChanges();

                return producto.ProductoId;
            }
            catch (Exception) { throw; }
        }

        public int Update(Producto producto)
        {
            try
            {
                _context.Producto.Update(producto);
                return _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public int DeleteByProductoId(int productoId)
        {
            try
            {
                int RowsDeleted = AsQueryable()
                        .Where(x => x.ProductoId == productoId)
                        .ExecuteDelete();

                _context.SaveChanges();

                return RowsDeleted;
            }
            catch (Exception) { throw; }
        }

        public void DeleteManyOrAll(Ajax ajax, string deleteType)
        {
            try
            {
                if (deleteType == "All")
                {
                    var RegistersToDelete = _context.Producto.ToList();

                    _context.Producto.RemoveRange(RegistersToDelete);

                    _context.SaveChanges();
                }
                else
                {
                    string[] RowsChecked = ajax.AjaxForString.Split(',');

                    for (int i = 0; i < RowsChecked.Length; i++)
                    {
                        _context.Producto
                                    .Where(x => x.ProductoId == Convert.ToInt32(RowsChecked[i]))
                                    .ExecuteDelete();

                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception) { throw; }
        }

        public int CopyByProductoId(int productoId)
        {
            try
            {
                Producto Producto = _context.Producto
                                .Where(x => x.ProductoId == productoId)
                                .FirstOrDefault();

                Producto.ProductoId = 0;

                _context.Producto.Add(Producto);
                return _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public int CopyManyOrAll(Ajax ajax, string copyType)
        {
            try
            {
                int NumberOfRegistersEntered = 0;

                if (copyType == "All")
                {
                    List<Producto> lstProducto = [];
                    lstProducto = _context.Producto.ToList();

                    for (int i = 0; i < lstProducto.Count; i++)
                    {
                        Producto Producto = lstProducto[i];
                        Producto.ProductoId = 0;
                        _context.Producto.Add(Producto);
                        NumberOfRegistersEntered += _context.SaveChanges();
                    }
                }
                else
                {
                    string[] RowsChecked = ajax.AjaxForString.Split(',');

                    for (int i = 0; i < RowsChecked.Length; i++)
                    {
                        Producto Producto = _context.Producto
                                                    .Where(x => x.ProductoId == Convert.ToInt32(RowsChecked[i]))
                                                    .FirstOrDefault();
                        Producto.ProductoId = 0;
                        _context.Producto.Add(Producto);
                        NumberOfRegistersEntered += _context.SaveChanges();
                    }
                }

                return NumberOfRegistersEntered;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Methods for DataTable
        public DataTable GetAllByProductoIdInDataTable(List<int> lstProductoChecked)
        {
            try
            {
                DataTable DataTable = new();
                DataTable.Columns.Add("ProductoId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("Nombre", typeof(string));
                DataTable.Columns.Add("CodigoProducto", typeof(string));
                DataTable.Columns.Add("Precio", typeof(string));


                foreach (int ProductoId in lstProductoChecked)
                {
                    Producto producto = _context.Producto.Where(x => x.ProductoId == ProductoId).FirstOrDefault();

                    if (producto != null)
                    {
                        DataTable.Rows.Add(
                        producto.ProductoId,
                        producto.Active,
                        producto.DateTimeCreation,
                        producto.DateTimeLastModification,
                        producto.UserCreationId,
                        producto.UserLastModificationId,
                        producto.Nombre,
                        producto.CodigoProducto,
                        producto.Precio


                        );
                    }
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }

        public DataTable GetAllInDataTable()
        {
            try
            {
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
                DataTable.Columns.Add("Precio", typeof(string));


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
                        producto.CodigoProducto,
                        producto.Precio


                        );
                }

                return DataTable;
            }
            catch (Exception) { throw; }
        }
        #endregion
    }
}
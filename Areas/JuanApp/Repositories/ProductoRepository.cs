using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using JuanApp.Areas.CMSCore.Entities;
using JuanApp.Areas.BasicCore;
using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Areas.JuanApp.DTOs;
using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Library;
using System.Data;

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

        public List<Producto?> GetAll()
        {
            try
            {
                return _context.Producto.ToList();
            }
            catch (Exception) { throw; }
        }

        public paginatedProductoDTO GetAllByProductoIdPaginated(string textToSearch,
            bool strictSearch,
            int pageIndex, 
            int pageSize)
        {
            try
            {
                //textToSearch: "novillo matias  com" -> words: {novillo,matias,com}
                string[] words = Regex
                    .Replace(textToSearch
                    .Trim(), @"\s+", " ")
                    .Split(" ");

                int TotalProducto = _context.Producto.Count();

                var query = from producto in _context.Producto
                            join userCreation in _context.User on producto.UserCreationId equals userCreation.UserId
                            join userLastModification in _context.User on producto.UserLastModificationId equals userLastModification.UserId
                            select new { Producto = producto, UserCreation = userCreation, UserLastModification = userLastModification };

                // Extraemos los resultados en listas separadas
                List<Producto> lstProducto = query.Select(result => result.Producto)
                        .Where(x => strictSearch ?
                            words.All(word => x.ProductoId.ToString().Contains(word)) :
                            words.Any(word => x.ProductoId.ToString().Contains(word)))
                        .OrderByDescending(p => p.DateTimeLastModification)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();
                List<User> lstUserCreation = query.Select(result => result.UserCreation).ToList();
                List<User> lstUserLastModification = query.Select(result => result.UserLastModification).ToList();

                return new paginatedProductoDTO
                {
                    lstProducto = lstProducto,
                    lstUserCreation = lstUserCreation,
                    lstUserLastModification = lstUserLastModification,
                    TotalItems = TotalProducto,
                    PageIndex = pageIndex,
                    PageSize = pageSize
                };
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
    }
}

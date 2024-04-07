using System.Data;
using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Areas.JuanApp.DTOs;
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

namespace JuanApp.Areas.JuanApp.Interfaces
{
    public interface IProductoRepository
    {
        IQueryable<Producto> AsQueryable();

        #region Queries
        int Count();

        Producto? GetByProductoId(int productoId);

        List<Producto?> GetAll();

        paginatedProductoDTO GetAllByProductoIdPaginated(string textToSearch,
            bool strictSearch,
            int pageIndex,
            int pageSize);
        #endregion

        #region Non-Queries
        int Add(Producto producto);

        int Update(Producto producto);

        int DeleteByProductoId(int producto);

        void DeleteManyOrAll(Ajax Ajax, string DeleteType);

        int CopyByProductoId(int ProductoId);

        int CopyManyOrAll(Ajax Ajax, string CopyType);
        #endregion
    }
}

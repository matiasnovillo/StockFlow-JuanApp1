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

namespace JuanApp.Areas.JuanApp.Interfaces
{
    public interface IRemitoRepository
    {
        IQueryable<Remito> AsQueryable();

        #region Queries
        int Count();

        Remito? GetByRemitoId(int remitoId);

        List<Remito?> GetAll();
        #endregion

        #region Non-Queries
        int Add(Remito remito);

        int Update(Remito remito);

        int DeleteByRemitoId(int remito);

        string DeleteManyOrAll(Ajax Ajax, string DeleteType);

        int CopyByRemitoId(int RemitoId);

        int CopyManyOrAll(Ajax Ajax, string CopyType);
        #endregion
    }
}

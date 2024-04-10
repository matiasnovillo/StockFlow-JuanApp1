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

namespace JuanApp.Areas.JuanApp.Interfaces
{
    public interface IEntradaRepository
    {
        IQueryable<Entrada> AsQueryable();

        #region Queries
        int Count();

        Entrada? GetByEntradaId(int entradaId);

        List<Entrada?> GetAll();
        #endregion

        #region Non-Queries
        int Add(Entrada entrada);

        int Update(Entrada entrada);

        int DeleteByEntradaId(int entrada);

        void DeleteManyOrAll(Ajax Ajax, string DeleteType);

        int CopyByEntradaId(int EntradaId);

        int CopyManyOrAll(Ajax Ajax, string CopyType);
        #endregion
    }
}

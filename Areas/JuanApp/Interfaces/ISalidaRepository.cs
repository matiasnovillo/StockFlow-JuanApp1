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
    public interface ISalidaRepository
    {
        IQueryable<Salida> AsQueryable();

        #region Queries
        int Count();

        Salida? GetBySalidaId(int salidaId);

        List<Salida?> GetAll();
        #endregion

        #region Non-Queries
        int Add(Salida salida);

        int Update(Salida salida);

        int DeleteBySalidaId(int salida);

        void DeleteManyOrAll(Ajax Ajax, string DeleteType);

        int CopyBySalidaId(int SalidaId);

        int CopyManyOrAll(Ajax Ajax, string CopyType);

        int DeleteAll();
        #endregion
    }
}

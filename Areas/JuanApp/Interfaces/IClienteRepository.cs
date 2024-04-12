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
    public interface IClienteRepository
    {
        IQueryable<Cliente> AsQueryable();

        #region Queries
        int Count();

        Cliente? GetByClienteId(int clienteId);

        List<Cliente?> GetAll();
        #endregion

        #region Non-Queries
        int Add(Cliente cliente);

        int Update(Cliente cliente);

        int DeleteByClienteId(int cliente);

        string DeleteManyOrAll(Ajax Ajax, string DeleteType);

        int CopyByClienteId(int ClienteId);

        int CopyManyOrAll(Ajax Ajax, string CopyType);
        #endregion
    }
}

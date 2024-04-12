using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using JuanApp.Areas.BasicCore;
using JuanApp.Areas.JuanApp.Entities;
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
    public class ClienteRepository : IClienteRepository
    {
        protected readonly JuanAppContext _context;

        public ClienteRepository(JuanAppContext context)
        {
            _context = context;
        }

        public IQueryable<Cliente> AsQueryable()
        {
            try
            {
                return _context.Cliente.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Cliente.Count();
            }
            catch (Exception) { throw; }
        }

        public Cliente? GetByClienteId(int clienteId)
        {
            try
            {
                return _context.Cliente
                            .FirstOrDefault(x => x.ClienteId == clienteId);
            }
            catch (Exception) { throw; }
        }

        public List<Cliente?> GetAll()
        {
            try
            {
                return _context.Cliente.ToList();
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public int Add(Cliente cliente)
        {
            try
            {
                _context.Cliente.Add(cliente);
                _context.SaveChanges();
                
                return cliente.ClienteId;   
            }
            catch (Exception) { throw; }
        }

        public int Update(Cliente cliente)
        {
            try
            {
                _context.Cliente.Update(cliente);
                return _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public int DeleteByClienteId(int clienteId)
        {
            try
            {
                int RowsDeleted = AsQueryable()
                        .Where(x => x.ClienteId == clienteId)
                        .ExecuteDelete();

                _context.SaveChanges();

                return RowsDeleted;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ajax"></param>
        /// <param name="deleteType"></param>
        /// <returns>Return the rows deleted</returns>
        public string DeleteManyOrAll(Ajax ajax, string deleteType)
        {
            try
            {
                if (deleteType == "All")
                {
                    var RegistersToDelete = _context.Cliente.ToList();
                    
                    List<Cliente> lstCliente = _context.Cliente.ToList();
                    string RowsDeleted = "";

                    for (int i = 0; i < lstCliente.Count; i++)
                    {
                        RowsDeleted += $@"{lstCliente[i].ClienteId},"; 
                    }

                    RowsDeleted = RowsDeleted.TrimEnd(',');

                    _context.Cliente.RemoveRange(RegistersToDelete);

                    _context.SaveChanges();

                    return RowsDeleted;
                }
                else
                {
                    string[] RowsChecked = ajax.AjaxForString.Split(',');

                    for (int i = 0; i < RowsChecked.Length; i++)
                    {
                        _context.Cliente
                                    .Where(x => x.ClienteId == Convert.ToInt32(RowsChecked[i]))
                                    .ExecuteDelete();

                        _context.SaveChanges();
                    }

                    ajax.AjaxForString = ajax.AjaxForString.TrimEnd(',');

                    return ajax.AjaxForString;
                }
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clienteId"></param>
        /// <returns>The last entered ID after the copy transaction</returns>        
        public int CopyByClienteId(int clienteId)
        {
            try
            {
                Cliente Cliente = _context.Cliente
                                .Where(x => x.ClienteId == clienteId)
                                .FirstOrDefault();

                Cliente.ClienteId = 0;

                _context.Cliente.Add(Cliente);
                _context.SaveChanges();

                return _context.Cliente
                                .OrderByDescending(x => x.ClienteId)
                                .FirstOrDefault().ClienteId;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ajax"></param>
        /// <param name="copyType"></param>
        /// <returns>The number of rows copied</returns>
        public int CopyManyOrAll(Ajax ajax, string copyType)
        {
            try
            {
                int NumberOfRegistersEntered = 0;

                if (copyType == "All")
                {
                    List<Cliente> lstCliente = [];
                    lstCliente = _context.Cliente.ToList();

                    for (int i = 0; i < lstCliente.Count; i++)
                    {
                        Cliente Cliente = lstCliente[i];
                        Cliente.ClienteId = 0;
                        _context.Cliente.Add(Cliente);
                        NumberOfRegistersEntered += _context.SaveChanges();
                    }
                }
                else
                {
                    string[] RowsChecked = ajax.AjaxForString.Split(',');

                    for (int i = 0; i < RowsChecked.Length; i++)
                    {
                        Cliente Cliente = _context.Cliente
                                                    .Where(x => x.ClienteId == Convert.ToInt32(RowsChecked[i]))
                                                    .FirstOrDefault();
                        Cliente.ClienteId = 0;
                        _context.Cliente.Add(Cliente);
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

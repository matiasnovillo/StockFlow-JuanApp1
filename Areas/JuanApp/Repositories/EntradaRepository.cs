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
    public class EntradaRepository : IEntradaRepository
    {
        protected readonly JuanAppContext _context;

        public EntradaRepository(JuanAppContext context)
        {
            _context = context;
        }

        public IQueryable<Entrada> AsQueryable()
        {
            try
            {
                return _context.Entrada.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Entrada.Count();
            }
            catch (Exception) { throw; }
        }

        public Entrada? GetByEntradaId(int entradaId)
        {
            try
            {
                return _context.Entrada
                            .FirstOrDefault(x => x.EntradaId == entradaId);
            }
            catch (Exception) { throw; }
        }

        public List<Entrada?> GetAll()
        {
            try
            {
                return _context.Entrada.ToList();
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public int Add(Entrada entrada)
        {
            try
            {
                _context.Entrada.Add(entrada);
                _context.SaveChanges();
                
                return entrada.EntradaId;   
            }
            catch (Exception) { throw; }
        }

        public int Update(Entrada entrada)
        {
            try
            {
                _context.Entrada.Update(entrada);
                return _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public int DeleteByEntradaId(int entradaId)
        {
            try
            {
                int RowsDeleted = AsQueryable()
                        .Where(x => x.EntradaId == entradaId)
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
                    var RegistersToDelete = _context.Entrada.ToList();

                    _context.Entrada.RemoveRange(RegistersToDelete);

                    _context.SaveChanges();
                }
                else
                {
                    string[] RowsChecked = ajax.AjaxForString.Split(',');

                    for (int i = 0; i < RowsChecked.Length; i++)
                    {
                        _context.Entrada
                                    .Where(x => x.EntradaId == Convert.ToInt32(RowsChecked[i]))
                                    .ExecuteDelete();

                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception) { throw; }
        }

        public int CopyByEntradaId(int entradaId)
        {
            try
            {
                Entrada Entrada = _context.Entrada
                                .Where(x => x.EntradaId == entradaId)
                                .FirstOrDefault();

                Entrada.EntradaId = 0;

                _context.Entrada.Add(Entrada);
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
                    List<Entrada> lstEntrada = [];
                    lstEntrada = _context.Entrada.ToList();

                    for (int i = 0; i < lstEntrada.Count; i++)
                    {
                        Entrada Entrada = lstEntrada[i];
                        Entrada.EntradaId = 0;
                        _context.Entrada.Add(Entrada);
                        NumberOfRegistersEntered += _context.SaveChanges();
                    }
                }
                else
                {
                    string[] RowsChecked = ajax.AjaxForString.Split(',');

                    for (int i = 0; i < RowsChecked.Length; i++)
                    {
                        Entrada Entrada = _context.Entrada
                                                    .Where(x => x.EntradaId == Convert.ToInt32(RowsChecked[i]))
                                                    .FirstOrDefault();
                        Entrada.EntradaId = 0;
                        _context.Entrada.Add(Entrada);
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

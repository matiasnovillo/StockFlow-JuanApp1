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
    public class SalidaRepository : ISalidaRepository
    {
        protected readonly JuanAppContext _context;

        public SalidaRepository(JuanAppContext context)
        {
            _context = context;
        }

        public IQueryable<Salida> AsQueryable()
        {
            try
            {
                return _context.Salida.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Salida.Count();
            }
            catch (Exception) { throw; }
        }

        public Salida? GetBySalidaId(int salidaId)
        {
            try
            {
                return _context.Salida
                            .FirstOrDefault(x => x.SalidaId == salidaId);
            }
            catch (Exception) { throw; }
        }

        public List<Salida?> GetAll()
        {
            try
            {
                return _context.Salida.ToList();
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public int Add(Salida salida)
        {
            try
            {
                _context.Salida.Add(salida);
                _context.SaveChanges();
                
                return salida.SalidaId;   
            }
            catch (Exception) { throw; }
        }

        public int Update(Salida salida)
        {
            try
            {
                _context.Salida.Update(salida);
                return _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public int DeleteBySalidaId(int salidaId)
        {
            try
            {
                int RowsDeleted = AsQueryable()
                        .Where(x => x.SalidaId == salidaId)
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
                    var RegistersToDelete = _context.Salida.ToList();

                    _context.Salida.RemoveRange(RegistersToDelete);

                    _context.SaveChanges();
                }
                else
                {
                    string[] RowsChecked = ajax.AjaxForString.Split(',');

                    for (int i = 0; i < RowsChecked.Length; i++)
                    {
                        _context.Salida
                                    .Where(x => x.SalidaId == Convert.ToInt32(RowsChecked[i]))
                                    .ExecuteDelete();

                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception) { throw; }
        }

        public int CopyBySalidaId(int salidaId)
        {
            try
            {
                Salida Salida = _context.Salida
                                .Where(x => x.SalidaId == salidaId)
                                .FirstOrDefault();

                Salida.SalidaId = 0;

                _context.Salida.Add(Salida);
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
                    List<Salida> lstSalida = [];
                    lstSalida = _context.Salida.ToList();

                    for (int i = 0; i < lstSalida.Count; i++)
                    {
                        Salida Salida = lstSalida[i];
                        Salida.SalidaId = 0;
                        _context.Salida.Add(Salida);
                        NumberOfRegistersEntered += _context.SaveChanges();
                    }
                }
                else
                {
                    string[] RowsChecked = ajax.AjaxForString.Split(',');

                    for (int i = 0; i < RowsChecked.Length; i++)
                    {
                        Salida Salida = _context.Salida
                                                    .Where(x => x.SalidaId == Convert.ToInt32(RowsChecked[i]))
                                                    .FirstOrDefault();
                        Salida.SalidaId = 0;
                        _context.Salida.Add(Salida);
                        NumberOfRegistersEntered += _context.SaveChanges();
                    }
                }

                return NumberOfRegistersEntered;
            }
            catch (Exception) { throw; }
        }

        public int DeleteAll()
        {
            var Salidas = _context.Salida.ToList();

            _context.Salida.RemoveRange(Salidas);

            return _context.SaveChanges();
        }
        #endregion
    }
}

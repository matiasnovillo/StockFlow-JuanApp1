using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Library;
using System.Data;
using Microsoft.Win32;
using JuanApp.DatabaseContexts;

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
    public class RemitoRepository : IRemitoRepository
    {
        protected readonly JuanAppContext _context;

        public RemitoRepository(JuanAppContext context)
        {
            _context = context;
        }

        public IQueryable<Remito> AsQueryable()
        {
            try
            {
                return _context.Remito.AsQueryable();
            }
            catch (Exception) { throw; }
        }

        #region Queries
        public int Count()
        {
            try
            {
                return _context.Remito.Count();
            }
            catch (Exception) { throw; }
        }

        public Remito? GetByRemitoId(int remitoId)
        {
            try
            {
                return _context.Remito
                            .FirstOrDefault(x => x.RemitoId == remitoId);
            }
            catch (Exception) { throw; }
        }

        public List<Remito?> GetAll()
        {
            try
            {
                return _context.Remito.ToList();
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Non-Queries
        public int Add(Remito remito)
        {
            try
            {
                _context.Remito.Add(remito);
                _context.SaveChanges();

                int LastId = _context.Remito
                                        .OrderByDescending(r => r.RemitoId)
                                        .First()
                                        .RemitoId;

                return LastId;   
            }
            catch (Exception) { throw; }
        }

        public int Update(Remito remito)
        {
            try
            {
                _context.Remito.Update(remito);
                return _context.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public int DeleteByRemitoId(int remitoId)
        {
            try
            {
                int RowsDeleted = AsQueryable()
                        .Where(x => x.RemitoId == remitoId)
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
                    var RegistersToDelete = _context.Remito.ToList();
                    
                    List<Remito> lstRemito = _context.Remito.ToList();
                    string RowsDeleted = "";

                    for (int i = 0; i < lstRemito.Count; i++)
                    {
                        RowsDeleted += $@"{lstRemito[i].RemitoId},"; 
                    }

                    RowsDeleted = RowsDeleted.TrimEnd(',');

                    _context.Remito.RemoveRange(RegistersToDelete);

                    _context.SaveChanges();

                    return RowsDeleted;
                }
                else
                {
                    string[] RowsChecked = ajax.AjaxForString.Split(',');

                    for (int i = 0; i < RowsChecked.Length; i++)
                    {
                        _context.Remito
                                    .Where(x => x.RemitoId == Convert.ToInt32(RowsChecked[i]))
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
        /// <param name="remitoId"></param>
        /// <returns>The last entered ID after the copy transaction</returns>        
        public int CopyByRemitoId(int remitoId)
        {
            try
            {
                Remito Remito = _context.Remito
                                .Where(x => x.RemitoId == remitoId)
                                .FirstOrDefault();

                Remito.RemitoId = 0;

                _context.Remito.Add(Remito);
                _context.SaveChanges();

                return _context.Remito
                                .OrderByDescending(x => x.RemitoId)
                                .FirstOrDefault().RemitoId;
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
                    List<Remito> lstRemito = [];
                    lstRemito = _context.Remito.ToList();

                    for (int i = 0; i < lstRemito.Count; i++)
                    {
                        Remito Remito = lstRemito[i];
                        Remito.RemitoId = 0;
                        _context.Remito.Add(Remito);
                        NumberOfRegistersEntered += _context.SaveChanges();
                    }
                }
                else
                {
                    string[] RowsChecked = ajax.AjaxForString.Split(',');

                    for (int i = 0; i < RowsChecked.Length; i++)
                    {
                        Remito Remito = _context.Remito
                                                    .Where(x => x.RemitoId == Convert.ToInt32(RowsChecked[i]))
                                                    .FirstOrDefault();
                        Remito.RemitoId = 0;
                        _context.Remito.Add(Remito);
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

using EF =  SBC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBC.Dal.UnitOfWork;
using System.Data.Entity;
using System.Linq.Expressions;
using SBC.Framework.Utility;

namespace SBC.Dal.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : EF.BaseEntity.IEntity
    {
        EF.Context.SBCContext _context { get; set; }

        IUnitOfWork _uow;

        DbSet<T> _dbset;

        public GenericRepository(IUnitOfWork uow)
        {
            _uow = uow;
            _context = _uow.context;
            _dbset = _context.Set<T>();
        }
        public IQueryable<T> Get() {
            return _dbset;
        }
        public List<T> GetAll()
        {
            return _dbset.ToList();
        }
        public T GetById(int id)
        {
           return _dbset.Find(id);
        }
        public T GetByRefId(Guid id)
        {
            return _dbset.FirstOrDefault(x => x.RawID == id);
        }
        public IQueryable<T> Select(Expression<Func<T, bool>> selector)
        {
            return _dbset.Where(selector);
        }
        public ActionStatus Insert(T obj)
        {
            _uow.BeginTransaction();
            ActionStatus response = new ActionStatus();
            try
            {
                _dbset.Add(obj);
                _uow.EndTransaction();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                response.IsSuccess = false;
                response.message = ex.Message;
            }
            return response;

        }
        public ActionStatus Update(T obj)
        {
            _uow.BeginTransaction();
            ActionStatus response = new ActionStatus();
            try
            {
                _dbset.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                _uow.EndTransaction();
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                response.IsSuccess = false;
                response.message = ex.Message;
            }
            return response;
        }
        public ActionStatus Delete(int id)
        {
            _uow.BeginTransaction();
            ActionStatus response = new ActionStatus();
            try
            {
                var obj = _dbset.Find(id);
                if (obj != null)
                {
                    _dbset.Remove(obj);
                    _uow.EndTransaction();
                    response.IsSuccess = true;
                }
                else
                {
                    response.IsSuccess = false;
                    response.message = "record not found";
                }

            }
            catch (Exception ex)
            {
                _uow.Rollback();
                response.IsSuccess = false;
                response.message = ex.Message;
            }
            return response;
        }
        public ActionStatus DeleteRange(int[] ids)
        {
            _uow.BeginTransaction();
            ActionStatus response = new ActionStatus();
            try
            {
                var list = _dbset.Where(x => ids.Contains(x.RecordID)).ToList();
                if (list.Count > 0)
                {
                    _dbset.RemoveRange(list);
                    _uow.EndTransaction();
                }
                else
                {
                    response.IsSuccess = false;
                    response.message = "record(s) not found";
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                response.IsSuccess = false;
                response.message = ex.Message;
            }
            return response;
        }
    }
}

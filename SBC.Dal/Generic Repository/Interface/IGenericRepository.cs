using SBC.Framework.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SBC.Dal.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> Get();
        List<T> GetAll();
        T GetById(int id);
        T GetByRefId(Guid id);
        IQueryable<T> Select(Expression<Func<T,bool>> selector);
        ActionStatus Insert(T obj);
        ActionStatus Update(T obj);
        ActionStatus Delete(int id);
        ActionStatus DeleteRange(int[] list);

    }
}

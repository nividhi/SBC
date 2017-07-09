using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF = SBC.Data;

namespace SBC.Dal.UnitOfWork
{
    public interface IUnitOfWork
    {
        EF.Context.SBCContext context { get; set; }
        void BeginTransaction();
        void Rollback();
        void SaveChanges();
        void EndTransaction();
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF = SBC.Data;

namespace SBC.Dal.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork , IDisposable
    {
        public EF.Context.SBCContext context { get; set; }
        private DbContextTransaction _transaction;

        public UnitOfWork(DbContext _context)
        {
            context = (EF.Context.SBCContext)_context;
        }

        public void BeginTransaction()
        {
            _transaction = context.Database.BeginTransaction();
        }
        public void Rollback()
        {
            _transaction.Rollback();
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public void EndTransaction()
        {
            context.SaveChanges();
            _transaction.Commit();
        }
        public void Dispose()
        {
            context.Dispose();
        }

    }
}

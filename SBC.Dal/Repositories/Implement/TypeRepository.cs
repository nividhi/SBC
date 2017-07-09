using SBC.Dal.GenericRepository;
using EF = SBC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBC.Dal.UnitOfWork;

namespace SBC.Dal.Repositories
{
    public class TypeRepository : GenericRepository<EF.Entities.Type> , ITypeRepository
    {
        IUnitOfWork _uow;
        public TypeRepository(IUnitOfWork uow)
            :base(uow)
        {

        }
    }
}

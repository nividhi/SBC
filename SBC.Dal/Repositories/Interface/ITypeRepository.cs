using SBC.Dal.GenericRepository;
using EF = SBC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC.Dal.Repositories
{
    public interface ITypeRepository : IGenericRepository<EF.Entities.Type>
    {

    }
}

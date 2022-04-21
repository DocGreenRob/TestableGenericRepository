using Test.DataAccess.Core;
using Test.DataAccess.Entities;

namespace Test.DataAccess.Repository
{
    public class DepartmentRepository : GenericRepository<Department>
    {
        public DepartmentRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
}

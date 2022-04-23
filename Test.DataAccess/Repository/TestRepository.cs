using Test.DataAccess.Core;

namespace Test.DataAccess.Repository
{
    public class TestRepository : GenericRepository<Entities.Test>, ITestRepository
    {
        public TestRepository(DatabaseObject db, IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
}

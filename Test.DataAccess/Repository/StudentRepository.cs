using Test.DataAccess.Core;
using Test.DataAccess.Entities;

namespace Test.DataAccess.Repository
{
    public class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
}

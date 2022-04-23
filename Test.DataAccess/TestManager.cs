using System.Threading.Tasks;
using Test.DataAccess.Core;
using Test.DataAccess.Repository;

namespace Test.DataAccess
{
    public class TestManager : ITestManager
    {
        private IUnitOfWork _unitOfWork;
        private ITestRepository _testRepository;

        public TestManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _testRepository = _unitOfWork.GetRepository<TestRepository>();
        }
        
        public async Task<string> DoWork()
        {
            return await _testRepository.GetAsync();
        }

    }
}

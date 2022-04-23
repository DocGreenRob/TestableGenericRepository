using System;
using System.Threading.Tasks;

namespace Test.DataAccess.Core
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        public GenericRepository(IUnitOfWork unitOfWork)
        {
            unitOfWork.GetRepository<T>();
        }

        public async Task<string> GetAsync()
        {
            return await Task.FromResult("result from db");
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }
    }
}

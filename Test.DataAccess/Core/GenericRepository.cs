using System;

namespace Test.DataAccess.Core
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        public GenericRepository(IUnitOfWork unitOfWork)
        {
            unitOfWork.Register(this);
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }
    }
}

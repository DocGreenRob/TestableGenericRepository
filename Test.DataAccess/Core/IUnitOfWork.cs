using System;

namespace Test.DataAccess.Core
{
    public interface IUnitOfWork : IDisposable
    {
        T GetRepository<T>() where T : class;
        void Save();
    }
}

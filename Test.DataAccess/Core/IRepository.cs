using System.Threading.Tasks;

namespace Test.DataAccess.Core
{
    public interface IRepository
    {
        void Submit();
        Task<string> GetAsync();
    }

    public interface IRepository<T> : IRepository where T : class { }
}

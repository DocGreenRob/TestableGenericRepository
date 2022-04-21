namespace Test.DataAccess.Core
{
    public interface IRepository
    {
        void Submit();
    }

    public interface IRepository<T> : IRepository where T : class { }
}

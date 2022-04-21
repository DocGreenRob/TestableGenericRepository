namespace Test.DataAccess.Core
{
    public interface IUnitOfWork
    {
        void Register(IRepository repository);
        void Commit();
    }
}

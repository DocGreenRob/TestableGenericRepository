using System.Threading.Tasks;

namespace Test.DataAccess
{
    public interface ITestManager
    {
        Task<string> DoWork();
    }
}

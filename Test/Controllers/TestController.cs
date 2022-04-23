using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Test.DataAccess;

namespace Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;
        private readonly ITestManager _testManager;

        public TestController(ILogger<TestController> logger,
            ITestManager testManager)
        {
            _logger = logger;
            _testManager = testManager;
        }

        [HttpGet]
        public async Task<string> Test()
        {
            return await _testManager.DoWork();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foo400;

namespace Bar430
{
    public class CallerAppService : Bar430AppService
    {
        private readonly ITestAppService _testAppService;

        public CallerAppService(ITestAppService testAppService)
        {
            _testAppService = testAppService;
        }

        public async Task<string> GetResultAsync()
        {
            return await _testAppService.HelloAsync("world");
        }
    }
}

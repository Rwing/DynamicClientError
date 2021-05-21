using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foo400
{
    public class TestAppService : Foo400AppService, ITestAppService
    {
        public async Task<string> HelloAsync(string text)
        {
            return await Task.FromResult("Hello " + text);
        }
    }
}

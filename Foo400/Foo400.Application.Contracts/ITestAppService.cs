using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Foo400
{
    public interface ITestAppService : IApplicationService
    {
        Task<string> HelloAsync(string text);
    }
}

using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Foo400.EntityFrameworkCore
{
    [DependsOn(
        typeof(Foo400EntityFrameworkCoreModule)
        )]
    public class Foo400EntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<Foo400MigrationsDbContext>();
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Bar430.EntityFrameworkCore
{
    [DependsOn(
        typeof(Bar430EntityFrameworkCoreModule)
        )]
    public class Bar430EntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<Bar430MigrationsDbContext>();
        }
    }
}

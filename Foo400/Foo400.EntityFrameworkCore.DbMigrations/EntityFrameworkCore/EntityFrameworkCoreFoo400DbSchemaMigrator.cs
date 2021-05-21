using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Foo400.Data;
using Volo.Abp.DependencyInjection;

namespace Foo400.EntityFrameworkCore
{
    public class EntityFrameworkCoreFoo400DbSchemaMigrator
        : IFoo400DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFoo400DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Foo400MigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Foo400MigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
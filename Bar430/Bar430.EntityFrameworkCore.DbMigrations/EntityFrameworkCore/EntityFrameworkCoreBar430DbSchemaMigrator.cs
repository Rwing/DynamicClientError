using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Bar430.Data;
using Volo.Abp.DependencyInjection;

namespace Bar430.EntityFrameworkCore
{
    public class EntityFrameworkCoreBar430DbSchemaMigrator
        : IBar430DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreBar430DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Bar430MigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Bar430MigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
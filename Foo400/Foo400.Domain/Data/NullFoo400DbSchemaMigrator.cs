using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Foo400.Data
{
    /* This is used if database provider does't define
     * IFoo400DbSchemaMigrator implementation.
     */
    public class NullFoo400DbSchemaMigrator : IFoo400DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
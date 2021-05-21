using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Bar430.Data
{
    /* This is used if database provider does't define
     * IBar430DbSchemaMigrator implementation.
     */
    public class NullBar430DbSchemaMigrator : IBar430DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
using System.Threading.Tasks;

namespace Foo400.Data
{
    public interface IFoo400DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

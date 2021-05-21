using System.Threading.Tasks;

namespace Bar430.Data
{
    public interface IBar430DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Foo400.EntityFrameworkCore
{
    public static class Foo400DbContextModelCreatingExtensions
    {
        public static void ConfigureFoo400(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(Foo400Consts.DbTablePrefix + "YourEntities", Foo400Consts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
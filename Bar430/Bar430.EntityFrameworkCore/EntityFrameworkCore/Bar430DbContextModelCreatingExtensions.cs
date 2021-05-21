using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Bar430.EntityFrameworkCore
{
    public static class Bar430DbContextModelCreatingExtensions
    {
        public static void ConfigureBar430(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(Bar430Consts.DbTablePrefix + "YourEntities", Bar430Consts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
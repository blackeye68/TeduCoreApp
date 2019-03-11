using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeduCoreApp.Data.Entities;
using static TeduCoreApp.Data.EF.Extensions.ModelBuilderExtensions;

namespace TeduCoreApp.Data.EF.Configurations
{
    public class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(255).IsRequired()
            .HasColumnType("varchar(255)");
            // etc.
        }
    }
}
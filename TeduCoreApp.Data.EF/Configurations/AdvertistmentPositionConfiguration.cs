using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeduCoreApp.Data.Entities;
using static TeduCoreApp.Data.EF.Extensions.ModelBuilderExtensions;

namespace TeduCoreApp.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
            // etc.
        }
    }
}
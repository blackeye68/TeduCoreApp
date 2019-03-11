using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeduCoreApp.Data.Entities;
using static TeduCoreApp.Data.EF.Extensions.ModelBuilderExtensions;

namespace TeduCoreApp.Data.EF.Configurations
{
    public class FooterConfiguration : DbEntityConfiguration<Footer>
    {
        public override void Configure(EntityTypeBuilder<Footer> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255)
                .HasColumnType("varchar(255)").IsRequired();
            // etc.
        }
    }
}
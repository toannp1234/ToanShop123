using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToanShop.Data.EF.Extensions;
using ToanShop.Data.Entities.Advs;

namespace ToanShop.Data.EF.Configurations
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
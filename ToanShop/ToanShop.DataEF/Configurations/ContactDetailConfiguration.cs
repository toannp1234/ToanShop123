using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToanShop.Data.EF.Extensions;
using ToanShop.Data.Entities;

namespace ToanShop.Data.EF.Configurations
{
    public class ContactDetailConfiguration : DbEntityConfiguration<ContactDetail>
    {
        public override void Configure(EntityTypeBuilder<ContactDetail> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
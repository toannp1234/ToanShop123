using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToanShop.Data.EF.Extensions;
using ToanShop.Data.Entities;

namespace ToanShop.Data.EF.Configurations
{
    public class BlogTagConfiguration : DbEntityConfiguration<PostTag>
    {
        public override void Configure(EntityTypeBuilder<PostTag> entity)
        {
           // entity.Property(d => d.PostId).IsRequired().IsUnicode();
            entity.Property(c => c.TagId).HasMaxLength(255).IsRequired()
            .HasColumnType("varchar(255)");
            // etc.
        }
    }
}
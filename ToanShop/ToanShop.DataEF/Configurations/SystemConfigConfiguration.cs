using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Data.EF.Extensions;
using ToanShop.Data.Entities;

namespace ToanShop.Data.EF.Configurations
{
    public class SystemConfigConfiguration : DbEntityConfiguration<Setting>
    {
        public override void Configure(EntityTypeBuilder<Setting> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}

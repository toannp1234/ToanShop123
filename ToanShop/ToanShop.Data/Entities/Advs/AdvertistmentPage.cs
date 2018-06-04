using System;
using System.ComponentModel.DataAnnotations.Schema;
using ToanShop.Data.Interfaces;
using ToanShop.Infrastructure.SharedKernel;

namespace ToanShop.Data.Entities.Advs
{
    [Table("AdvertistmentPages")]
    public class AdvertistmentPage : DomainEntity<Guid>, IHasUniqueCode
    {
        public string UniqueCode { get; set; }
        public string Name { get; set; }
    }
}
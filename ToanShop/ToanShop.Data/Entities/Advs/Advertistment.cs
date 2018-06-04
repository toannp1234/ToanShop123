using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToanShop.Data.Interfaces;
using ToanShop.Infrastructure.Enums;
using ToanShop.Infrastructure.SharedKernel;

namespace ToanShop.Data.Entities.Advs
{
    [Table("Advertistments")]
    public class Advertistment : DomainEntity<Guid>, ISwitchable, ISortable, IDateTracking
    {
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [StringLength(250)]
        public string Url { get; set; }

        public Guid PositionId { get; set; }

        public int SortOrder { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
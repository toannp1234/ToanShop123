using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToanShop.Data.Interfaces;
using ToanShop.Infrastructure.Enums;
using ToanShop.Infrastructure.SharedKernel;

namespace ToanShop.Data.Entities
{
    [Table("Footers")]
    public class Footer : DomainEntity<string>, ISwitchable
    {
        [Required]
        public string Content { set; get; }

        public Status Status { set; get; }
    }
}
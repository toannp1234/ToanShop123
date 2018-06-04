using System;
using System.ComponentModel.DataAnnotations.Schema;
using ToanShop.Infrastructure.SharedKernel;

namespace ToanShop.Data.Entities
{
    [Table("BlogTags")]
    public class PostTag : DomainEntity<Guid>
    {
        public Guid PostId { set; get; }

        public string TagId { set; get; }
    }
}
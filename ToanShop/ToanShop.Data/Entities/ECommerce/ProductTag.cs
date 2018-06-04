using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToanShop.Infrastructure.SharedKernel;

namespace ToanShop.Data.Entities
{
    [Table("ProductTags")]
    public class ProductTag : DomainEntity<Guid>
    {
        
        public Guid ProductId { set; get; }
        
        public string TagId { set; get; }
    }
}
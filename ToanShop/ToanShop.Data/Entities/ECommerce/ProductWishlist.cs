using System;
using System.ComponentModel.DataAnnotations.Schema;
using ToanShop.Data.Interfaces;
using ToanShop.Infrastructure.SharedKernel;

namespace ToanShop.Data.Entities
{
    [Table("ProductWishlists")]
    public class ProductWishlist : DomainEntity<Guid>, IDateTracking
    {
        public ProductWishlist()
        {
        }

        public ProductWishlist(Guid id, Guid userId, Guid productId)
        {
            Id = id;
            UserId = userId;
            ProductId = productId;
        }

        public Guid ProductId { get; set; }

        public Guid UserId { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { set; get; }
    }
}
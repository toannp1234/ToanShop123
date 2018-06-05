using System;

namespace ToanShop.Application.ViewModel.ECommerce
{
    public class ProductWishlistViewModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }

        public Guid UserId { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
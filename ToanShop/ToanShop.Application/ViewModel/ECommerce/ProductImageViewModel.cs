using System;

namespace ToanShop.Application.ViewModel.ECommerce
{
    public class ProductImageViewModel
    {
        public Guid Id { get; set; }

        public Guid productId { get; set; }

        public string Path { get; set; }

        public string Caption { get; set; }
    }
}
using System;

namespace ToanShop.Application.ViewModel.ECommerce
{
    public class BillDetailViewModel
    {
        public Guid Id { get; set; }
        public Guid BillId { set; get; }

        public Guid ProductId { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public BillViewModel Bill { set; get; }

        public ProductViewModel Product { set; get; }

    }
}

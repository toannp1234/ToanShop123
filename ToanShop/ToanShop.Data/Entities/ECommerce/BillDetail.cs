using System;
using System.ComponentModel.DataAnnotations.Schema;
using ToanShop.Infrastructure.SharedKernel;

namespace ToanShop.Data.Entities
{
    [Table("BillDetails")]
    public class BillDetail : DomainEntity<Guid>
    {
        public BillDetail()
        {
        }

        public BillDetail(Guid id, Guid billId, Guid productId,
            int quantity, decimal price)
        {
            Id = id;
            BillId = billId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }

        public Guid BillId { set; get; }

        public Guid ProductId { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToanShop.Application.ViewModel.ECommerce
{
    public class WholePriceViewModel
    {
        public Guid productId { get; set; }

        public int FromQuantity { get; set; }

        public int ToQuantity { get; set; }

        public decimal Price { get; set; }
    }
}

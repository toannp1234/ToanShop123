﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToanShop.Infrastructure.SharedKernel;

namespace ToanShop.Data.Entities.Advs
{
    [Table("AdvertistmentPositions")]
    public class AdvertistmentPosition : DomainEntity<Guid>
    {
        public Guid PageId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }
    }
}
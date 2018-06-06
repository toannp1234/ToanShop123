﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ToanShop.Infrastructure.Enums;

namespace ToanShop.Application.ViewModel.System
{
    public class FunctionViewModel
    {
        public Guid Id { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string URL { set; get; }

        public int DisplayOrder { set; get; }

        public Guid? ParentId { set; get; }

        public Status Status { set; get; }

        public string IconCss { get; set; }
    }
}

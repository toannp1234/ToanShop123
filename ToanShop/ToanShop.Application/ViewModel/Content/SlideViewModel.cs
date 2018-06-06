using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ToanShop.Data.Enums;
using ToanShop.Infrastructure.Enums;

namespace ToanShop.Application.ViewModel.Content
{
    public class SlideViewModel
    {
        public Guid Id { set; get; }

        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [StringLength(250)]
        public string Description { set; get; }

        [StringLength(250)]
        [Required]
        public string Image { set; get; }

        [StringLength(250)]
        public string Url { set; get; }

        public int DisplayOrder { set; get; }

        public Status Status { set; get; }

        public string Content { set; get; }

        [Required]
        public SlideGroup GroupAlias { get; set; }
    }
}

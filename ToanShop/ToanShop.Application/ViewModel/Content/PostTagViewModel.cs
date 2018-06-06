using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Application.ViewModel.DTOs;

namespace ToanShop.Application.ViewModel.Content
{
    public class PostTagViewModel
    {
        public int BlogId { set; get; }

        public string TagId { set; get; }

        public PostViewModel Blog { set; get; }

        public TagViewModel Tag { set; get; }
    }
}

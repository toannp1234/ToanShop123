using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToanShop.Application.ViewModel.System
{
    public class AppRoleViewModel
    {
        
            public string Id { set; get; }

            [Required(ErrorMessage = "Bạn phải nhập tên")]
            public string Name { set; get; }

            public string Description { set; get; }

    }
}

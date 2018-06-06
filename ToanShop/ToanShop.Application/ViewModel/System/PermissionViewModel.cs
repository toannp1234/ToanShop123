﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToanShop.Application.ViewModel.System
{
    public class PermissionViewModel
    {
       
            public Guid Id { get; set; }


            public Guid RoleId { get; set; }

            public Guid FunctionId { get; set; }

            public bool CanCreate { set; get; }

            public bool CanRead { set; get; }

            public bool CanUpdate { set; get; }

            public bool CanDelete { set; get; }

       
    }
}

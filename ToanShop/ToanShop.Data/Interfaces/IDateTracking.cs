﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToanShop.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { get; set; }
        DateTime? DateModified { get; set; }
        DateTime? DateDeleted { get; set; }
    }
}

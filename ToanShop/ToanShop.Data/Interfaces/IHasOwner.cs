﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToanShop.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }
    }
}

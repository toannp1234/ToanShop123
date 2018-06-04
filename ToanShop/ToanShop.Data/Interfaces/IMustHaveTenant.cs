using System;
using System.Collections.Generic;
using System.Text;

namespace ToanShop.Data.Interfaces
{
    interface IMustHaveTenant
    {
      Guid TenantId { get; set; }

    }
}

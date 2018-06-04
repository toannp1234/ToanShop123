using System;

namespace ToanShop.Data.Interfaces
{
    internal interface IMustHaveTenant
    {
        Guid TenantId { get; set; }
    }
}
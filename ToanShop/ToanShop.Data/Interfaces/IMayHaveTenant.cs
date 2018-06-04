using System;

namespace ToanShop.Data.Interfaces
{
    public interface IMayHaveTenant
    {
        Guid? TenantId { get; set; }
    }
}
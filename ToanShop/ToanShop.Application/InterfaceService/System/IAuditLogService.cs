using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Data.Entities;

namespace ToanShop.Application.InterfaceService.System
{
    public interface IAuditLogService
    {
        void Create(AuditLog error);

        void Save();
    }
}

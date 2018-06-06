using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Application.InterfaceService.System;
using ToanShop.Data.Entities;
using ToanShop.Infrastructure.Interfaces;

namespace ToanShop.Application.ImplementService.System
{
    public class AuditLogService : IAuditLogService
    {
        private IRepository<AuditLog, Guid> _errorRepository;
        private IUnitOfWork _unitOfWork;

        public AuditLogService(IRepository<AuditLog, Guid> errorRepository, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Create(AuditLog error)
        {
            _errorRepository.Insert(error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}

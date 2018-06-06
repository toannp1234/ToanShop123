using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToanShop.Application.ViewModel.System;

namespace ToanShop.Application.InterfaceService.System
{
    public interface IPermissionService
    {
        ICollection<PermissionViewModel> GetByFunctionId(Guid functionId);

        Task<List<PermissionViewModel>> GetByUserId(Guid userId);

        void Add(PermissionViewModel permission);

        void DeleteAll(Guid functionId);

        void SaveChange();
    }
}

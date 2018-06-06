using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToanShop.Application.ViewModel.System;
using ToanShop.Utilities.Dtos;

namespace ToanShop.Application.InterfaceService.System
{
    public interface IUserService
    {
        Task<bool> AddAsync(AppUserViewModel userVm);

        Task DeleteAsync(Guid id);

        Task<List<AppUserViewModel>> GetAllAsync();

        PagedResult<AppUserViewModel> GetAllPagingAsync(string keyword, int page, int pageSize);

        Task<AppUserViewModel> GetById(Guid id);


        Task UpdateAsync(AppUserViewModel userVm);

    }
}

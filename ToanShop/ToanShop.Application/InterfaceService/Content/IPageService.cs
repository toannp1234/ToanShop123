using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Application.ViewModel.Content;
using ToanShop.Utilities.Dtos;

namespace ToanShop.Application.InterfaceService.Content
{
    public interface IPageService : IDisposable
    {
        void Add(PageViewModel pageVm);

        void Update(PageViewModel pageVm);

        void Delete(Guid id);

        List<PageViewModel> GetAll();

        PagedResult<PageViewModel> GetAllPaging(string keyword, int page, int pageSize);

        PageViewModel GetByAlias(string alias);

        PageViewModel GetById(Guid id);

        void SaveChanges();
    }
}

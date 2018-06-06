using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Application.ViewModel.Content;
using ToanShop.Utilities.Dtos;

namespace ToanShop.Application.InterfaceService.Content
{
    public interface ISlideService
    {
        void Add(SlideViewModel slideVm);

        void Update(SlideViewModel slideVm);

        void Delete(Guid id);

        List<SlideViewModel> GetAll();

        PagedResult<SlideViewModel> GetAllPaging(string keyword, int page, int pageSize, string sortBy);

        SlideViewModel GetById(Guid id);

        void SaveChanges();
    }
}

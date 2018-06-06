using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Application.ViewModel.Content;
using ToanShop.Data.Entities;
using ToanShop.Utilities.Dtos;

namespace ToanShop.Application.InterfaceService.Content
{
    public interface IFeedbackService : IWebServiceBase<Feedback, Guid, FeedbackViewModel>
    {
        PagedResult<FeedbackViewModel> GetAllPaging(string keyword, int page, int pageSize);
    }
}

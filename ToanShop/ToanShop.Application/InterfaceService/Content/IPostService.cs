using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Application.ViewModel.Content;
using ToanShop.Application.ViewModel.DTOs;
using ToanShop.Data.Entities;
using ToanShop.Utilities.Dtos;

namespace ToanShop.Application.InterfaceService.Content
{
    public interface IPostService : IWebServiceBase<Post, Guid, PostViewModel>
    {

        PagedResult<PostViewModel> GetAllPaging(string keyword, int pageSize, int page);

        List<PostViewModel> GetLastest(int top);

        List<PostViewModel> GetHotProduct(int top);

        List<PostViewModel> GetListPaging(int page, int pageSize, string sort, out int totalRow);

        List<PostViewModel> Search(string keyword, int page, int pageSize, string sort, out int totalRow);

        List<PostViewModel> GetList(string keyword);

        List<PostViewModel> GetReatedBlogs(Guid id, int top);

        List<string> GetListByName(string name);

        List<TagViewModel> GetListTagById(Guid id);

        TagViewModel GetTag(string tagId);

        void IncreaseView(Guid id);

        List<PostViewModel> GetListByTag(string tagId, int page, int pagesize, out int totalRow);

        List<TagViewModel> GetListTag(string searchText);
    }
}

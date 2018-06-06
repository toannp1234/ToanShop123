using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Application.ViewModel.DTOs;
using ToanShop.Application.ViewModel.ECommerce;
using ToanShop.Data.Entities;
using ToanShop.Utilities.Dtos;

namespace ToanShop.Application.InterfaceService.ECommerce
{
    public interface IProductService : IWebServiceBase<Product, Guid, ProductViewModel>
    {

        PagedResult<ProductViewModel> GetAllPaging(Guid? categoryId, string keyword, int page, int pageSize, string sortBy);

        List<ProductViewModel> GetLastest(int top);

        List<ProductViewModel> GetHotProduct(int top);

        List<ProductViewModel> GetListProductByCategoryIdPaging(Guid categoryId, int page, int pageSize, string sort, out int totalRow);

        List<ProductViewModel> Search(string keyword, int page, int pageSize, string sort, out int totalRow);

        List<ProductViewModel> GetListProduct(string keyword);

        List<ProductViewModel> GetReatedProducts(Guid id, int top);

        List<string> GetListProductByName(string name);

        List<TagViewModel> GetListTagByProductId(Guid id);

        TagViewModel GetTag(string tagId);

        void IncreaseView(Guid id);

        List<ProductViewModel> GetListProductByTag(string tagId, int page, int pagesize, out int totalRow);

        List<TagViewModel> GetListProductTag(string searchText);

        void ImportExcel(string filePath, Guid categoryId);

        void AddImages(Guid productId, string[] images);

        List<ProductImageViewModel> GetImages(Guid productId);

        List<ProductViewModel> GetUpsellProducts(int top);

        PagedResult<ProductViewModel> GetMyWishlist(Guid userId, int page, int pageSize);
    }
}

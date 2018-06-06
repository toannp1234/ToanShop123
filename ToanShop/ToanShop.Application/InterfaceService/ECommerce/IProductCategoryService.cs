using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Application.ViewModel.ECommerce;
using ToanShop.Data.Entities;

namespace ToanShop.Application.InterfaceService.ECommerce
{
    public interface IProductCategoryService : IWebServiceBase<ProductCategory, Guid, ProductCategoryViewModel>
    {
        List<ProductCategoryViewModel> GetAll(string keyword);

        List<ProductCategoryViewModel> GetAllByParentId(Guid? parentId);

        void UpdateParentId(Guid sourceId, Guid targetId, Dictionary<Guid, int> items);

        void ReOrder(Guid sourceId, Guid targetId);

        List<ProductCategoryViewModel> GetHomeCategories(int top);
    }
}

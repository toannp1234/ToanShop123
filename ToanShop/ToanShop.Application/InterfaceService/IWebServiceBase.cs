using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ToanShop.Infrastructure.Enums;
using ToanShop.Infrastructure.SharedKernel;
using ToanShop.Utilities.Dtos;

namespace ToanShop.Application.InterfaceService
{
    public interface IWebServiceBase<TEntity, TPrimaryKey, ViewModel> where ViewModel : class
       where TEntity : DomainEntity<TPrimaryKey>
    {
        void Add(ViewModel viewModel);

        void Update(ViewModel viewModel);

        void Delete(TPrimaryKey id);

        ViewModel GetById(TPrimaryKey id);

        List<ViewModel> GetAll();

        PagedResult<ViewModel> GetAllPaging(Expression<Func<TEntity, bool>> predicate, Func<TEntity, bool> orderBy,
            SortDirection sortDirection, int pageIndex, int pageSize);

        void Save();
    }
}

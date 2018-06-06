﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ToanShop.Application.InterfaceService;
using ToanShop.Infrastructure.Enums;
using ToanShop.Infrastructure.Interfaces;
using ToanShop.Infrastructure.SharedKernel;
using ToanShop.Utilities.Dtos;

namespace ToanShop.Application.ImplementService
{
    public abstract class WebServiceBase<TEntity, TPrimaryKey, ViewModel> : IWebServiceBase<TEntity, TPrimaryKey, ViewModel>
       where ViewModel : class
       where TEntity : DomainEntity<TPrimaryKey>
    {
        private readonly IRepository<TEntity, TPrimaryKey> _repository;
        private readonly IUnitOfWork _unitOfWork;

        protected WebServiceBase(IRepository<TEntity, TPrimaryKey> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public virtual void Add(ViewModel viewModel)
        {
            var model = Mapper.Map<ViewModel, TEntity>(viewModel);
            _repository.Insert(model);
        }

        public virtual void Delete(TPrimaryKey id)
        {
            _repository.Delete(id);
        }

        public virtual ViewModel GetById(TPrimaryKey id)
        {
            return Mapper.Map<TEntity, ViewModel>(_repository.GetById(id));
        }

        public virtual List<ViewModel> GetAll()
        {
            return _repository.GetAll().ProjectTo<ViewModel>().ToList();
        }

        public virtual PagedResult<ViewModel> GetAllPaging(Expression<Func<TEntity, bool>> predicate, Func<TEntity, bool> orderBy,
            SortDirection sortDirection, int pageIndex, int pageSize)
        {
            var query = _repository.GetAll().Where(predicate);

            int totalRow = query.Count();

            if (sortDirection == SortDirection.Ascending)
            {
                query = query.OrderBy(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsQueryable();
            }
            else
            {
                query = query.OrderByDescending(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsQueryable();
            }

            var data = query.ProjectTo<ViewModel>().ToList();
            var paginationSet = new PagedResult<ViewModel>()
            {
                Results = data,
                CurrentPage = pageIndex,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;
        }

        public virtual void Save()
        {
            _unitOfWork.Commit();
        }

        public virtual void Update(ViewModel viewModel)
        {
            var model = Mapper.Map<ViewModel, TEntity>(viewModel);
            _repository.Update(model);
        }
    }
}

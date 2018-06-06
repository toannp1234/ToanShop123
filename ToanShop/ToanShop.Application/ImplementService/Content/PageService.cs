﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToanShop.Application.InterfaceService.Content;
using ToanShop.Application.ViewModel.Content;
using ToanShop.Data.Entities;
using ToanShop.Infrastructure.Interfaces;
using ToanShop.Utilities.Dtos;

namespace ToanShop.Application.ImplementService.Content
{
    public class PageService : IPageService
    {
        private IRepository<Page, Guid> _pageRepository;
        private IUnitOfWork _unitOfWork;

        public PageService(IRepository<Page, Guid> pageRepository,
            IUnitOfWork unitOfWork)
        {
            this._pageRepository = pageRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(PageViewModel pageVm)
        {
            var page = Mapper.Map<PageViewModel, Page>(pageVm);
            _pageRepository.Insert(page);
        }

        public void Delete(Guid id)
        {
            _pageRepository.Delete(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<PageViewModel> GetAll()
        {
            return _pageRepository.GetAll().ProjectTo<PageViewModel>().ToList();
        }

        public PagedResult<PageViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _pageRepository.GetAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Name.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderByDescending(x => x.UniqueCode)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            var paginationSet = new PagedResult<PageViewModel>()
            {
                Results = data.ProjectTo<PageViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;
        }

        public PageViewModel GetByAlias(string alias)
        {
            return Mapper.Map<Page, PageViewModel>(_pageRepository.Single(x => x.UniqueCode == alias));
        }

        public PageViewModel GetById(Guid id)
        {
            return Mapper.Map<Page, PageViewModel>(_pageRepository.GetById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(PageViewModel pageVm)
        {
            var page = Mapper.Map<PageViewModel, Page>(pageVm);
            _pageRepository.Update(page);
        }
    }
}

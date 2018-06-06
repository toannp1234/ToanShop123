using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using ToanShop.Application.InterfaceService.Content;
using ToanShop.Application.ViewModel.Content;
using ToanShop.Data.Entities;
using ToanShop.Infrastructure.Interfaces;
using ToanShop.Utilities.Dtos;

namespace ToanShop.Application.ImplementService.Content
{
    public class ContactService : IContactService
    {
        private IRepository<ContactDetail, string> _pageRepository;
        private IUnitOfWork _unitOfWork;

        public ContactService(IRepository<ContactDetail, string> pageRepository,
            IUnitOfWork unitOfWork)
        {
            this._pageRepository = pageRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(ContactDetailViewModel pageVm)
        {
            var page = Mapper.Map<ContactDetailViewModel, ContactDetail>(pageVm);
            _pageRepository.Insert(page);
        }

        public void Delete(string id)
        {
            _pageRepository.Delete(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ContactDetailViewModel> GetAll()
        {
            return _pageRepository.GetAll().ProjectTo<ContactDetailViewModel>().ToList();
        }

        public PagedResult<ContactDetailViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _pageRepository.GetAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Name.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderByDescending(x => x.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            var paginationSet = new PagedResult<ContactDetailViewModel>()
            {
                Results = data.ProjectTo<ContactDetailViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;
        }

        public ContactDetailViewModel GetById(string id)
        {
            return Mapper.Map<ContactDetail, ContactDetailViewModel>(_pageRepository.GetById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(ContactDetailViewModel pageVm)
        {
            var page = Mapper.Map<ContactDetailViewModel, ContactDetail>(pageVm);
            _pageRepository.Update(page);
        }
    }
}
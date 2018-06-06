using AutoMapper;
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
    public class SlideService : ISlideService
    {
        private readonly IRepository<Slide, Guid> _slideRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SlideService(IRepository<Slide, Guid> slideRepository,
            IUnitOfWork unitOfWork)
        {
            _slideRepository = slideRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(SlideViewModel slideVm)
        {
            _slideRepository.Insert(Mapper.Map<SlideViewModel, Slide>(slideVm));
        }

        public void Update(SlideViewModel slideVm)
        {
            _slideRepository.Update(Mapper.Map<SlideViewModel, Slide>(slideVm));
        }

        public void Delete(Guid id)
        {
            _slideRepository.Delete(id);
        }

        public List<SlideViewModel> GetAll()
        {
            return _slideRepository.GetAll()
                .ProjectTo<SlideViewModel>().ToList();
        }

        public PagedResult<SlideViewModel> GetAllPaging(string keyword, int page, int pageSize, string sortBy)
        {
            var query = _slideRepository.GetAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Name.Contains(keyword));

            int totalRow = query.Count();

            query = query.OrderByDescending(x => x.Id).Skip((page - 1) * pageSize)
                .Take(pageSize);

            var data = query.ProjectTo<SlideViewModel>().ToList();
            var paginationSet = new PagedResult<SlideViewModel>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;
        }

        public SlideViewModel GetById(Guid id)
        {
            return Mapper.Map<Slide, SlideViewModel>(_slideRepository.GetById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}

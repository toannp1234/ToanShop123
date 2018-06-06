using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToanShop.Application.InterfaceService.System;
using ToanShop.Application.ViewModel.Content;
using ToanShop.Application.ViewModel.System;
using ToanShop.Data.Entities;
using ToanShop.Data.Enums;
using ToanShop.Infrastructure.Enums;
using ToanShop.Infrastructure.Interfaces;
using ToanShop.Utilities.Constants;

namespace ToanShop.Application.ImplementService.System
{
    public class CommonService : ICommonService
    {
        private IRepository<Footer, string> _footerRepository;
        private IRepository<Setting, Guid> _systemConfigRepository;
        private IUnitOfWork _unitOfWork;
        private IRepository<Slide, Guid> _slideRepository;

        public CommonService(IRepository<Footer, string> footerRepository,
            IRepository<Setting, Guid> systemConfigRepository,
            IUnitOfWork unitOfWork,
            IRepository<Slide, Guid> slideRepository)
        {
            _footerRepository = footerRepository;
            _unitOfWork = unitOfWork;
            _systemConfigRepository = systemConfigRepository;
            _slideRepository = slideRepository;
        }

        public FooterViewModel GetFooter()
        {
            return Mapper.Map<Footer, FooterViewModel>(_footerRepository.Single(x => x.Id ==
            CommonConstants.DefaultFooterId));
        }

        public List<SlideViewModel> GetSlides(SlideGroup groupAlias)
        {
            return _slideRepository.GetAll().Where(x => x.Status == Status.Actived && x.GroupAlias == groupAlias).OrderBy(x => x.DisplayOrder)
                .ProjectTo<SlideViewModel>().ToList();
        }

        public SettingViewModel GetSystemConfig(string code)
        {
            return Mapper.Map<Setting, SettingViewModel>(_systemConfigRepository.Single(x => x.UniqueCode == code));
        }
    }
}

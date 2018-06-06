using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Application.ViewModel.Content;
using ToanShop.Application.ViewModel.System;
using ToanShop.Data.Enums;

namespace ToanShop.Application.InterfaceService.System
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();

        SettingViewModel GetSystemConfig(string code);
        List<SlideViewModel> GetSlides(SlideGroup groupAlias);
    }
}

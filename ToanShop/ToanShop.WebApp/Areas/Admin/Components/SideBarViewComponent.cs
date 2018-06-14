using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ToanShop.Application.InterfaceService.System;
using ToanShop.Application.ViewModel.System;
using ToanShop.Utilities.Constants;
using ToanShop.WebApp.Extensions;

namespace ToanShop.WebApp.Areas.Admin.Components
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly IFunctionService _functionService;

        public SideBarViewComponent(IFunctionService functionService)
        {
            _functionService = functionService;
        }
        public async Task<IViewComponentResult> InvokeAsync() {
            var roles = ((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x=>x.Type == CommonConstants.UserClaim.Roles);
           // var roles = ((ClaimsPrincipal)User).GetSpecificClaim("Roles");
            List<FunctionViewModel> function;
            if(roles!=null && roles.Value.Split(";").Contains(CommonConstants.AppRole.Admin))
            {
                function = await _functionService.GetAll(string.Empty);
            }
            else
            {
                function = await _functionService.GetAllWithPermission(User.Identity.Name);
            }
            return View(function);
        }
    }
}

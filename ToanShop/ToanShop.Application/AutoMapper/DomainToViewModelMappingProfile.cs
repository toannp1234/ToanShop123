using AutoMapper;
using ToanShop.Application.ViewModel.Content;
using ToanShop.Application.ViewModel.DTOs;
using ToanShop.Application.ViewModel.ECommerce;
using ToanShop.Application.ViewModel.System;
using ToanShop.Data.Entities;

namespace ToanShop.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Function, FunctionViewModel>().MaxDepth(2);
            CreateMap<Bill, BillViewModel>().MaxDepth(1);
            CreateMap<BillDetail, BillDetailViewModel>().MaxDepth(1);
            CreateMap<ProductCategory, ProductCategoryViewModel>().MaxDepth(2);
            CreateMap<Product, ProductViewModel>().MaxDepth(2);
            CreateMap<Tag, TagViewModel>().MaxDepth(2);
            CreateMap<ProductTag, ProductTagViewModel>().MaxDepth(2);
            CreateMap<Post, PostViewModel>().MaxDepth(2);
            CreateMap<PostTag, PostTagViewModel>().MaxDepth(2);
            CreateMap<Footer, FooterViewModel>().MaxDepth(2);
            CreateMap<Slide, SlideViewModel>().MaxDepth(2);
            CreateMap<Setting, SettingViewModel>().MaxDepth(2);
            CreateMap<AppUser, AppUserViewModel>().MaxDepth(2);
            CreateMap<AppRole, AppRoleViewModel>().MaxDepth(2);
            CreateMap<ProductImage, ProductImageViewModel>().MaxDepth(2);
            CreateMap<Page, PageViewModel>().MaxDepth(2);

            CreateMap<ContactDetail, ContactDetailViewModel>().MaxDepth(2);
            CreateMap<Feedback, FeedbackViewModel>().MaxDepth(2);
            CreateMap<ProductWishlist, ProductWishlistViewModel>().MaxDepth(2);
        }
    }
}
﻿using AutoMapper;
using ToanShop.Application.ViewModel.Content;
using ToanShop.Application.ViewModel.ECommerce;
using ToanShop.Application.ViewModel.System;
using ToanShop.Data.Entities;

namespace ToanShop.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<FunctionViewModel, Function>()
              .ConstructUsing(c => new Function(c.Name, c.URL, c.ParentId,
              c.IconCss, c.DisplayOrder));

            CreateMap<ProductViewModel, Product>()
              .ConstructUsing(c => new Product(c.Id, c.Name, c.Code, c.CategoryId, c.ThumbnailImage, c.Price, c.OriginalPrice,
              c.PromotionPrice, c.Description, c.Content, c.HomeFlag, c.HotFlag, c.Tags, c.Quantity, c.Unit, c.Status,
              c.SeoPageTitle, c.SeoAlias, c.SeoKeywords, c.SeoDescription));

            CreateMap<ProductCategoryViewModel, ProductCategory>()
                .ConstructUsing(c => new ProductCategory(c.Id, c.Name, c.Code, c.Description, c.ParentId, c.HomeOrder, c.Image,
                    c.HomeFlag, c.SortOrder, c.Status, c.SeoPageTitle, c.SeoAlias, c.SeoKeywords, c.SeoDescription));

            CreateMap<PostViewModel, Post>()
              .ConstructUsing(c => new Post(c.Name, c.Image, c.Description,
              c.Content, c.HomeFlag, c.HotFlag, c.Tags, c.Status,
              c.SeoPageTitle, c.SeoAlias, c.SeoKeywords, c.SeoDescription));

            CreateMap<BillViewModel, Bill>()
              .ConstructUsing(c => new Bill(c.Id, c.CustomerName, c.CustomerAddress, c.CustomerMobile, c.CustomerMessage, c.BillStatus, c.PaymentMethod, c.CustomerFacebook, c.ShippingFee));

            CreateMap<BillDetailViewModel, BillDetail>()
              .ConstructUsing(c => new BillDetail(c.Id, c.BillId, c.ProductId, c.Quantity, c.Price));

            CreateMap<AppUserViewModel, AppUser>()
             .ConstructUsing(c => new AppUser(c.FullName, c.UserName, c.Email, c.PhoneNumber, c.Avatar, c.Status));

            CreateMap<PermissionViewModel, Permission>()
             .ConstructUsing(c => new Permission(c.RoleId, c.FunctionId));

            CreateMap<SlideViewModel, Slide>()
                .ConstructUsing(c => new Slide(c.Id, c.Name, c.Description, c.Image, c.Url, c.DisplayOrder, c.Status, c.Content, c.GroupAlias));

            CreateMap<PageViewModel, Page>()
               .ConstructUsing(c => new Page(c.Id, c.Name, c.Alias, c.Content, c.Status));

            CreateMap<ContactDetailViewModel, ContactDetail>()
                .ConstructUsing(c => new ContactDetail(c.Id, c.Name, c.Phone, c.Email, c.Website, c.Address, c.Other, c.Lng, c.Lat, c.Status));

            CreateMap<FeedbackViewModel, Feedback>()
                .ConstructUsing(c => new Feedback(c.Id, c.Name, c.Email, c.Message, c.Status));

            CreateMap<ProductWishlistViewModel, ProductWishlist>()
                .ConstructUsing(c => new ProductWishlist(c.Id, c.UserId, c.ProductId));
        }
    }
}
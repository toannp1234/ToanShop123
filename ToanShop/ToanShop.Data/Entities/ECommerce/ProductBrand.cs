using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ToanShop.Data.Interfaces;
using ToanShop.Infrastructure.Enums;
using ToanShop.Infrastructure.SharedKernel;

namespace ToanShop.Data.Entities.ECommerce
{
    public class ProductBrand : DomainEntity<Guid>, IHasSeoMetaData,
        ISwitchable, ISortable, IDateTracking
    {
        public ProductBrand()
        {
        }
        public ProductBrand(Guid id, string name, string code, string description, Guid? parentId, int? homeOrder, string image, bool? homeFlag,
            int sortOrder, Status status, string seoPageTitle, string seoAlias, string seoKeywords, string seoDescriptions)
        {
            Id = id;
            Name = name;
            Code = code;
            Description = description;
            ParentId = parentId;
            HomeOrder = homeOrder;
            Image = image;
            HomeFlag = homeFlag;
            SortOrder = sortOrder;
            Status = status;
            SeoPageTitle = seoPageTitle;
            SeoAlias = seoAlias;
            SeoKeywords = seoKeywords;
            SeoDescription = seoDescriptions;
        }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(50)]
        public string Code { get; set; }

        [DefaultValue(0)]
        public int CurrentIdentity { get; set; }

        [MaxLength(500)]
        public string Description { set; get; }

        public Guid? ParentId { set; get; }

        public int? HomeOrder { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public bool? HomeFlag { set; get;}
        public string SeoPageTitle { get ; set ; }
        public string SeoAlias { get ; set ; }
        public string SeoKeywords { get ; set ; }
        public string SeoDescription { get ; set ; }
        public Status Status { get ; set ; }
        public int SortOrder { get ; set ; }
        public DateTime DateCreated { get ; set ; }
        public DateTime? DateModified { get ; set ; }
        public DateTime? DateDeleted { get ; set ; }
    }
}

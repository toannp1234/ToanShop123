using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Infrastructure.Enums;

namespace ToanShop.Application.ViewModel.System
{
    public class SettingViewModel
    {
        public string Id { set; get; }
        public string Name { get; set; }

        public string Value1 { get; set; }
        public int? Value2 { get; set; }

        public bool? Value3 { get; set; }

        public DateTime? Value4 { get; set; }

        public decimal? Value5 { get; set; }
        public Status Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ToanShop.Utilities.Dtos
{
    //tạo một trang trả về với số lượng phần tử được định sẵn, hỗ trợ cho việc phân trang
    public abstract class PagedResultBase
    {
        public int CurrentPage { get; set; }
        public int PageCount{ get {
                var PageCount = (double)RowCount / PageSize;
                return (int)Math.Ceiling(PageCount);
            } set { PageCount = value; } }
        public int PageSize { get; set; }
        public int RowCount { get; set; }
        public int FirstRowOnPage
        {
            get {
                return (CurrentPage - 1) * PageSize + 1;
            }
        }
        public int LastRowOnPage
        {
            get
            {
                return Math.Min((CurrentPage*PageSize),RowCount);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Application.ViewModel.ECommerce;
using ToanShop.Data.Entities;
using ToanShop.Data.Enums;
using ToanShop.Utilities.Dtos;

namespace ToanShop.Application.InterfaceService.ECommerce
{
    public interface IBillService : IWebServiceBase<Bill, Guid, BillViewModel>
    {
        PagedResult<BillViewModel> GetAllPaging(string startDate, string endDate, string keyword,
            int pageIndex, int pageSize);

        BillViewModel GetDetail(Guid billId);

        BillDetailViewModel CreateDetail(BillDetailViewModel billDetailVm);

        void DeleteDetail(Guid productId, Guid billId);

        void UpdateStatus(Guid orderId, BillStatus status);

        List<BillDetailViewModel> GetBillDetails(Guid billId);

        void ConfirmBill(Guid id);

        void CancelBill(Guid id);

        void PendingBill(Guid id);
    }
}

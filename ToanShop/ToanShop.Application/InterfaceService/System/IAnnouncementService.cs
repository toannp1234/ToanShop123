using System;
using System.Collections.Generic;
using System.Text;
using ToanShop.Data.Entities;

namespace ToanShop.Application.InterfaceService.System
{
    public interface IAnnouncementService
    {
        void Create(Announcement announcement);

        List<Announcement> GetListByUserId(Guid userId, int pageIndex, int pageSize, out int totalRow);

        List<Announcement> GetListByUserId(Guid userId, int top);

        void Delete(Guid notificationId);

        void MarkAsRead(Guid userId, Guid notificationId);

        Announcement GetDetail(Guid id);

        List<Announcement> GetListAll(int pageIndex, int pageSize, out int totalRow);

        List<Announcement> ListAllUnread(Guid userId, int pageIndex, int pageSize, out int totalRow);

        void Save();

    }
}

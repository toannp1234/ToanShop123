using ToanShop.Infrastructure.Enums;

namespace ToanShop.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IOrderDetailsRepository : IGenericRepository<OrderDetail>
    {
        OrderDetail GetMostRecentOrderDetails();
    }
}

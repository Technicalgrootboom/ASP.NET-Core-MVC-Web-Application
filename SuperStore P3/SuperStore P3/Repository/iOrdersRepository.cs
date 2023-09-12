using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Repository
{
    public interface iOrdersRepository :IGenericRepository<OrdersRepository>
    {
        OrdersRepository GetMostRecentService();
    }
}



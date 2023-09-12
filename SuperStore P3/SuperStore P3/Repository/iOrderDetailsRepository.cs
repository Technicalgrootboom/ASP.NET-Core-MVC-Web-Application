using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Repository
{
    public interface iOrderDetailsRepository : IGenericRepository<OrderDetailsRepository>
    {
        OrderDetailsRepository GetMostRecentService();
    }
}


using Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrdersRepository : GenericRepository<Order>, IOrdersRepository
    {
        public OrdersRepository(SuperStoreContext context) : base(context)
        {
        }

        public Order GetMostRecentOrders()
        {
            return _context.Orders.OrderByDescending(order => order.OrderId).FirstOrDefault();
        }
    }
}
